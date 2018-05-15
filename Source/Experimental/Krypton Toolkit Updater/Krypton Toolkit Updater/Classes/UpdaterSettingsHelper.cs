using Krypton.Toolkit;
using KryptonToolkitUpdater.Settings;
using System;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.Classes
{
    /// <summary>
    /// Modifies values in <see cref="UpdaterSettings"/>.
    /// </summary>
    public class UpdaterSettingsHelper
    {
        #region Variables
        UpdaterSettings updaterSettings = new UpdaterSettings();
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterSettingsHelper"/> class.
        /// </summary>
        public UpdaterSettingsHelper()
        {

        }
        #endregion

        #region Setters & Getters

        #region Booleans
        /// <summary>
        /// Sets the AlwaysCheckInternetConnection to the value of value.
        /// </summary>
        /// <param name="value">The desired value of AlwaysCheckInternetConnection.</param>
        public void SetAlwaysCheckInternetConnection(bool value)
        {
            updaterSettings.AlwaysCheckInternetConnection = value;
        }

        /// <summary>
        /// Returns the value of the AlwaysCheckInternetConnection.
        /// </summary>
        /// <returns>The value of the AlwaysCheckInternetConnection.</returns>
        public bool GetAlwaysCheckInternetConnection()
        {
            return updaterSettings.AlwaysCheckInternetConnection;
        }

        /// <summary>
        /// Sets the AlwaysAskForDownloadLocation to the value of value.
        /// </summary>
        /// <param name="value">The desired value of AlwaysAskForDownloadLocation.</param>
        public void SetAlwaysAskForDownloadLocation(bool value)
        {
            updaterSettings.AlwaysAskForDownloadLocation = value;
        }

        /// <summary>
        /// Returns the value of the AlwaysAskForDownloadLocation.
        /// </summary>
        /// <returns>The value of the AlwaysAskForDownloadLocation.</returns>
        public bool GetAlwaysAskForDownloadLocation()
        {
            return updaterSettings.AlwaysAskForDownloadLocation;
        }

        /// <summary>
        /// Sets the ShowProgressBarInTaskbar to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ShowProgressBarInTaskbar.</param>
        public void SetShowProgressBarInTaskbar(bool value)
        {
            updaterSettings.ShowProgressBarInTaskbar = value;
        }

        /// <summary>
        /// Returns the value of the ShowProgressBarInTaskbar.
        /// </summary>
        /// <returns>The value of the ShowProgressBarInTaskbar.</returns>
        public bool GetShowProgressBarInTaskbar()
        {
            return updaterSettings.ShowProgressBarInTaskbar;
        }

        /// <summary>
        /// Sets the VerifyDownload to the value of value.
        /// </summary>
        /// <param name="value">The desired value of VerifyDownload.</param>
        public void SetVerifyDownload(bool value)
        {
            updaterSettings.VerifyDownload = value;
        }

        /// <summary>
        /// Returns the value of the VerifyDownload.
        /// </summary>
        /// <returns>The value of the VerifyDownload.</returns>
        public bool GetVerifyDownload()
        {
            return updaterSettings.VerifyDownload;
        }

        /// <summary>
        /// Sets the LaunchUpdatePackageUponDownload to the value of value.
        /// </summary>
        /// <param name="value">The desired value of LaunchUpdatePackageUponDownload.</param>
        public void SetLaunchUpdatePackageUponDownload(bool value)
        {
            updaterSettings.LaunchUpdatePackageUponDownload = value;
        }

        /// <summary>
        /// Returns the value of the LaunchUpdatePackageUponDownload.
        /// </summary>
        /// <returns>The value of the LaunchUpdatePackageUponDownload.</returns>
        public bool GetLaunchUpdatePackageUponDownload()
        {
            return updaterSettings.LaunchUpdatePackageUponDownload;
        }

        /// <summary>
        /// Sets the AlwaysShowTrayNotificationIcon to the value of value.
        /// </summary>
        /// <param name="value">The desired value of AlwaysShowTrayNotificationIcon.</param>
        public void SetAlwaysShowTrayNotificationIcon(bool value)
        {
            updaterSettings.AlwaysShowTrayNotificationIcon = value;
        }

        /// <summary>
        /// Returns the value of the AlwaysShowTrayNotificationIcon.
        /// </summary>
        /// <returns>The value of the AlwaysShowTrayNotificationIcon.</returns>
        public bool GetAlwaysShowTrayNotificationIcon()
        {
            return updaterSettings.AlwaysShowTrayNotificationIcon;
        }

        /// <summary>
        /// Sets the UseGarbageCollection to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseGarbageCollection.</param>
        public void SetUseGarbageCollection(bool value)
        {
            updaterSettings.UseGarbageCollection = value;
        }

        /// <summary>
        /// Returns the value of the UseGarbageCollection.
        /// </summary>
        /// <returns>The value of the UseGarbageCollection.</returns>
        public bool GetUseGarbageCollection()
        {
            return updaterSettings.UseGarbageCollection;
        }

        /// <summary>
        /// Sets the IsConnectedToTheInternet to the value of value.
        /// </summary>
        /// <param name="value">The desired value of IsConnectedToTheInternet.</param>
        public void SetIsConnectedToTheInternet(bool value)
        {
            updaterSettings.IsConnectedToTheInternet = value;
        }

        /// <summary>
        /// Returns the value of the IsConnectedToTheInternet.
        /// </summary>
        /// <returns>The value of the IsConnectedToTheInternet.</returns>
        public bool GetIsConnectedToTheInternet()
        {
            return updaterSettings.IsConnectedToTheInternet;
        }
        #endregion

        #region Strings
        /// <summary>
        /// Sets the DownloadLocation to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadLocation.</param>
        public void SetDownloadLocation(string value)
        {
            updaterSettings.DownloadLocation = value;
        }

        /// <summary>
        /// Returns the value of the DownloadLocation.
        /// </summary>
        /// <returns>The value of the DownloadLocation.</returns>
        public string GetDownloadLocation()
        {
            return updaterSettings.DownloadLocation;
        }

        /// <summary>
        /// Sets the PingAddress to the value of value.
        /// </summary>
        /// <param name="value">The desired value of PingAddress.</param>
        public void SetPingAddress(string value)
        {
            updaterSettings.PingAddress = value;
        }

        /// <summary>
        /// Returns the value of the PingAddress.
        /// </summary>
        /// <returns>The value of the PingAddress.</returns>
        public string GetPingAddress()
        {
            return updaterSettings.PingAddress;
        }
        #endregion

        #region Date & Time
        /// <summary>
        /// Sets the DateOfLastCheck to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DateOfLastCheck.</param>
        public void SetDateOfLastCheck(DateTime value)
        {
            updaterSettings.DateOfLastCheck = value;
        }

        /// <summary>
        /// Returns the value of the DateOfLastCheck.
        /// </summary>
        /// <returns>The value of the DateOfLastCheck.</returns>
        public DateTime GetDateOfLastCheck()
        {
            return updaterSettings.DateOfLastCheck;
        }
        #endregion

        #endregion

        #region Methods
        /// <summary>
        /// Saves the updater settings.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void SaveUpdaterSettings(bool showConfirmationDialogue = true)
        {
            if (showConfirmationDialogue)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current values?", "Save Current Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    updaterSettings.Save();
                }
            }
            else
            {
                updaterSettings.Save();
            }
        }

        /// <summary>
        /// Resets the updater settings back to default.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void ResetUpdaterSettingsBackToDefault(bool showConfirmationDialogue = true)
        {
            if (showConfirmationDialogue)
            {
                DialogResult result = KryptonMessageBox.Show("Are you sure that you want to reset the update settings back to their defaults?\n\n(NOTE: Once this action has completed, it cannot be reverted)", "Reset Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    SetAlwaysAskForDownloadLocation(false);

                    SetAlwaysCheckInternetConnection(true);

                    SetAlwaysShowTrayNotificationIcon(true);

                    SetLaunchUpdatePackageUponDownload(false);

                    SetShowProgressBarInTaskbar(true);

                    SetUseGarbageCollection(true);

                    SetVerifyDownload(false);

                    SetIsConnectedToTheInternet(false);

                    if (!File.Exists(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates"))
                    {
                        File.Create(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates");
                    }

                    SetDownloadLocation(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates");

                    SetPingAddress(string.Empty);

                    SaveUpdaterSettings(false);

                    SetDateOfLastCheck(DateTime.Now);
                }
            }
            else
            {
                SetAlwaysAskForDownloadLocation(false);

                SetAlwaysCheckInternetConnection(true);

                SetAlwaysShowTrayNotificationIcon(true);

                SetLaunchUpdatePackageUponDownload(false);

                SetShowProgressBarInTaskbar(true);

                SetUseGarbageCollection(true);

                SetVerifyDownload(false);

                SetIsConnectedToTheInternet(false);

                if (!File.Exists(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates"))
                {
                    File.Create(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates");
                }

                SetDownloadLocation(Environment.SpecialFolder.MyDocuments + "\\Krypton Toolkit Suite\\Updates");

                SetPingAddress(string.Empty);

                SaveUpdaterSettings(false);

                SetDateOfLastCheck(DateTime.Now);
            }
        }
        #endregion
    }
}