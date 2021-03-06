﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using static Data.Helpers;
using Autodesk.Revit.ApplicationServices;
//using ArpUtilities;


namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("B0AD89BE-1F6A-44ED-BDE2-5EA79130AAB2"));

        public static string infoMsgMain = "";
        public static string infoMsgBody = "";

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            // add event handler for when the app does not find the ArpUtilies.dll assembly
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            if (!GetSelectedDoors(uidoc).Any() && !GetSelectedWalls(uidoc).Any())
            {
                infoMsgMain = "Select";
                infoMsgBody = "You need to select walls or doors before executing the application";
                using (UI.Info.Form_Info1 thisForm = new UI.Info.Form_Info1()) { thisForm.ShowDialog(); }

                return Result.Cancelled;
            }

            using (Form.Main_Form thisForm = new Form.Main_Form(doc, uidoc, app))
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
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Flip.Resources.ArpUtilities.dll"))
        //    {
        //        byte[] assemblyData = new byte[stream.Length];
        //        stream.Read(assemblyData, 0, assemblyData.Length);
        //        return Assembly.Load(assemblyData);
        //    }
        //}
    }
}
