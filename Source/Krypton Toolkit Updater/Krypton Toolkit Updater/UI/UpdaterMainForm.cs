using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Classes;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    public partial class UpdaterMainForm : KryptonForm
    {
        #region Variables
        private bool _checkingForUpdates = false;
        private string _currentToolkitVersion;
        private Utilities utilities = new Utilities();
        private XMLParser parser = new XMLParser();
        private UpdatePackageInformationSettingsHelper updatePackageInformation = new UpdatePackageInformationSettingsHelper();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether [checking for updates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [checking for updates]; otherwise, <c>false</c>.
        /// </value>
        private bool CheckingForUpdates { get { return _checkingForUpdates; } set { _checkingForUpdates = value; } }

        /// <summary>
        /// Gets or sets the current toolkit version.
        /// </summary>
        /// <value>
        /// The current toolkit version.
        /// </value>
        private string CurrentToolkitVersion { get { return _currentToolkitVersion; } set { _currentToolkitVersion = value; } }
        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterMainForm"/> class.
        /// </summary>
        public UpdaterMainForm()
        {
            InitializeComponent();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            if (_checkingForUpdates)
            {
                DialogResult result = KryptonMessageBox.Show("Checking for updates. Do you want to quit now?", "Update in Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void kbtnCheckForUpdates_Click(object sender, EventArgs e)
        {
            CheckForUpdates("https://github.com/Wagnerp/Krypton-NET-5.4700/blob/master/Updates/update.xml");
        }

        private void kbtnOptions_Click(object sender, EventArgs e)
        {
            UpdaterOptionsForm updaterOptions = new UpdaterOptionsForm();

            updaterOptions.Show();
        }

        private void UpdaterMainForm_Load(object sender, EventArgs e)
        {
            SetCurrentToolkitVersion(GetFileVersionInformation(@".\Krypton Toolkit.dll").ToString());
        }

        private void UpdaterMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Methods
        /// <summary>
        /// Checks for updates.
        /// </summary>
        /// <param name="updateXMLPath">The update XML path.</param>
        private void CheckForUpdates(string updateXMLPath)
        {
            SetCheckingForUpdates(true);

            try
            {
                if (utilities.CheckInternetConnectionState())
                {
                    if (utilities.ExistsOnServer(new Uri(updateXMLPath)))
                    {
                        XMLParser.ParseUpdateXMLFile(updateXMLPath);

                        if (utilities.IsNewerThan(Version.Parse(updatePackageInformation.GetCurrentInstalledVersion())))
                        {
                            kbtnCheckForUpdates.Visible = false;

                            klblCurrentStatus.Text = "A new update is now available!";

                            SetCheckingForUpdates(false);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SetCheckingForUpdates(false);
            }
        }

        /// <summary>
        /// Gets the file version information.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private Version GetFileVersionInformation(string filePath)
        {
            Version tmpVersion;

            try
            {
                if (File.Exists(filePath))
                {
                    tmpVersion = Version.Parse(FileVersionInfo.GetVersionInfo(filePath).FileVersion);

                    return tmpVersion;
                }
            }
            catch (Exception error)
            {
                KryptonMessageBox.Show($"An error has occurred: { error.Message }", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tmpVersion = Version.Parse("0.0.0.0");
            }

            tmpVersion = Assembly.GetExecutingAssembly().GetName().Version;

            return tmpVersion;
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the CheckingForUpdates to the value of value.
        /// </summary>
        /// <param name="value">The desired value of CheckingForUpdates.</param>
        private void SetCheckingForUpdates(bool value)
        {
            CheckingForUpdates = value;
        }

        /// <summary>
        /// Returns the value of the CheckingForUpdates.
        /// </summary>
        /// <returns>The value of the CheckingForUpdates.</returns>
        private bool GetCheckingForUpdates()
        {
            return CheckingForUpdates;
        }

        /// <summary>
        /// Sets the CurrentToolkitVersion to the value of versionValue.
        /// </summary>
        /// <param name="versionValue">The value of versionValue.</param>
        private void SetCurrentToolkitVersion(string versionValue)
        {
            CurrentToolkitVersion = versionValue;
        }

        /// <summary>
        /// Gets the CurrentToolkitVersion value.
        /// </summary>
        /// <returns>The value of versionValue.</returns>
        private string GetCurrentToolkitVersion()
        {
            return CurrentToolkitVersion;
        }
        #endregion

        private void kllHelp_LinkClicked(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("This utility will enable you to check for and download updates for Krypton .NET 5.470.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kbtnDownloadUpdate_Click(object sender, EventArgs e)
        {
            DownloadUpdateForm downloadUpdate = new DownloadUpdateForm(updatePackageInformation.GetDownloadURL(), updatePackageInformation.GetDownloadLocalLocation());

            downloadUpdate.Show();
        }
    }
}