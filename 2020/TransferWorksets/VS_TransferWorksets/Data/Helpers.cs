using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    class Helpers
    {
        public static List<Document> GetOpenDocuments(Document doc, Application app)
        {
            DocumentSet docset = app.Documents;
            List<Document> openDocs = new List<Document>();

            foreach (Document d in docset)
            {
                if (d.IsWorkshared == true)
                {
                    if (doc.Title != d.Title)
                    {
                        if (d.IsFamilyDocument == false)
                        {
                            openDocs.Add(d);
                        }
                    }
                }                
            }
            return openDocs;
        }

        public static List<string> GetWorksetNames(Document doc)
        {
            List<string> wNames = new List<string>();
            IEnumerable<Workset> worksetCol = new FilteredWorksetCollector(doc)
                                                    .Where(q => q.Kind == WorksetKind.UserWorkset);
            foreach (Workset ws in worksetCol)
            {
                wNames.Add(ws.Name);
            }
            return wNames;
        }

        public static List<string> GetUsedNames(Document CurrentDoc, List<string> SelectedWorksets)
        {
            List<string> usedNames = new List<string>();

            foreach (string s in SelectedWorksets)
            {
                if (!WorksetTable.IsWorksetNameUnique(CurrentDoc, s))
                {
                    usedNames.Add(s);
                }
            }
            return usedNames;
        }

    }
}
