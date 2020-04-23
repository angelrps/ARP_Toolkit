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
        public static List<string> failNamesList = new List<string>();
        public static int countSuccess = 0;
        public static List<string> namesSuccess = new List<string>();
        public static string instanceOrType = "";
        public static string exceptionMessage = "";

        public static SortedDictionary<string, List<Definition>> GetParameterByGroup(Application app)
        {
            SortedDictionary<string, List<Definition>> DefinitionsByGroup = new SortedDictionary<string ,List<Definition>>();

            DefinitionFile definitionFile = null;
            // definition file exists?
            try
            {
                definitionFile = app.OpenSharedParameterFile();
            }
            catch (Exception)
            {
            }

            if (definitionFile is null)
            {
                exceptionMessage = "DefinitionFile of Shared Parameters File does not exist." +
                                    " Something went wrong when trying to open the Shared Parameter File.";
                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
            }

            try
            {                
                // iterate through all groups
                foreach (DefinitionGroup gr in definitionFile.Groups)
                {
                    // create sorted list of Definitions
                    List<Definition> defList = new List<Definition>();
                    foreach (Definition def in gr.Definitions)
                    {
                        defList.Add(def);
                    }
                    List<Definition> sortedList = defList.OrderBy(x => x.Name).ToList();

                    // iterate sorted list and populate dictionary
                    foreach (Definition def in sortedList)
                    {
                        // By Groups
                        if (!DefinitionsByGroup.ContainsKey(gr.Name))
                        {
                            DefinitionsByGroup.Add(gr.Name, sortedList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionMessage = "Parameters could not be loaded: " + ex.Message;
                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
            }
            return DefinitionsByGroup;
        }

        public static SortedDictionary<string, List<Definition>> GetParameterByType(Application app)
        {
            SortedDictionary<string, List<Definition>> DefinitionsByType = new SortedDictionary<string, List<Definition>>();

            DefinitionFile definitionFile = null;
            // definition file exists?
            try
            {
                definitionFile = app.OpenSharedParameterFile();
            }
            catch (Exception)
            {
            }

            if (definitionFile is null)
            {
                exceptionMessage = "DefinitionFile of Shared Parameters File does not exist." +
                                    " Something went wrong when trying to open the Shared Parameter File.";
                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
            }

            try
            {
                // iterate all groups
                foreach (DefinitionGroup gr in definitionFile.Groups)
                {
                    // create sorted list of Definitions
                    List<Definition> defList = new List<Definition>();
                    foreach (Definition def in gr.Definitions)
                    {
                        defList.Add(def);
                    }
                    List<Definition> sortedList = defList.OrderBy(x => x.Name).ToList();

                    // itereate sorted list and populate dictionary
                    foreach (Definition def in sortedList)
                    {
                        // By Type
                        if (!DefinitionsByType.ContainsKey(def.ParameterType.ToString()))
                        {
                            DefinitionsByType.Add(def.ParameterType.ToString(), sortedList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionMessage = "Parameters could not be loaded: " + ex.Message;
                using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
            }
            return DefinitionsByType;
        }

        public static void LoadSharedParameterFile(Application app, string file)
        {
            // load the file
            app.SharedParametersFilename = file;
            DefinitionFile df = app.OpenSharedParameterFile();

            // get parameters
            //if ()
            //{

            //}
        }

        public static List<BuiltInParameterGroup> ParameterGroupsList()
        {
            List<BuiltInParameterGroup> validGroups = new List<BuiltInParameterGroup>();

            #region add parameters one by one
            validGroups.Add(BuiltInParameterGroup.PG_ANALYSIS_RESULTS);
            validGroups.Add(BuiltInParameterGroup.PG_ANALYTICAL_ALIGNMENT);
            validGroups.Add(BuiltInParameterGroup.PG_ANALYTICAL_MODEL);
            validGroups.Add(BuiltInParameterGroup.PG_CONSTRAINTS);
            validGroups.Add(BuiltInParameterGroup.PG_CONSTRUCTION);
            validGroups.Add(BuiltInParameterGroup.PG_COUPLER_ARRAY);
            validGroups.Add(BuiltInParameterGroup.PG_DATA);
            validGroups.Add(BuiltInParameterGroup.PG_GEOMETRY); // Dimensions
            validGroups.Add(BuiltInParameterGroup.PG_DIVISION_GEOMETRY);
            validGroups.Add(BuiltInParameterGroup.PG_AELECTRICAL);
            validGroups.Add(BuiltInParameterGroup.PG_ELECTRICAL_CIRCUITING);
            validGroups.Add(BuiltInParameterGroup.PG_ELECTRICAL_LIGHTING);
            validGroups.Add(BuiltInParameterGroup.PG_ELECTRICAL_LOADS);
            validGroups.Add(BuiltInParameterGroup.PG_ELECTRICAL);
            validGroups.Add(BuiltInParameterGroup.PG_ENERGY_ANALYSIS);
            validGroups.Add(BuiltInParameterGroup.PG_FIRE_PROTECTION);
            validGroups.Add(BuiltInParameterGroup.PG_FORCES);
            validGroups.Add(BuiltInParameterGroup.PG_GENERAL);
            validGroups.Add(BuiltInParameterGroup.PG_GRAPHICS);
            validGroups.Add(BuiltInParameterGroup.PG_GREEN_BUILDING);
            validGroups.Add(BuiltInParameterGroup.PG_IDENTITY_DATA);
            validGroups.Add(BuiltInParameterGroup.PG_IFC);
            validGroups.Add(BuiltInParameterGroup.PG_REBAR_SYSTEM_LAYERS);
            validGroups.Add(BuiltInParameterGroup.PG_MATERIALS);
            validGroups.Add(BuiltInParameterGroup.PG_MECHANICAL);
            validGroups.Add(BuiltInParameterGroup.PG_MECHANICAL_AIRFLOW);
            validGroups.Add(BuiltInParameterGroup.PG_MECHANICAL_LOADS);
            validGroups.Add(BuiltInParameterGroup.PG_ADSK_MODEL_PROPERTIES);
            validGroups.Add(BuiltInParameterGroup.PG_MOMENTS);
            validGroups.Add(BuiltInParameterGroup.INVALID); // other
            validGroups.Add(BuiltInParameterGroup.PG_OVERALL_LEGEND);
            validGroups.Add(BuiltInParameterGroup.PG_PHASING);
            validGroups.Add(BuiltInParameterGroup.PG_LIGHT_PHOTOMETRICS);
            validGroups.Add(BuiltInParameterGroup.PG_PLUMBING);
            validGroups.Add(BuiltInParameterGroup.PG_PRIMARY_END);
            validGroups.Add(BuiltInParameterGroup.PG_REBAR_ARRAY);
            validGroups.Add(BuiltInParameterGroup.PG_RELEASES_MEMBER_FORCES);
            validGroups.Add(BuiltInParameterGroup.PG_SECONDARY_END);
            validGroups.Add(BuiltInParameterGroup.PG_SEGMENTS_FITTINGS);
            validGroups.Add(BuiltInParameterGroup.PG_SLAB_SHAPE_EDIT);
            validGroups.Add(BuiltInParameterGroup.PG_STRUCTURAL);
            validGroups.Add(BuiltInParameterGroup.PG_STRUCTURAL_ANALYSIS);
            validGroups.Add(BuiltInParameterGroup.PG_TEXT);
            validGroups.Add(BuiltInParameterGroup.PG_TITLE);
            validGroups.Add(BuiltInParameterGroup.PG_VISIBILITY);
            #endregion

            return validGroups;
        }

        public static void BindDefinitionsToCategories(Document doc,
                                                Application app,
                                                List<Definition> defList,
                                                List<Category> catList,
                                                BuiltInParameterGroup bipGroup,
                                                bool isInstance)
        {
            // restart variables to 0.
            failNamesList.Clear();
            countSuccess = 0;
            namesSuccess.Clear();
            instanceOrType = isInstance == true ? instanceOrType = "Instance" : instanceOrType = "Type";

            // category set
            CategorySet catSet = app.Create.NewCategorySet();
            foreach (Category cat in catList)
            {
                catSet.Insert(cat);
            }

            using (TransactionGroup tg = new TransactionGroup (doc, "Load Shared Parameters"))
            {
                tg.Start();
                foreach (Definition def in defList)
                {
                    using (Transaction t = new Transaction(doc, "Add parameter Binding: " + def.Name))
                    {
                        t.Start();
                        try
                        {
                            // is Family?
                            if (doc.IsFamilyDocument == true)
                            {
                                try
                                {
                                    ExternalDefinition extDef = def as ExternalDefinition;
                                    FamilyManager famMan = doc.FamilyManager;
                                    famMan.AddParameter(extDef, bipGroup, isInstance);

                                    countSuccess += 1;
                                    namesSuccess.Add(def.Name);
                                }
                                catch (Exception e)
                                {
                                    failNamesList.Add(def.Name + " (" + e.Message + ")");
                                }
                            }
                            // is project document
                            else
                            {
                                if (isInstance == true) // instance parameter
                                {
                                    ExternalDefinition extDef = def as ExternalDefinition;
                                    InstanceBinding bind = app.Create.NewInstanceBinding(catSet);
                                    doc.ParameterBindings.Insert(extDef, bind, bipGroup);

                                    countSuccess += 1;
                                    namesSuccess.Add(def.Name);
                                }
                                else // type parameter
                                {
                                    TypeBinding bind = app.Create.NewTypeBinding(catSet);
                                    doc.ParameterBindings.Insert(def, bind, bipGroup);

                                    countSuccess += 1;
                                    namesSuccess.Add(def.Name);
                                }
                            }
                            t.Commit();
                        }
                        catch (Exception e)
                        {
                            failNamesList.Add(def.Name + " (" + e.Message + ")");
                        }
                    }
                }
                tg.Assimilate();
            }            
        }

    }
}
