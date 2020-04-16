using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
//test//
namespace DeleteUnusedTextNoteTypes
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("72214AC1-046F-4176-A8EB-A31E0CEFF864"));

        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // check if there are unused text note types and show a message if there aren´t
            if (!Helpers.GetUnusedTextNoteTypes(doc).Any())
            {
                TaskDialog.Show("Message", "There are not unused text note types in this document.");

                return Result.Succeeded;
            }

            // else, open up windows form
            else
            {
                using (TextNotesForm thisForm = new TextNotesForm(doc, app))
                {
                    thisForm.ShowDialog();
                    if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return Result.Cancelled;
                    }
                }

                return Result.Succeeded;
            }
        }
    }
}
