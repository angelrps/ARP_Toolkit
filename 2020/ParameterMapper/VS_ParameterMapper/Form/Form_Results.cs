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

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {
            // populate textbox with results
            TbxResultMessage.Clear();
            TbxResultMessage.AppendText("Attempted to update " + Form.Form_Main.elemTry + " elements." + Environment.NewLine + Environment.NewLine);
            TbxResultMessage.AppendText(Form.Form_Main.elemFail + " Failures." + Environment.NewLine + Environment.NewLine);
            TbxResultMessage.AppendText("Grouped elements are excluded from edition");
        }
    }
}
