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
    public partial class Form_Results : Form
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
            
            // populate textbox with results            
            foreach (string st in UI.Form_Main.createdWorksets)
            {
                TbxResultMessage.AppendText(st + Environment.NewLine);
            }          
        }
    }
}
