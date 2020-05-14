using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Windows.Media.Imaging;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using ArpUtilities;

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("FAF39317-C57B-4D41-8F2B-FA73422B3717"));

        public static List<string> lt_purgedFamilies = new List<string>();
        public static List<string> lt_purgedNestedFam = new List<string>();
        public static List<string> lt_purgedNestedTypes = new List<string>();
        // dictionary with results in regards to purged types. PHASE 1.
        public static Dictionary<string, Dictionary<string, List<string>>> DictTypeResults = new Dictionary<string, Dictionary<string, List<string>>>();
        // dictionary with results in regards to purged nested families. PHASE 2.
        public static Dictionary<string, List<string>> dictNestedResults = new Dictionary<string, List<string>>();

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            #region variables declaration
            List<int> categoriesToPurge = new List<int>();
            List<Family> familiesToPurge = new List<Family>();
            #endregion

            // clear dictionaries to avoid second run error: "An item with the same key already exists"
            DictTypeResults.Clear();
            dictNestedResults.Clear();

            #region List of loadable categories which families will be purged

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
            #endregion

            // Show warning message
            using (UI.Warning.Form_Warning thisForm = new UI.Warning.Form_Warning())
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
            }

            // Proceed to purge
            using (TransactionGroup tg = new TransactionGroup (doc, "Purge Nested Families"))
            {
                tg.Start();

                // iterate through all project families and get the editable ones
                foreach (Family fam in new FilteredElementCollector(doc)
                        .OfClass(typeof(Family))
                        .Cast<Family>()
                        .Where(q => categoriesToPurge.Contains(q.FamilyCategory.Id.IntegerValue)))
                {
                    // declare dictionary (<string nestedf, List<string> typef) of nested families for results. PHASE 1.
                    Dictionary<string, List<string>> DictNestResults = new Dictionary<string, List<string>>();
                    string parentf = String.Format("<FAMILY> {0}", fam.Name);      // parent family

                    // filter editable families
                    if (fam != null && fam.IsInPlace == false && fam.IsEditable == true && fam.Name != "Model Text")
                    {
                        Document famdoc = doc.EditFamily(fam); // get family document

                        List<ElementId> nestedTypesToPurge = new List<ElementId>(); // list of nested types to purge
                        List<ElementId> nestedFamiliesToPurge = new List<ElementId>(); // list of nested families to purge
                        List<string> typeList = new List<string>(); // list with types per nested family

                        #region Look inside the family for types to purge and create "nestedTypesToPurge" list	
                        foreach (ElementType et in new FilteredElementCollector(famdoc)
                                .OfClass(typeof(ElementType))
                                .Cast<ElementType>()
                                .Where(q => q.Category != null 
                                           && categoriesToPurge.Contains(q.Category.Id.IntegerValue) 
                                           && q.FamilyName != "Model Text"))
                        {
                            if (new FilteredElementCollector(famdoc)
                                .WhereElementIsNotElementType()
                                .Where(q => q.GetTypeId() == et.Id).Count() == 0)
                            {
                                nestedTypesToPurge.Add(et.Id); // populate list with ids to delete afterwards

                                #region Populate dictionary of results to show in TreeView. PHASE 1.                               
                                string nestedf = string.Format("<FAMILY> {0}", et.FamilyName); // nested family
                                string typef = string.Format("<TYPE> {0}", et.Name);         // element type inside nested family

                                // does parent family exists?
                                if (DictTypeResults.ContainsKey(parentf))
                                {
                                    // does nested family exist? If yes, add type
                                    if (DictNestResults.ContainsKey(nestedf))
                                    {
                                        typeList.Add(typef);                    // update typeList
                                        DictNestResults[nestedf] = typeList;    // update DictNestResults
                                        DictTypeResults[parentf] = DictNestResults; // update DictTypeResults                                        
                                    }
                                    // if not, add nested family, add type
                                    else
                                    {
                                        typeList.Add(typef);                    // add first element to typeList
                                        DictNestResults.Add(nestedf, typeList); // create new key-value pair
                                        DictTypeResults[parentf] = DictNestResults; // update DictTypeResults                                        
                                    }
                                }
                                // If not, add parent family, add nested family, add type
                                else
                                {
                                    typeList.Add(typef);                        // add first element to typeList
                                    DictNestResults.Add(nestedf, typeList);     // create new key-value pair in DictNestResults
                                    DictTypeResults.Add(parentf, DictNestResults);  // create new key-value pair in DictTypeResults
                                    
                                }
                                #endregion
                            }                            
                        }
                        #endregion

                        #region PURGE TYPES
                        if (nestedTypesToPurge != null && nestedTypesToPurge.Count() != 0)
                        {
                            using (Transaction t = new Transaction (famdoc, "Purge family types"))
                            {
                                t.Start();
                                foreach (ElementId eId in nestedTypesToPurge)
                                {
                                    lt_purgedNestedTypes.Add(famdoc.GetElement(eId).Name);
                                    famdoc.Delete(eId);
                                }
                                t.Commit();
                            }
                        }
                        #endregion

                        #region look inside the family for nested families to purge and create "nestedFamiliesToPurge" list
                        
                        List<string> listNestedResults = new List<string>(); // declare list of nested families to show on results

                        dictNestedResults.Add(parentf, listNestedResults);

                        foreach (Family nesfam in new FilteredElementCollector(famdoc)
                                .OfClass(typeof(Family))
                                .Cast<Family>()
                                .Where(q => categoriesToPurge.Contains(q.FamilyCategory.Id.IntegerValue) && q.Name != ""))
                        {
                            if (new FilteredElementCollector(famdoc)
                                .OfClass(typeof(FamilyInstance))
                                .Cast<FamilyInstance>()
                                .Where(q => q.Symbol.Family.Id == nesfam.Id)
                                .Count() == 0)
                            {
                                nestedFamiliesToPurge.Add(nesfam.Id);
                                familiesToPurge.Add(fam);

                                listNestedResults.Add(string.Format("<FAMILY> {0}", nesfam.Name));             // update results list of purged nested families
                                dictNestedResults[parentf] = listNestedResults; // update dictionary to show on results
                            }
                        }
                        familiesToPurge = familiesToPurge.Distinct().ToList();
                        #endregion

                        #region PURGE FAMILIES
                        if (nestedFamiliesToPurge.Count() != 0)
                        {
                            foreach (ElementId eId in nestedFamiliesToPurge)
                            {
                                if (famdoc.GetElement(eId) != null)
                                {
                                    try
                                    {
                                        lt_purgedNestedFam.Add(famdoc.GetElement(eId).Name);
                                        using (Transaction t = new Transaction(famdoc, "Purge nested families Transaction"))
                                        {
                                            t.Start();
                                            famdoc.Delete(eId);
                                            t.Commit();
                                        }
                                    }
                                    catch (Exception)
                                    {

                                    }
                                }
                            }
                        }
                        
                        #endregion
                    }
                }

                #region Load families back to the project
                if (familiesToPurge.Count() != 0)
                {
                    foreach (Family f in familiesToPurge)
                    {
                        lt_purgedFamilies.Add(f.Name);
                        Document fdoc = doc.EditFamily(f);

                        Data.Helpers.MyFamilyLoadOptions familyOptions = new Data.Helpers.MyFamilyLoadOptions();
                        fdoc.LoadFamily(doc, familyOptions);
                        fdoc.Close(false);
                    }
                }
                #endregion

                tg.Assimilate();
            }

            // Show results
            using (UI.Results.Form_Results thisForm = new UI.Results.Form_Results())
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
            }

            //try
            //{
            //    Utilities.GetAnalyticsCSV(doc, app);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            return Result.Succeeded;
        }
    }
}

// NOTE: excluir titleblocks de la purga
