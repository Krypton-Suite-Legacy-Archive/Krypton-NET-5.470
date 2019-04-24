using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Settings;
using System;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.Classes
{
    public class UpdatePackageInformationSettingsHelper
    {
        #region Variables
        private UpdatePackageInformationSettings updatePackageInformationSettings = new UpdatePackageInformationSettings();
        #endregion

        #region Constructors        
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdatePackageInformationSettingsHelper"/> class.
        /// </summary>
        public UpdatePackageInformationSettingsHelper()
        {

        }
        #endregion

        #region Getters & Setters

        #region Booleans
        /// <summary>
        /// Sets the BetaFlag to the value of value.
        /// </summary>
        /// <param name="value">The desired value of BetaFlag.</param>
        public void SetBetaFlag(bool value)
        {
            updatePackageInformationSettings.BetaFlag = value;
        }

        /// <summary>
        /// Returns the value of the BetaFlag.
        /// </summary>
        /// <returns>The value of the BetaFlag.</returns>
        public bool GetBetaFlag()
        {
            return updatePackageInformationSettings.BetaFlag;
        }

        /// <summary>
        /// Sets the StartUpdateInstallationUponDownloadCompletion to the value of value.
        /// </summary>
        /// <param name="value">The desired value of StartUpdateInstallationUponDownloadCompletion.</param>
        public void SetStartUpdateInstallationUponDownloadCompletion(bool value)
        {
            updatePackageInformationSettings.StartUpdateInstallationUponDownloadCompletion = value;
        }

        /// <summary>
        /// Returns the value of the StartUpdateInstallationUponDownloadCompletion.
        /// </summary>
        /// <returns>The value of the StartUpdateInstallationUponDownloadCompletion.</returns>
        public bool GetStartUpdateInstallationUponDownloadCompletion()
        {
            return updatePackageInformationSettings.StartUpdateInstallationUponDownloadCompletion;
        }
        #endregion

        #region Date & Time
        /// <summary>
        /// Sets the UpdatePackageBuildDate to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UpdatePackageBuildDate.</param>
        public void SetUpdatePackageBuildDate(DateTime value)
        {
            updatePackageInformationSettings.UpdatePackageBuildDate = value;
        }

        /// <summary>
        /// Returns the value of the UpdatePackageBuildDate.
        /// </summary>
        /// <returns>The value of the UpdatePackageBuildDate.</returns>
        public DateTime GetUpdatePackageBuildDate()
        {
            return updatePackageInformationSettings.UpdatePackageBuildDate;
        }

        /// <summary>
        /// Sets the UpdatePackageReleaseDate to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UpdatePackageReleaseDate.</param>
        public void SetUpdatePackageReleaseDate(DateTime value)
        {
            updatePackageInformationSettings.UpdatePackageReleaseDate = value;
        }

        /// <summary>
        /// Returns the value of the UpdatePackageReleaseDate.
        /// </summary>
        /// <returns>The value of the UpdatePackageReleaseDate.</returns>
        public DateTime GetUpdatePackageReleaseDate()
        {
            return updatePackageInformationSettings.UpdatePackageReleaseDate;
        }
        #endregion

        #region Strings
        /// <summary>
        /// Sets the ChangelogURL to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ChangelogURL.</param>
        public void SetChangelogURL(string value)
        {
            updatePackageInformationSettings.ChangelogURL = value;
        }

        /// <summary>
        /// Returns the value of the ChangelogURL.
        /// </summary>
        /// <returns>The value of the ChangelogURL.</returns>
        public string GetChangelogURL()
        {
            return updatePackageInformationSettings.ChangelogURL;
        }

        /// <summary>
        /// Sets the CurrentInstalledVersion to the value of value.
        /// </summary>
        /// <param name="value">The desired value of CurrentInstalledVersion.</param>
        public void SetCurrentInstalledVersion(string value)
        {
            updatePackageInformationSettings.CurrentInstalledVersion = value;
        }

        /// <summary>
        /// Returns the value of the CurrentInstalledVersion.
        /// </summary>
        /// <returns>The value of the CurrentInstalledVersion.</returns>
        public string GetCurrentInstalledVersion()
        {
            return updatePackageInformationSettings.CurrentInstalledVersion;
        }

        /// <summary>
        /// Sets the ServerVersion to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ServerVersion.</param>
        public void SetServerVersion(string value)
        {
            updatePackageInformationSettings.ServerVersion = value;
        }

        /// <summary>
        /// Returns the value of the ServerVersion.
        /// </summary>
        /// <returns>The value of the ServerVersion.</returns>
        public string GetServerVersion()
        {
            return updatePackageInformationSettings.ServerVersion;
        }

        /// <summary>
        /// Sets the DownloadURL to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadURL.</param>
        public void SetDownloadURL(string value)
        {
            updatePackageInformationSettings.DownloadURL = value;
        }

        /// <summary>
        /// Returns the value of the DownloadURL.
        /// </summary>
        /// <returns>The value of the DownloadURL.</returns>
        public string GetDownloadURL()
        {
            return updatePackageInformationSettings.DownloadURL;
        }

        /// <summary>
        /// Sets the FileName to the value of value.
        /// </summary>
        /// <param name="value">The desired value of FileName.</param>
        public void SetFileName(string value)
        {
            updatePackageInformationSettings.FileName = value;
        }

        /// <summary>
        /// Returns the value of the FileName.
        /// </summary>
        /// <returns>The value of the FileName.</returns>
        public string GetFileName()
        {
            return updatePackageInformationSettings.FileName;
        }

        /// <summary>
        /// Sets the MD5CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of MD5CheckSum.</param>
        public void SetMD5CheckSum(string value)
        {
            updatePackageInformationSettings.MD5CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the MD5CheckSum.
        /// </summary>
        /// <returns>The value of the MD5CheckSum.</returns>
        public string GetMD5CheckSum()
        {
            return updatePackageInformationSettings.MD5CheckSum;
        }

        /// <summary>
        /// Sets the SHA1CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA1CheckSum.</param>
        public void SetSHA1CheckSum(string value)
        {
            updatePackageInformationSettings.SHA1CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the SHA1CheckSum.
        /// </summary>
        /// <returns>The value of the SHA1CheckSum.</returns>
        public string GetSHA1CheckSum()
        {
            return updatePackageInformationSettings.SHA1CheckSum;
        }

        /// <summary>
        /// Sets the SHA256CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA256CheckSum.</param>
        public void SetSHA256CheckSum(string value)
        {
            updatePackageInformationSettings.SHA256CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the SHA256CheckSum.
        /// </summary>
        /// <returns>The value of the SHA256CheckSum.</returns>
        public string GetSHA256CheckSum()
        {
            return updatePackageInformationSettings.SHA256CheckSum;
        }

        /// <summary>
        /// Sets the SHA384CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA384CheckSum.</param>
        public void SetSHA384CheckSum(string value)
        {
            updatePackageInformationSettings.SHA384CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the SHA384CheckSum.
        /// </summary>
        /// <returns>The value of the SHA384CheckSum.</returns>
        public string GetSHA384CheckSum()
        {
            return updatePackageInformationSettings.SHA384CheckSum;
        }

        /// <summary>
        /// Sets the SHA512CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA512CheckSum.</param>
        public void SetSHA512CheckSum(string value)
        {
            updatePackageInformationSettings.SHA512CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the SHA512CheckSum.
        /// </summary>
        /// <returns>The value of the SHA512CheckSum.</returns>
        public string GetSHA512CheckSum()
        {
            return updatePackageInformationSettings.SHA512CheckSum;
        }

        /// <summary>
        /// Sets the RIPEMD160CheckSum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of RIPEMD160CheckSum.</param>
        public void SetRIPEMD160CheckSum(string value)
        {
            updatePackageInformationSettings.RIPEMD160CheckSum = value;
        }

        /// <summary>
        /// Returns the value of the RIPEMD160CheckSum.
        /// </summary>
        /// <returns>The value of the RIPEMD160CheckSum.</returns>
        public string GetRIPEMD160CheckSum()
        {
            return updatePackageInformationSettings.RIPEMD160CheckSum;
        }

        /// <summary>
        /// Sets the VirusTotalURL to the value of value.
        /// </summary>
        /// <param name="value">The desired value of VirusTotalURL.</param>
        public void SetVirusTotalURL(string value)
        {
            updatePackageInformationSettings.VirusTotalURL = value;
        }

        /// <summary>
        /// Returns the value of the VirusTotalURL.
        /// </summary>
        /// <returns>The value of the VirusTotalURL.</returns>
        public string GetVirusTotalURL()
        {
            return updatePackageInformationSettings.VirusTotalURL;
        }

        /// <summary>
        /// Sets the XMLUpdatePathURL to the value of value.
        /// </summary>
        /// <param name="value">The desired value of XMLUpdatePathURL.</param>
        public void SetXMLUpdatePathURL(string value)
        {
            updatePackageInformationSettings.XMLUpdatePathURL = value;
        }

        /// <summary>
        /// Returns the value of the XMLUpdatePathURL.
        /// </summary>
        /// <returns>The value of the XMLUpdatePathURL.</returns>
        public string GetXMLUpdatePathURL()
        {
            return updatePackageInformationSettings.XMLUpdatePathURL;
        }

        /// <summary>
        /// Sets the DownloadLocalLocation to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetDownloadLocalLocation(string value)
        {
            updatePackageInformationSettings.DownloadLocalLocation = value;
        }

        /// <summary>
        /// Gets the DownloadLocalLocation value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public string GetDownloadLocalLocation()
        {
            return updatePackageInformationSettings.DownloadLocalLocation;
        }
        #endregion

        #region Integers
        /// <summary>
        /// Sets the UpdatePackageFileSize to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UpdatePackageFileSize.</param>
        public void SetUpdatePackageFileSize(int value)
        {
            updatePackageInformationSettings.UpdatePackageFileSize = value;
        }

        /// <summary>
        /// Returns the value of the UpdatePackageFileSize.
        /// </summary>
        /// <returns>The value of the UpdatePackageFileSize.</returns>
        public int GetUpdatePackageFileSize()
        {
            return updatePackageInformationSettings.UpdatePackageFileSize;
        }
        #endregion

        #endregion

        #region Methods        
        /// <summary>
        /// Saves the update package information settings.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void SaveUpdatePackageInformationSettings(bool showConfirmationDialogue = true)
        {
            if (showConfirmationDialogue)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current values?", "Save Current Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    updatePackageInformationSettings.Save();
                }
            }
            else
            {
                updatePackageInformationSettings.Save();
            }
        }

        /// <summary>
        /// Resets the update package information settings back to default.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void ResetUpdatePackageInformationSettingsBackToDefault(bool showConfirmationDialogue = true)
        {
            if (showConfirmationDialogue)
            {
                DialogResult result = KryptonMessageBox.Show("Are you sure that you want to reset the update settings back to their defaults?\n\n(NOTE: Once this action has completed, it cannot be reverted)", "Reset Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {

                }
            }
            else
            {

            }

            SaveUpdatePackageInformationSettings(showConfirmationDialogue);
        }
        #endregion
    }
}