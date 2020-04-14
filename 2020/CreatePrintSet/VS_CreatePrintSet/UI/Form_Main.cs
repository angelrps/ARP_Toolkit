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
using Autodesk.Revit.ApplicationServices;
using System.Windows.Media.Imaging;
using System.IO;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;

        public Form_Main(Document doc)
        {
            InitializeComponent();
            m_doc = doc;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<ViewSheet, string> pair in Data.Helpers.GetViewSheetDict(m_doc))
            {
                ListViewItem viewItem = new ListViewItem(pair.Key.SheetNumber);
                viewItem.SubItems.Add(pair.Value);

                LsvSheets.Items.Add(viewItem);
            }
            LsvSheets.Sorting = SortOrder.Ascending;
        }
        private async void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            // do not reload view list if search box says "Type to filter..."
            if (TxbSearch.Text == "Type to filter...")
            {
            }
            // do not reload view list if search box is blank and items count is = to total nº of items
            else if (TxbSearch.Text == "" && LsvSheets.Items.Count == Data.Helpers.GetViewSheetDict(m_doc).Count())
            {
            }
            else
            {
                // async inner method to delay TextChanged event while user typing
                async Task<bool> UserKeepsTyping()
                {
                    string txt = TxbSearch.Text;    // remember text
                    await Task.Delay(400);          // wait some 400 miliseconds
                    return txt != TxbSearch.Text;   // return that text changed or not
                }
                if (await UserKeepsTyping()) return;

                // load sheets
                LsvSheets.Items.Clear();
                foreach (KeyValuePair<ViewSheet, string> pair in Data.Helpers.GetFilteredViewSheetDict(m_doc, TxbSearch.Text))
                {
                    ListViewItem viewItem = new ListViewItem(pair.Key.SheetNumber);
                    viewItem.SubItems.Add(pair.Value);

                    LsvSheets.Items.Add(viewItem);
                }
            }
            
            LsvSheets.Sorting = SortOrder.Ascending;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // check if at least one item is selected
            if (LsvSheets.CheckedItems.Count == 0)
            {
                TaskDialog.Show("Information", "At least one sheet must be selected");
            }

            // check if the user entered a Set Name
            if (TxbSetName.Text == "")
            {
                TaskDialog.Show("Information", "Please, enter Sheet Set Name.");
            }
            else
            {
                string sheetSetName = TxbSetName.Text;

                // collect selected sheets
                List<string> selSheetsTxt = new List<string>();
                List<ViewSheet> allViewSheets = Data.Helpers.GetViewSheets(m_doc);
                foreach (ListViewItem lv in LsvSheets.CheckedItems)
                {
                    selSheetsTxt.Add(lv.SubItems[0].Text);
                }
                List<ViewSheet> selViewSheets = Data.Helpers.GetSelectedSheets(allViewSheets, selSheetsTxt);

                // collect existing view sheet sets
                List<Element> existingViewSheetSet = new FilteredElementCollector(m_doc)
                                                         .OfClass(typeof(ViewSheetSet))
                                                         .WhereElementIsNotElementType()
                                                         .ToElements()
                                                         .ToList();

                // check if new print set name exists
                Dictionary<Element, string> existingVSSDict = new Dictionary<Element, string>();
                foreach (Element el in existingViewSheetSet)
                {
                    existingVSSDict.Add(el, el.Name);
                }
                if (existingVSSDict.ContainsValue(sheetSetName))
                {
                    TaskDialog.Show("Information", "You have chosen a Sheet Set Name that already exists.\nPlease enter a different name.");
                }
                else
                {
                    using (Transaction t = new Transaction(m_doc, "Create New Sheet Set"))
                    {
                        t.Start();
                        PrintManager printManager = m_doc.PrintManager;
                        printManager.PrintRange = PrintRange.Select;
                        ViewSheetSetting existingPrintSets = printManager.ViewSheetSetting;

                        // create ViewSet
                        ViewSet myViewSet = new ViewSet();
                        foreach (ViewSheet vs in selViewSheets)
                        {
                            myViewSet.Insert(vs);
                        }

                        existingPrintSets.CurrentViewSheetSet.Views = myViewSet;
                        existingPrintSets.SaveAs(sheetSetName);
                        t.Commit();
                    }
                    TaskDialog.Show("Information", $"A new Sheet Set '{sheetSetName}' has been added to the project.");
                    DialogResult = DialogResult.OK;
                }
            }


        }

        // remove "Filter" text and change font to black when searching
        private void TxbSearch_Enter(object sender, EventArgs e)
        {
            if (TxbSearch.Text == "Type to filter...")
            {
                TxbSearch.Text = "";
                TxbSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        // add "Filter" text and change font to silver when not searching
        private void TxbSearch_Leave(object sender, EventArgs e)
        {
            if (TxbSearch.Text == "")
            {
                TxbSearch.Text = "Type to filter...";
                TxbSearch.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvSheets.Items.Count; i++)
            {
                LsvSheets.Items[i].Checked = true;
            }
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LsvSheets.Items.Count; i++)
            {
                LsvSheets.Items[i].Checked = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
