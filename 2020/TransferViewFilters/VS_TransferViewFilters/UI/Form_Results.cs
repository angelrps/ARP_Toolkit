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
        public static string resultHead;
        public static string resultMain1;
        public static string resultMain2;
        public static List<string> resultList1;
        public static List<string> resultList2;
        
        public Form_Results()
        {
            InitializeComponent();
        }       

        private void Form_Results_Load(object sender, EventArgs e)
        {
            LblResultsHead.Text = resultHead;
            LblResultsMain1.Text = resultMain1;
            LblResultsMain2.Text = resultMain2;
            TbxResultMsg1.Clear();
            TbxResultMsg2.Clear();
            if (!resultList1.Any())
            {
                TbxResultMsg1.AppendText("None");
            }
            else
            {
                foreach (string st in resultList1)
                {
                    TbxResultMsg1.AppendText(st + Environment.NewLine);
                }                
            }
            if (!resultList2.Any())
            {
                TbxResultMsg2.AppendText("None");
            }
            else
            {
                foreach (string st in resultList2)
                {
                    TbxResultMsg2.AppendText(st + Environment.NewLine);
                }
            }         
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
