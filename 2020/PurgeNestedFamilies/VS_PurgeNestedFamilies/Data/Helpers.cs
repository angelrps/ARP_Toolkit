using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    class Helpers
    {
        public class MyFamilyLoadOptions : IFamilyLoadOptions
        {
            public bool OnFamilyFound (bool familyInUse, out bool overwriteParameterValues)
            {
                overwriteParameterValues = false;
                return true;
            }
            public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
            {
                source = FamilySource.Family;
                overwriteParameterValues = false;
                return true;
            }
        }

        public class MyFailureHandler : IFailuresPreprocessor
        {
            public FailureProcessingResult PreprocessFailures(FailuresAccessor failuresAccessor)
            {
                failuresAccessor.DeleteAllWarnings();
                return FailureProcessingResult.Continue;
            }
        }

    }
}
