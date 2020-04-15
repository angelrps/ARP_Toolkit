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
using System.Diagnostics;
using ArpUtilities;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        public bool transactionMade = false; // to check if a transaction has been made before closing the dialog, to trigger Analytics method

        #region Variables for analytics
        private static Stopwatch useTime = new Stopwatch(); // total time user has the application open and it does actually make a transaction
        private static Stopwatch executionTime = new Stopwatch();   // net time of the sheet duplication

        public static string UseTimeElapseS { get; set; } = "";
        public static string ExecTimeElapseS { get; set; } = "";
        public static int Ana_NoOfCopies { get; set; } = 0;     // number of sheets duplicated
        public static int Ana_NoOfViewports { get; set; } = 0;  // number of viewports duplicated
        public static string Ana_SheetNumber { get; set; } = "";
        public static string Ana_SheetName { get; set; } = "";
        // execTimeElapseS
        #endregion

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            useTime.Start();

            InitializeComponent();
            m_doc = doc;
            m_app = app;
            LoadSheets();
        }
        
        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            // reset viewport counter
            Ana_NoOfViewports = 0;

            // get number of copies
            int copies = Convert.ToInt32(NumOfCopies.Value);

            // set Dependent views Duplicate Option
            ViewDuplicateOption dependentOption = ViewDuplicateOption.AsDependent;
            if (CbxDependent.Checked != true)
            {
                dependentOption = ViewDuplicateOption.WithDetailing;
            }

            // is there at least one item selected?
            if (LsvSheets.CheckedItems.Count == 0)
            {
                TaskDialog tdItemChecked = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "At least one sheet must be selected.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdItemChecked.Show();
            }

            // proceed with duplication
            else
            {
                executionTime.Start(); // start execution time counter

                // collect selected sheets, for multiple selection
                List<string> selSheetsTxt = new List<string>();
                List<ViewSheet> allViewSheets = Data.Helpers.GetViewSheets(m_doc);
                foreach (ListViewItem lv in LsvSheets.CheckedItems)
                {
                    selSheetsTxt.Add(lv.SubItems[0].Text);
                }
                List<ViewSheet> selViewSheets = Data.Helpers.GetSelectedSheets(allViewSheets, selSheetsTxt);
                // currently multiple selection is not allowed, so take just one item
                ViewSheet sourceSheet = selViewSheets.First();
                Ana_SheetNumber = sourceSheet.SheetNumber;
                Ana_SheetName = sourceSheet.Name;
                Ana_NoOfCopies = copies;

                DuplicateSheets(m_doc, sourceSheet, copies, dependentOption);

                transactionMade = true; // to trigger stopwatch stop in other methods
                executionTime.Stop(); // stop execution time counter
                ExecTimeElapseS = executionTime.Elapsed.Seconds.ToString();

                TaskDialog tdContinue = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconInformation,
                    MainInstruction = string.Format("You have made {1} copies of '{0}'.\n\nNOTE: A suffix 'DupX' has been added to the view names. "
                                                    + "Please, rename the views appropriately. \n\nDo you want to duplicate another sheet?"
                                                    , sourceSheet.Name, copies),
                    CommonButtons = TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No,
                    TitleAutoPrefix = false
                };
                switch (tdContinue.Show())
                {
                    case TaskDialogResult.Yes:
                        useTime.Stop();
                        UseTimeElapseS = useTime.Elapsed.Seconds.ToString();
                        Utilities.GetAnalyticsCSV(m_doc, m_app);
                        Data.Helpers.DuplicateSheetsAnalytics(m_doc, m_app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfCopies, Ana_NoOfViewports, Ana_SheetNumber, Ana_SheetName);
                        useTime.Restart();    // reset use time and start time counter again
                        break;

                    case TaskDialogResult.No:
                        useTime.Stop();
                        UseTimeElapseS = useTime.Elapsed.Seconds.ToString();
                        Utilities.GetAnalyticsCSV(m_doc, m_app);
                        Data.Helpers.DuplicateSheetsAnalytics(m_doc, m_app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfCopies, Ana_NoOfViewports, Ana_SheetNumber, Ana_SheetName);

                        DialogResult = DialogResult.OK;                        
                        break;
                }
            }            
        }

        // text box filter behavior
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

        // allow only one checked item
        private void LsvSheets_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LsvSheets.SelectedItems.Count > 0)
            {
                for (int i = 0; i < LsvSheets.Items.Count; i++)
                {
                    LsvSheets.Items[i].Checked = false;
                }
                //var df = LsvSheets.CheckedIndices;
                LsvSheets.SelectedItems[0].Checked = true;
            }
        }

        // allow only one checked item
        private void LsvSheets_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < LsvSheets.Items.Count; ++i)
                {
                    if (e.Index != i)
                        LsvSheets.Items[i].Checked = false;
                }
                LsvSheets.Items[e.Index].Selected = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void LoadSheets()
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

        /// <summary>
        /// Duplicates the input sheet a number of times. It allows for ViewDuplicateOption for dependent views.
        /// </summary>
        /// <param name="m_doc"></param>
        /// <param name="sourceSheet"></param>
        /// <param name="copies"></param>
        /// <param name="dependentOption"></param>
        private void DuplicateSheets(Document m_doc, ViewSheet sourceSheet, int copies, ViewDuplicateOption dependentOption)
        {
            // get Title Block
            FamilyInstance titleBlock = new FilteredElementCollector(m_doc)
                                            .OfClass(typeof(FamilyInstance))
                                            .OfCategory(BuiltInCategory.OST_TitleBlocks)
                                            .Cast<FamilyInstance>()
                                            .First(q => q.OwnerViewId == sourceSheet.Id);
            using (TransactionGroup tg = new TransactionGroup(m_doc, "Duplicate Sheet"))
            {
                tg.Start();
                for (int i = 0; i < copies; i++)
                {
                    // create unique sheet number
                    string uniqueSheetNumber = Data.Helpers.CreateUniqueSheetNumber(m_doc, sourceSheet);

                    using (Transaction t = new Transaction(m_doc, "Duplicate Sheet"))
                    {
                        t.Start();

                        // create new SHEET, new NUMBER and new NAME
                        ViewSheet newSheet = ViewSheet.Create(m_doc, titleBlock.GetTypeId());
                        newSheet.SheetNumber = uniqueSheetNumber;
                        newSheet.Name = sourceSheet.Name;

                        #region Loop through viewports (except schedules) because GetAllPlacedViews() does not return Schedules
                        foreach (ElementId eid in sourceSheet.GetAllPlacedViews())
                        {
                            // get view element
                            Autodesk.Revit.DB.View sourceView = m_doc.GetElement(eid) as Autodesk.Revit.DB.View;
                            Autodesk.Revit.DB.View newView = null;  // declare newView variable

                            // DUPLICATE views
                            // if view element is legend newView is equal to sourceView
                            if (sourceView.ViewType == ViewType.Legend)
                            {
                                newView = sourceView;
                            }
                            else // for non-legend views
                            {
                                if (sourceView.GetPrimaryViewId() == ElementId.InvalidElementId) // if parent view
                                {
                                    ElementId newViewId = sourceView.Duplicate(ViewDuplicateOption.WithDetailing);
                                    newView = m_doc.GetElement(newViewId) as Autodesk.Revit.DB.View;
                                    newView.Name = Data.Helpers.CreateUniqueViewName(m_doc, sourceView);
                                    //newView.ChangeTypeId(sourceTypeId);
                                }
                                else // if dependent view
                                {
                                    ElementId newViewId = sourceView.Duplicate(dependentOption);
                                    newView = m_doc.GetElement(newViewId) as Autodesk.Revit.DB.View;
                                    newView.Name = Data.Helpers.CreateUniqueViewName(m_doc, sourceView);
                                    //newView.ChangeTypeId(sourceTypeId);
                                }
                            }
                            // CREATE viewport and MOVE it
                            foreach (Viewport vp in new FilteredElementCollector(m_doc).OfClass(typeof(Viewport)))
                            {
                                if (vp.SheetId == sourceSheet.Id && vp.ViewId == sourceView.Id)
                                {
                                    XYZ sourceCenter = vp.GetBoxCenter();
                                    ElementId sourceTypeId = vp.GetTypeId();

                                    Viewport newViewport = Viewport.Create(m_doc, newSheet.Id, newView.Id, XYZ.Zero);
                                    newViewport.ChangeTypeId(sourceTypeId);
                                    Ana_NoOfViewports += 1; // add 1 to the viewport counter

                                    XYZ newCenter = newViewport.GetBoxCenter();

                                    ElementTransformUtils.MoveElement(m_doc, newViewport.Id, new XYZ(
                                                                      sourceCenter.X - newCenter.X,
                                                                      sourceCenter.Y - newCenter.Y,
                                                                      0));
                                }
                            }
                        }
                        #endregion

                        #region Loop through schedules
                        foreach (ScheduleSheetInstance si in (new FilteredElementCollector(m_doc).OfClass(typeof(ScheduleSheetInstance))))
                        {
                            if (si.OwnerViewId == sourceSheet.Id)
                            {
                                if (!si.IsTitleblockRevisionSchedule)
                                {
                                    foreach (ViewSchedule viewSchedule in new FilteredElementCollector(m_doc).OfClass(typeof(ViewSchedule)))
                                    {
                                        if (si.ScheduleId == viewSchedule.Id)
                                        {
                                            XYZ sourceCenter = si.Point;
                                            ScheduleSheetInstance newSSheetInstance = ScheduleSheetInstance.Create(m_doc, newSheet.Id, viewSchedule.Id, XYZ.Zero);
                                            XYZ newCenter = newSSheetInstance.Point;
                                            ElementTransformUtils.MoveElement(m_doc, newSSheetInstance.Id, new XYZ(
                                                                                    sourceCenter.X - newCenter.X,
                                                                                    sourceCenter.Y - newCenter.Y,
                                                                                    0));
                                        }
                                    }
                                }
                            }
                        }
                        #endregion

                        t.Commit();
                    }
                }
                tg.Assimilate();
            }            
        }
    }
}
