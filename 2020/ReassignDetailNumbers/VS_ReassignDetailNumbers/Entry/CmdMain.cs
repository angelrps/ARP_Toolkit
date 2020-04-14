using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using Autodesk.Revit.ApplicationServices;
using ArpUtilities;

namespace Entry
{
    using static Data.Helpers;

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("1FFC042A-7100-420D-AB03-6927467EA44B"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = commandData.Application.ActiveUIDocument.Document;
            string infoResult = "";

            // verify active view is sheet
            View activeView = doc.ActiveView;
            if (!(activeView is Autodesk.Revit.DB.ViewSheet))
            {
                TaskDialog tdActView = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "You must be on a sheet to use this tool.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdActView.Show();
                return Result.Cancelled;
            }

            // verify sheet has viewports
            List<Element> viewportList = GetAllViewport(doc, activeView as ViewSheet);
            if (!viewportList.Any())
            {
                TaskDialog tdHasViewP = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "This sheet does not contain any Viewport.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdHasViewP.Show();
                return Result.Cancelled;
            }

            // get maximum value of detail number parameter
            int maxNum = MaxDetailNumber(doc, viewportList);

            // renumber viewports
            using (Transaction t = new Transaction(doc, "Reassign Detail Number"))
            {
                t.Start();
                
                // allows selection of as many viewports as there are in the sheet
                List<Element> selection = new List<Element>();
                while (selection.Count() < viewportList.Count())
                {
                    try
                    {
                        Element e = doc.GetElement(uidoc.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element,
                                                                                new ViewportSelectionFilter(),
                                                                                "Select Viewports sequentially to re-number."));
                        selection.Add(doc.GetElement(e.Id));
                    }
                    catch (Exception)
                    {
                        if (selection.Count != 0)
                        {
                            TaskDialog.Show("Information", "You have not selected all the viewports in this sheet." + "\n" + 
                                                        "Only selected ones will be renumbered sequentially." + "\n" +
                                                        "Please, review the other numbers because duplicated numbers might have changed.");
                        }
                        else // cancel command if no views selected
                        {
                            return Result.Cancelled;
                        }
                        break;
                    }
                }
                // create list of tarjet values
                List<string> tarjetValues = new List<string>();
                for (int i = 1; i < selection.Count() + 1; i++)
                {
                    tarjetValues.Add(i.ToString());
                }
                // detect viewports with det num value equals to one of the tarjet values
                // and set it to a higher number so they don´t get duplicated
                int counter = 1;
                foreach (Element e in viewportList)
                {
                    string currentValue = e.get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER).AsString();
                    if (tarjetValues.Contains(currentValue)) // detect elements witl detail number equal to any tarjet value
                    {
                        e.get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER).Set((maxNum + counter).ToString());
                        counter = +1;
                    }                    
                }                

                // set new value for each item selected
                int newDetNumber = 0;
                foreach (Element e in selection)
                {
                    newDetNumber = newDetNumber + 1;
                    e.get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER).Set(newDetNumber.ToString());
                    Viewport vp = e as Viewport;
                    infoResult += newDetNumber + ":   " + doc.GetElement(vp.ViewId).Name + "\n";
                }
                t.Commit();
                TaskDialog.Show("Information", "The following viewports have been renumbered:" + "\n" + "\n" + infoResult);
            }
            try
            {
                Utilities.GetAnalyticsCSV(doc, app);
            }
            catch (Exception)
            {
            }
            return Result.Succeeded;
        }
    }
}
