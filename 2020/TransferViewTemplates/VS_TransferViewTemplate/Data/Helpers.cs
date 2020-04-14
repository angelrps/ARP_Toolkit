using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using System.Windows.Media.Imaging;
using System.IO;
using System.Reflection;

namespace Data
{
    class Helpers
    {
        public static List<Document> GetOpenDocuments(Document doc, Autodesk.Revit.ApplicationServices.Application app)
        {           
            DocumentSet docset = app.Documents;
            List<Document> openDocs = new List<Document>();
            foreach (Document d in docset)
            {
                if (doc.Title != d.Title)
                {
                    if (d.IsFamilyDocument == false)
                    {
                        openDocs.Add(d);
                    }                    
                }                
            }
            return openDocs;
        }

        public static List<View> GetViewTemplates(Document doc)
        {
            //List<View> viewList = new List<View>();
            List<View> viewCol = new FilteredElementCollector(doc).
                                OfClass(typeof(View)).
                                Cast<View>().
                                Where(q => q.IsTemplate).
                                ToList();
            return viewCol;
        }

        public static List<string> GetViewTemplateNames(Document doc)
        {
            List<string> viewNames = new List<string>();
            List<View> viewCol = new FilteredElementCollector(doc).
                                OfClass(typeof(View)).
                                Cast<View>().
                                Where(q => q.IsTemplate).
                                ToList();
            foreach (View v in viewCol)
            {
                viewNames.Add(v.Name);
            }
            return viewNames;
        }

    }
}
