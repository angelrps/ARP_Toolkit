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
        public static List<ViewSheet> GetViewSheets(Document doc)
        {
            List<ViewSheet> viewSheets = new FilteredElementCollector(doc).
                                        OfClass(typeof(ViewSheet)).
                                        Cast<ViewSheet>().
                                        Where(i => i.IsPlaceholder == false).
                                        ToList();
            return viewSheets;
        }
        
        public static Dictionary<ViewSheet, string> GetViewSheetDict(Document doc)
        {
            Dictionary<ViewSheet, string> viewSheetDict = new Dictionary<ViewSheet, string>();
            List<ViewSheet> viewSheetCol = new FilteredElementCollector(doc).
                                        OfClass(typeof(ViewSheet)).
                                        Cast<ViewSheet>().
                                        Where(i => i.IsPlaceholder == false).
                                        ToList();

            foreach (ViewSheet vs in viewSheetCol)
            {
                viewSheetDict.Add(vs, vs.Name);
            }
            return viewSheetDict;
        }

        public static Dictionary<ViewSheet, string> GetFilteredViewSheetDict(Document doc, String st)
        {
            Dictionary<ViewSheet, string> viewSheetDict = new Dictionary<ViewSheet, string>();
            List<ViewSheet> viewSheetCol = new FilteredElementCollector(doc)
                                        .OfClass(typeof(ViewSheet))
                                        .Cast<ViewSheet>()
                                        .Where(i => i.IsPlaceholder == false)
                                        .ToList();

            foreach (ViewSheet vs in viewSheetCol)
            {
                if (vs.SheetNumber.ToUpper().Contains(st.ToUpper()) || vs.Name.ToUpper().Contains(st.ToUpper()))
                {
                    viewSheetDict.Add(vs, vs.Name);
                }
            }
            return viewSheetDict;
        }

        public static List<ViewSheet> GetSelectedSheets(List<ViewSheet> allSheets, List<string> selSheetNumber)
        {
            List<ViewSheet> selectedSheets = new List<ViewSheet>();

            foreach (ViewSheet vs in allSheets)
            {
                string vsNumber = vs.SheetNumber;
                if (selSheetNumber.Contains(vsNumber))
                {
                    selectedSheets.Add(vs);
                }
            }
            return selectedSheets;
        }

    }
}
