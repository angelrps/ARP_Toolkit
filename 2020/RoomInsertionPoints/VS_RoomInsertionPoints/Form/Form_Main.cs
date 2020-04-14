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
                TaskDialog.Show("Information", "Select and option to move.");
            }

            // show message if there are neither tags not rooms
            if ((CbxRoomCentroid.Checked || CbxRoomTag.Checked)
                && !Data.Helpers.GetModelRooms(m_doc).Any()
                && !Data.Helpers.GetModelRoomTags(m_doc).Any()
                && !Data.Helpers.GetLinkRoomTags(m_doc).Any())
            {
                TaskDialog.Show("Information", "There are not placed rooms or room tags in the project.");
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
                            TaskDialog.Show("Information", "There are not placed rooms in this Project.");
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
                            TaskDialog.Show("Information", "Room insertion points have been moved to centroid.");

                            DialogResult = DialogResult.OK;
                        }
                    }

                    if (RbtActiveView.Checked) // if "Active View" is checked
                    {
                        if (!Data.Helpers.GetModelRoomsActView(m_doc).Any()) // show message if there are no rooms in active view
                        {
                            TaskDialog.Show("Information", "There are not placed rooms in this view.");
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
                            TaskDialog.Show("Information", "Room location points have been moved to centroid.");

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
                            TaskDialog.Show("Information", "There are not room tags in this active view, or they are tagging rooms from a linked model.");
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
                            TaskDialog.Show("Information", "Room tags have been moved to room location point.");

                            DialogResult = DialogResult.OK;
                        }
                    }

                    if (RbtProject.Checked) // if "Entire Project" is checked
                    {
                        if (CbxLinkedRoomTag.Checked && CbxRoomTag.Checked) // if "Include tags of linked rooms" is checked
                        {                            
                            if (!Data.Helpers.GetLinkRoomTags(m_doc).Any())
                            {
                                TaskDialog.Show("Information", "There are not room tags tagging linked rooms in the model.");                                
                            }
                            else // move all tags
                            {
                                using (Transaction t = new Transaction(m_doc, "Tags to Room Insertion Point"))
                                {
                                    t.Start();
                                    Data.Helpers.MoveModelTags(m_doc, Data.Helpers.GetModelRoomTags(m_doc)); // move model tags
                                    TaskDialog.Show("Information", "Room tags have been moved to room insertion point.");
                                    try
                                    {
                                        foreach (RoomTag rt in Data.Helpers.GetLinkRoomTags(m_doc)) // move linked tags
                                        {
                                            Data.Helpers.MoveLinkTags(m_doc, rt);
                                        }
                                        TaskDialog.Show("Information", "Tags of linked rooms have been moved to room insertion point.");
                                    }
                                    catch (Exception)
                                    {
                                        TaskDialog.Show("Information","Tags of linked rooms were not moved.\n" +
                                                                        "One or more links containing tagged rooms are unloaded.\n" +
                                                                        "Please, reload links and try again.");
                                        DialogResult = DialogResult.Cancel;
                                    }                                                                      
                                    t.Commit();
                                }
                                //TaskDialog.Show("Information", "Room tags have been moved to room insertion point. Including tags of linked rooms.");

                                DialogResult = DialogResult.OK;
                            }
                        }

                        if (!CbxLinkedRoomTag.Checked) // if "Include tags of linked rooms" is unchecked 
                        {
                            if (!Data.Helpers.GetModelRoomTags(m_doc).Any())
                            {
                                TaskDialog.Show("Information", "There are not room tags in the model, or they are tagging rooms from a linked model.");
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
                                TaskDialog.Show("Information", "Room tags have been moved to room insertion point.");

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
