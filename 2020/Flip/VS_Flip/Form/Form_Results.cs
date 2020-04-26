using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form;

namespace UI.Info
    
{
    public partial class Form_Results : System.Windows.Forms.Form
    {

        public Form_Results()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {
            TbxResultMessage.Clear();

            LblResults.Text = Main_Form.elemSuccess.ToString() + " Elements have been flipped.";
            TbxResultMessage.AppendText(string.Format("Attempted to flip {0} elements.{1}{1}", Main_Form.elemTry.ToString(), Environment.NewLine));
            TbxResultMessage.AppendText(Main_Form.elemFail.ToString() + " Failures.");
        }
    }
}
