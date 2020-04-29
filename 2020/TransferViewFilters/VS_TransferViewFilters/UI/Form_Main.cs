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
using Data;
using System.Diagnostics;
using ArpUtilities;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {

        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;

        #region Variables for analytics
        private static Stopwatch useTime = new Stopwatch();         // total time user has the application open and it does actually make a transaction
        private static Stopwatch executionTime = new Stopwatch();   // net time of the sheet duplication

        public static string UseTimeElapseS { get; set; } = "";
        public static string ExecTimeElapseS { get; set; } = "";
        public static int Ana_NoOfFilters_Total { get; set; } = 0;
        public static int Ana_NoOfFilters_Applied { get; set; } = 0;
        public static int Ana_NoOfFilters_Overriden { get; set; } = 0;
        public static int Ana_NoOfTemplates { get; set; } = 0;
        #endregion

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            useTime.Start();

            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // LOAD TEMPLATES
            Dictionary<Autodesk.Revit.DB.View, string> viewTemplatesDict = Helpers.GetViewTemplatesDict(m_doc);
            LoadTemplates(viewTemplatesDict);

            // LOAD FILTERS, GROUPED BY TEMPLATE
            Dictionary<Autodesk.Revit.DB.View, string> filtersDict = Helpers.GetViewTemplateWithFilters(m_doc);
            LoadFilters(m_doc, filtersDict);
        }

        private async void TxbSearchFilters_TextChanged(object sender, EventArgs e)
        {
            async Task<bool> UserKeepsTyping()
            {
                string txt = TxbSearchFilters.Text;     // remember text
                await Task.Delay(400);                  // wait some 400 milisecond
                return txt != TxbSearchFilters.Text;    // return that text changed or not
            }
            if (await UserKeepsTyping()) return;

            // load filters
            LsvFilters.Items.Clear();
            Dictionary<Autodesk.Revit.DB.View, string> filtersDict = Helpers.GetViewTemplateWithFilters(m_doc);
            LoadFiltersSearch(m_doc, filtersDict, TxbSearchFilters.Text);
        }

        private async void TxbSearchTemplates_TextChanged(object sender, EventArgs e)
        {
            async Task<bool> UserKeepsTyping()
            {
                string txt = TxbSearchTemplates.Text;     // remember text
                await Task.Delay(400);                  // wait some 400 milisecond
                return txt != TxbSearchTemplates.Text;    // return that text changed or not
            }
            if (await UserKeepsTyping()) return;

            // load filters
            LsvTemplates.Items.Clear();
            Dictionary<Autodesk.Revit.DB.View, string> viewTemplatesDict = Data.Helpers.GetViewTemplatesDict(m_doc);
            LoadTemplatesSearch(viewTemplatesDict, TxbSearchTemplates.Text);
        }

        private void LsvFilters_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            ListViewItem selectedItem = LsvFilters.Items[e.Index];
            
            foreach (ListViewItem item in LsvFilters.CheckedItems)
            {
                if (item != selectedItem && item.Text == selectedItem.Text)
                {
                    UI.Info.Form_Info1.infoMsgMain = "Duplicated Selection";
                    UI.Info.Form_Info1.infoMsgBody = "This filter is already selected in another template." +
                                                    "\nYou can only select a filter once." +
                                                    "\nThis filter will be unchecked.";
                    using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                    {
                        thisForm.ShowDialog();
                    }
                    e.NewValue = CheckState.Unchecked;
                }
            }            
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            List<string> infoFiltersTransferred = new List<string>();
            List<string> infoFiltersGraphicOverriden = new List<string>();

            #region items selected?
            if (LsvFilters.CheckedItems.Count == 0)
            {
                UI.Info.Form_Info1.infoMsgMain = "Select";
                UI.Info.Form_Info1.infoMsgBody = "Select one or more View Filters from the list to continue.";
                using (UI.Info.Form_Info1 thisForm = new Info.Form_Info1()) { thisForm.ShowDialog(); }
                return;
            }
            if (LsvTemplates.CheckedItems.Count == 0)
            {
                UI.Info.Form_Info1.infoMsgMain = "Select";
                UI.Info.Form_Info1.infoMsgBody = "Select one or more View Templates from the list to continue.";
                using (UI.Info.Form_Info1 thisForm = new Info.Form_Info1()) { thisForm.ShowDialog(); }
                return;
            }
            #endregion

            #region CHECK IF FILTER IS ALREADY APPLIED
            List<string> infoIsFilterApplied = new List<string>();
            bool triggerIsFilterApplied = false;
            foreach (ListViewItem tItem in LsvTemplates.CheckedItems)    // LOOP THROUGH TEMPLATES
            {
                ElementId templateId = new ElementId(tItem.ImageIndex);
                Autodesk.Revit.DB.View template = m_doc.GetElement(templateId) as Autodesk.Revit.DB.View;

                foreach (ListViewItem vItem in LsvFilters.CheckedItems)  // LOOP THROUGH FILTERS
                {
                    ElementId filterId = new ElementId(vItem.ImageIndex);
                    if (template.IsFilterApplied(filterId))
                    {
                        infoIsFilterApplied.Add(string.Format("{0} -> {1}",vItem.Text, template.Name));
                        triggerIsFilterApplied = true;
                    }
                }                
            }
            if (triggerIsFilterApplied)
            {
                // show warning form
                UI.Info.Form_Warning.warningHead = "You should know...";
                UI.Info.Form_Warning.warningMain = "The following Filters are already applied to one or more selected View Templates:";
                UI.Info.Form_Warning.warningFoot = "Graphic settings will be overriden.";
                UI.Info.Form_Warning.warningList = infoIsFilterApplied;
                using (UI.Info.Form_Warning thisForm = new Info.Form_Warning())
                {
                    thisForm.ShowDialog();
                }
            }
            #endregion

            #region PROCEED WITH TRANSACTION
            executionTime.Start();
            using (Transaction t = new Transaction(m_doc, "Transfer View Filters"))
            {
                Ana_NoOfTemplates = LsvTemplates.CheckedItems.Count;     // collect data for analytics

                t.Start();
                // FOR EACH FILTER SELECTED FROM THE LIST, GET HOST VIEW TEMPLATE AND GRAPHIC OVERRIDES
                foreach (ListViewItem filterItem in LsvFilters.CheckedItems)
                {
                    ElementId filterId = new ElementId(filterItem.ImageIndex);
                    // GET SOURCE VIEW TEMPLATE TO GET GRAPHIC OVERRIDES
                    Autodesk.Revit.DB.View sourceTemplate = Data.Helpers.GetTemplateByName(m_doc, filterItem.Group.ToString());
                    OverrideGraphicSettings graphSetting = sourceTemplate.GetFilterOverrides(filterId);

                    //FOR EACH TARGET TEMPLATE SELECTED, APPLY FILTERS
                    foreach (ListViewItem templateItem in LsvTemplates.CheckedItems)
                    {
                        ElementId templateId = new ElementId(templateItem.ImageIndex);
                        Autodesk.Revit.DB.View targetTemplate = m_doc.GetElement(templateId) as Autodesk.Revit.DB.View;

                        if (!targetTemplate.IsFilterApplied(filterId))   // IF FILTER IS NOT APPLIED, ADD FILTER AND OVERRIDE GRAPHICS
                        {
                            targetTemplate.AddFilter(filterId);
                            targetTemplate.SetFilterOverrides(filterId, graphSetting);

                            infoFiltersTransferred.Add(m_doc.GetElement(filterId).Name + " -> " + targetTemplate.Name);

                            Ana_NoOfFilters_Applied += 1;       // collect data for analytics
                        }

                        else // IF FILTER ALREADY APPLIED, JUST OVERRIDE GRAPHICS
                        {
                            targetTemplate.SetFilterOverrides(filterId, graphSetting);

                            infoFiltersGraphicOverriden.Add(m_doc.GetElement(filterId).Name + " -> " + targetTemplate.Name);

                            Ana_NoOfFilters_Overriden += 1;     // collect data for analytics
                        }

                        Ana_NoOfFilters_Total += 1;     // collect data for analytics
                    }
                }
                t.Commit();
            }
            executionTime.Stop();
            ExecTimeElapseS = executionTime.Elapsed.Seconds.ToString();     // collect data for analytics
            #endregion

            #region show Results Form
            UI.Info.Form_Results.resultHead = "Results";
            UI.Info.Form_Results.resultMain1 = "Filters Transferred:";
            UI.Info.Form_Results.resultMain2 = "Filters with Graphic Settings Overriden";
            UI.Info.Form_Results.resultList1 = infoFiltersTransferred;
            UI.Info.Form_Results.resultList2 = infoFiltersGraphicOverriden;

            using (UI.Info.Form_Results thisForm = new Info.Form_Results())
            {
                thisForm.ShowDialog();
            }
            #endregion// show Results Form

            //DialogResult = DialogResult.OK;
            useTime.Stop();
            UseTimeElapseS = useTime.Elapsed.Seconds.ToString();    // collect data for analytics
            Utilities.GetAnalyticsCSV(m_doc, m_app);
            Helpers.TransferViewFiltersAnalytics(m_doc, m_app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFilters_Total, Ana_NoOfFilters_Applied, Ana_NoOfFilters_Overriden, Ana_NoOfTemplates);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        #region HELPERS
        private void LoadTemplates(Dictionary<Autodesk.Revit.DB.View, string> templatesDict)
        {
            if (templatesDict.Count == 0)   // SHOW MESSAGE AND DISABLE LISTVIEW IF NO TEMPLATES ARE FOUND
            {
                LsvTemplates.Items.Add("No View Templates were found.");
                LsvTemplates.Enabled = false;
                LsvTemplates.CheckBoxes = false;
                TxbSearchTemplates.Enabled = false;
            }
            foreach (KeyValuePair<Autodesk.Revit.DB.View, string> p in templatesDict)
            {
                ListViewItem viewItem = new ListViewItem(p.Value, p.Key.Id.IntegerValue);
                LsvTemplates.Items.Add(viewItem);
            }
            LsvTemplates.Sorting = SortOrder.Ascending;
        }

        private void LoadTemplatesSearch(Dictionary<Autodesk.Revit.DB.View, string> dict, string search)
        {
            foreach (KeyValuePair<Autodesk.Revit.DB.View, string> p in dict)
            {
                if (p.Value.ToUpper().Contains(search.ToUpper()))
                {
                    ListViewItem viewItem = new ListViewItem(p.Value, p.Key.Id.IntegerValue);
                    LsvTemplates.Items.Add(viewItem);
                }                
            }
            LsvTemplates.Sorting = SortOrder.Ascending;
        }

        private void LoadFilters(Document m_doc, Dictionary<Autodesk.Revit.DB.View, string> filters)
        {
            if (filters.Count == 0) // SHOW MESSAGE AND DISABLE LISTVIEW IF NO FILTERS ARE FOUND OR APPLIED
            {
                LsvFilters.Items.Add("This project does not contain filters");
                LsvFilters.Items.Add("or none of them are applied to a View Template.");
                LsvFilters.CheckBoxes = false;
                LsvFilters.Enabled = false;
                LsvTemplates.Enabled = false;
                TxbSearchFilters.Enabled = false;
                TxbSearchTemplates.Enabled = false;
                BtnTransfer.Enabled = false;
            }
            else
            {
                foreach (KeyValuePair<Autodesk.Revit.DB.View, string> p in filters)
                {
                    ListViewGroup viewGroup = new ListViewGroup(p.Value);
                    foreach (ElementId eid in p.Key.GetFilters())
                    {
                        ListViewItem viewItem = new ListViewItem(m_doc.GetElement(eid).Name, eid.IntegerValue, viewGroup);
                        LsvFilters.Groups.Add(viewGroup);
                        LsvFilters.Items.Add(viewItem);
                    }

                }
                LsvFilters.Sorting = SortOrder.Ascending;
            }
        }

        private void LoadFiltersSearch(Document m_doc, Dictionary<Autodesk.Revit.DB.View, string> filters, string search)
        {
            foreach (KeyValuePair<Autodesk.Revit.DB.View, string> p in filters)
            {
                ListViewGroup viewGroup = new ListViewGroup(p.Value);
                foreach (ElementId eid in p.Key.GetFilters())
                {
                    if (m_doc.GetElement(eid).Name.ToUpper().Contains(search.ToUpper()) || p.Value.ToUpper().Contains(search.ToUpper()))
                    {
                        ListViewItem viewItem = new ListViewItem(m_doc.GetElement(eid).Name, eid.IntegerValue, viewGroup);
                        LsvFilters.Groups.Add(viewGroup);
                        LsvFilters.Items.Add(viewItem);
                    }                    
                }
            }
            LsvFilters.Sorting = SortOrder.Ascending;
        }
        #endregion
    }
}
