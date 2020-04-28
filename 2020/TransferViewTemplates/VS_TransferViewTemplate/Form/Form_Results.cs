using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Info
{
    public partial class Form_Results : System.Windows.Forms.Form
    {
        public Form_Results()
        {
            InitializeComponent();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {
            LblResultsMain.Text = Form.Form_Main.resultHead;
            LblResults.Text = Form.Form_Main.resultMain;
            TbxResultMessage.Clear();
            foreach (string st in Form.Form_Main.resultBody)
            {
                TbxResultMessage.AppendText(st + Environment.NewLine);
            }        
        }

        private void BtnYes_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
