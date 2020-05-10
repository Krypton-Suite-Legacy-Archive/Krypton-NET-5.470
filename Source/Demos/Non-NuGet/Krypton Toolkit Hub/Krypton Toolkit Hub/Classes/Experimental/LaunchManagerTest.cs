using KryptonToolkitHub.Enumerations;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitHub.Classes.Experimental
{
    public class LaunchManagerTest
    {
        #region Constructor
        public LaunchManagerTest()
        {

        }
        #endregion

        #region Methods

        #region Component Examples
        /// <summary>
        /// Launches the specified component example.
        /// </summary>
        /// <param name="componentExample">The component example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchComponentExample(ComponentToolkitExamples componentExample, ToolStripLabel statusLabel = null, bool useFullPath = false)
        {
            string statusText = null;

            switch (componentExample)
            {
                case ComponentToolkitExamples.KRYPTONBUTTON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Button Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKBUTTON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton CheckButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDROPBUTTON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton DropButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOLOURBUTTON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton ColorButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKSET:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton CheckSet Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton CheckBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONRADIOBUTTON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton RadioButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLABEL:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLINKLABEL:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Link Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONWRAPLABEL:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Wrap Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONSPLITCONTAINER:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Split Container Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCONTEXTMENU:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Context Menu Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTRACKBAR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton TrackBar Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLISTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton ListBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKEDLISTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Checked ListBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTEXTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMASKEDTEXTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Masked TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONRICHTEXTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Rich TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOMBOBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton ComboBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONNUMERICUPDOWN:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Numeric UpDown Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDOMAINUPDOWN:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Domain UpDown Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONBREADCRUMB:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Bread Crumb Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDATETIMEPICKER:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton DateTimePicker Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMONTHCALENDAR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Month Calendar Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDATAGRIDVIEW:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Data GridView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTREEVIEW:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton TreeView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONBORDEREDGE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Border Edge Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONSEPARATOR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Separator Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONPANEL:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Panel Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONGROUP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Group Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONGROUPBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton GroupBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONHEADERGROUP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Header Group Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONHEADER:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Header Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONPALETTE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Palette Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOMMAND:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Command Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONINPUTBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton InputBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMESSAGEBOX:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton MessageBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTASKDIALOG:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton TaskDialog Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONFORM:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Form Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Application Toolkit Examples
        /// <summary>
        /// Launches the application toolkit example.
        /// </summary>
        /// <param name="applicationExample">The application example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchApplicationToolkitExample(ApplicationToolkitExamples applicationExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (applicationExample)
            {
                case ApplicationToolkitExamples.INPUTFORM:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Input Form Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.THREEPANEAPPLICATIONBASIC:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Three Pane Application Basic.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.THREEPANEAPPLICATIONEXTENDED:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Three Pane Application Extended.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSSPLITTERS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Expanding Header Groups Splitters Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSDOCKSTYLE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Expanding Header Groups DockStyle Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSSTACK:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Expanding Header Groups Stack Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.MDIAPPLICATION:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\MDI Application.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CHILDCONTROLSTACK:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Child Control Stack.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.BUTTONSPECPLAYGROUND:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Button Spec Playground.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CUSTOMCONTROLUSINGPALETTES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Custom Control Using Palettes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CUSTOMCONTROLUSINGRENDERERS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Custom Control Using Renderers.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Test Application Toolkit Examples
        /// <summary>
        /// Launches the test application toolkit example.
        /// </summary>
        /// <param name="applicationToolkitExample">The application toolkit example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchTestApplicationToolkitExample(TestApplicationToolkitExamples applicationToolkitExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (applicationToolkitExample)
            {
                case TestApplicationToolkitExamples.KRYPTONTREEVIEW:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton TreeView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.SYSTEMTHEMEDFORMS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\System Themed Forms.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTCLIPBASE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Test Clip Base.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTMESSAGEBOXCLIPPING:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Test MessageBox Clipping.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTTEXTCLIPPING:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Test Text Clipping.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Docking Feature Examples
        /// <summary>
        /// Launches the docking feature examples.
        /// </summary>
        /// <param name="dockingFeatureExample">The docking feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchDockingFeatureExample(DockingFeatureExamples dockingFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (dockingFeatureExample)
            {
                case DockingFeatureExamples.DOCKINGCUSTOMISED:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Docking Customized.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.DOCKINGPERSISTENCE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Docking Persistence.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.DOCKINGFLAGS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Docking Flags.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.MULTICONTROLDOCKING:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Multi Control Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.EXTERNALDRAGTODOCKING:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\External Drag To Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Docking Usage Examples
        /// <summary>
        /// Launches the docking usage examples.
        /// </summary>
        /// <param name="dockingUsageExample">The docking usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchDockingUsageExample(DockingUsageExamples dockingUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (dockingUsageExample)
            {
                case DockingUsageExamples.STANDARDDOCKING:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Standard Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingUsageExamples.NAVICATORPLUSFLOATINGWINDOWS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator And Floating Windows.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Workspace Feature Examples
        /// <summary>
        /// Launches the workspace feature examples.
        /// </summary>
        /// <param name="workspaceFeatureExample">The workspace feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchWorkspaceFeatureExample(WorkspaceFeatureExamples workspaceFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (workspaceFeatureExample)
            {
                case WorkspaceFeatureExamples.WORKSPACECELLMODES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Workspace Cell Modes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.WORKSPACECELLLAYOUT:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Workspace Cell Layout.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.WORKSPACEPERSISTENCE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Workspace Persistence.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.CELLMAXIMISEPLUSRESTORE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Cell Maximize And Restore.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.BASICPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Basic Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.ADVANCEDPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Advanced Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Workspace Usage Examples
        /// <summary>
        /// Launches the workspace usage example.
        /// </summary>
        /// <param name="workspaceUsageExample">The workspace usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchWorkspaceUsageExample(WorkspaceUsageExamples workspaceUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (workspaceUsageExample)
            {
                case WorkspaceUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon And Navigator And Workspace.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceUsageExamples.MEMOEDITOR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Memo Editor.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Navigator Feature Examples
        /// <summary>
        /// Launches the navigator feature example.
        /// </summary>
        /// <param name="navigatorFeatureExample">The navigator feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchNavigatorFeatureExample(NavigatorFeatureExamples navigatorFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (navigatorFeatureExample)
            {
                case NavigatorFeatureExamples.NAVIGATORMODES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator Modes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.NAVIGATORPALETTES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator Palettes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.OREINTATIONPLUSALIGNMENT:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Orientation Plus Alignment.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.SINGLELINEPLUSMULTILINE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Singleline Plus Multiline.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.TABBORDERSTYLES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Tab Border Styles.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.POPUPPAGES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Popup Pages.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.PERTABBUTTONS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Per Tab Buttons.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.NAVIGATORTOOLTIPS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator Tool Tips.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.NAVIGATORCONTEXTMENUS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator Context Menus.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.NAVIGATORPLAYGROROUND:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator Playground.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.BASICPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Basic Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.ADVANCEDPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Advanced Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.BASICEVENTS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Basic Events.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Navigator Usage Examples
        /// <summary>
        /// Launches the navigator usage example.
        /// </summary>
        /// <param name="navigatorUsageExample">The navigator usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchNavigatorUsageExample(NavigatorUsageExamples navigatorUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (navigatorUsageExample)
            {
                case NavigatorUsageExamples.USERPAGECREATION:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\User Page Creation.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.ONENOTETABS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\OneNote Tabs.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.OUTLOOKMOCKUP:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Outlook Mockup.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon And Navigator And Workspace.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.EXPANDINGPAGES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Expanding Pages.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.NAVIGATORPLUSFLOATINGWINDOWS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Navigator And Floating Windows.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case NavigatorUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Ribbon Feature Examples
        /// <summary>
        /// Launches the ribbon feature example.
        /// </summary>
        /// <param name="ribbonFeatureExample">The ribbon feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchRibbonFeatureExample(RibbonFeatureExamples ribbonFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (ribbonFeatureExample)
            {
                case RibbonFeatureExamples.CONTEXTUALTABS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Contextual Tabs.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.KEYTIPSPLUSKEYBOARDACCESS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Key Tips And Keyboard Access.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.AUTOSHRINKINGGROUPS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Auto Shrinking Groups.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.QUICKACCESSTOOLBAR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Quick Access Toolbar.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.RIBBONGALLERY:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon Gallery.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.RIBBONTOOLTIPS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon Tool Tips.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.RIBBONCONTROLS:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon Controls.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.APPLICATIONMENU:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Application Menu.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.KRYPTONGALLERYEXAMPLES:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Krypton Gallery Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Ribbon Usage Examples
        /// <summary>
        /// Launches the ribbon usage example.
        /// </summary>
        /// <param name="ribbonUsageExample">The ribbon usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchRibbonUsageExample(RibbonUsageExamples ribbonUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (ribbonUsageExample)
            {
                case RibbonUsageExamples.OUTLOOKMAILCLONE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Outlook Mail Clone.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Ribbon And Navigator And Workspace.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonUsageExamples.MDIRIBBON:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\MDI Ribbon.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonUsageExamples.MEMOEDITOR:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Memo Editor.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case RibbonUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Krypton Applications
        /// <summary>
        /// Launches the krypton application.
        /// </summary>
        /// <param name="kryptonApplication">The krypton application.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchKryptonApplication(KryptonApplications kryptonApplication, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (kryptonApplication)
            {
                case KryptonApplications.PALETTEDESIGNER:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Palette Designer.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case KryptonApplications.PALETTEUPGRADETOOL:
                    ProcessManager.LaunchProcess(IOOperations.GetApplicationProcessExecutablePath() + "\\Palette Upgrade Tool.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case KryptonApplications.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Status Update
        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        private static void UpdateStatus(ToolStripLabel statusLabel, string processName, bool useFullPath = false)
        {
            if (useFullPath)
            {
                statusLabel.Text = $"Attempting to launch: '{ Path.GetFullPath(processName) }'";
            }
            else if (processName == "Ready" || processName == "ready" || processName == "READY")
            {
                statusLabel.Text = "Ready";
            }
            else
            {
                statusLabel.Text = $"Attempting to launch: '{ processName }'";
            }
        }
        #endregion

        #endregion
    }
}