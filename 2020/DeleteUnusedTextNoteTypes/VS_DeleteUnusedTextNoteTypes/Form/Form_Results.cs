using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeleteUnusedTextNoteTypes;

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
            if (!TextNotesForm.itemExceptList.Any())
            {
                LblResults.Text = string.Format("You have successfully deleted {0} Text Note Types: \r\n \r\n", TextNotesForm.nOfItems);
                TbxResultMessage.Clear();
                foreach (string item in TextNotesForm.infoList)
                {
                    TbxResultMessage.AppendText(item + Environment.NewLine);
                }
            }
            else
            {
                LblResults.Text = string.Format("You have successfully deleted {0} Text Note Type(s): \r\n \r\n", TextNotesForm.nOfItems);
                TbxResultMessage.Clear();
                foreach (string item in TextNotesForm.infoList)
                {
                    TbxResultMessage.AppendText(item + Environment.NewLine);
                }

                // append not purged items
                TbxResultMessage.AppendText("\r\nThe following item(s) could not be deleted: \r\n \r\n");
                foreach (string item in TextNotesForm.itemExceptList)
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
