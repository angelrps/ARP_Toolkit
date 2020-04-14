using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;
using System.Reflection;

namespace DeleteUnusedFilters
{
    class Helpers
    {
        //method to get Used Filters Ids
        public static List<ElementId> GetUsedFiltersIds(Document doc)
        {
            FilteredElementCollector usedFilters = new FilteredElementCollector(doc).OfClass(typeof(View));
            List<ElementId> usedFilterIds = new List<ElementId>();

            foreach (View v in usedFilters)
            {
                try
                {
                    foreach (ElementId eId in v.GetFilters())
                    {
                        //add filter Ids to the ussedFilterIds list
                        usedFilterIds.Add(eId);
                    }
                }
                catch (Autodesk.Revit.Exceptions.InvalidOperationException)
                {
                    continue;
                }
            }
            return usedFilterIds;
        }

        //method to get Unused Parameter Filter Elements
        public static List<ParameterFilterElement> GetUnusedFilterElem (Document doc)
        {
            List<ParameterFilterElement> unusedFilterElem = new List<ParameterFilterElement>();
            FilteredElementCollector col = new FilteredElementCollector(doc);
            List<ElementId> usedfilterIds = GetUsedFiltersIds(doc);

            //si EXISTEN USED filters
            if (usedfilterIds.Any())
            {
                FilteredElementCollector unusedlFilters = col.OfClass(typeof(ParameterFilterElement)).Excluding(usedfilterIds);
                foreach (ParameterFilterElement e in unusedlFilters)
                {
                    unusedFilterElem.Add(e);
                }
            }
            // si NO EXISTEN USED filters
            if ((!usedfilterIds.Any()))
            {
                FilteredElementCollector unusedlFilters = col.OfClass(typeof(ParameterFilterElement));
                foreach (ParameterFilterElement e in unusedlFilters)
                {
                    unusedFilterElem.Add(e);
                }
                // si EXISTE ALGÚN FILTRO NO USADO
                if (unusedFilterElem.Any())
                {
                    return unusedFilterElem;
                }
                else
                {
                }
            }

            return unusedFilterElem;
        }

    }
}
