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

        public static List<string> info = new List<string>();       // elements removed
        public static List<string> infoFail = new List<string>();   // elements failed to be removed
        public static int count = 0;                                // number of elements removed
        public static int countFail = 0;                            // number of elements failed

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            #region check if it is family document
            if (doc.IsFamilyDocument)
            {
                using (UI.Form_Info3 thisForm = new UI.Form_Info3())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }
            #endregion

            #region warn the user if he wants to proceed
            using (UI.Warning.Form_Warning thisForm = new UI.Warning.Form_Warning())
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
            }
            #endregion

            #region remove elevation tags
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
                            //string itemInfo = "ID: " + "\t" + e.Id + "     Elevation Type: " + elevType;
                            //string itemFail = "ID: " + "\t" + e.Id + "     Elevation Type: " + elevType;
                            string itemInfo = string.Format("Elevation Type: {0} (ID: {1})", elevType, e.Id);
                            string itemFail = string.Format("Elevation Type: {0} (ID: {1})", elevType, e.Id);
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
                                info.Add(itemInfo);
                                count += 1;
                            }
                            catch (Exception)
                            {
                                infoFail.Add(itemFail);
                                countFail += 1;
                            }
                        }                                               
                    }
                tg.Assimilate();
                }
            #endregion

            // if count = 0 show Not Found form
            if (count == 0)
            {
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
            }

            // show Results Form
            if (count != 0)
            {
                using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results())
                {
                    thisForm.ShowDialog();
                }
            }

            #region get analytics
            try
            {
                Utilities.GetAnalyticsCSV(doc, app);
            }
            catch (Exception)
            {
            }
            #endregion

            return Result.Succeeded;   
            
        }
    }
}
