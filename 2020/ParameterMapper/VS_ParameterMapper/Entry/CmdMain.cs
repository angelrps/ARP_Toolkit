﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
//using ArpUtilities;
using System.Reflection;

namespace Entry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class CmdMain : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("BB530605-A179-43F9-B85B-52FF4A41B5D5"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // add event handler for when the app does not find the ArpUtilies.dll assembly
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);


            #region check if it is family document
            if (doc.IsFamilyDocument)
            {
                using (UI.Form_FamDoc thisForm = new UI.Form_FamDoc())
                {
                    thisForm.ShowDialog();
                    return Result.Cancelled;
                }
            }
            #endregion

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
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ParameterMapper.Resources.ArpUtilities.dll"))
        //    {
        //        byte[] assemblyData = new byte[stream.Length];
        //        stream.Read(assemblyData, 0, assemblyData.Length);
        //        return Assembly.Load(assemblyData);
        //    }
        //}
    }
}
