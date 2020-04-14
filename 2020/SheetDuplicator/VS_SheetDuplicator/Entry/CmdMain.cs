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
using ArpUtilities;


namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("C0F245BC-69A7-4662-9EB1-739170E4AC0E"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            #region Is family document?
            if (doc.IsFamilyDocument)
            {
                TaskDialog tdFamily = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "This is a family document.\nRun this tool in a project document.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdFamily.Show();
                return Result.Cancelled;
            }
            #endregion

            using (UI.Form_Main thisForm = new UI.Form_Main(doc, app))
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
