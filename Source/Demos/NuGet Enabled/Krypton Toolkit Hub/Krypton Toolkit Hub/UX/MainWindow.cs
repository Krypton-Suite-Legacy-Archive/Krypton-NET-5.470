using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitHub.Classes;
using KryptonToolkitHub.Enumerations;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace KryptonToolkitHub.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private IOOperations _io = new IOOperations();
        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version, _kryptonDocking = null, _kryptonNavigator = null, _kryptonRibbon = null, _kryptonToolkit = null, _kryptonWorkspace = null;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            TextExtra = $"(Beta Build: { _currentVersion.Build.ToString() })";

            klblKryptonToolkitHubVersion.Text = $"Krypton Toolkit Hub Version: { _currentVersion.ToString() }";

            if (_io.DoesFileExist(@".\Krypton Docking.dll"))
            {
                _kryptonDocking = _io.GetFileVersion(@".\Krypton Docking.dll");

                klblKryptonDockingVersion.Text = $"Krypton Docking Version: { _kryptonDocking.ToString() }";
            }
            else
            {
                klblKryptonDockingVersion.Visible = false;
            }
        }

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kbtnProjectHomepage_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Wagnerp/Krypton-NET-5.4700");
        }

        private void kbtnReportABug_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Wagnerp/Krypton-NET-5.4700/issues");
        }

        private void tsslCurrentStatus_MouseEnter(object sender, EventArgs e)
        {
            tsslCurrentStatus.ToolTipText = tsslCurrentStatus.Text;
        }

        #region Link Event Handlers

        #region Krypton Components
        private void linkKryptonButton_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONBUTTON, tsslCurrentStatus);
        }

        private void linkKryptonCheckButton_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCHECKBUTTON, tsslCurrentStatus);
        }

        private void linkKryptonDropButton_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONDROPBUTTON, tsslCurrentStatus);
        }

        private void linkKryptonColourButton_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCOLOURBUTTON, tsslCurrentStatus);
        }

        private void linkKryptonCheckSet_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCHECKSET, tsslCurrentStatus);
        }

        private void linkKryptonCheckBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCHECKBOX, tsslCurrentStatus);
        }

        private void linkKryptonRadioButton_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONRADIOBUTTON, tsslCurrentStatus);
        }

        private void linkKryptonLabel_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONLABEL, tsslCurrentStatus);
        }

        private void linkKryptonLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONLINKLABEL, tsslCurrentStatus);
        }

        private void linkKryptonWrapLabel_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONWRAPLABEL, tsslCurrentStatus);
        }

        private void linkKryptonSplitContainer_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONSPLITCONTAINER, tsslCurrentStatus);
        }

        private void linkKryptonContextMenu_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCONTEXTMENU, tsslCurrentStatus);
        }

        private void linkKryptonTrackBar_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONTRACKBAR, tsslCurrentStatus);
        }

        private void linkKryptonListBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONLISTBOX, tsslCurrentStatus);
        }

        private void linkKryptonCheckedListBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCHECKEDLISTBOX, tsslCurrentStatus);
        }

        private void linkKryptonTextBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONTEXTBOX, tsslCurrentStatus);
        }

        private void linkKryptonMaskedTextBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONMASKEDTEXTBOX, tsslCurrentStatus);
        }

        private void linkKryptonRichTextBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONRICHTEXTBOX, tsslCurrentStatus);
        }

        private void linkKryptonComboBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCOMBOBOX, tsslCurrentStatus);
        }

        private void linkKryptonNumericUpDown_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONNUMERICUPDOWN, tsslCurrentStatus);
        }

        private void linkKryptonDomainUpDown_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONDOMAINUPDOWN, tsslCurrentStatus);
        }

        private void linkKryptonBreadCrumb_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONBREADCRUMB, tsslCurrentStatus);
        }

        private void linkKryptonDateTimePicker_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONDATETIMEPICKER, tsslCurrentStatus);
        }

        private void linkKryptonMonthCalendar_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONMONTHCALENDAR, tsslCurrentStatus);
        }

        private void linkKryptonDataGridView_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONDATAGRIDVIEW, tsslCurrentStatus);
        }

        private void linkKryptonTreeView_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONTREEVIEW, tsslCurrentStatus);
        }

        private void linkKryptonBorderEdge_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONBORDEREDGE, tsslCurrentStatus);
        }

        private void linkKryptonSeparator_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONSEPARATOR, tsslCurrentStatus);
        }

        private void linkKryptonPanel_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONPANEL, tsslCurrentStatus);
        }

        private void linkKryptonGroup_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONGROUP, tsslCurrentStatus);
        }

        private void linkKryptonGroupBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONGROUPBOX, tsslCurrentStatus);
        }

        private void linkKryptonHeaderGroup_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONHEADERGROUP, tsslCurrentStatus);
        }

        private void linkKryptonHeader_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONHEADER, tsslCurrentStatus);
        }

        private void linkKryptonPalette_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONPALETTE, tsslCurrentStatus);
        }

        private void linkKryptonCommand_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONCOMMAND, tsslCurrentStatus);
        }

        private void linkKryptonInputBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONINPUTBOX, tsslCurrentStatus);
        }

        private void linkKryptonMessageBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONMESSAGEBOX, tsslCurrentStatus);
        }

        private void linkKryptonTaskDialog_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONTASKDIALOG, tsslCurrentStatus);
        }

        private void linkKryptonForm_LinkClicked(object sender, EventArgs e)
        {
            LaunchManager.LaunchComponentExample(ComponentToolkitExamples.KRYPTONFORM, tsslCurrentStatus);
        }
        #endregion

        #endregion
    }
}