using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using ArpUtilities;

namespace DeleteUnusedFilters
{
    using static DeleteUnusedFilters.Helpers;

    public partial class ViewFiltersForm : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        public static List<string> listInfo = new List<string>();
        public static string info = "";
        public static int nOfFilters = 0;

        public ViewFiltersForm(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void ViewFiltersForm_Load(object sender, EventArgs e)
        {
            foreach (ParameterFilterElement pfe in Helpers.GetUnusedFilterElem(m_doc))
            {
                clbViewFilters.Items.Add(pfe.Name);
            }
        }

        private void clbViewFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
           lbTotalItems.Text = clbViewFilters.CheckedItems.Count.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            //get list of checked indices
            List<int> checkedIndices = new List<int>();
            foreach (int indexChecked in clbViewFilters.CheckedIndices)
            {
                checkedIndices.Add(indexChecked);
            }

            //check if there are any boxes checked
            if (!checkedIndices.Any())
            {
                TaskDialog.Show("Message", "You have not selected any filter.");
            }

            else
            {
                //get list of selected filter elements so they can be deleted
                List<ParameterFilterElement> AllUnusedFilters = DeleteUnusedFilters.Helpers.GetUnusedFilterElem(m_doc);
                List<ParameterFilterElement> SelectedFilters = new List<ParameterFilterElement>();
                foreach (int index in checkedIndices)
                {
                    SelectedFilters.Add(AllUnusedFilters[index]);
                }

                //deletes selected filters
                
                using (Transaction t = new Transaction(m_doc, "Delete filters"))
                {
                    t.Start();
                    foreach (ParameterFilterElement pfe in SelectedFilters)
                    {
                        listInfo.Add(pfe.Name);
                        info += pfe.Name + "\n";
                        nOfFilters += 1;
                        m_doc.Delete(pfe.Id);
                    }
                    t.Commit();
                }
                TaskDialog.Show("Message", "You have successfully deleted " + nOfFilters.ToString() + " filters:" + "\n" + "\n" + info);
                DialogResult = DialogResult.OK;

                using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results())
                {
                    thisForm.ShowDialog();
                }

                try
                {
                    Utilities.GetAnalyticsCSV(m_doc, m_app);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbViewFilters.Items.Count; i++)
            {
                clbViewFilters.SetItemChecked(i, true);
            }
            lbTotalItems.Text = clbViewFilters.CheckedItems.Count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbViewFilters.Items.Count; i++)
            {
                clbViewFilters.SetItemChecked(i, false);
            }
            lbTotalItems.Text = clbViewFilters.CheckedItems.Count.ToString();
        }

        private void lbTotalItems_Click(object sender, EventArgs e)
        {
            
        }
    }
}
