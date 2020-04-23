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
            LblResults.Text = Data.Helpers.countSuccess.ToString() + " new " + Data.Helpers.instanceOrType + " Parameters Loaded:";
            // populate textbox with results            
            foreach (string st in Data.Helpers.namesSuccess)
            {
                TbxResultMessage.AppendText(st + Environment.NewLine);
            }
            // populate fail parameters
            if (Data.Helpers.failNamesList.Any())
            {
                TbxResultMessage.AppendText(Environment.NewLine + "Failed to load these parameters:" + Environment.NewLine + Environment.NewLine);
                foreach (string st in Data.Helpers.failNamesList)
                {
                    TbxResultMessage.AppendText(st + Environment.NewLine);
                }
            }            
        }
    }
}
