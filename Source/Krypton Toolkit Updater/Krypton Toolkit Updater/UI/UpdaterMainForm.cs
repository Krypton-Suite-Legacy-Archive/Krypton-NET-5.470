using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Classes;
using System;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    public partial class UpdaterMainForm : KryptonForm
    {
        #region Variables
        bool _checkingForUpdates = false;

        Utilities utilities = new Utilities();

        XMLParser parser = new XMLParser();

        UpdatePackageInformationSettingsHelper updatePackageInformation = new UpdatePackageInformationSettingsHelper();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether [checking for updates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [checking for updates]; otherwise, <c>false</c>.
        /// </value>
        private bool CheckingForUpdates { get { return _checkingForUpdates; } set { _checkingForUpdates = value; } }
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
            CheckForUpdates("https://github.com/Wagnerp/Krypton-NET-4.70/blob/master/Updates/update.xml");
        }

        private void kbtnOptions_Click(object sender, EventArgs e)
        {
            UpdaterOptionsForm updaterOptions = new UpdaterOptionsForm();

            updaterOptions.Show();
        }

        private void UpdaterMainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdaterMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Methods
        private void CheckForUpdates(string updateXMLPath)
        {
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
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        #endregion

        private void kllHelp_LinkClicked(object sender, System.EventArgs e)
        {
            KryptonMessageBox.Show("This utility will enable you to check for and download updates for Krypton .NET 4.70.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kbtnDownloadUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}