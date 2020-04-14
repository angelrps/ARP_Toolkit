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
    using static Data.Helpers;

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("F200732D-3047-4C17-BDE2-42551B12E864"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // check if is family document
            if (doc.IsFamilyDocument)
            {
                TaskDialog tdFam = new TaskDialog("Information")
                {
                    MainInstruction = "This is a family document.\nRun this tool in a project document.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdFam.Show();
                return Result.Cancelled;
            }

            // check if document is workshared
            if (!doc.IsWorkshared)
            {
                TaskDialog tdWorkshared = new TaskDialog("Information")
                {
                    MainInstruction = "This document is not workshared. Activate 'Collaborate' to enable collaboration and workset creation.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdWorksharedInfoResult = tdWorkshared.Show();
                return Result.Cancelled;
            }

            //check if open document are workshared
            if (!GetOpenDocuments(doc, app).Any())
            {
                TaskDialog tdOpenDoc = new TaskDialog("Information")
                {
                    MainInstruction = "None of the other open documents in this session are Workshared."
                                        + "\n" + "This application will be closed.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdWorksharedInfoResult = tdOpenDoc.Show();
                return Result.Cancelled;
            }

            using (UI.Form_Main thisForm = new UI.Form_Main(doc, app))
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
            }
            try
            {
                Utilities.GetAnalyticsCSV(doc, app);
            }
            catch (Exception)
            {
            }
            return Result.Succeeded;
        }
    }
}
