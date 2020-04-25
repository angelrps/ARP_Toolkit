using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;

namespace Form
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public static string infoMsgMain = "";
        public static string infoMsgBody = "";
        public static string warningMsgMain = "";
        public static string warningMsgBody = "";

        public Form_Main(Document doc)
        {
            InitializeComponent();
            m_doc = doc;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // show message if both boxes are unchecked
            if (!CbxRoomCentroid.Checked && !CbxRoomTag.Checked)
            {
                infoMsgMain = "Hey!";
                infoMsgBody = "Choose an action from the menu.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
            }

            // show message if there are neither tags not rooms
            if ((CbxRoomCentroid.Checked || CbxRoomTag.Checked)
                && !Data.Helpers.GetModelRooms(m_doc).Any()
                && !Data.Helpers.GetModelRoomTags(m_doc).Any()
                && !Data.Helpers.GetLinkRoomTags(m_doc).Any())
            {
                // show dialog
                infoMsgMain = "Missing elements";
                infoMsgBody = "There are not placed rooms or room tags in this project.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                Close();
            }

            else // if there are tags or rooms
            {
                if (CbxRoomCentroid.Checked)
                {
                    if (RbtProject.Checked) // if "Entire Project" is checked
                    {
                        if (!Data.Helpers.GetModelRooms(m_doc).Any()) // show message if there are no rooms
                        {
                            // show dialog
                            infoMsgMain = "Missing elements";
                            infoMsgBody = "There are not placed rooms in this project.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            Close();
                        }
                        else // move room insertion point to centroid
                        {
                            using (Transaction t = new Transaction(m_doc, "Room Insertion Point to Centroid"))
                            {
                                t.Start();
                                Data.Helpers.MoveRoomToCentroid(m_doc, Data.Helpers.GetModelRooms(m_doc));
                                t.Commit();
                            }
                            // show dialog
                            infoMsgMain = "Result";
                            infoMsgBody = "Room location points have been moved to centroid.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            DialogResult = DialogResult.OK;
                        }
                    }

                    if (RbtActiveView.Checked) // if "Active View" is checked
                    {
                        if (!Data.Helpers.GetModelRoomsActView(m_doc).Any()) // show message if there are no rooms in active view
                        {
                            // show dialog
                            infoMsgMain = "Missing elements";
                            infoMsgBody = "There are not placed rooms in this view.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            Close();
                        }
                        else // move room insertion point to centroid
                        {
                            using (Transaction t = new Transaction(m_doc, "Room Insertion Point to Centroid"))
                            {
                                t.Start();
                                Data.Helpers.MoveRoomToCentroid(m_doc, Data.Helpers.GetModelRoomsActView(m_doc));
                                t.Commit();
                            }
                            // show dialog
                            infoMsgMain = "Result";
                            infoMsgBody = "Room location points have been moved to centroid.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            DialogResult = DialogResult.OK;
                        }
                    }
                }

                if (CbxRoomTag.Checked)
                {
                    if (RbtActiveView.Checked) // if "Active View" is checked
                    {
                        if (!Data.Helpers.GetModelRoomTagsActView(m_doc).Any()) // show message if there are no tags
                        {
                            // show dialog
                            infoMsgMain = "Missing elements";
                            infoMsgBody = "There are not room tags in this active view, or they are tagging rooms from a linked model.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            Close();
                        }
                        else // move tag to room insertion point
                        {
                            using (Transaction t = new Transaction(m_doc, "Tags to Room Insertion Point"))
                            {
                                t.Start();
                                Data.Helpers.MoveModelTags(m_doc, Data.Helpers.GetModelRoomTagsActView(m_doc));
                                t.Commit();
                            }
                            // show dialog
                            infoMsgMain = "Result";
                            infoMsgBody = "Room tags have been moved to room location point.";
                            using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            DialogResult = DialogResult.OK;
                        }
                    }

                    if (RbtProject.Checked) // if "Entire Project" is checked
                    {
                        if (CbxLinkedRoomTag.Checked && CbxRoomTag.Checked) // if "Include tags of linked rooms" is checked
                        {                            
                            if (!Data.Helpers.GetLinkRoomTags(m_doc).Any())
                            {
                                // show dialog
                                infoMsgMain = "Missing elements";
                                infoMsgBody = "There are not room tags tagging linked rooms in the model.";
                                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                            }
                            else // move all tags
                            {
                                using (Transaction t = new Transaction(m_doc, "Tags to Room Insertion Point"))
                                {
                                    t.Start();
                                    Data.Helpers.MoveModelTags(m_doc, Data.Helpers.GetModelRoomTags(m_doc)); // move model tags
                                    // show dialog
                                    infoMsgMain = "Result";
                                    infoMsgBody = "Room tags have been moved to room location point.";
                                    using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
                                    try
                                    {
                                        foreach (RoomTag rt in Data.Helpers.GetLinkRoomTags(m_doc)) // move linked tags
                                        {
                                            Data.Helpers.MoveLinkTags(m_doc, rt);
                                        }
                                        // show dialog
                                        infoMsgMain = "Result";
                                        infoMsgBody = "Tags of linked rooms have been moved to room insertion point.";
                                        using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }                                        
                                    }
                                    catch (Exception)
                                    {
                                        // show dialog
                                        warningMsgMain = "For your information";
                                        warningMsgBody = string.Format("Some tags of linked rooms were not moved " +
                                                                        "because one or more links containing tagged rooms are unloaded.{0}{0}" +
                                                                        "Please, reload links and try again.", Environment.NewLine);
                                        using (UI.Info.Form_Warning thisForm = new UI.Info.Form_Warning()) { thisForm.ShowDialog(); }
                                        DialogResult = DialogResult.Cancel;
                                    }                                                                      
                                    t.Commit();
                                }
                                DialogResult = DialogResult.OK;
                            }
                        }

                        if (!CbxLinkedRoomTag.Checked) // if "Include tags of linked rooms" is unchecked 
                        {
                            if (!Data.Helpers.GetModelRoomTags(m_doc).Any())
                            {
                                // show dialog
                                infoMsgMain = "Missing elements";
                                infoMsgBody = "There are not room tags in the model, or they are tagging rooms from a linked model.";
                                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }

                                Close();
                            }
                            else // move model tags
                            {
                                using (Transaction t = new Transaction(m_doc, "Tags to Room Insertion Point"))
                                {
                                    t.Start();
                                    Data.Helpers.MoveModelTags(m_doc, Data.Helpers.GetModelRoomTags(m_doc));
                                    t.Commit();
                                }
                                // show dialog
                                infoMsgMain = "ResultAA";
                                infoMsgBody = "Room tags have been moved to room insertion point.";
                                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }

                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbxRoomTag_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtActiveView.Checked)
            {
                CbxLinkedRoomTag.Enabled = false;
                textBox1.Enabled = false;
            }
            if (!RbtActiveView.Checked && !CbxRoomTag.Checked)
            {
                CbxLinkedRoomTag.Enabled = false;
                CbxLinkedRoomTag.Checked = false;
                textBox1.Enabled = false;
            }
            if (!RbtActiveView.Checked && CbxRoomTag.Checked)
            {
                CbxLinkedRoomTag.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void RbtActiveView_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtActiveView.Checked)
            {
                CbxLinkedRoomTag.Enabled = false;
                CbxLinkedRoomTag.Checked = false;
                textBox1.Enabled = false;
            }
        }

        private void RbtProject_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtProject.Checked && CbxRoomTag.Checked)
            {
                CbxLinkedRoomTag.Enabled = true;
                textBox1.Enabled = true;
            }
        }
    }
}
