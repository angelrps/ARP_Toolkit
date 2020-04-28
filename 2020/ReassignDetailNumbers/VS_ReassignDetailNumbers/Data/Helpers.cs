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
using System.Text.RegularExpressions;

namespace Data
{
    class Helpers
    {
        // collect viewports on sheet
        public static List<Element> GetAllViewport(Document doc, ViewSheet viewSheet)
        {
            List<Element> vList = new List<Element>();

            foreach (ElementId vId in viewSheet.GetAllViewports())
            {
                // legend views viewports don´t have detail number so don´t include in the list
                Viewport vp = doc.GetElement(vId) as Viewport;
                View v = doc.GetElement(vp.ViewId) as View;
                if (v.ViewType != ViewType.Legend)
                {
                    vList.Add(doc.GetElement(vId));
                }                
            }
            return vList;
        }

        public static Dictionary<string, Element> GetAllViewports_DICT (List<Element> viewports)
        {
            Dictionary<string, Element> vDict = new Dictionary<string, Element>();

            foreach (Element e in viewports)
            {
                string detNumParam = e.get_Parameter(BuiltInParameter.VIEWPORT_DETAIL_NUMBER).AsString();
                if (detNumParam != null)
                {
                    try
                    {
                        vDict.Add(detNumParam, e);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
            return vDict;
        }

        // find max detail number value of viewports
        public static int MaxDetailNumber (List<Element> viewports)
        {
            Dictionary<string, Element> vDict = GetAllViewports_DICT(viewports);

            string[] detNumsArray;
            List<int> detNumsIntegers = new List<int>();
            int maxNumber;

            foreach (string st in vDict.Keys)
            {
                detNumsArray = Regex.Split(st, @"\D+"); // get numbers contained within the string
                string jointNum = string.Join("", detNumsArray); // join them in a single string
                if (jointNum.Count() != 0)
                {
                    detNumsIntegers.Add(System.Convert.ToInt32(jointNum)); // convert string to int and add to the list
                }
            }
            // handle exception for when all viewports numbers are letters
            if (detNumsIntegers.Count() > 0)
            {
                maxNumber = detNumsIntegers.Max();
            }
            else
            {
                maxNumber = vDict.Keys.Count() + 1;
            }

            return maxNumber;
        }
        
        public class ViewportSelectionFilter : Autodesk.Revit.UI.Selection.ISelectionFilter
        {
            public bool AllowElement(Element elem)
            {
                if (elem.Category.Name == "Viewports")
                return true;
                return false;
            }
            public bool AllowReference(Reference reference, XYZ position)
            {
                return true;
            }
        }
    }
}
