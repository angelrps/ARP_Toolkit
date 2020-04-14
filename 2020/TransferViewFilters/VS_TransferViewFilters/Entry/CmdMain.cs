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

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("C7F1BA3C-6D68-4BCE-A113-45BE1E333F0B"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            #region Is Family Document?
            if (doc.IsFamilyDocument)
            {
                TaskDialog tdActView = new TaskDialog("Information")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "This is a family document.\nRun this tool in a project document.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdActView.Show();
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
