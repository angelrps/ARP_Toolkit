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
    using static Data.Helpers;

    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;
        public bool transactionMade = false; // to check if a transaction has been made before closing the dialog, to trigger Analytics method

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
            LoadViews();
        }

        public async void TxbSearch_TextChanged(object sender, EventArgs e)
        {
            // async inner method to delay TextChanged event while user typing
            async Task<bool> UserKeepsTyping()
            {
                string txt = TxbSearch.Text;    // remember text
                await Task.Delay(500);          // wait some
                return txt != TxbSearch.Text;   // return that text changed or not
            }
            if (await UserKeepsTyping()) return;

            LoadViews();
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            TreeView.ExpandAll();
        }

        private void BtnCollapse_Click(object sender, EventArgs e)
        {
            TreeView.CollapseAll();
        }

        #region Controls Drag & Drop Tree

        // select correct node depth. Occurs when the user begins dragging a node.
        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // allow ONLY views to be dragged (views are Level 2 nodes)
            TreeNode tNode = e.Item as TreeNode;
            if (tNode.Level == 2)
            {
                // set the drag node and initiate the DragDrop
                DoDragDrop(e.Item, DragDropEffects.Move);
            }            
        }
        
        // set the target drop effect to the effect specified in the ItemDrag event handler.
        // Occurs when an object is dragged into the control´s bounds.
        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true))
            //{
            //    e.Effect = DragDropEffects.Move;
            //}
            //else e.Effect = DragDropEffects.None;
            e.Effect = e.AllowedEffect;
        }

        // Select the node under the mouse pointer to indicate the expected drop location.
        // Occurs when an object is dragged over the control´s bounds.
        private void TreeView_DragOver(object sender, DragEventArgs e)
        {
            // check that there is a TreeNode being dragged
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", true) == false)
            {
                return;
            }

            // get the TreeView raising the event
            //TreeView selectedTreeView = sender as TreeView;

            // as the mouse moves over nodes, provide feddback to 
            // the user by highlighting the node that is the current drop target

            System.Drawing.Point targetPoint = TreeView.PointToClient(new System.Drawing.Point(e.X, e.Y));
            TreeNode targetNode = TreeView.GetNodeAt(targetPoint);

            //System.Drawing.Point targetPoint = selectedTreeView.PointToClient(new System.Drawing.Point(e.X, e.Y));
            //TreeNode targetNode = selectedTreeView.GetNodeAt(targetPoint);

            // see if targetNode is currently selected, if so no need to validate again
            if (TreeView.SelectedNode != targetNode)
            {
                // select the node currently under the cursor
                TreeView.SelectedNode = targetNode;
                // default behavior
                e.Effect = DragDropEffects.None;
                // validation only to level 1 nodes
                if (targetNode.Level == 1)
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        // Occurs when a drag-and-drop operation is completed
        private void TreeView_DragDrop (object sender, DragEventArgs e)
        {
            // get the TreeNode being dragged
            TreeNode draggedNode = e.Data.GetData(typeof(TreeNode)) as TreeNode;

            // retrieve coordinates of drop location
            System.Drawing.Point targetPoint = TreeView.PointToClient(new System.Drawing.Point(e.X, e.Y));

            // The target node should be selected from the DragOver event
            TreeNode targetNode = TreeView.GetNodeAt(targetPoint);

            Autodesk.Revit.DB.View m_view = draggedNode.Tag as Autodesk.Revit.DB.View;
            //Autodesk.Revit.DB.View m_template = targetNode.Tag as Autodesk.Revit.DB.View;          

            using (Transaction t = new Transaction(m_doc, "Assign View Template"))
            {
                t.Start();
                ElementId newId = new ElementId(System.Convert.ToInt32(targetNode.Name));
                m_view.ViewTemplateId = newId;
                transactionMade = true; // to trigger the Analytics method
                t.Commit();
            }

            draggedNode.Remove();
            if (targetNode == null)
            {
                TreeView.Nodes.Add(draggedNode);
            }
            else
            {
                targetNode.Nodes.Add(draggedNode);
            }

            draggedNode.EnsureVisible();
            TreeView.SelectedNode = draggedNode;
            targetNode.Expand();    // to show the dropped node
        }
        #endregion

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (transactionMade == true) // only record analytics if a transaction has been made
            {
                //try
                //{
                //    Utilities.GetAnalyticsCSV(m_doc, m_app);
                //}
                //catch (Exception)
                //{
                //}
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        #region HELPERS

        private void LoadViews()
        {
            TreeView.Nodes.Clear();

            // add view templates
            foreach (Autodesk.Revit.DB.View vt in GetViewTemplates(m_doc))
            {
                if (!TreeView.Nodes.ContainsKey(vt.ViewType.ToString()))
                {
                    TreeView.Nodes.Add(vt.ViewType.ToString(), vt.ViewType.ToString());
                    TreeView.Nodes[vt.ViewType.ToString()].Nodes.Add("-1", "<Views Without Template>").NodeFont = new Font(TreeView.Font, FontStyle.Bold);
                }

                TreeView.Nodes[vt.ViewType.ToString()].Nodes.Add(vt.Id.ToString(), "TEMPLATE: " + vt.Name).NodeFont = new Font(TreeView.Font, FontStyle.Bold);
            }

            // add views
            foreach (Autodesk.Revit.DB.View v in GetViews(m_doc))
            {
                // hide it?
                if (!string.IsNullOrEmpty(TxbSearch.Text))
                {
                    if (!v.Name.ToLower().Contains(TxbSearch.Text.ToLower()))
                    {
                        continue;
                    }
                }

                // get view template from view
                Autodesk.Revit.DB.View vtemp = m_doc.GetElement(v.ViewTemplateId) as Autodesk.Revit.DB.View;

                // set m_text parameter
                try
                {
                    string m_text = "";
                    if (v.GenLevel != null)
                    {
                        m_text = string.Format("({0}) {1}", v.GenLevel.Name.ToString(), v.Name);
                    }
                    else
                    {
                        m_text = v.Name;
                    }
                    if (v.ViewTemplateId.ToString() == "-1") // id view has NO template assigned
                    {
                        TreeNode tn = TreeView.Nodes[v.ViewType.ToString()].Nodes[v.ViewTemplateId.IntegerValue.ToString()].Nodes.Add(v.Id.ToString(), m_text);
                        
                        if(!string.IsNullOrEmpty(TxbSearch.Text))
                        {
                            tn.BackColor = System.Drawing.Color.LightGray;
                            //TreeView.ExpandAll();
                        }
                            
                        TreeView.Nodes[v.ViewType.ToString()].Nodes[v.ViewTemplateId.IntegerValue.ToString()].Nodes[v.Id.ToString()].Tag = v;
                    }
                    if (v.ViewTemplateId.ToString() != "-1") // id view HAS template assigned
                    {
                        TreeNode tn = TreeView.Nodes[vtemp.ViewType.ToString()].Nodes[v.ViewTemplateId.IntegerValue.ToString()].Nodes.Add(v.Id.ToString(), m_text);
                        if (!string.IsNullOrEmpty(TxbSearch.Text))
                        {
                            tn.BackColor = System.Drawing.Color.LightGray;
                            //TreeView.ExpandAll();arrivals
                        }

                        TreeView.Nodes[vtemp.ViewType.ToString()].Nodes[v.ViewTemplateId.IntegerValue.ToString()].Nodes[v.Id.ToString()].Tag = v;
                    }                    
                }
                catch (Exception)
                {
                }

                // expand all when searching
                if (!string.IsNullOrEmpty(TxbSearch.Text))
                {
                    TreeView.ExpandAll();
                }
            }
        }
        #endregion
    }
}
