using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace UI.Info
{
    public partial class Form_Warning : System.Windows.Forms.Form
    {
        public static string warningMsgHead = "";
        public static string warningMsgMain = "";
        public static string warningMsgBody = "";

        public Form_Warning()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form_Warning_Load(object sender, EventArgs e)
        {
            LblWarningHead.Text = warningMsgHead;
            LblWarningMain.Text = warningMsgMain;
            LblWarningBody.Text = warningMsgBody;
        }
    }
}
