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
using System.Diagnostics;

namespace Entry
{
    public class AppMain : IExternalApplication
    {
        private const string ArpTabName = "ARP Tools"; //tab name is a constant so it can never be changed
        //private string _path; //declare assembly path
        public static string AssemblyPath { get; private set; }

        public static string AssemblyVersion { get; private set; } // declare assembly version property

        public Result OnStartup (UIControlledApplication application)
        {
            AssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //get ribbon assembly directory.
            AssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            #region Import CAD message
            UIControlledApplication uicontrolapp = application;
            RevitCommandId importCommandId = RevitCommandId.LookupCommandId("ID_FILE_IMPORT");
            try
            {
                AddInCommandBinding importBinding = uicontrolapp.CreateAddInCommandBinding(importCommandId);
                importBinding.BeforeExecuted += new EventHandler<Autodesk.Revit.UI.Events.BeforeExecutedEventArgs>(ImportReplacement);
            }
            catch (Exception)
            {
                throw;
            }
            #endregion

            #region InPlace component message
            RevitCommandId inplaceCommandId = RevitCommandId.LookupCommandId("ID_INPLACE_COMPONENT");
            try
            {
                AddInCommandBinding inplaceBinding = uicontrolapp.CreateAddInCommandBinding(inplaceCommandId);
                inplaceBinding.BeforeExecuted += new EventHandler<Autodesk.Revit.UI.Events.BeforeExecutedEventArgs>(InplaceReplacement);
            }
            catch (Exception)
            {
                throw;
            }
            #endregion

            #region Create Ribbon tab
            application.CreateRibbonTab(ArpTabName);
            #endregion

            #region Create Panels
            //create ribbon panels
            RibbonPanel modelManagementPanel = application.CreateRibbonPanel(ArpTabName, "Model Management");
            RibbonPanel drawingsPanel = application.CreateRibbonPanel(ArpTabName, "Drawings");
            RibbonPanel printPanel = application.CreateRibbonPanel(ArpTabName, "Print");
            RibbonPanel helpPanel = application.CreateRibbonPanel(ArpTabName, "ARP Tools v" + AssemblyVersion);
            #endregion

            #region Create Buttons            
            // uncomment the if block below if restrict button load to specific users
            //load the following buttons ONLY or entitled users            
            //if (Data.Helpers.IsExtendedToolsEntitled())
            //{
                # region Delete Unused Filters Button
                // create data needed for the button
                PushButtonData deleteFiltersButtonData = new PushButtonData(
                    "cmdDeleteFilters",                                    // unique name/id for the new button
                    "Purge" + "\n" + "Filters",                            // text that will be displayed under the button
                    Path.Combine(AssemblyPath, "DeleteUnusedFilters.dll"),        // dll location that will run where the button is pushed
                    "DeleteUnusedFilters.CmdMain");                        // namespace and method that will be called

                // data is added to the button and then to the panel
                PushButton deleteFiltersButton = modelManagementPanel.AddItem(deleteFiltersButtonData) as PushButton;

                // tooltip message that will be displayed when the users hover over the button
                deleteFiltersButton.ToolTip = "Removed unused view filters from the project.";

                // bitmap image for the button
                BitmapImage deleteFiltersLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/DeleteUnusedFiltersIcon_32.ico"));
                deleteFiltersButton.LargeImage = deleteFiltersLargeImage;
                #endregion

                #region Delete Unused Text Note Button
                PushButtonData deleteTextButtonData = new PushButtonData(
                    "cmdPurgeText",
                    "Purge" + "\n" + "Text",
                    Path.Combine(AssemblyPath, "DeleteUnusedTextNoteTypes.dll"),
                    "DeleteUnusedTextNoteTypes.CmdMain");

                PushButton deleteTextButton = modelManagementPanel.AddItem(deleteTextButtonData) as PushButton;

                deleteTextButton.ToolTip = "Removes unused Text Note Types from the project.";

                BitmapImage deleteTextLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/DeleteUnusedTextNoteTypesIcon_32.ico"));
                deleteTextButton.LargeImage = deleteTextLargeImage;
                #endregion

                #region Purge Dimension Styles Button
                PushButtonData purgeDimStylesButtonData = new PushButtonData(
                    "cmdPurgeDimStyles",
                    "Purge" + "\n" + "Dim Styles",
                    Path.Combine(AssemblyPath, "PurgeDimStyles.dll"),
                    "Entry.CmdMain");

                PushButton purgeDimStylesButton = modelManagementPanel.AddItem(purgeDimStylesButtonData) as PushButton;

                purgeDimStylesButton.ToolTip = "Removes unused Dimension Styles from the project.";

                BitmapImage purgeDimStylesLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/PurgeDimStyles_32.ico"));
                purgeDimStylesButton.LargeImage = purgeDimStylesLargeImage;
                #endregion

                #region Remove Empty Elevation Tags
                PushButtonData elevationTagsButtonData = new PushButtonData(
                    "cmdElevationTags",
                    "Remove Empty" + "\n" + "Elevation Tags",
                    Path.Combine(AssemblyPath, "RemoveEmptyElevationTags.dll"),
                    "Entry.CmdMain");

                PushButton elevationTagsButton = modelManagementPanel.AddItem(elevationTagsButtonData) as PushButton;

                elevationTagsButton.ToolTip = "Generally if all elevations hosted in an elevation tag are deleted from the model, " + "\n"
                                                + "the empty elevation tag still remains in its location. This application will delete " + "\n"
                                                +"all empty elevation tags from the model.";

                BitmapImage elevationTagsLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/RemoveEmptyElevationTags_32.ico"));
                elevationTagsButton.LargeImage = elevationTagsLargeImage;
                #endregion

                #region Purge Nested Families Button
                PushButtonData purgeNestedFamButtonData = new PushButtonData(
                    "cmdPurgeNestedFam",
                    "Purge" + "\n" + "Nested Families",
                    Path.Combine(AssemblyPath, "PurgeNestedFamilies.dll"),
                    "Entry.CmdMain");

                PushButton purgeNestedFamButton = modelManagementPanel.AddItem(purgeNestedFamButtonData) as PushButton;

                purgeNestedFamButton.ToolTip = "Use this tool to purge nested families from your project families." + "\n"
                                                + "It currently purges up to one level of nesting, and only model categories (not annotation categories).";

                BitmapImage purgeNestedFamLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/PurgeNestedFamilies_32.ico"));
                purgeNestedFamButton.LargeImage = purgeNestedFamLargeImage;
                #endregion

                #region Parameter Mapper Button
                PushButtonData paramMapperButtonData = new PushButtonData(
                    "cmdParamMapper",
                    "Parameter" + "\n" + "Mapper",
                    Path.Combine(AssemblyPath, "ParameterMapper.dll"),
                    "Entry.CmdMain");

                PushButton paramMapperButton = modelManagementPanel.AddItem(paramMapperButtonData) as PushButton;

                paramMapperButton.ToolTip = "Copy values from one parameter to another by selecting Category and Source Parameter." + "\n"
                                                + "Grouped elements are excluded from edition.";

                BitmapImage paramMapperLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/ParameterMapper_32.ico"));
                paramMapperButton.LargeImage = paramMapperLargeImage;
                #endregion

                #region Parameter Loader Button
                PushButtonData ParameterLoaderButtonData = new PushButtonData(
                    "cmdParameterLoader",
                    "Parameter" + "\n" + "Loader",
                    Path.Combine(AssemblyPath, "ParameterLoader.dll"),
                    "Entry.CmdMain");

                PushButton ParameterLoaderButton = modelManagementPanel.AddItem(ParameterLoaderButtonData) as PushButton;

                ParameterLoaderButton.ToolTip = "Load Shared Parameters in batch." + "\n"
                                                + "It can be used in both Project and Family environment.";

                BitmapImage ParameterLoaderLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/ParameterLoader_32.ico"));
                ParameterLoaderButton.LargeImage = ParameterLoaderLargeImage;
                #endregion

                #region Transfer Worksets Button
                PushButtonData transferWorksetsButtonData = new PushButtonData(
                    "cmdTransferWorksets",
                    "Transfer" + "\n" + "Worksets",
                    Path.Combine(AssemblyPath, "TransferWorksets.dll"),
                    "Entry.CmdMain");

                PushButton transferWorksetsButton = modelManagementPanel.AddItem(transferWorksetsButtonData) as PushButton;

                transferWorksetsButton.ToolTip = "Transfer selected worksets from another project. Only the workset is transferred, not the geometry inside." + "\n"
                                                + "The source project must be open in the same Revit session.";

                BitmapImage transferWorksetsLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/TransferWorksets_32.ico"));
                transferWorksetsButton.LargeImage = transferWorksetsLargeImage;
                #endregion
            //}

            // load the rest of the buttons
            #region Schedule to Excel
            PushButtonData scheduleToExcelData = new PushButtonData(
                "cmdScheduleToExcel",
                "Schedule" + "\n" + "to Excel",
                Path.Combine(AssemblyPath, "ScheduleToExcel.dll"),
                "Entry.CmdMain");

            PushButton scheduleToExcelButton = modelManagementPanel.AddItem(scheduleToExcelData) as PushButton;

            scheduleToExcelButton.ToolTip = "Select schedules in the Project Browser and then click this button. They will open in Excel." + "\n"
                                         + "It can also open your active view in Excel (if this is a schedule).";

            BitmapImage scheduleToExcelLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/ScheduleToExcel_32.ico"));
            scheduleToExcelButton.LargeImage = scheduleToExcelLargeImage;
            #endregion

            #region Room Centroid and Tag Button
            PushButtonData roomCentroidButtonData = new PushButtonData(
                "cmdRoomCentroid",
                "Room Centroid," + "\n" + "Tag to Room",
                Path.Combine(AssemblyPath, "RoomCentroidAndTags.dll"),
                "Entry.CmdMain");

            PushButton roomCentroidButton = drawingsPanel.AddItem(roomCentroidButtonData) as PushButton;

            roomCentroidButton.ToolTip = "Moves room insertion point to room centroid." + "\n"
                                            + "Move room tags to room insertion point. " +
                                            "It works with both tags tagging rooms in the current model or in a linked model " +
                                            "(but linked models and current model coordinates must match).";

            BitmapImage roomCentroidLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/RoomCentroidAndTags_32.ico"));
            roomCentroidButton.LargeImage = roomCentroidLargeImage;
            #endregion

            #region Flip button
            PushButtonData flipButtonData = new PushButtonData(
                "cmdFlip",
                "Flip Walls" + "\n" + "or Doors",
                Path.Combine(AssemblyPath, "Flip.dll"),
                "Entry.CmdMain");

            PushButton flipButton = drawingsPanel.AddItem(flipButtonData) as PushButton;

            flipButton.ToolTip = "Flip a selection of Walls by centerline regardless of the Location Line." + "\n"
                                            + "Flip a selection of doors controlling whether you want to flip the hand or the facing.";

            BitmapImage flipLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/Flip_32.ico"));
            flipButton.LargeImage = flipLargeImage;
            #endregion

            #region Transfer View Template
            PushButtonData transTemplateButtonData = new PushButtonData(
                "cmdTransferTemplate",
                "Transfer" + "\n" + "View Templates",
                Path.Combine(AssemblyPath, "TransferViewTemplate.dll"),
                "Entry.CmdMain");

            PushButton transTemplateButton = drawingsPanel.AddItem(transTemplateButtonData) as PushButton;

            transTemplateButton.ToolTip = "Transfer selected View Templates from another project." + "\n"
                                            + "The source porject must be either opened in the same Revit session" +
                                            " or linked (and loaded) in the current project.";

            BitmapImage transferTemplateLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/TransferViewTemplates_32.ico"));
            transTemplateButton.LargeImage = transferTemplateLargeImage;
            #endregion

            #region Assign View Template
            PushButtonData AssignTemplateButtonData = new PushButtonData(
                "cmdAssignTemplate",
                "Assign" + "\n" + "View Templates",
                Path.Combine(AssemblyPath, "AssignViewTemplates.dll"),
                "Entry.CmdMain");

            PushButton AssignTemplateButton = drawingsPanel.AddItem(AssignTemplateButtonData) as PushButton;

            AssignTemplateButton.ToolTip = "Drag a View into a View Template to assign it.";

            BitmapImage AssignTemplateLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/AssignViewTemplates_32.ico"));
            AssignTemplateButton.LargeImage = AssignTemplateLargeImage;
            #endregion

            #region Reassign Detail Number
            PushButtonData ReassignDetNumButtonData = new PushButtonData(
                "cmdReassignDetNum",
                "Reassign" + "\n" + "Detail Number",
                Path.Combine(AssemblyPath, "ReassignDetailNumbers.dll"),
                "Entry.CmdMain");

            PushButton ReassignDetNumButton = drawingsPanel.AddItem(ReassignDetNumButtonData) as PushButton;

            ReassignDetNumButton.ToolTip = "Run this tool in a sheet view and click on sheet viewports" + "\n"
                                            + "one by one to change the detail number sequentially.";

            BitmapImage ReassignDetNumLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/ReassignDetailNumber_32.ico"));
            ReassignDetNumButton.LargeImage = ReassignDetNumLargeImage;
            #endregion

            #region Create Print Set
            PushButtonData printSetButtonData = new PushButtonData(
                "cmdPrintSet",
                "Create" + "\n" + "Print Set",
                Path.Combine(AssemblyPath, "CreatePrintSet.dll"),
                "Entry.CmdMain");

            PushButton printSetButton = printPanel.AddItem(printSetButtonData) as PushButton;

            printSetButton.ToolTip = "Creates a Sheet Set from selected sheets." + "\n"
                                            + "Once created, it will appear in the Print menu > Print Range > Selected views/sheets.";

            BitmapImage printSetLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/CreatePrintSet_32.ico"));
            printSetButton.LargeImage = printSetLargeImage;
            #endregion

            #region Sheet Duplicator
            PushButtonData sheetDuplicatorButtonData = new PushButtonData(
                "cmdSheetDuplicator",
                "Sheet" + "\n" + "Duplicator",
                Path.Combine(AssemblyPath, "SheetDuplicator.dll"),
                "Entry.CmdMain");

            PushButton sheetDuplicatorButton = drawingsPanel.AddItem(sheetDuplicatorButtonData) as PushButton;

            sheetDuplicatorButton.ToolTip = "Select a sheet and duplicate it multiple times." + "\n"
                                            + "Default duplicate option is 'with Detailing'. For dependent views, you can choose 'Duplicate as a Dependent'." + "\n"
                                            + "Legend Views and Schedules are not duplicated, just placed again in the sheet.";

            BitmapImage sheetDuplicatorLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/SheetDuplicator_32.ico"));
            sheetDuplicatorButton.LargeImage = sheetDuplicatorLargeImage;
            #endregion

            #region Transfer View Filters
            PushButtonData transFiltersButtonData = new PushButtonData(
                "cmdTransferViewFilters",
                "Transfer" + "\n" + "View Filters",
                Path.Combine(AssemblyPath, "TransferViewFilters.dll"),
                "Entry.CmdMain");

            PushButton transFiltersButton = drawingsPanel.AddItem(transFiltersButtonData) as PushButton;

            transFiltersButton.ToolTip = "Transfer multiple View Filters from one template to another." + "\n"
                                         + "Or override their graphic settings if the selected filters are already applied in the target Template.";

            BitmapImage transFiltersLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/TransferViewFilters_32.ico"));
            transFiltersButton.LargeImage = transFiltersLargeImage;
            #endregion

            #region Help
            PushButtonData helpButtonData = new PushButtonData(
                "cmdHelp",
                "Help",
                Path.Combine(AssemblyPath, "ArpRibbon.dll"),
                "Data.CmdAbout");

            PushButton helpButton = helpPanel.AddItem(helpButtonData) as PushButton;

            helpButton.ToolTip = "ARP Tools info and User Guide.";

            BitmapImage helpLargeImage = new BitmapImage(new Uri("pack://application:,,,/ArpRibbon;component/Icons/Help_32x32.ico"));
            helpButton.LargeImage = helpLargeImage;
            #endregion
            #endregion

            return Result.Succeeded;
        }

