using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;
using System.Diagnostics;
using ArpUtilities;

namespace Form
{
    using static Data.Helpers;
    using static Entry.CmdMain;

    public partial class Main_Form : System.Windows.Forms.Form
    {
        public Document m_doc;
        public UIDocument m_uidoc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        public static int elemTry = 0;
        public static int elemFail = 0;
        public static int elemSuccess = 0;

        #region Variables for analytics
        private static Stopwatch useTime = new Stopwatch();         // total time user has the application open and it does actually make a transaction
        private static Stopwatch executionTime = new Stopwatch();   // net time of the sheet duplication

        public static string UseTimeElapseS { get; set; } = "";
        public static string ExecTimeElapseS { get; set; } = "";
        public static int Ana_NoOfFlippedWalls { get; set; } = 0;
        public static int Ana_NoOfFlippedDoors { get; set; } = 0;

        #endregion

        public Main_Form(Document doc, UIDocument uidoc, Autodesk.Revit.ApplicationServices.Application app)
        {
            useTime.Start();    // collect data for analytics

            InitializeComponent();
            m_doc = doc;
            m_uidoc = uidoc;
            m_app = app;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (RbtFlipHand.Checked == false && RbtFlipFacing.Checked == false && RbtFlipWalls.Checked == false)
            {
                infoMsgMain = "Choose option";
                infoMsgBody = "You need to choose an option in order to flip.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                
            }

            if (RbtFlipHand.Checked == true)
            {
                if (!GetSelectedDoors(m_uidoc).Any())
                {
                    infoMsgMain = "Select";
                    infoMsgBody = "You need to select a door.";
                    using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                }
                else
                {
                    executionTime.Start();      // collect data for analytics

                    IList<FamilyInstance> doorInstances = GetSelectedDoors(m_uidoc).Cast<FamilyInstance>().ToList();
                    elemTry = doorInstances.Count();
                    using (Transaction t = new Transaction(m_doc, "Flip Door Hand"))
                    {
                        t.Start();
                        try
                        {
                            foreach (FamilyInstance fi in doorInstances)
                            {
                                fi.flipHand();
                                elemSuccess += 1;
                            }
                        }
                        catch (Exception)
                        {
                            elemFail += 1;
                        }
                        t.Commit();
                    }
                    executionTime.Stop();                                       // collect data for analytics
                    ExecTimeElapseS = executionTime.Elapsed.Seconds.ToString(); // collect data for analytics

                    // show Results Form
                    using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results()){ thisForm.ShowDialog(); }
                    
                    DialogResult = DialogResult.OK;

                    useTime.Stop();
                    UseTimeElapseS = useTime.Elapsed.Seconds.ToString();    // collect data for analytics
                    Ana_NoOfFlippedDoors = elemSuccess;                     // collect data for analytics
                    Utilities.GetAnalyticsCSV(m_doc,m_app);                 // collect data for analytics
                    FlipAnalytics(m_doc,m_app,UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFlippedWalls, Ana_NoOfFlippedDoors);       // collect data for analytics             
                }
            }

            if (RbtFlipFacing.Checked == true)
            {
                if (!GetSelectedDoors(m_uidoc).Any())
                {
                    infoMsgMain = "Select";
                    infoMsgBody = "You need to select one or more doors.";
                    using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                }
                else
                {
                    executionTime.Start();      // collect data for analytics

                    IList<FamilyInstance> doorInstances = GetSelectedDoors(m_uidoc).Cast<FamilyInstance>().ToList();
                    elemTry = doorInstances.Count();
                    using (Transaction t = new Transaction(m_doc, "Flip Door Facing"))
                    {
                        t.Start();
                        try
                        {
                            foreach (FamilyInstance fi in doorInstances)
                            {
                                fi.flipFacing();
                                elemSuccess += 1;
                            }
                        }
                        catch (Exception)
                        {
                            elemFail += 1;
                        }                        
                        t.Commit();
                    }
                    executionTime.Stop();                                       // collect data for analytics
                    ExecTimeElapseS = executionTime.Elapsed.Seconds.ToString(); // collect data for analytics

                    // show Results Form
                    using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results()) { thisForm.ShowDialog(); }

                    DialogResult = DialogResult.OK;

                    useTime.Stop();
                    UseTimeElapseS = useTime.Elapsed.Seconds.ToString();    // collect data for analytics
                    Ana_NoOfFlippedDoors = elemSuccess;                     // collect data for analytics
                    Utilities.GetAnalyticsCSV(m_doc, m_app);                 // collect data for analytics
                    FlipAnalytics(m_doc, m_app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFlippedWalls, Ana_NoOfFlippedDoors);       // collect data for analytics
                }                
            }

            if (RbtFlipWalls.Checked == true)
            {
                if (!GetSelectedWalls(m_uidoc).Any())
                {
                    infoMsgMain = "Select";
                    infoMsgBody = "You need to select one or more walls.";
                    using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                }
                else
                {
                    executionTime.Start();      // collect data for analytics

                    IList<Wall> wallInstances = GetSelectedWalls(m_uidoc).Cast<Wall>().ToList();
                    elemTry = wallInstances.Count();
                    using (TransactionGroup tg = new TransactionGroup(m_doc, "Flip Walls"))
                    {
                        tg.Start();
                        foreach (Wall w in wallInstances)
                        {
                            try
                            {
                                Parameter loc_line = w.get_Parameter(BuiltInParameter.WALL_KEY_REF_PARAM);
                                int currentValue = loc_line.AsInteger();
                                using (Transaction t = new Transaction(m_doc, "Change Location Line"))
                                {
                                    t.Start();
                                    loc_line.Set(0);
                                    t.Commit();
                                }
                                using (Transaction t = new Transaction(m_doc, "Flip the wall"))
                                {
                                    t.Start();
                                    w.Flip();
                                    elemSuccess += 1;
                                    loc_line.Set(currentValue);
                                    t.Commit();
                                }
                            }
                            catch (Exception)
                            {
                                elemFail += 1;
                            }                            
                        }
                        tg.Assimilate();
                    }
                    executionTime.Stop();                                       // collect data for analytics
                    ExecTimeElapseS = executionTime.Elapsed.Seconds.ToString(); // collect data for analytics

                    // show Results Form
                    using (UI.Info.Form_Results thisForm = new UI.Info.Form_Results()) { thisForm.ShowDialog(); }

                    DialogResult = DialogResult.OK;

                    useTime.Stop();
                    UseTimeElapseS = useTime.Elapsed.Seconds.ToString();    // collect data for analytics
                    Ana_NoOfFlippedWalls = elemSuccess;
                    Utilities.GetAnalyticsCSV(m_doc, m_app);                 // collect data for analytics
                    FlipAnalytics(m_doc, m_app, UseTimeElapseS, ExecTimeElapseS, Ana_NoOfFlippedWalls, Ana_NoOfFlippedDoors);       // collect data for analytics
                }                
            }
        }

        private void RbtFlipHand_Click(object sender, EventArgs e)
        {
            if (RbtFlipHand.Checked == true)
            {
                RbtFlipWalls.Checked = false;
            }
        }

        private void RbtFlipFacing_Click(object sender, EventArgs e)
        {
            if (RbtFlipFacing.Checked == true)
            {
                RbtFlipWalls.Checked = false;
            }
        }

        private void RbtFlipWall_Click(object sender, EventArgs e)
        {
            if (RbtFlipFacing.Checked == true || RbtFlipHand.Checked == true)
            {
                RbtFlipFacing.Checked = false;
                RbtFlipHand.Checked = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
