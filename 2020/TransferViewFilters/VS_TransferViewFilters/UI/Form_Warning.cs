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
    public partial class Form_Warning : System.Windows.Forms.Form
    {
        public static string warningHead;
        public static string warningMain;
        public static string warningFoot;
        public static List<string> warningList;

        public Form_Warning()
        {
            InitializeComponent();
        }

        private void Form_DupResults_Load(object sender, EventArgs e)
        {
            LblResultsHead.Text = warningHead;
            LblResultsMain.Text = warningMain;
            LblResultsFoot.Text = warningFoot;
            TbxResultMessage.Clear();
            foreach (string st in warningList)
            {
                TbxResultMessage.AppendText(st + Environment.NewLine);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
