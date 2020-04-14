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
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("AFE68AD6-B55B-4A1D-9BEE-A46D1DFE3381"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // check if is family document
            if (doc.IsFamilyDocument)
            {
                TaskDialog tdFam = new TaskDialog("Information")
                {
                    MainInstruction = "This is a family document.\nRun this tool in a project document.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdFam.Show();
                return Result.Cancelled;
            }

            // warns the user if he wants to proceed
            TaskDialog td = new TaskDialog("Remove Empty Elevation Tags")
            {
                AllowCancellation = true,
                MainInstruction = "This application will remove all Empty Elevation Tags from the Project."
                                    + "\n" + "\n" + "Do you want to proceed?",
                CommonButtons = TaskDialogCommonButtons.Cancel | TaskDialogCommonButtons.Ok,
                TitleAutoPrefix = false
            };

            TaskDialogResult tResult = td.Show();

            // cancel execution if dialog is closed or cancelled
            if (TaskDialogResult.Cancel == tResult)
            {
                return Result.Cancelled;
            }
            // execute code
            else
            {
                string info = "";       // elements removed
                string infoFail = "";   // elements failed to be removed
                int count = 0;          // number of elements removed
                int countFail = 0;      // number of elements failed

                using (TransactionGroup tg = new TransactionGroup (doc, "Remove Elevation Tags"))
                {
                    tg.Start();
                    foreach (Element e in new FilteredElementCollector(doc)
                                            .OfClass(typeof(ElevationMarker))
                                            .WhereElementIsNotElementType()
                                            .ToElements())
                    {
                        ElevationMarker em = e as ElevationMarker;

                        // only proceed with empty elevation marks
                        if (em.HasElevations() == false)
                        {
                            string elevType = doc.GetElement(e.GetTypeId()).Name;
                            string itemInfo = "ID: " + "\t" + e.Id + "     Elevation Type: " + elevType;
                            string itemFail = "ID: " + "\t" + e.Id + "     Elevation Type: " + elevType;
                            try
                            {
                                // delete item
                                using (Transaction t = new Transaction(doc, "Remove Single Elevation Tag"))
                                {
                                    t.Start();
                                    doc.Delete(e.Id);
                                    t.Commit();
                                }
                                // collect info
                                info += itemInfo + "\n";
                                count += 1;
                            }
                            catch (Exception)
                            {
                                infoFail += itemFail + "\n";
                                countFail += 1;
                            }
                        }                                               
                    }
                    tg.Assimilate();
                }

                try
                {
                    Utilities.GetAnalyticsCSV(doc, app);
                }
                catch (Exception)
                {
                }

                if (count == 0)
                {
                    TaskDialog tdInfo1 = new TaskDialog("Information")
                    {
                        MainInstruction = "There are not Empty Elevation Tags in this document.",
                        TitleAutoPrefix = false
                    };
                    TaskDialogResult tdInfo1Result = tdInfo1.Show();
                    return Result.Succeeded;
                }

                if (count != 0)
                {
                    TaskDialog tdInfo2 = new TaskDialog("Information")
                    {
                        MainInstruction = "Items removed: " + count + "\n" + "\n" + info + "\n"
                                                + "Failed removing these items: " + countFail + "\n" + "\n" + infoFail,
                        TitleAutoPrefix = false
                    };
                    TaskDialogResult tdInfoResult = tdInfo2.Show();
                    return Result.Succeeded;
                }
                

                return Result.Succeeded;
                
                //TaskDialog.Show("Information", "Items removed: " + count + "\n" + "\n" + info + "\n"
                //                                + "Failed removing these items: " + countFail + "\n" + "\n" + infoFail);
            }            
        }
    }
}
