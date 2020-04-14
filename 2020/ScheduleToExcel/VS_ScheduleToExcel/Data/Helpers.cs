using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    // method to replace illegal characters
    class Helpers
    {
        // remove invalida characters from schedule name
        public static string ReplaceIllegalCharaters (string stringWithIllegalChar)
        {
            char[] badChars = Path.GetInvalidFileNameChars();
            string updated = stringWithIllegalChar;
            foreach (char c in badChars)
            {
                updated = updated.Replace(c.ToString(), "_");
            }
            return updated;
        }

        // getFileMajorVersion
        private int GetMajorVersionFile (string p)
        {
            // return value
            int m_val = 0;
            // check for file
            if (System.IO.File.Exists(p))
            {
                try
                {
                    m_val = System.Diagnostics.FileVersionInfo.GetVersionInfo(p).FileMajorPart;
                }
                catch (Exception)
                {
                }
            }
            return m_val;
        }
        // get office installed version

        public static bool CheckFileExists (string excelPaths_FilePath)
        {
            bool fileExists = true;
            if (!File.Exists(excelPaths_FilePath))
            {                
                fileExists = false;
            }
            return fileExists;
        }

        public static bool CheckExcelInstall (string excelPaths_FilePath)
        {
            bool excelPathExists = false;

            string thisLine = "";
            using (StreamReader reader = new StreamReader(excelPaths_FilePath))
            {
                while (thisLine != null)
                {
                    thisLine = reader.ReadLine();
                    if (File.Exists(thisLine))
                    {
                        excelPathExists = true;
                        break;
                    }
                }
            }
            return excelPathExists;
        }

        public static List<View> GetViewSelection(Document doc, ICollection<ElementId> selIds)
        {
            List<View> validViews = new List<View>();

            if (0 != selIds.Count)
            {
                // check if the selection are view schedules
                foreach (ElementId eId in selIds)
                {
                    Element elem = doc.GetElement(eId);

                    try // try cast to View. If ViewType == schedule, add to list.
                    {
                        View v = elem as View;
                        if (v.ViewType == ViewType.Schedule)
                        {
                            validViews.Add(v);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return validViews;
        }

        public static View GetActiveViewSchedule(Document doc)
        {
            if (doc.ActiveView.ViewType == ViewType.Schedule)
            {
                return doc.ActiveView;
            }
            return null;
        }

        public static List<View> GetSelectedSchedules(Document doc, ICollection<ElementId> selIds)
        {
            List<View> scheduleList = new List<View>();

            foreach (View v in GetViewSelection(doc, selIds))
            {
                scheduleList.Add(v);
            }
            if (doc.ActiveView.ViewType == ViewType.Schedule)
            {
                scheduleList.Add(doc.ActiveView);
            }           

            return scheduleList;
        }

        public static void ScheduleToExcelAnalytics(Document doc, Application app,
                                                    string UseTimeElapseS,
                                                    string ExecTimeElapseS,
                                                    int Ana_NoOfExports)
        {
            #region INFORMATION VARIABLES
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            string time = DateTime.Now.ToString("HH:mm:ss");

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string appName = Assembly.GetExecutingAssembly().GetName().Name;
            string fileName = doc.Title;

            string projectNumber = doc.ProjectInformation.Number;
            string projectName = doc.ProjectInformation.Name;
            string isInCloud = doc.IsModelInCloud.ToString();

            string subVersionNumber = app.SubVersionNumber;
            string buildNumber = app.VersionBuild;
            string pcNumber = System.Environment.MachineName;

            string fullString = string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13}",
                                                date, time, userName, appName,
                                                fileName, projectNumber, projectName, isInCloud, subVersionNumber, buildNumber, pcNumber,
                                                UseTimeElapseS, ExecTimeElapseS, Ana_NoOfExports);
            #endregion

            string csvName = "Analytics_ScheduleToExcel" + ".csv";

            string filePath = @"D:\ANGEL\BIM\07-Macros and Plugins\ARP_Tools\z_Resources";
            string fullPath = Path.Combine(filePath, csvName);

            try
            {
                using (StreamWriter sw = File.AppendText(fullPath))
                {
                    sw.WriteLine(fullString);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
