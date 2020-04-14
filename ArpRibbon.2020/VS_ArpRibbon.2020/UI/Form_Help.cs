using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArpRibbon.UI
{
    public partial class Form_Help : Form
    {
        public Form_Help()
        {
            InitializeComponent();
            LblVersion.Text = "v" + Entry.AppMain.AssemblyVersion;
        }

        private void BtnUserGuide_Click(object sender, EventArgs e)
        {
            string filename = "ARP Tools_Documentation.pdf";
            string filepath = @"\\vaa-data01\00 SOFTWARE\PLUGIN REVIT";
            try
            {
                System.Diagnostics.Process.Start(Path.Combine(filepath, filename));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n" + filename);
            }            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