        public Result OnShutdown (UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        #region importReplacement method
        public void ImportReplacement(object sender, Autodesk.Revit.UI.Events.BeforeExecutedEventArgs arg)
        {
            TaskDialog td = new TaskDialog("Warning!")
            {
                MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                MainInstruction = "Stop! Do not import CAD!" + "\n"
                                + "It is not the best practice." + "\n" + "\n"
                                + "You can use \'Link CAD\' instead." + "\n" + "\n"
                                + "Consider speaking with your BIM Manager.",

                CommonButtons = TaskDialogCommonButtons.Ok,
                TitleAutoPrefix = false
            };
            TaskDialogResult tResult = td.Show();
        }
        #endregion

        #region inplaceReplacement method
        public void InplaceReplacement(object sender, Autodesk.Revit.UI.Events.BeforeExecutedEventArgs arg)
        {
            TaskDialog td = new TaskDialog("Warning!")
            {
                MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                MainInstruction = "Stop! Do not create In-place Components!" + "\n"
                                + "It is not the best practice." + "\n" + "\n"
                                + "I´m sure you can use an external family instead!" + "\n" + "\n"
                                + "Please speak with your BIM Manager before proceeding.",

                CommonButtons = TaskDialogCommonButtons.Ok,
                TitleAutoPrefix = false
            };
            TaskDialogResult tResult = td.Show();
        }
        #endregion
    }
}
