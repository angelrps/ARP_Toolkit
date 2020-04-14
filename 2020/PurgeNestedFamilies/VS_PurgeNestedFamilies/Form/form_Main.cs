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

namespace PurgeNestedFamilies
{
    public partial class form_Main : System.Windows.Forms.Form
    {
        public Document m_doc;
        public Autodesk.Revit.ApplicationServices.Application m_app;

        public form_Main(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {
            InitializeComponent();
            m_doc = doc;
            m_app = app;
        }

        private void form_Main_Load(object sender, EventArgs e)
        {

        }


        #region UTILITIES
        private void LoadFamilyTree()
        {

        }

        private void GetFamDict(Document m_doc, List<Family> editableFamilies)
        {
            List<int> catToPurge = Data.Helpers.CategoriesToPurge();            

            // get editable families
            foreach (Family fam in editableFamilies)
            {
                // get purgable Element Types
                Document famdoc = m_doc.EditFamily(fam);
                List<ElementType> PurgableNestedTypes = Data.Helpers.GetPurgableNestedTypes(famdoc, catToPurge);

                // get purgable Families

            }

        }
        #endregion
    }
}
