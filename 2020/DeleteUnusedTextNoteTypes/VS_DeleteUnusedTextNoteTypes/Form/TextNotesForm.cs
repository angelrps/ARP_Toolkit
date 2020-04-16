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

namespace DeleteUnusedTextNoteTypes
{
    using static DeleteUnusedTextNoteTypes.Helpers;

    public partial class TextNotesForm : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;

        public TextNotesForm(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void TextNotesForm_Load(object sender, EventArgs e)
        {
            // load used list
            foreach (string str in Helpers.GetUsedTextNoteNames(m_doc))
            {
                lbxUsedTypes.Items.Add(str);
            }

            // load used label
            lblTotalUsed.Text = lbxUsedTypes.Items.Count.ToString();
                        
            // load unused list
            foreach (ElementId eId in Helpers.GetUnusedTextNoteTypes(m_doc))
            {
                clbUnused.Items.Add(m_doc.GetElement(eId).Name);
            }

            // set items checked by defoult
            for (int i = 0; i < clbUnused.Items.Count; i++)
            {
                clbUnused.SetItemChecked(i, true);
            }

            // load unused label
            lblTotalUnused.Text = clbUnused.Items.Count.ToString();

            // load total label
            int totalItems = lbxUsedTypes.Items.Count + clbUnused.Items.Count;
            lblTotalItems.Text = totalItems.ToString();

            // load items checked label
            lblItemsChecked.Text = clbUnused.CheckedItems.Count.ToString();
        }

        private void clbUnused_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItemsChecked.Text = clbUnused.CheckedItems.Count.ToString();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbUnused.Items.Count; i++)
            {
                clbUnused.SetItemChecked(i, true);
            }
            lblItemsChecked.Text = clbUnused.CheckedItems.Count.ToString();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbUnused.Items.Count; i++)
            {
                clbUnused.SetItemChecked(i, false);
            }
            lblItemsChecked.Text = clbUnused.CheckedItems.Count.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // get list of checked indices
            List<int> checkedIndices = new List<int>();
            foreach (int index in clbUnused.CheckedIndices)
            {
                checkedIndices.Add(index);
            }

            // check if there are any boxes checked
            if (!checkedIndices.Any())
            {
                TaskDialog.Show("Message", "You have not selected any item to purge.");
            }

            else
            {
                List<ElementId> unusedItems = Helpers.GetUnusedTextNoteTypes(m_doc).ToList();
                List<ElementId> selectedItems = new List<ElementId>();

                foreach (int index in checkedIndices)
                {
                    selectedItems.Add(unusedItems[index]);
                }

                // delete selected filters
                List<string> infoList = new List<string>();
                List<string> itemExceptList = new List<string>();
                string infoSt = "";
                string infoExceptSt = "";
                int nOfItems = 0;

                using (Transaction t = new Transaction(m_doc, "Purge Text Note Types"))
                {
                    t.Start();

                    foreach (ElementId eId in selectedItems)
                    {
                        try
                        {                            
                            infoList.Add(m_doc.GetElement(eId).Name);
                            nOfItems += 1;
                            m_doc.Delete(eId);
                        }
                        catch (Exception)
                        {
                            itemExceptList.Add(m_doc.GetElement(eId).Name);
                            infoList.Remove(m_doc.GetElement(eId).Name);
                            nOfItems -= 1;

                            continue;
                        }
                    }
                    
                    t.Commit();
                }

                this.DialogResult = DialogResult.OK;
                try
                {
                    Utilities.GetAnalyticsCSV(m_doc, m_app);
                    //GetAnalyticsCSV(m_doc, m_app);
                }
                catch (Exception)
                {
                }
                
                Close();

                if (!itemExceptList.Any())
                {                    
                    foreach(string st in infoList)
                    {
                        infoSt += st + "\n";
                    }
                    TaskDialog.Show("Message", "You have successfully deleted " + nOfItems.ToString() + " Text Note Type(s):" + "\n" + "\n" + infoSt);
                }
                else
                {
                    foreach (string st in infoList)
                    {
                        infoSt += st + "\n";
                    }
                    foreach (string st in itemExceptList)
                    {
                        infoExceptSt += st + "\n";
                    }

                    TaskDialog.Show("Message", "You have successfully deleted " + nOfItems.ToString() + " Text Note Type(s):" + "\n" + "\n"
                    + infoSt + "\n" + "\n"
                    + "The following item(s) can´t be deleted:" + "\n" + "\n" + infoExceptSt);
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbxUsedTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
