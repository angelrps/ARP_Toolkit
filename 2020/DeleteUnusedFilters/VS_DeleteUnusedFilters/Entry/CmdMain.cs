using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using ArpUtilities;

namespace DeleteUnusedFilters
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("557AE539-1458-4548-982E-D657C48D9A2B"));

        public Autodesk.Revit.UI.Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            //first check if there are any filters in the document
            //if there are not, show a message and close the command
            if (!Helpers.GetUnusedFilterElem(doc).Any())
            {
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return Result.Cancelled;
                    }
                }
                return Result.Succeeded;
            }
            //if there are, open the form
            else
            {
                //using windows form
                using (ViewFiltersForm thisForm = new ViewFiltersForm(doc, app))
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
