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
using ArpUtilities;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        List<ElementId> unusedTypesIds = new List<ElementId>();
        List<ElementId> usedTypesIds = new List<ElementId>();

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // load used list            
            usedTypesIds = Data.Helpers.GetUsedDimTypes(m_doc);
            unusedTypesIds = Data.Helpers.GetUnusedTypeIds(m_doc, usedTypesIds);
            foreach (ElementId id in usedTypesIds)
            {
                DimensionType dim = m_doc.GetElement(id) as DimensionType;
                LsvUsed.Items.Add(dim.Name + " (" + dim.StyleType.ToString() + ")");
            }

            // load used label
            LblTotalUsed.Text = LsvUsed.Items.Count.ToString();

            // load unused list
            foreach (ElementId eid in unusedTypesIds)
            {
                DimensionType dim = m_doc.GetElement(eid) as DimensionType;
                LsvUnused.Items.Add(m_doc.GetElement(eid).Name + " (" + dim.StyleType.ToString() + ")");
            }

            // set items checked by default
            for (int i = 0; i < LsvUnused.Items.Count; i++)
            {
                LsvUnused.Items[i].Checked = true;
            }

            // load unused label
            LblTotalUnused.Text = LsvUnused.Items.Count.ToString();

            // load total label
            int totalItems = LsvUsed.Items.Count + LsvUnused.Items.Count;
            LblTotalItems.Text = totalItems.ToString();
        }

        private void LsvUnused_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            LblItemsChecked.Text = LsvUnused.CheckedItems.Count.ToString();
        }

        private void LsvUsed_ItemSelectionChanged (object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // list of checked indices
            List<int> checkedIndices = new List<int>();
            foreach (int index in LsvUnused.CheckedIndices)
            {
                checkedIndices.Add(index);
            }

            // message if there are no items selected
            if (LsvUnused.CheckedIndices.Count == 0)
            {
                TaskDialog tdSelect = new TaskDialog("Information")
                {
                    MainInstruction = "You must select at least one item to purge.",
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdResult = tdSelect.Show();
            }
            else // go ahead with deleting
            {
                // list of ElementIds of selected items
                List<ElementId> unusedItems = unusedTypesIds;
                List<ElementId> selectedItems = new List<ElementId>();
                foreach (int index in checkedIndices)
                {
                    selectedItems.Add(unusedItems[index]);
                }

                // declare some variables
                List<string> infoList = new List<string>();
                List<string> itemExceptList = new List<string>();
                string infoSt = "";
                string infoExceptSt = "";
                int nOfItems = 0;

                // delete items
                using (Transaction t = new Transaction(m_doc, "Purge Dimension Styles"))
                {
                    t.Start();
                    foreach (ElementId eid in selectedItems)
                    {
                        try
                        {
                            infoList.Add(m_doc.GetElement(eid).Name);
                            nOfItems += 1;
                            m_doc.Delete(eid);
                        }
                        catch (Exception)
                        {
                            itemExceptList.Add(m_doc.GetElement(eid).Name);
                            infoList.Remove(m_doc.GetElement(eid).Name);
                            nOfItems -= 1;
                            continue;
                        }                        
                    }
                    t.Commit();
                }

                // handle info dialogs
                if (!itemExceptList.Any())
                {
                    foreach (string st in infoList)
                    {
                        infoSt += st + "\n";
                    }
                    TaskDialog tdInfo1 = new TaskDialog("Information")
                    {
                        MainInstruction = "You have successfully deleted " + nOfItems.ToString() + " Dimension Style(s):" + "\n" + "\n" + infoSt,
                        TitleAutoPrefix = false
                    };
                    TaskDialogResult tdResult = tdInfo1.Show();
                }
                else
                {
                    foreach (string st in infoList)
                    {
                        infoSt += "- " + st + "\n";
                    }
                    foreach (string st in itemExceptList)
                    {
                        infoExceptSt += "- " + st + "\n";
                    }

                    TaskDialog tdInfo2 = new TaskDialog("Information")
                    {
                        MainInstruction = "You have successfully deleted " + nOfItems.ToString() + " Dimension Style(s):" + "\n" + "\n" + infoSt
                                            + "\n" + "\n" + "The following item(s) can´t be deleted." +
                                            " At least one dimension style of each type must remain in the document:" + "\n" + "\n" + infoExceptSt,
                        TitleAutoPrefix = false
                    };
                    TaskDialogResult tdResult = tdInfo2.Show();
                }

                this.DialogResult = DialogResult.OK;
                try
                {
                    Utilities.GetAnalyticsCSV(m_doc, m_app);
                }
                catch (Exception)
                {
                }                
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvUnused.Items.Count; i++)
            {
                LsvUnused.Items[i].Checked = true;
            }
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvUnused.Items.Count; i++)
            {
                LsvUnused.Items[i].Checked = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}
