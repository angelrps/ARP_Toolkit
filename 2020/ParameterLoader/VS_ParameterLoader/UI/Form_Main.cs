using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // is family document? If so disable Categories group
            if (m_doc.IsFamilyDocument == true)
            {
                PanCategories.Enabled = false;
            }

            LoadCategories();
            LoadGroupingNames();

            // try get shared parameters file and load them
            try
            {
                DefinitionFile df = m_app.OpenSharedParameterFile();

                if (df != null)
                {
                    LoadSharedParameters();
                    LblSharedParameterFile.Text = df.Filename;
                }
            }
            catch (Exception)
            {
            }            
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                DefaultExt = "*.txt",
                Filter = "Shared Parameter File | *.txt",
                Title = "Select a Shared Parameter File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (!string.IsNullOrEmpty(filePath))
                {
                    LblSharedParameterFile.Text = filePath;
                    Data.Helpers.LoadSharedParameterFile(m_app, filePath);
                    LoadSharedParameters();
                }
            }            
        }

        public async void TxbFilterParam_TextChanged(object sender, EventArgs e)
        {
            // async inner method to delay TextChanged event while user typing
            async Task<bool> UserKeepsTyping()
            {
                string txt = TxbFilterParam.Text;    // remember text
                await Task.Delay(400);            // wait some
                return txt != TxbFilterParam.Text;   // return that text changed or not
            }
            if (await UserKeepsTyping()) return;

            LoadSharedParameters();
        }

        private void BtnExpandAll_Click(object sender, EventArgs e)
        {
            TreeViewParameters.ExpandAll();
        }

        private void BtnCollapseAll_Click(object sender, EventArgs e)
        {
            TreeViewParameters.CollapseAll();
        }

        public async void TxbFilterCat_TextChanged(object sender, EventArgs e)
        {
            // async inner method to delay TextChanged event while user typing
            async Task<bool> UserKeepsTyping()
            {
                string txt = TxbFilterCat.Text;    // remember text
                await Task.Delay(400);            // wait some
                return txt != TxbFilterCat.Text;   // return that text changed or not
            }
            if (await UserKeepsTyping()) return;

            LoadCategories();
        }

        private void RbtByGroup_CheckedChanged(object sender, EventArgs e)
        {
            LoadSharedParameters();
        }

        private void TreeViewParameters_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                //node is parent
                if (e.Node.Level == 0)
                {
                    foreach (TreeNode node in e.Node.Nodes) //match children checking
                    {
                        node.Checked = e.Node.Checked;
                    }
                }
                // node is child
                if (e.Node.Level != 0)
                {
                    foreach (TreeNode childNode in e.Node.Parent.Nodes) // end action if any childNode is checked
                    {
                        if (childNode.Checked == true)
                        {
                            e.Node.Parent.Checked = true;
                            foreach (TreeNode childNode2 in e.Node.Parent.Nodes)
                            {
                                if (childNode2.Checked == false)
                                {
                                    return;
                                }
                            }
                            return;
                        }
                    }
                    e.Node.Parent.Checked = false;
                }
            }
            
            
        }

        private void BtnAllParam_Click(object sender, EventArgs e)
        {            
            foreach (TreeNode n in TreeViewParameters.Nodes) // parents
            {
                n.Checked = true;
                
                foreach (TreeNode c in n.Nodes) // children
                {
                    c.Checked = true;
                }
            }
        }

        private void BtnNoneParam_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in TreeViewParameters.Nodes) // parents
            {
                n.Checked = false;

                foreach (TreeNode c in n.Nodes) // children
                {
                    c.Checked = false;
                }
            }
        }

        private void BtnAllCat_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in TreeViewCategories.Nodes)
            {
                n.Checked = true;
            }
        }

        private void BtnNoneCat_Click(object sender, EventArgs e)
        {
            foreach (TreeNode n in TreeViewCategories.Nodes)
            {
                n.Checked = false;
            }
        }

        private void BtnAddParameters_Click(object sender, EventArgs e)
        {
            #region get all checked parameters
            List<Definition> defList = new List<Definition>();
            foreach (TreeNode n1 in TreeViewParameters.Nodes)
            {
                foreach (TreeNode n2 in n1.Nodes)
                {
                    if (n2.Checked == true)
                    {
                        defList.Add(n2.Tag as Definition);
                    }
                }
            }
            #endregion

            #region get all checked categories
            List<Category> catList = new List<Category>();
            if (m_doc.IsFamilyDocument == true)
            {
                catList.Add(m_doc.OwnerFamily.FamilyCategory);
            }
            else
            {
                foreach (TreeNode c in TreeViewCategories.Nodes)
                {
                    if (c.Checked == true)
                    {
                        catList.Add(c.Tag as Category);
                    }
                }
            }
            #endregion

            #region is there a shared parameter FILE selected?
            if (m_app.OpenSharedParameterFile() == null)
            {
                TaskDialog tdSelectPrompt = new TaskDialog("Warning")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "Please select a shared parameter file (.txt).",
                    TitleAutoPrefix = false
                };
                tdSelectPrompt.Show();
                return;
            }
            #endregion

            #region is there any PARAMETER selected?
            if (defList.Count == 0)
            {
                TaskDialog tdSelectPrompt = new TaskDialog("Warning")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "Please select at least one parameter from the list.",
                    TitleAutoPrefix = false
                };
                tdSelectPrompt.Show();
                return;
            }
            #endregion

            #region is there any CATEGORY selected
            // check if is family document
            if (m_doc.IsFamilyDocument == false)
            {
                if (catList.Count == 0)
                {
                    TaskDialog tdSelectPrompt = new TaskDialog("Warning")
                    {
                        MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                        MainInstruction = "Please select at least one category from the list.",
                        TitleAutoPrefix = false
                    };
                    tdSelectPrompt.Show();
                    return;
                }
            }
            
            #endregion

            // get parameter group
            KeyValuePair<BuiltInParameterGroup, string> groupKeyValuePair = (KeyValuePair<BuiltInParameterGroup, string>)CbxGroup.SelectedItem;
            BuiltInParameterGroup group = groupKeyValuePair.Key;

            // Bind the Definitions
            Data.Helpers.BindDefinitionsToCategories(m_doc,
                                                     m_app,
                                                     defList,
                                                     catList,
                                                     group,
                                                     RbtInstance.Checked);

            TaskDialog tdContinue = new TaskDialog("Continue or Close?")
            {
                MainIcon = TaskDialogIcon.TaskDialogIconNone,
                MainInstruction = "Do you want to load more parameters?",
                CommonButtons = TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No,
                TitleAutoPrefix = false
            };
            //TaskDialogResult tdInfoResult = tdContinue.Show();
            switch (tdContinue.Show())
            {
                case TaskDialogResult.Yes:
                    break;
                case TaskDialogResult.No:
                    DialogResult = DialogResult.OK;
                    break;
            }

            // uncheck parameters
            foreach (TreeNode n in TreeViewParameters.Nodes) // parents
            {
                n.Checked = false;

                foreach (TreeNode c in n.Nodes) // children
                {
                    c.Checked = false;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #region Utilities
        private void LoadCategories()
        {
            TreeViewCategories.Nodes.Clear();
            foreach (Category cat in m_doc.Settings.Categories)
            {
                if (cat.AllowsBoundParameters == true)
                {
                    if (!(string.IsNullOrEmpty(TxbFilterCat.Text)))
                    {
                        if (!cat.Name.ToLower().Contains(TxbFilterCat.Text.ToLower()))
                        {
                            continue;
                        }
                    }
                    TreeNode tn = TreeViewCategories.Nodes.Add(cat.Name, cat.Name);
                    tn.Tag = cat;
                }                
            }
            TreeViewCategories.Sort();
        }

        private void LoadSharedParameters()
        {            
            TreeViewParameters.Nodes.Clear(); // fresh list

            if (RbtByGroup.Checked == true) // load by group
            {
                SortedDictionary<string, List<Definition>> parametersByBroup = Data.Helpers.GetParameterByGroup(m_app);

                if (string.IsNullOrEmpty(TxbFilterParam.Text)) // filter is empty
                {
                    foreach (KeyValuePair<string, List<Definition>> pair in parametersByBroup)
                    {
                        List<Definition> defList = pair.Value;
                        //TaskDialog.Show("OJO", "looking through groups");
                        foreach (Definition def in defList)
                        {
                            if (!TreeViewParameters.Nodes.ContainsKey(pair.Key.ToString())) // group doesn´t exist
                            {
                                TreeViewParameters.Nodes.Add(pair.Key.ToString(), pair.Key.ToString());
                                TreeNode childNode = TreeViewParameters.Nodes[pair.Key.ToString()].Nodes.Add(def.Name, def.Name);
                                childNode.Tag = def; // set Definition as object containing data
                            }
                            else // group exists
                            {
                                TreeNode childNode = TreeViewParameters.Nodes[pair.Key.ToString()].Nodes.Add(def.Name, def.Name);
                                childNode.Tag = def; // set Definition as object containing data
                            }
                            //TreeViewParameters.Sort();
                        }
                    }
                }
                else // filter contains text
                {
                    foreach (KeyValuePair<string, List<Definition>> pair in parametersByBroup)
                    {
                        foreach (Definition def in pair.Value)
                        {
                            if (def.Name.ToLower().Contains(TxbFilterParam.Text.ToLower())) // contains text
                            {
                                if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // group doesn´t exist
                                {
                                    TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
                                    TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                    childNode.Tag = def; // set Definition as object containing data
                                }
                                else // group exists
                                {
                                    TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                    childNode.Tag = def; // set Definition as object containing data
                                }
                                //TreeViewParameters.Sort();
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }                    
                }                
            }
            else // load by type
            {
                SortedDictionary<string, List<Definition>> parametersByType = Data.Helpers.GetParameterByType(m_app);
                foreach (KeyValuePair<string, List<Definition>> pair in parametersByType)
                {
                    foreach (Definition def in pair.Value)
                    {
                        if (string.IsNullOrEmpty(TxbFilterParam.Text)) // filter is empty
                        {
                            if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // type doesn´t exist
                            {
                                TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
                                TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                childNode.Tag = def; // set Definition as object containing data
                            }
                            else // type exists
                            {
                                TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                childNode.Tag = def;  // set Definition as object containing data
                            }
                            //TreeViewParameters.Sort();
                        }
                        else // filter contains text
                        {
                            if (def.Name.ToLower().Contains(TxbFilterParam.Text.ToLower())) // contains text
                            {
                                if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // type doesn´t exist
                                {
                                    TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
                                    TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                    childNode.Tag = def; // set Definition as object containing data
                                }
                                else // type exists
                                {
                                    TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
                                    childNode.Tag = def; // set Definition as object containing data
                                }
                                //TreeViewParameters.Sort();
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
             // expand all when searching
            if (!string.IsNullOrEmpty(TxbFilterParam.Text))
            {
               TreeViewParameters.ExpandAll();
            }
        }

        //private void LoadSharedParameters_ORIGINAL()
        //{
        //    TreeViewParameters.Nodes.Clear(); // fresh list

        //    if (RbtByGroup.Checked == true) // load by group
        //    {
        //        Dictionary<string, List<Definition>> parametersByBroup = Data.Helpers.GetParameterByGroup(m_app);
        //        TaskDialog.Show("OJO", "Dictionary calculated");
        //        foreach (KeyValuePair<string, List<Definition>> pair in parametersByBroup)
        //        {
        //            TaskDialog.Show("OJO", "looking through groups");
        //            foreach (Definition def in pair.Value)
        //            {
        //                if (string.IsNullOrEmpty(TxbFilterParam.Text)) // filter is empty
        //                {
        //                    if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // group doesn´t exist
        //                    {
        //                        TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
        //                        TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                        childNode.Tag = def; // set Definition as object containing data
        //                    }
        //                    else // group exists
        //                    {
        //                        TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                        childNode.Tag = def; // set Definition as object containing data
        //                    }
        //                    TreeViewParameters.Sort();
        //                }
        //                else // filter contains text
        //                {
        //                    if (def.Name.ToLower().Contains(TxbFilterParam.Text.ToLower())) // contains text
        //                    {
        //                        if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // group doesn´t exist
        //                        {
        //                            TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
        //                            TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                            childNode.Tag = def; // set Definition as object containing data
        //                        }
        //                        else // group exists
        //                        {
        //                            TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                            childNode.Tag = def; // set Definition as object containing data
        //                        }
        //                        TreeViewParameters.Sort();
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            }
        //        }
        //        TaskDialog.Show("OJO", "TreeView populated");
        //    }
        //    else // load by type
        //    {
        //        TaskDialog.Show("OJO", "about to load by type");
        //        Dictionary<string, List<Definition>> parametersByType = Data.Helpers.GetParameterByType(m_app);
        //        TaskDialog.Show("OJO", "Dictionary calculated");
        //        foreach (KeyValuePair<string, List<Definition>> pair in parametersByType)
        //        {
        //            foreach (Definition def in pair.Value)
        //            {
        //                if (string.IsNullOrEmpty(TxbFilterParam.Text)) // filter is empty
        //                {
        //                    if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // type doesn´t exist
        //                    {
        //                        TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
        //                        TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                        childNode.Tag = def; // set Definition as object containing data
        //                    }
        //                    else // type exists
        //                    {
        //                        TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                        childNode.Tag = def;  // set Definition as object containing data
        //                    }
        //                    TreeViewParameters.Sort();
        //                }
        //                else // filter contains text
        //                {
        //                    if (def.Name.ToLower().Contains(TxbFilterParam.Text.ToLower())) // contains text
        //                    {
        //                        if (!TreeViewParameters.Nodes.ContainsKey(pair.Key)) // type doesn´t exist
        //                        {
        //                            TreeViewParameters.Nodes.Add(pair.Key, pair.Key);
        //                            TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                            childNode.Tag = def; // set Definition as object containing data
        //                        }
        //                        else // type exists
        //                        {
        //                            TreeNode childNode = TreeViewParameters.Nodes[pair.Key].Nodes.Add(def.Name, def.Name);
        //                            childNode.Tag = def; // set Definition as object containing data
        //                        }
        //                        TreeViewParameters.Sort();
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            }
        //        }
        //        TaskDialog.Show("OJO", "TreeView populated");
        //    }
        //    // expand all when searching
        //    if (!string.IsNullOrEmpty(TxbFilterParam.Text))
        //    {
        //        TreeViewParameters.ExpandAll();
        //    }
        //}

        private void LoadGroupingNames()
        {
            var groupDict = new SortedDictionary<BuiltInParameterGroup, string>();

            foreach (BuiltInParameterGroup pg in Data.Helpers.ParameterGroupsList())
            {
                groupDict.Add(pg, LabelUtils.GetLabelFor(pg));
            }
            CbxGroup.Sorted = true;
            CbxGroup.DataSource = new BindingSource(groupDict, null);
            CbxGroup.DisplayMember = "Value";
            CbxGroup.ValueMember = "Key";
        }
        #endregion
    }
}
