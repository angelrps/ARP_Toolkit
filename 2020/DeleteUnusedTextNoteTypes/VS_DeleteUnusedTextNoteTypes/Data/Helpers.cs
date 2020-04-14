using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;
using System.Reflection;

namespace DeleteUnusedTextNoteTypes
{
    class Helpers
    {
        #region Used text note types
        public static List<ElementId> GetUsedTextNoteTypes (Document doc)
        {
            List<ElementId> usedTextNoteTypeIds = new List<ElementId>();

            FilteredElementCollector TextNoteCollector = new FilteredElementCollector(doc).OfClass(typeof(TextNote));

            foreach (TextNote tn in TextNoteCollector)
            {
                usedTextNoteTypeIds.Add(tn.TextNoteType.Id);
            }

            // sort list by Name
            usedTextNoteTypeIds = usedTextNoteTypeIds.OrderBy(i => doc.GetElement(i).Name).ToList();

            return usedTextNoteTypeIds;
        }
        #endregion

        #region Names of used text note types, removing duplicates
        public static List<string> GetUsedTextNoteNames(Document doc)
        {
            List<string> usedTextNoteNames = new List<string>();

            foreach (ElementId eId in Helpers.GetUsedTextNoteTypes(doc))
            {
                usedTextNoteNames.Add(doc.GetElement(eId).Name);
            }
            usedTextNoteNames = usedTextNoteNames.Distinct().ToList();

            return usedTextNoteNames;
        }
        #endregion

        #region Unused text note types
        public static ICollection<ElementId> GetUnusedTextNoteTypes (Document doc)
        {
            FilteredElementCollector unusedTypeCollector = new FilteredElementCollector(doc)
                .OfClass(typeof(TextNoteType));

            // if there are USED Text Notes exclude the from the collector
            if (0 < Helpers.GetUsedTextNoteTypes(doc).Count)
            {
                unusedTypeCollector.Excluding(Helpers.GetUsedTextNoteTypes(doc));
                // sort list by Name
                List<ElementId> sortedlist = unusedTypeCollector.ToElementIds().ToList();
                sortedlist = sortedlist.OrderBy(i => doc.GetElement(i).Name).ToList();

                return sortedlist;
            }

            // otherwise return the whole list from the collector
            else
            {
                List<ElementId> sortedlist = unusedTypeCollector.ToElementIds().ToList();
                sortedlist = sortedlist.OrderBy(i => doc.GetElement(i).Name).ToList();

                return sortedlist;
                //return unusedTypeCollector.ToElementIds();
            }
        }
        #endregion
    }
}
