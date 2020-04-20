using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Results
{
    using static Entry.CmdMain;

    public partial class Form_Results : System.Windows.Forms.Form
    {
        public Form_Results()
        {
            InitializeComponent();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {
            if (!DictTypeResults.Keys.Any() && !DictTypeResults.Keys.Any())
            {
                LblNotFoundMessage.Visible = true;
            }
            else
            {
                LoadTree();
                TreeResults.SelectedNode = null;               
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #region HELPERS
        private void LoadTree()
        {
            // PHASE 1. Populate tree with purged types
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> parentf in DictTypeResults)
            {
                // add parent family
                TreeResults.Nodes.Add(parentf.Key, parentf.Key);

                // loop through nested families
                foreach (KeyValuePair<string, List<string>> nestedf in parentf.Value)
                {
                    TreeResults.Nodes[parentf.Key].Nodes.Add(nestedf.Key, nestedf.Key);

                    foreach (string type in nestedf.Value)
                    {
                        if (type != null)
                        {
                            //TreeResults.Nodes[parentf.Key].Nodes[nestedf.Key].Nodes.Add(type).NodeFont = new Font(TreeResults.Font, FontStyle.Strikeout);
                            TreeNode tn = TreeResults.Nodes[parentf.Key].Nodes[nestedf.Key].Nodes.Add(type);
                            tn.ForeColor = Color.Red;
                        }                       
                    }
                }
            }
            //PHASE 2. Populate tree with additional nested families
            foreach (KeyValuePair<string, List<string>> parent in dictNestedResults)
            {
                // if tree does not contain parent family
                if (!TreeResults.Nodes.ContainsKey(parent.Key))
                {
                    // does list of nested families have any element?
                    if (parent.Value.Any())
                    {
                        // add new parent family and all nested families
                        TreeResults.Nodes.Add(parent.Key,parent.Key);
                        foreach (string nestedf in parent.Value)
                        {
                            //TreeResults.Nodes[parent.Key].Nodes.Add(nestedf).NodeFont = new Font(TreeResults.Font, FontStyle.);
                            TreeNode tn = TreeResults.Nodes[parent.Key].Nodes.Add(nestedf);
                            tn.ForeColor = Color.Red;

                        }
                    }
                }
                // if parent family already exists
                else
                {
                    foreach (string nestedf in parent.Value)
                    {
                        // if nested family does not exits, add it
                        if (!TreeResults.Nodes[parent.Key].Nodes.ContainsKey(nestedf))
                        {
                            //TreeResults.Nodes[parent.Key].Nodes.Add(nestedf).NodeFont = new Font(TreeResults.Font, FontStyle.Strikeout);
                            TreeNode tn = TreeResults.Nodes[parent.Key].Nodes.Add(nestedf);
                            tn.ForeColor = Color.Red;
                        }
                        // if nested family already exists, change font style
                        else
                        {
                            TreeNode tn = TreeResults.Nodes[parent.Key].Nodes[nestedf];
                            tn.ForeColor = Color.Red;
                        }
                    }
                }
            }
            TreeResults.ExpandAll();
        }
        #endregion        
    }

}
