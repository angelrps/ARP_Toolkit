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
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    class Helpers
    {
        public class DoorSelectionFilter : ISelectionFilter
        {
            public bool AllowElement(Element elem)
            {
                if (elem.Category.Name == "Doors")
                {
                    return true;
                }
                return false;
            }

            public bool AllowReference(Reference reference, XYZ position)
            {
                return true;
            }
        }

        public class WallSelectionFilter : ISelectionFilter
        {
            public bool AllowElement(Element elem)
            {
                if (elem.Category.Name == "Walls")
                {
                    return true;
                }
                return false;
            }

            public bool AllowReference(Reference reference, XYZ position)
            {
                return true;
            }
        }

        public static List<Element> GetSelectedDoors(UIDocument uidoc)
        {
            List<Element> doorList = new List<Element>();
            ICollection<ElementId> doorIds = uidoc.Selection.GetElementIds();

            foreach (ElementId eId in doorIds)
            {
                Element doorElem = uidoc.Document.GetElement(eId);
                if (doorElem.Category.Name == "Doors")
                {
                    doorList.Add(doorElem);
                }
            }
            return doorList;
        }

        public static List<Element> GetSelectedWalls(UIDocument uidoc)
        {
            List<Element> wallList = new List<Element>();
            ICollection<ElementId> wallIds = uidoc.Selection.GetElementIds();

            foreach (ElementId eId in wallIds)
            {
                Element wallElem = uidoc.Document.GetElement(eId);
                if (wallElem.Category.Name == "Walls")
                {
                    wallList.Add(wallElem);
                }
            }
            return wallList;
        }

        public static void FlipAnalytics(Document doc, Application app,
                                                    string UseTimeElapseS,
                                                    string ExecTimeElapseS,
                                                    int Ana_NoOfFlippedWalls,
                                                    int Ana_NoOfFlippedDoors)
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

            string fullString = string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}",
                                                date, time, userName, appName,
                                                fileName, projectNumber, projectName, isInCloud, subVersionNumber, buildNumber, pcNumber,
                                                UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFlippedWalls, Ana_NoOfFlippedDoors);
            #endregion

            string csvName = "Analytics_Flip" + ".csv";

            string filePath = @"D:\ANGEL\BIM\07 - Macros and Plugins\ARP_Tools\z_Resources";
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
