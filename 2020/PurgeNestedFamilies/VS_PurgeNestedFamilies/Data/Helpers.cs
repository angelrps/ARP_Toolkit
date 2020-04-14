using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    class Helpers
    {
        // WORKS
        public static List<int> CategoriesToPurge()
        {
            List<int> categoriesToPurge = new List<int>();

            categoriesToPurge.Add((int)BuiltInCategory.OST_CableTrayFitting);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Casework);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Columns);
            categoriesToPurge.Add((int)BuiltInCategory.OST_CommunicationDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_ConduitFitting);
            categoriesToPurge.Add((int)BuiltInCategory.OST_DataDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Doors);
            categoriesToPurge.Add((int)BuiltInCategory.OST_DuctAccessory);
            categoriesToPurge.Add((int)BuiltInCategory.OST_DuctFitting);
            categoriesToPurge.Add((int)BuiltInCategory.OST_ElectricalEquipment);
            categoriesToPurge.Add((int)BuiltInCategory.OST_ElectricalFixtures);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Entourage);
            categoriesToPurge.Add((int)BuiltInCategory.OST_FireAlarmDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Furniture);
            categoriesToPurge.Add((int)BuiltInCategory.OST_FurnitureSystems);
            categoriesToPurge.Add((int)BuiltInCategory.OST_GenericModel);
            categoriesToPurge.Add((int)BuiltInCategory.OST_LightingDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_LightingFixtures);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Mass);
            categoriesToPurge.Add((int)BuiltInCategory.OST_MechanicalEquipment);
            categoriesToPurge.Add((int)BuiltInCategory.OST_NurseCallDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Parking);
            categoriesToPurge.Add((int)BuiltInCategory.OST_PipeAccessory);
            categoriesToPurge.Add((int)BuiltInCategory.OST_PipeFitting);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Planting);
            categoriesToPurge.Add((int)BuiltInCategory.OST_PlumbingFixtures);
            categoriesToPurge.Add((int)BuiltInCategory.OST_RailingSupport);
            categoriesToPurge.Add((int)BuiltInCategory.OST_RailingTermination);
            categoriesToPurge.Add((int)BuiltInCategory.OST_SecurityDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Site);
            categoriesToPurge.Add((int)BuiltInCategory.OST_SpecialityEquipment);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Sprinklers);
            categoriesToPurge.Add((int)BuiltInCategory.OST_StructuralColumns);
            categoriesToPurge.Add((int)BuiltInCategory.OST_StructuralFoundation);
            categoriesToPurge.Add((int)BuiltInCategory.OST_StructuralFraming);
            categoriesToPurge.Add((int)BuiltInCategory.OST_StructuralStiffener);
            categoriesToPurge.Add((int)BuiltInCategory.OST_TelephoneDevices);
            categoriesToPurge.Add((int)BuiltInCategory.OST_Windows);

            return categoriesToPurge;
        }
        // WORKS
        public static List<Family> GetEditableFamilies(Document doc)
        {
            List<Family> editableFamilies = new List<Family>();
            List<int> categoriesToPurge = Data.Helpers.CategoriesToPurge();

            foreach (Family fam in new FilteredElementCollector(doc)
                        .OfClass(typeof(Family))
                        .Cast<Family>()
                        .Where(q => categoriesToPurge.Contains(q.FamilyCategory.Id.IntegerValue)))
            {
                if (fam != null && fam.IsInPlace == false && fam.IsEditable == true && fam.Name != "Model Text")
                {
                    editableFamilies.Add(fam);
                }
            }

            return editableFamilies;
        }

        //public static  GetPurgableFam ()
        //{

        //}

        public static List<ElementType> GetPurgableNestedTypes(Document famdoc, List<int> categoriesToPurge)
        {
            List<ElementType> purgableNestedTypes = new List<ElementType>();

            // collection of all ElementTypes (non user visible elements that define instances)
            IEnumerable<ElementType> elemTypeCol = new FilteredElementCollector(famdoc)
                                                .OfClass(typeof(ElementType))
                                                .Cast<ElementType>()
                                                .Where(q => q.Category != null && categoriesToPurge.Contains(q.Category.Id.IntegerValue) && q.FamilyName != "Model Text");

            // collection of places instances which are not ElementType.
            FilteredElementCollector NotElemTypeCol = new FilteredElementCollector(famdoc)
                                    .WhereElementIsNotElementType();

            foreach (ElementType et in elemTypeCol)
            {
                if (NotElemTypeCol.Where(q => q.GetTypeId() == et.Id).Count() == 0)
                {
                    purgableNestedTypes.Add(et);
                }
            }

            return purgableNestedTypes;
        }

        public static List<Family> GetPurgableNestedFamilies(Document famdoc, List<int> categoriesToPurge)
        {
            List<Family> purgableNestedFamilies = new List<Family>();

            // collection off all purgable nested families
            IEnumerable<Family> familyCol = new FilteredElementCollector(famdoc)
                                .OfClass(typeof(Family))
                                .Cast<Family>()
                                .Where(q => categoriesToPurge.Contains(q.FamilyCategory.Id.IntegerValue) && q.Name != "");

            // collection of family instances
            IEnumerable<FamilyInstance> instanceCol = new FilteredElementCollector(famdoc)
                                                            .OfClass(typeof(FamilyInstance))
                                                            .Cast<FamilyInstance>();

            // compare Ids of instances with families
            foreach (Family nesfam in familyCol)
            {
                if (instanceCol.Where(q => q.Symbol.Family.Id == nesfam.Id)
                    .Count() == 0)
                {
                    purgableNestedFamilies.Add(nesfam);
                }
            }

            return purgableNestedFamilies;
        }


        public class MyFamilyLoadOptions : IFamilyLoadOptions
        {
            public bool OnFamilyFound (bool familyInUse, out bool overwriteParameterValues)
            {
                overwriteParameterValues = false;
                return true;
            }
            public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
            {
                source = FamilySource.Family;
                overwriteParameterValues = false;
                return true;
            }
        }

        public class MyFailureHandler : IFailuresPreprocessor
        {
            public FailureProcessingResult PreprocessFailures(FailuresAccessor failuresAccessor)
            {
                failuresAccessor.DeleteAllWarnings();
                return FailureProcessingResult.Continue;
            }
        }

        public static void GetAnalyticsCSV(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            #region INFORMATION VARIABLES
            List<string> infoList = new List<string>();

            string date = DateTime.Now.ToString("yyyy.MM.dd");
            string time = DateTime.Now.ToString("HH:mm:ss");

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string appName = Assembly.GetExecutingAssembly().GetName().Name;
            string fileName = doc.Title;

            string subVersionNumber = app.SubVersionNumber;
            string buildNumber = app.VersionBuild;
            string pcNumber = System.Environment.MachineName;

            string fullString = string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7}",
                                                date, time, userName, appName,
                                                fileName, subVersionNumber, buildNumber, pcNumber);
            #endregion

            string csvName = "CSVAnalytics" + ".csv";
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
