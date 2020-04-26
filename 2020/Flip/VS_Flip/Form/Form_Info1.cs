﻿using System;
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
    public partial class Form_Info1 : System.Windows.Forms.Form
    {
        public Form_Info1()
        {
            InitializeComponent();
            LblInfo1Main.Text = Entry.CmdMain.infoMsgMain;
            LblInfo1Body.Text = Entry.CmdMain.infoMsgBody;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
