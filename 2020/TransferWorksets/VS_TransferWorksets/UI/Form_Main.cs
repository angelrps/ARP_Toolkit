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
    using static Data.Helpers;

    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        public static List<string> usedNames = new List<string>();
        public static List<string> createdWorksets = new List<string>();

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            foreach (Document d in GetOpenDocuments(m_doc, m_app))
            {
                CbxOpenDocs.Items.Add(d);
            }
            CbxOpenDocs.Sorted = true;
            CbxOpenDocs.DisplayMember = "Title";
            CbxOpenDocs.SelectedIndex = 0;
        }

        private void CbxOpenDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsvWorksets.Items.Clear();
            Document selDoc = CbxOpenDocs.SelectedItem as Document;

            foreach (string s in GetWorksetNames(selDoc))
            {
                LsvWorksets.Items.Add(s);
            }
            LsvWorksets.Sorting = SortOrder.Ascending;
            
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // check if at least one item is selected
            if (LsvWorksets.CheckedItems.Count == 0)
            {
                using (UI.Info.Form_Info1 thisForm = new Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
            }
            else
            {
                // collect selected worksets
                List<string> selectedWorksets = new List<string>();
                foreach (ListViewItem item in LsvWorksets.CheckedItems)
                {
                    selectedWorksets.Add(item.Text);
                }

                // check if workset name is in use
                usedNames = GetUsedNames(m_doc, selectedWorksets);
                if (usedNames.Any())
                {
                    using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning())
                    {
                        thisForm.ShowDialog();
                    }
                }
                // proceed if workset names are unique
                else
                {
                    using (TransactionGroup tg = new TransactionGroup(m_doc, "Transfer Worksets"))
                    {
                        tg.Start();
                        foreach (string WorksetName in selectedWorksets)
                        {
                            using (Transaction t = new Transaction(m_doc, "Single Transaction"))
                            {
                                t.Start();
                                Workset newWorkset = null;
                                newWorkset = Workset.Create(m_doc, WorksetName);
                                createdWorksets.Add(WorksetName);
                                t.Commit();
                            }
                        }
                        tg.Assimilate();
                    }
                    // show Results Form
                    using (UI.Info.Form_Results thisForm = new Info.Form_Results())
                    {
                        thisForm.ShowDialog();
                    }
                    DialogResult = DialogResult.OK;
                }                
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvWorksets.Items.Count; i++)
            {
               LsvWorksets.Items[i].Checked = true;
            }
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvWorksets.Items.Count; i++)
            {
                LsvWorksets.Items[i].Checked = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
