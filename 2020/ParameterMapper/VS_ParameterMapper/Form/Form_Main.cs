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
            foreach (Category cat in GetCategories(m_doc))
            {
                CbxCategories.Items.Add(cat);
            }
            CbxCategories.Sorted = true;
            CbxCategories.DisplayMember = "Name";
            LblParamTypeSource.Text = "";
            LblParamTypeTarget.Text = "";
        }

        private void CbxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ClearComboBox(CbxSourceParameters);
            ClearComboBox(CbxTargetParameters);

            Category cat = CbxCategories.SelectedItem as Category;

            if (GetInstances(m_doc, cat).Count < 1)
            {
                using (UI.Info.Form_Info2 thisForm = new UI.Info.Form_Info2())
                {
                    thisForm.ShowDialog();
                }

                LblParamTypeSource.Text = "";
                LblParamTypeTarget.Text = "";
            }
            else
            {
                if (RbtSourceParam.Checked == true) // if source param radio button checked, load sourceParam combo box
                {
                    PopulateSourceComboBox(CbxSourceParameters, m_doc, cat);
                    SetTypeParameterLabel(LblParamTypeSource, CbxSourceParameters);
                    LblParamTypeTarget.Text = "";
                }
                else // if element id checked, load target text parameters
                {
                    try
                    {
                        PopulateTargetComboBoxTextParams(CbxTargetParameters, m_doc, cat);
                        LblParamTypeTarget.Text = ""; // reset label before re-set
                        SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (RbtElementId.Checked == true)
            {
                LblParamTypeSource.Text = "Element Id will always be transferred as Text"; // reset parameter type label
            }            
        }

        private void CbxSourceParameters_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ClearComboBox(CbxTargetParameters);
            Category cat = CbxCategories.SelectedItem as Category;

            try
            {
                PopulateTargetComboBox(CbxSourceParameters, CbxTargetParameters, m_doc, cat);                
            }
            catch (Exception)
            {
            }

            SetTypeParameterLabel(LblParamTypeSource, CbxSourceParameters);
            LblParamTypeTarget.Text = ""; // reset LblParamTypeTarget
            SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
        }

        private void RbtSourceParam_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxCategories.SelectedItem == null)
            {
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                }
                //TaskDialog tdError = new TaskDialog("Error")
                //{
                //    MainIcon = TaskDialogIcon.TaskDialogIconError,
                //    MainInstruction = "You need to select a Category first."
                //};
                //tdError.Show();
            }
            else
            {
                ClearComboBox(CbxTargetParameters);
                ClearComboBox(CbxSourceParameters);

                Category cat = CbxCategories.SelectedItem as Category;

                if (RbtElementId.Checked)
                {
                    LblParamTypeSource.Text = "Element Id will always be transferred as Text";
                    CbxSourceParameters.Enabled = false; // disable source parameter combo box

                    try
                    {
                        PopulateTargetComboBoxTextParams(CbxTargetParameters, m_doc, cat);
                        SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (RbtAsText.Checked)
                {
                    LblParamTypeSource.Text = "";
                    CbxSourceParameters.Enabled = true;

                    PopulateSourceComboBox(CbxSourceParameters, m_doc, cat);
                    SetTypeParameterLabel(LblParamTypeSource, CbxSourceParameters);

                    try
                    {
                        PopulateTargetComboBoxTextParams(CbxTargetParameters, m_doc, cat);
                        SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                    }
                    catch (Exception)
                    {
                    }
                }
                else // reload source parameters
                {   
                    LblParamTypeSource.Text = "";
                    CbxSourceParameters.Enabled = true;

                    PopulateSourceComboBox(CbxSourceParameters, m_doc, cat);
                    SetTypeParameterLabel(LblParamTypeSource, CbxSourceParameters);

                    try // reload target parameters
                    {
                        PopulateTargetComboBox(CbxSourceParameters, CbxTargetParameters, m_doc, cat);
                        SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                    }
                    catch (Exception)
                    {
                    }
                }                
            }            
        }

        private void RbtAsText_CheckedChanged(object sender, EventArgs e)
        {
            Category cat = CbxCategories.SelectedItem as Category;
            if (RbtAsText.Checked == true || RbtElementId.Checked == true)
            {
                ClearComboBox(CbxTargetParameters);

                try // reload target parameters
                {                   
                    PopulateTargetComboBoxTextParams(CbxTargetParameters, m_doc, cat);
                    LblParamTypeTarget.Text = "";
                    SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    PopulateTargetComboBox(CbxSourceParameters, CbxTargetParameters, m_doc, cat);
                    LblParamTypeTarget.Text = "";
                    SetTypeParameterLabel(LblParamTypeTarget, CbxTargetParameters);
                }
                catch (Exception)
                {
                }                
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // handle error if no data is selected
            if (CbxCategories.SelectedItem == null)
            {
                TaskDialog tdError = new TaskDialog("Error")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconError,
                    MainInstruction = "You need to select a Category first."
                };
                tdError.Show();
            }
            else
            {
                Category cat = CbxCategories.SelectedItem as Category;
                int elemTry = GetInstances(m_doc, cat).Count();
                int elemFail = 0;
                
                KeyValuePair<Parameter, string> targetKeyValuePair = (KeyValuePair<Parameter, string>)CbxTargetParameters.SelectedItem;
                
                Parameter targetParam = targetKeyValuePair.Key;

                using (TransactionGroup tg = new TransactionGroup(m_doc, "Parameter Mapper"))
                {
                    tg.Start();
                    // for each element of the selected category
                    foreach (Element elem in GetInstances(m_doc, cat))
                    {
                        using (Transaction t = new Transaction(m_doc, "Parameter Mapper Single Transaction"))
                        {
                            t.Start();
                            try
                            {                                
                                Parameter elemTargetParam = elem.get_Parameter(targetParam.Definition);

                                if (RbtElementId.Checked == true) // when Element Id is selected
                                {
                                    string eId = elem.Id.ToString();
                                    elemTargetParam.Set(eId);
                                    t.Commit();
                                }
                                else if (RbtSourceParam.Checked == true && RbtAsText.Checked == true) // when "Number As Text" is selected
                                {
                                    KeyValuePair<Parameter, string> sourceKeyValuePair = (KeyValuePair<Parameter, string>)CbxSourceParameters.SelectedItem;
                                    Parameter sourceParam = sourceKeyValuePair.Key;
                                    Parameter elemSourceParam = elem.get_Parameter(sourceParam.Definition);

                                    string sourceValueString = GetParamValueAsString(elemSourceParam);
                                    elemTargetParam.Set(sourceValueString);
                                    t.Commit();

                                }
                                else // when "Number As Number" is selected
                                {
                                    KeyValuePair<Parameter, string> sourceKeyValuePair = (KeyValuePair<Parameter, string>)CbxSourceParameters.SelectedItem;
                                    Parameter sourceParam = sourceKeyValuePair.Key;
                                    Parameter elemSourceParam = elem.get_Parameter(sourceParam.Definition);

                                    if (elemSourceParam.StorageType != StorageType.Double)
                                    {
                                        string sourceValueString = GetParamValueAsString(elemSourceParam);
                                        elemTargetParam.Set(sourceValueString);
                                        t.Commit();
                                    }
                                    else
                                    {
                                        if (RbtAsNumber.Checked == true)
                                        {
                                            double sourceValueDouble = elemSourceParam.AsDouble();
                                            elemTargetParam.Set(sourceValueDouble);
                                            t.Commit();
                                        }
                                        else
                                        {
                                            string sourceValueString = GetParamValueAsString(elemSourceParam);
                                            elemTargetParam.Set(sourceValueString);
                                            t.Commit();
                                        }
                                    }
                                }                                
                            }
                            catch (Exception)
                            {
                                elemFail += 1;
                            }
                        }
                    }
                    tg.Assimilate();
                }

                TaskDialog tdInfo = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconInformation,
                    MainInstruction = "Parameter values have been updated.",
                    MainContent = String.Format("Attempted to update {0} Elements.\n\n{1} Failures.\n\n(Grouped elements are excluded from edition)", elemTry.ToString(), elemFail),
                };

                TaskDialogResult tResult = tdInfo.Show();
                DialogResult = DialogResult.OK;
            }            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region HELPERS
        private void ClearComboBox (System.Windows.Forms.ComboBox cbx)
        {
            if (cbx.Items != null)
            {
                cbx.DataSource = null;
                cbx.Items.Clear();
            }
        }

        private void PopulateSourceComboBox(System.Windows.Forms.ComboBox cbx, Document doc, Category cat)
        {
            Dictionary<Parameter, string> sourceParamDict = new Dictionary<Parameter, string>();

            foreach (Parameter sourceP in GetSourceParameters(GetInstances(doc, cat)))
            {
                sourceParamDict.Add(sourceP, sourceP.Definition.Name);
            }
            cbx.Sorted = true;
            cbx.DataSource = new BindingSource(sourceParamDict, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";        
        }

        private void PopulateTargetComboBox(System.Windows.Forms.ComboBox SourceCbx, System.Windows.Forms.ComboBox TargetCbx, Document doc, Category cat)
        {
            Dictionary<Parameter, string> targetParamDict = new Dictionary<Parameter, string>();
            // the item taken from the CbxSourceParameters is a KeyValuePair
            KeyValuePair<Parameter, string> sourceKeyValuePair = (KeyValuePair<Parameter, string>)SourceCbx.SelectedItem;
            Parameter sourceP = sourceKeyValuePair.Key; // get parameter (key) from keyValuePair

            foreach (Parameter targetP in GetTargetParameters(doc, cat, sourceP))
            {
                targetParamDict.Add(targetP, targetP.Definition.Name);
            }
            TargetCbx.Sorted = true;
            TargetCbx.DataSource = new BindingSource(targetParamDict, null);
            TargetCbx.DisplayMember = "Value";
            TargetCbx.ValueMember = "Key";            
        }

        private void PopulateTargetComboBoxTextParams(System.Windows.Forms.ComboBox cbx, Document doc, Category cat)
        {
            Dictionary<Parameter, string> targetTextParamDict = new Dictionary<Parameter, string>();

            foreach (Parameter targetTextP in GetTargetTextParameters(doc, cat))
            {
                targetTextParamDict.Add(targetTextP, targetTextP.Definition.Name);
            }
            cbx.Sorted = true;
            cbx.DataSource = new BindingSource(targetTextParamDict, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
        }

        private void SetTypeParameterLabel (Label lbl, System.Windows.Forms.ComboBox cbx)
        {
            try
            {
                KeyValuePair<Parameter, string> KeyValuePair = (KeyValuePair<Parameter, string>)cbx.SelectedItem;
                Parameter selectedP = KeyValuePair.Key; // get parameter (key) from keyValuePair

                if (selectedP.Definition.ParameterType.ToString() == "Invalid")
                {
                    lbl.Text = "Text";
                }
                else if (selectedP.Definition.Name.ToString() == "")
                {
                    lbl.Text = "";
                }
                else
                {
                    lbl.Text = selectedP.Definition.ParameterType.ToString();
                }
            }
            catch (Exception)
            {
            }            
        }
        #endregion
    }
}
