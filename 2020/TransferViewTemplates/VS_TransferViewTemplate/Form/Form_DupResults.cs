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
    public partial class Form_DupResults : System.Windows.Forms.Form
    {
        public Form_DupResults()
        {
            InitializeComponent();
        }

        private void Form_DupResults_Load(object sender, EventArgs e)
        {
            LblResultsMain.Text = Form.Form_Main.resultHead;
            LblResults.Text = Form.Form_Main.resultMain;
            TbxResultMessage.Clear();
            foreach (string st in Form.Form_Main.resultBody)
            {
                TbxResultMessage.AppendText(st + Environment.NewLine);
            }        
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
