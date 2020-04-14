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
        // USED dimension types ids
        public static List<ElementId> GetUsedDimTypes(Document doc)
        {
            List<ElementId> usedTypes = new List<ElementId>();
            IEnumerable<Dimension> dimCol = new FilteredElementCollector(doc)
                                                .OfClass(typeof(Dimension))
                                                //.Where(q => q.Name != "Linear Dimension Style")
                                                .Cast<Dimension>();

            List<Dimension> filteredList = dimCol.GroupBy(q => q.DimensionType.Id).Select(group => group.First()).ToList();
            foreach (Dimension dim in filteredList)
            {
                usedTypes.Add(dim.DimensionType.Id);
            }

            return usedTypes;
        }

        // UNUSED dimendion type ids
        public static List<ElementId> GetUnusedTypeIds(Document doc, List<ElementId> usedTypeIds)
        {
            List<ElementId> idList = new List<ElementId>();
            List<DimensionType> dimTypeCol = new FilteredElementCollector(doc)
                                                     .OfClass(typeof(DimensionType))
                                                     .Cast<DimensionType>()
                                                     .Where(q => q.ParametersMap.Size != 0)
                                                     .ToList();

            //dimTypeCol = dimTypeCol.OrderBy(x => x.Name).ToList();
            if (0 < usedTypeIds.Count)
            {
                foreach (DimensionType dt in dimTypeCol)
                {
                    if (!usedTypeIds.Contains(dt.Id))
                    {
                        idList.Add(dt.Id);
                    }
                }
            }
            else
            {
                foreach (DimensionType dt in dimTypeCol)
                {
                    idList.Add(dt.Id);
                }
            }
            return idList;
        }

    }
}
