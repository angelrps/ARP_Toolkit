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

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    public class CmdMain : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            #region variables declaration
            List<int> categoriesToPurge = Data.Helpers.CategoriesToPurge();
            List<Family> editableFamilies = Data.Helpers.GetEditableFamilies(doc);
            List<Family> familiesToPurge = new List<Family>();   
            string st_purgedNestedFam = "";
            string st_purgedFamilies = "";
            string st_purgedNestedTypes = "";
            #endregion

            // warn the user if he wants to proceed
            TaskDialog td = new TaskDialog("Purge Nested Families")
            {
                MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                AllowCancellation = true,
                MainInstruction = "This tool is very destructive. It deletes all unused nested families from your project families. "
                                    + "Proceed only if you know what you are doing!"
                                    + "\n" + "\n" + "Are you sure you want to proceed?",
                CommonButtons = TaskDialogCommonButtons.Cancel | TaskDialogCommonButtons.Ok,
                TitleAutoPrefix = false
            };

            TaskDialogResult tResult = td.Show();

            if (TaskDialogResult.Cancel == tResult)
            {
                return Result.Cancelled;
            }

            using (TransactionGroup tg = new TransactionGroup (doc, "Purge Nested Families"))
            {
                tg.Start();

                // iterate through all editable families and get the editable ones
                foreach (Family fam in editableFamilies)
                {                    
                    Document famdoc = doc.EditFamily(fam); // get family document

                    List<ElementId> nestedTypesToPurge = new List<ElementId>(); // list of nested types to purge
                    List<ElementId> nestedFamiliesToPurge = new List<ElementId>(); // list of nested families to purge

                    #region Look inside the family for types to purge and create "nestedTypesToPurge" list	
                    foreach (ElementType et in new FilteredElementCollector(famdoc)  // Element Types are non user visible elements that contain instances
                            .OfClass(typeof(ElementType))
                            .Cast<ElementType>()
                            .Where(q => q.Category != null && categoriesToPurge.Contains(q.Category.Id.IntegerValue) && q.FamilyName != "Model Text"))
                    {
                        if (new FilteredElementCollector(famdoc)  // compare current loop ElementType id with all placed instances
                            .WhereElementIsNotElementType()       // if NOT found matches, add ElementType id to purge list
                            .Where(q => q.GetTypeId() == et.Id).Count() == 0)
                        {
                            nestedTypesToPurge.Add(et.Id);
                        }
                    }
                    #endregion

                    #region PURGE TYPES
                    if (nestedTypesToPurge != null)
                    {
                        using (Transaction t = new Transaction (famdoc, "Purge family types"))
                        {
                            t.Start();
                            foreach (ElementId eId in nestedTypesToPurge)
                            {
                                st_purgedNestedTypes += "-" + famdoc.GetElement(eId).Name + "\n";
                                famdoc.Delete(eId);
                            }
                            t.Commit();
                        }
                    }
                    #endregion

                    #region look inside the family for nested families to purge and create "nestedFamiliesToPurge" list
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
                        }
                    }
                    familiesToPurge = familiesToPurge.Distinct().ToList();
                    #endregion

                    #region PURGE FAMILIES
                    foreach (ElementId eId in nestedFamiliesToPurge)
                    {
                        if (famdoc.GetElement(eId) != null)
                        {
                            //string familyMother = famdoc.OwnerFamily.Name;
                            try
                            {
                                st_purgedNestedFam += "-" + famdoc.GetElement(eId).Name + "\n";
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
                            //st_purgedNestedFam += famdoc.GetElement(eId).Name + "\n";
                            //using (Transaction t = new Transaction (famdoc, "Purge nested families Transaction"))
                            //{
                            //    t.Start();
                            //    famdoc.Delete(eId);
                            //    t.Commit();
                            //}
                        }
                    }
                    #endregion
                    
                }

                #region Load families back to the project
                foreach (Family f in familiesToPurge)
                {
                    st_purgedFamilies += "-" + f.Name + "\n";
                    Document fdoc = doc.EditFamily(f);

                    Data.Helpers.MyFamilyLoadOptions familyOptions = new Data.Helpers.MyFamilyLoadOptions();
                    fdoc.LoadFamily(doc, familyOptions);
                    fdoc.Close(false);
                }
                #endregion

                tg.Assimilate();
            }

            TaskDialog.Show("Information", "Purged Families:" + "\n" + st_purgedFamilies + "\n"
                                           + "Deleted Nested Families:" + "\n" + st_purgedNestedFam + "\n"
                                           + "Deleted Nested Types:" + "\n" + st_purgedNestedTypes);
            try
            {
                Data.Helpers.GetAnalyticsCSV(doc, app);
            }
            catch (Exception)
            {

                throw;
            }
            return Result.Succeeded;
        }
    }
}

// NOTE: excluir titleblocks de la purga
