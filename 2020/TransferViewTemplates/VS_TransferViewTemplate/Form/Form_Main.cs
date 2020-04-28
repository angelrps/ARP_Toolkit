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

        public static List<string> resultBody = new List<string>();
        public static string resultHead = "";
        public static string resultMain = "";

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
            CopyPasteOptions copyOpt = new CopyPasteOptions();
            Document sourceDoc = CbxOpenDocs.SelectedItem as Document;
            List<ElementId> templatesToCopy = new List<ElementId>();
            List<string> duplicatedNames = new List<string>();
            List<string> transferredViews = new List<string>();

            // is there at least one item selected?
            if (ClbTemplates.CheckedItems.Count == 0)
            {
                UI.Info.Form_Info1.infoMsgMain = "Select";
                UI.Info.Form_Info1.infoMsgBody = "Select one or more View Templates to continue.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }
            }
            
            // proceed to transfer
            try
            {
                foreach (Autodesk.Revit.DB.View v in ClbTemplates.CheckedItems)
                {
                    templatesToCopy.Add(v.Id);
                    transferredViews.Add(v.Name);

                    // get duplicated names
                    if (GetViewTemplateNames(m_doc).Contains(v.Name))
                    {
                        duplicatedNames.Add(v.Name);
                    }
                }
                // show message if there are duplicated names
                if (duplicatedNames.Any())
                {
                    resultHead = "Information";
                    resultMain = "The following templates already exist or have the same name:";
                    resultBody = duplicatedNames;
                    // show message if there are duplicates
                    using (UI.Info.Form_DupResults thisForm = new UI.Info.Form_DupResults())
                    {
                        thisForm.ShowDialog();

                        // transfer view templates y pressed 'Yes'
                        if (thisForm.DialogResult == DialogResult.Yes)
                        {
                            using (Transaction t = new Transaction(m_doc, "Transfer View Templates"))
                            {
                                t.Start();
                                ElementTransformUtils.CopyElements(sourceDoc, templatesToCopy, m_doc, Transform.Identity, copyOpt);
                                t.Commit();
                            }
                            // show Results Form
                            resultHead = "Result";
                            resultMain = "The following View Templates have been transferred:";
                            resultBody = transferredViews;
                            using (UI.Info.Form_Results ResultForm = new UI.Info.Form_Results())
                            {
                                ResultForm.ShowDialog();
                            }
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
                // go ahead if no duplicates
                else
                {
                    using (Transaction t = new Transaction(m_doc, "Transfer View Templates"))
                    {
                        t.Start();
                        ElementTransformUtils.CopyElements(sourceDoc, templatesToCopy, m_doc, Transform.Identity, copyOpt);
                        t.Commit();
                    }
                    // show Results Form
                    resultHead = "Result";
                    resultMain = "The following View Templates have been transferred:";
                    resultBody = transferredViews;
                    using (UI.Info.Form_Results ResultForm = new UI.Info.Form_Results())
                    {
                        ResultForm.ShowDialog();
                    }
                    DialogResult = DialogResult.OK;
                }
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
