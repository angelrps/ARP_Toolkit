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
        public static Dictionary<View, string> GetViewTemplatesDict(Document doc)
        {
            Dictionary<View, string> viewTemplatesDict = new Dictionary<View, string>();
            List<View> viewCol = new FilteredElementCollector(doc).
                                OfClass(typeof(View)).
                                Cast<View>().
                                Where(q => q.IsTemplate).
                                ToList();
            foreach (View v in viewCol)
            {
                viewTemplatesDict.Add(v, v.Name);
            }
            return viewTemplatesDict;
        }

        public static Dictionary<View, String> GetViewTemplateWithFilters(Document doc)
        {
            Dictionary<View, String> templatesWithFilters = new Dictionary<View, String>();

            List<View> viewCol = new FilteredElementCollector(doc).
                                OfClass(typeof(View)).
                                Cast<View>().
                                Where(q => q.IsTemplate).
                                ToList();

            foreach (View v in viewCol)
            {
                if (v.GetFilters().Count > 0)
                {
                    templatesWithFilters.Add(v, v.Name);
                }
            }

            return templatesWithFilters;
        }

        public static View GetTemplateByName(Document doc, string name)
        {
            View template = new FilteredElementCollector(doc).
                                OfClass(typeof(View)).
                                Cast<View>().
                                Where(q => q.IsTemplate && q.Name == name).
                                FirstOrDefault();
            return template;
        }

        public static void TransferViewFiltersAnalytics(Document doc, Application app,
                                                    string UseTimeElapseS,
                                                    string ExecTimeElapseS,
                                                    int Ana_NoOfFilters_Total,
                                                    int Ana_NoOfFilters_Applied,
                                                    int Ana_NoOfFilters_Overriden,
                                                    int Ana_NoOfTemplates)
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
                                                UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFilters_Total, Ana_NoOfFilters_Applied, Ana_NoOfFilters_Overriden, Ana_NoOfTemplates);
            #endregion

            string csvName = "Analytics_TransferViewFilters" + ".csv";

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
