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
using System.Reflection;


namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static readonly AddInId appId = new AddInId(new Guid("7B55D2BE-4A5E-4656-958A-CE89D1736D0C"));

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

        // event handle for when the ArpUtilities.dll assembly is missing. I will read it from the project resources
        //private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AssignViewTemplates.Resources.ArpUtilities.dll"))
        //    {
        //        byte[] assemblyData = new byte[stream.Length];
        //        stream.Read(assemblyData, 0, assemblyData.Length);
        //        return Assembly.Load(assemblyData);
        //    }
        //}
    }
}
