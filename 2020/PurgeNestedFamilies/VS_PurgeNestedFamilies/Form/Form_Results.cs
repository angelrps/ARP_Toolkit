using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
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
            LoadTree();
            Dictionary<string, List<string>> somedict = DictResults.FirstOrDefault().Value;
            label1.Text = somedict.FirstOrDefault().Value.FirstOrDefault();
        }

        #region HELPERS
        private void LoadTree()
        {
            TreeResults.Nodes.Clear();

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> parentf in DictResults)
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
                            TreeResults.Nodes[parentf.Key].Nodes[nestedf.Key].Nodes.Add(type);
                        }                       
                    }
                }
            }
        }
        #endregion
    }
}
