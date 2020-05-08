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



        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/angelruizpeinado/");
        }

        private void linkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/angelrps/ARP_Toolkit");
        
        }

        private void linkLabel_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + "angelruizpeinado@gmail.com");
        }

        private void linkLabel_YouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCyTdvDYsex9jm1oQ4vyDUBA");
        }

        private void linkLabel_UserGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://angelruizpeinado.gitbook.io/arp-toolkit/");
        }

        //private void linkLabel_UserGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    string filename = "ARP Toolkit_Documentation.pdf";
        //    string filepath = @"D:\ANGEL\BIM\07-Macros and Plugins\ARP_Toolkit\z_Resources\ARP Toolkit Documentation\";
        //    string file = filepath + filename;
        //    System.IO.File.WriteAllBytes(file, global::ArpRibbon.Properties.Resources.ARP_Toolkit_Documentation);

        //    try
        //    {
        //        System.Diagnostics.Process.Start(file);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + "\n" + filename);
        //    }
        //}
    }
}
