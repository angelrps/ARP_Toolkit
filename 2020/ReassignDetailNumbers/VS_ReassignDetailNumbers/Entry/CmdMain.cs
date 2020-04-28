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

        public static List<string> infoResult = new List<string>();
        public static string resultMsgMain = "";

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = commandData.Application.ActiveUIDocument.Document;
            
            #region is family document?
            if (doc.IsFamilyDocument)
            {
                UI.Info.Form_Info1.infoMsgMain = "Wrong document";
                UI.Info.Form_Info1.infoMsgBody = "This is a family document.\nRun this tool in a project document.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }
            #endregion

            #region verify active view is sheet
            View activeView = doc.ActiveView;
            if (!(activeView is Autodesk.Revit.DB.ViewSheet))
            {
                UI.Info.Form_Info1.infoMsgMain = "Wrong Active View";
                UI.Info.Form_Info1.infoMsgBody = "Please, open a Sheet to run this tool.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }
            #endregion

            #region sheet has viewports?
            List<Element> viewportList = GetAllViewport(doc, activeView as ViewSheet);
            if (!viewportList.Any())
            {
                UI.Info.Form_Info1.infoMsgMain = "Viewports?";
                UI.Info.Form_Info1.infoMsgBody = "This sheet does not contain any Viewport to renumber.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }
            #endregion

            // get maximum value of detail number parameter
            int maxNum = MaxDetailNumber(viewportList);

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
                            UI.Info.Form_Info1.infoMsgMain = "Incomplete Selection";
                            UI.Info.Form_Info1.infoMsgBody = "You have not selected all the viewports in this sheet.\n" +
                                                            "Only selected ones will be renumbered sequentially.\n" +
                                                            "Please, review the other detail numbers because they might have changed.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                        }
                        else // cancel command if no views selected
                        {
                            return Result.Cancelled;
                        }
                        break;
                    }
                }

                // detect viewports with det num value equals to one of the tarjet values
                // and set it to a higher number so they don´t get duplicated
                for (int i = 1; i < selection.Count() + 1; i++)
                {
                    try
                    {
                        GetAllViewports_DICT(viewportList)[i.ToString()].                 // get element with key value = i   
                            get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER). // get Detail Number parameter
                            Set((maxNum + i).ToString());                           // set parameter to greater value than the maximum of values
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                // set new value for each item selected
                int newDetNumber = 0;
                foreach (Element e in selection)
                {
                    newDetNumber += 1;
                    e.get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER).Set(newDetNumber.ToString());
                    Viewport vp = e as Viewport;
                    infoResult.Add(newDetNumber + "  ->  " + doc.GetElement(vp.ViewId).Name);
                }
                t.Commit();

                // show Results Form
                resultMsgMain = "The following viewports have been renumbered:";
                using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results()) { thisForm.ShowDialog(); }
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
