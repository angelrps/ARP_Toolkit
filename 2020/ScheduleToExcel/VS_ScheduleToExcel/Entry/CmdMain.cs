using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Microsoft.Office.Interop.Excel;
using Autodesk.Revit.ApplicationServices;
using ArpUtilities;
using System.Diagnostics;

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("E8232172-2898-410F-9535-364C2D46445F"));
        static public string warningMsgMain = "";
        static public string warningMsgBody = "";

        #region Variables for analytics
        private static readonly Stopwatch useTime = new Stopwatch();        // total time user has the application open and it does actually make a transaction

        public static string UseTimeElapseS { get; set; } = "";
        public static string ExecTimeElapseS { get; set; } = "";    // for this application Use Time will be the same as Execution Time
        public static int Ana_NoOfExports { get; set; } = 0;        // number of schedules exported
        #endregion

        public Result Execute (ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            #region variables
            UIApplication uiapp = commandData.Application;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            // element selection
            ICollection<ElementId> selIds = uidoc.Selection.GetElementIds();

            // excel export settings
            ViewScheduleExportOptions export_options = new ViewScheduleExportOptions();

            // paths to check Excel install                  
            string excelPaths_FileName = "OpenInExcel_UserPaths.txt";
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string excelPaths_FilePath = Path.Combine(assemblyPath, excelPaths_FileName);

            // paths to export schedule
            string temp_folder = Path.GetTempPath();
            #endregion

            // check if file exists
            if (!Data.Helpers.CheckFileExists(excelPaths_FilePath))
            {
                warningMsgMain = "File missing";
                warningMsgBody = string.Format("Could not find the File: {0}{0}{1} in {2}{0}{0}Contact angelruizpeinado@gmail.com for help.",
                                                Environment.NewLine,
                                                excelPaths_FileName,
                                                assemblyPath);
                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
                return Result.Cancelled;
            }

            // check if excel is installed in usual paths
            if (!Data.Helpers.CheckExcelInstall(excelPaths_FilePath))
            {
                warningMsgMain = "Excel not found";
                warningMsgBody = string.Format("Could not find Excel installed in the usual paths.{0}{0}" +
                                                "Please install Excel or add your Excel path to the OpenInExcel_UserPaths.txt " +
                                                "(located in {1}) and try again.{0}{0}" +
                                                "Contact angelruizpeinado@gmail.com for help.", Environment.NewLine, assemblyPath);

                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
                return Result.Cancelled;
            }

            // if there are not schedules selected or open throw a message
            if (!Data.Helpers.GetSelectedSchedules(doc, selIds).Any())
            {
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
                return Result.Cancelled;
            }

            // go ahead and export the selected schedules
            if (Data.Helpers.GetSelectedSchedules(doc, selIds).Any())
            {
                // start counters. For this application Use Time and Execution time will be the same.
                useTime.Start();

                Random randomNumber = new Random();

                // create excel name with schedule name + random number
                foreach (View v in Data.Helpers.GetSelectedSchedules(doc, selIds))
                {
                    Ana_NoOfExports += 1;   // count number of schedules exported

                    string scheduleName = Data.Helpers.ReplaceIllegalCharaters(v.Name);
                    string txtFileName = scheduleName + "_" + randomNumber.Next(1000) + ".txt";
                    string scheduleExportPath = Path.Combine(temp_folder, txtFileName);

                    // export schedule to .txt
                    ViewSchedule viewSchedule = v as ViewSchedule;
                    viewSchedule.Export(temp_folder, txtFileName, export_options);

                    // open .txt schedule with excel
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Visible = true; // make the running excel instance visible
                    Workbook wb = excelApp.Workbooks.Open(scheduleExportPath);
                }
                useTime.Stop();
                UseTimeElapseS = useTime.Elapsed.Seconds.ToString();
                ExecTimeElapseS = UseTimeElapseS;
            }
            try
            {
                Utilities.GetAnalyticsCSV(doc, app);
                Data.Helpers.ScheduleToExcelAnalytics(doc, app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfExports);
            }
            catch (Exception)
            {
            }
            return Result.Succeeded;
        }
    }
}
