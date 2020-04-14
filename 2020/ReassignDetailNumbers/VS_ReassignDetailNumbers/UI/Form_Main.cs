using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace UI
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;

        public Form_Main(Document doc)
        {
            InitializeComponent();
            m_doc = doc;
        }
    }
}
