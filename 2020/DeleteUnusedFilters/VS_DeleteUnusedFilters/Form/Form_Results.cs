using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeleteUnusedFilters;

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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form_Results_Load(object sender, EventArgs e)
        {
            TbxResultMessage.Text = string.Format("You have successfully deleted {0} filters: \r\n \r\n", ViewFiltersForm.nOfFilters);
            //AppendTextBoxLine(TbxResultMessage, ViewFiltersForm.info);
            foreach (string item in ViewFiltersForm.listInfo)
            {
                TbxResultMessage.AppendText(item + Environment.NewLine);
            }

            //TbxResultMessage.Text = ViewFiltersForm.info;
        }

        public void AppendTextBoxLine(TextBox source, string myStr)
        {
            if (source.Text.Length > 0)
            {
                source.AppendText(Environment.NewLine);
            }
            source.AppendText(myStr);
        }
    }
}
