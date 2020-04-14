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

namespace Form
{
    using static Data.Helpers;

    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;

        public Form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            foreach (Document d in GetOpenDocuments(m_doc, m_app))
            {
                CbxOpenDocs.Items.Add(d);
            }
            CbxOpenDocs.Sorted = true;
            CbxOpenDocs.DisplayMember = "Title";
            CbxOpenDocs.SelectedIndex = 0;
        }        

        private void CbxOpenDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClbTemplates.Items.Clear();
            Document selDoc = CbxOpenDocs.SelectedItem as Document;

            foreach (Autodesk.Revit.DB.View v in GetViewTemplates(selDoc))
            {
                ClbTemplates.Items.Add(v);
            }
            ClbTemplates.Sorted = true;
            ClbTemplates.ValueMember = "Name";

            LblCount.Text = ClbTemplates.CheckedItems.Count.ToString();
        }

        private void ClbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblCount.Text = ClbTemplates.CheckedItems.Count.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string info = "";
            string duplicatedNames = "";
            CopyPasteOptions copyOpt = new CopyPasteOptions();
            Document sourceDoc = CbxOpenDocs.SelectedItem as Document;
            List<ElementId> templatesToCopy = new List<ElementId>();

            // is there at least one item selected?
            if (ClbTemplates.CheckedItems.Count == 0)
            {
                TaskDialog tdItemChecked = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "At least one View Template must be selected.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdItemChecked.Show();
            }
            
            // proceed to transfer
            try
            {
                foreach (Autodesk.Revit.DB.View v in ClbTemplates.CheckedItems)
                {
                    templatesToCopy.Add(v.Id);
                    info += v.Name + "\n";

                    // get duplicated names
                    if (GetViewTemplateNames(m_doc).Contains(v.Name))
                    {
                        duplicatedNames += "- " + v.Name + "\n";
                    }
                }
                if (duplicatedNames != "") // show message if there are duplicated names
                {
                    TaskDialog tdDuplicates = new TaskDialog("Information")
                    {
                        MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                        MainInstruction = "The following templates already exist or have the same name:"
                                            + "\n" + "\n" + duplicatedNames
                                            + "\n" + "\n" + "A suffix will be added to the name." + "\n"
                                            + "Do you want to continue?",
                        TitleAutoPrefix = false,
                        CommonButtons =TaskDialogCommonButtons.No | TaskDialogCommonButtons.Yes,
                    };
                    TaskDialogResult tdInfoResult = tdDuplicates.Show();

                    //TaskDialog.Show("Information", "The following templates already exist or have the same name."
                    //                            + "\n" + "\n" + duplicatedNames
                    //                            + "\n" + "\n" + "A suffix will be added to the name.");
                    if (tdInfoResult == TaskDialogResult.No)    // close Taskdialog if press NO
                    {
                        DialogResult = DialogResult.None;
                    }
                    else // continue transfering view templates
                    {
                        using (Transaction t = new Transaction(m_doc, "Transfer View Templates"))
                        {
                            t.Start();
                            ElementTransformUtils.CopyElements(sourceDoc, templatesToCopy, m_doc, Transform.Identity, copyOpt);
                            t.Commit();
                        }
                        TaskDialog.Show("Information", "The following View Templates have been transferred:" + "\n" + "\n" + info);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    using (Transaction t = new Transaction(m_doc, "Transfer View Templates"))
                    {
                        t.Start();
                        ElementTransformUtils.CopyElements(sourceDoc, templatesToCopy, m_doc, Transform.Identity, copyOpt);
                        t.Commit();
                    }
                    TaskDialog.Show("Information", "The following View Templates have been transferred:" + "\n" + "\n" + info);
                    DialogResult = DialogResult.OK;
                }
                
                //TaskDialog.Show("Information", "The following View Templates have been transferred:" + "\n" + "\n" + info);
                //DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClbTemplates.Items.Count; i++)
            {
                ClbTemplates.SetItemChecked(i, true);
            }
            LblCount.Text = ClbTemplates.CheckedItems.Count.ToString();
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClbTemplates.Items.Count; i++)
            {
                ClbTemplates.SetItemChecked(i, false);
            }
            LblCount.Text = ClbTemplates.CheckedItems.Count.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
