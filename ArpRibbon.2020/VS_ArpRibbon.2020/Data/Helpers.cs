using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Reflection;
using System.IO;
//using Microsoft.Office.Interop.Excel;

namespace Data
{
    class Helpers
    {
        public static bool IsExtendedToolsEntitled()
        {
            // get windows user name
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // declare return variable
            bool isUserEntitled = false;

            // create list of entitled users
            List<string> usersList = new List<string> { "VYA\\ars",
                                                        "VYA\\sm",
                                                        "VYA\\smf",
                                                        "VYA\\jac",
                                                        "VYA\\nm",
                                                        "VYA\\jfm",
                                                        "VYA\\th",
                                                        "VYA\\mr",
                                                      };

            // compare windows username with entitled users
            foreach (string s in usersList)
            {
                if (s == username)
                {
                    isUserEntitled = true;
                    return isUserEntitled;
                }
            }
            return isUserEntitled;
        }
    }

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdAbout : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            using (ArpRibbon.UI.Form_Help thisForm = new ArpRibbon.UI.Form_Help())
            {
                thisForm.ShowDialog();
            }
            return Result.Succeeded;
        }
    }
}
