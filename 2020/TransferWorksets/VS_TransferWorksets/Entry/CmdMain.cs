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

            // add event handler for when the app does not find the ArpUtilies.dll assembly
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            #region Is family document?
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
            #endregion

            // check if document is workshared
            if (!doc.IsWorkshared)
            {
                UI.Info.Form_Info1.infoMsgMain = "Worksharing?";
                UI.Info.Form_Info1.infoMsgBody = "This document is not workshared." + Environment.NewLine 
                                                + "Activate 'Collaborate' to enable collaboration and workset creation.";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }

            //check if open document are workshared
            if (!GetOpenDocuments(doc, app).Any())
            {
                UI.Info.Form_Info1.infoMsgMain = "Worksharing?";
                UI.Info.Form_Info1.infoMsgBody = "None of the other open documents in this session are Workshared." + Environment.NewLine
                                                + "This application will close.";
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
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TransferWorksets.Resources.ArpUtilities.dll"))
        //    {
        //        byte[] assemblyData = new byte[stream.Length];
        //        stream.Read(assemblyData, 0, assemblyData.Length);
        //        return Assembly.Load(assemblyData);
        //    }
        //}
    }
}
