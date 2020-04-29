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
            // set font bold so the header is bold
            LsvSheets.Columns[0].ListView.Font = new Font(LsvSheets.Columns[0].ListView.Font, FontStyle.Bold);

            foreach (KeyValuePair<ViewSheet, string> pair in Data.Helpers.GetViewSheetDict(m_doc))
            {
                ListViewItem viewItem = new ListViewItem(pair.Key.SheetNumber);
                //set the items font back to regular
                viewItem.Font = new Font(viewItem.Font, FontStyle.Regular);

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
                    //set the items font back to regular
                    viewItem.Font = new Font(viewItem.Font, FontStyle.Regular);
                    viewItem.SubItems.Add(pair.Value);

                    LsvSheets.Items.Add(viewItem);
                }
            }
            
            LsvSheets.Sorting = SortOrder.Ascending;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            #region check Sheet Set Name entered?
            if (TxbSetName.Text == "")
            {
                UI.Info.Form_Info1.infoMsgMain = "Value missing";
                UI.Info.Form_Info1.infoMsgBody = "Please, enter Sheet Set Name to continue.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
                return;
            }
            #endregion// check if the user entered a Set Name

            #region check if new print set name exists
            // get new sheet set name
            string sheetSetName = TxbSetName.Text;

            // collect existing view sheet sets
            List<Element> existingViewSheetSet = new FilteredElementCollector(m_doc)
                                                     .OfClass(typeof(ViewSheetSet))
                                                     .WhereElementIsNotElementType()
                                                     .ToElements()
                                                     .ToList();
            Dictionary<Element, string> existingVSSDict = new Dictionary<Element, string>();
            foreach (Element el in existingViewSheetSet)
            {
                existingVSSDict.Add(el, el.Name);
            }
            if (existingVSSDict.ContainsValue(sheetSetName))
            {
                UI.Info.Form_Info1.infoMsgMain = "Duplicated name";
                UI.Info.Form_Info1.infoMsgBody = "You have chosen a Sheet Set Name that already exists.\nPlease enter a different name.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
                return;
            }
            #endregion

            #region check sheets selected?
            if (LsvSheets.CheckedItems.Count == 0)
            {
                UI.Info.Form_Info1.infoMsgMain = "Select";
                UI.Info.Form_Info1.infoMsgBody = "Please, select one or more sheets to continue.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
                return;
            }
            #endregion        

            #region create Sheet Set
            // collect selected sheets
            List<string> selSheetsTxt = new List<string>();
            List<ViewSheet> allViewSheets = Data.Helpers.GetViewSheets(m_doc);
            foreach (ListViewItem lv in LsvSheets.CheckedItems)
            {
                selSheetsTxt.Add(lv.SubItems[0].Text);
            }
            List<ViewSheet> selViewSheets = Data.Helpers.GetSelectedSheets(allViewSheets, selSheetsTxt);
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
            #endregion

            #region show Results Form
            UI.Info.Form_Info1.infoMsgMain = "Results";
            UI.Info.Form_Info1.infoMsgBody = $"A new Sheet Set '{sheetSetName}' has been added to the project.";
            using (UI.Info.Form_Info1 thisForm = new Info.Form_Info1()) { thisForm.ShowDialog(); }
            #endregion

            DialogResult = DialogResult.OK;
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
