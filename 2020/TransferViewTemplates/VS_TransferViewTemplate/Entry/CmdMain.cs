using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using System.Windows.Media.Imaging;
using System.IO;
using ArpUtilities;

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("B46318A3-8917-43EF-858E-AD98BAC1F74C"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // add event handler for when the app does not find the ArpUtilies.dll assembly
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            // is family document
            if (doc.IsFamilyDocument)
            {
                UI.Info.Form_Info1.infoMsgMain = "Wrong document";
                UI.Info.Form_Info1.infoMsgBody = "This is a family document.\nRun this tool in a project document.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }

            // are there other projects open?
            if (Data.Helpers.GetOpenDocuments(doc, app).Count() == 0)
            {
                UI.Info.Form_Info1.infoMsgMain = "Project not found";
                UI.Info.Form_Info1.infoMsgBody = "There are not other project documents open in this session.\nThis application will close.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }

            // open main form
            using (Form.Form_Main thisForm = new Form.Form_Main(doc, app))
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
            }
            //try
            //{
            //    Utilities.GetAnalyticsCSV(doc, app);
            //}
            //catch (Exception)
            //{
            //}
            return Result.Succeeded;
        }

        // event handle for when the ArpUtilities.dll assembly is missing. I will read it from the project resources
        //private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TransferViewTemplate.Resources.ArpUtilities.dll"))
        //    {
        //        byte[] assemblyData = new byte[stream.Length];
        //        stream.Read(assemblyData, 0, assemblyData.Length);
        //        return Assembly.Load(assemblyData);
        //    }
        //}
    }
}
