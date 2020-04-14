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

namespace Data
{
    class Helpers
    {
        public static string CreateUniqueSheetNumber(Document doc, ViewSheet activeViewSheet)
        {
            string uniqueSheetNumber = "";
            string suffix = "_Dup";
            int sequence = 1;
            ViewSheet vs = null;

            do
            {
                try  // look for duplicated sheet numbers. If collector == null es que no hay duplicados
                {
                    vs = new FilteredElementCollector(doc)
                             .OfClass(typeof(ViewSheet))
                             .Cast<ViewSheet>()
                             .Where(existingVs => existingVs.SheetNumber == activeViewSheet.SheetNumber + suffix + sequence.ToString())
                             .First();

                }
                catch (Exception)
                {
                    break;
                }
                sequence += 1;
            } while (vs != null);

            uniqueSheetNumber = activeViewSheet.SheetNumber + suffix + sequence;

            return uniqueSheetNumber;
        }

        public static string CreateUniqueViewName(Document doc, View vOnSheet)
        {
            string uniqueViewName = "";
            string suffix = "_Dup";
            int sequence = 1;
            View v = null;

            do
            {
                try
                {
                    v = new FilteredElementCollector(doc)
                        .OfClass(typeof(View))
                        .Cast<View>()
                        .Where(existingV => existingV.Name == vOnSheet.Name + suffix + sequence.ToString())
                        .First();
                }
                catch (Exception)
                {
                    break;
                }
                sequence += 1;
            } while (v != null);

            uniqueViewName = vOnSheet.Name + suffix + sequence;

            return uniqueViewName;
        }

        public static Dictionary<ViewSheet, string> GetViewSheetDict(Document doc)
        {
            Dictionary<ViewSheet, string> viewSheetDict = new Dictionary<ViewSheet, string>();
            List<ViewSheet> viewSheetCol = new FilteredElementCollector(doc).
                                        OfClass(typeof(ViewSheet)).
                                        Cast<ViewSheet>().
                                        Where(i => i.IsPlaceholder == false).
                                        ToList();

            foreach (ViewSheet vs in viewSheetCol)
            {
                viewSheetDict.Add(vs, vs.Name);
            }
            return viewSheetDict;
        }

        public static Dictionary<ViewSheet, string> GetFilteredViewSheetDict(Document doc, String st)
        {
            Dictionary<ViewSheet, string> viewSheetDict = new Dictionary<ViewSheet, string>();
            List<ViewSheet> viewSheetCol = new FilteredElementCollector(doc)
                                        .OfClass(typeof(ViewSheet))
                                        .Cast<ViewSheet>()
                                        .Where(i => i.IsPlaceholder == false)
                                        .ToList();

            foreach (ViewSheet vs in viewSheetCol)
            {
                if (vs.SheetNumber.ToUpper().Contains(st.ToUpper()) || vs.Name.ToUpper().Contains(st.ToUpper()))
                {
                    viewSheetDict.Add(vs, vs.Name);
                }
            }
            return viewSheetDict;
        }

        public static List<ViewSheet> GetSelectedSheets(List<ViewSheet> allSheets, List<string> selSheetNumber)
        {
            List<ViewSheet> selectedSheets = new List<ViewSheet>();

            foreach (ViewSheet vs in allSheets)
            {
                string vsNumber = vs.SheetNumber;
                if (selSheetNumber.Contains(vsNumber))
                {
                    selectedSheets.Add(vs);
                }
            }
            return selectedSheets;
        }

        public static List<ViewSheet> GetViewSheets(Document doc)
        {
            List<ViewSheet> viewSheets = new FilteredElementCollector(doc).
                                        OfClass(typeof(ViewSheet)).
                                        Cast<ViewSheet>().
                                        Where(i => i.IsPlaceholder == false).
                                        ToList();
            return viewSheets;
        }

        public static void DuplicateSheetsAnalytics(Document doc, Application app,
                                                    string UseTimeElapseS,
                                                    string ExecTimeElapseS,
                                                    int Ana_NoOfCopies,
                                                    int Ana_NoOfViewports,
                                                    string Ana_SheetNumber,
                                                    string Ana_SheetName)
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

            string fullString = string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16}",
                                                date, time, userName, appName,
                                                fileName, projectNumber, projectName, isInCloud, subVersionNumber, buildNumber, pcNumber,
                                                UseTimeElapseS, ExecTimeElapseS, Ana_NoOfCopies, Ana_NoOfViewports, Ana_SheetNumber, Ana_SheetName);
            #endregion

            string csvName = "Analytics_SheetDuplicator" + ".csv";

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
