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
            // populate textbox with results
            if (!Form_Main.itemExceptList.Any())
            {
                LblResults.Text = string.Format("You have successfully deleted {0} Dimension Style(s): \r\n \r\n", Form_Main.nOfItems);
                TbxResultMessage.Clear();
                foreach (string item in Form_Main.infoList)
                {
                    TbxResultMessage.AppendText(item + Environment.NewLine);
                }
            }
            else
            {
                LblResults.Text = string.Format("You have successfully deleted {0} Dimension Style(s): \r\n \r\n", Form_Main.nOfItems);
                TbxResultMessage.Clear();
                foreach (string item in Form_Main.infoList)
                {
                    TbxResultMessage.AppendText(item + Environment.NewLine);
                }

                // append not purged items
                TbxResultMessage.AppendText("\r\nThe following item(s) could not be deleted: \r\n \r\n");
                foreach (string item in Form_Main.itemExceptList)
                {
                    TbxResultMessage.AppendText(item + Environment.NewLine);
                }
            }
            
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
