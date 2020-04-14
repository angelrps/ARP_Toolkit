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
        public static List<View> GetViewTemplates(Document doc)
        {
            List<View> templatesList = new List<View>();

            foreach (View v in new FilteredElementCollector(doc).OfClass(typeof(View)))
            {
                if (v.ViewType == ViewType.CostReport) continue;
                if (v.ViewType == ViewType.DrawingSheet) continue;
                if (v.ViewType == ViewType.Internal) continue;
                if (v.ViewType == ViewType.Legend) continue;
                if (v.ViewType == ViewType.LoadsReport) continue;
                if (v.ViewType == ViewType.PresureLossReport) continue;
                if (v.ViewType == ViewType.Rendering) continue;
                if (v.ViewType == ViewType.Report) continue;
                if (v.ViewType == ViewType.Schedule) continue;
                if (v.ViewType == ViewType.SystemBrowser) continue;
                if (v.ViewType == ViewType.Undefined) continue;
                if (v.ViewType == ViewType.Walkthrough) continue;

                if (v != null)
                {
                    if (v.IsTemplate)
                    {
                        templatesList.Add(v);
                    }
                }
            }
            return templatesList;
        }

        public static List<View> GetViews(Document doc)
        {
            List<View> viewList = new List<View>();

            foreach (View v in new FilteredElementCollector(doc).OfClass(typeof(View)))
            {
                if (v.ViewType == ViewType.CostReport) continue;
                if (v.ViewType == ViewType.DrawingSheet) continue;
                if (v.ViewType == ViewType.Internal) continue;
                if (v.ViewType == ViewType.Legend) continue;
                if (v.ViewType == ViewType.LoadsReport) continue;
                if (v.ViewType == ViewType.PresureLossReport) continue;
                if (v.ViewType == ViewType.Rendering) continue;
                if (v.ViewType == ViewType.Report) continue;
                if (v.ViewType == ViewType.Schedule) continue;
                if (v.ViewType == ViewType.SystemBrowser) continue;
                if (v.ViewType == ViewType.Undefined) continue;
                if (v.ViewType == ViewType.Walkthrough) continue;

                if (v != null)
                {
                    if (!v.IsTemplate)
                    {
                        viewList.Add(v);
                    }
                }
            }
            return viewList;
        }

    }
}
