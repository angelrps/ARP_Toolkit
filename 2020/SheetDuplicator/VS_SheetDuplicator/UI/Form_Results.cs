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
            LblResultsMain.Text = UI.Form_Main.resultHead;
            LblResults.Text = UI.Form_Main.resultMain;
            LblResultBody.Text = UI.Form_Main.resultBody;
        }
        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
