using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Enumerations;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.Classes
{
    /// <summary>
    /// Various methods that are not attached to anything.
    /// </summary>
    public class Utilities
    {
        #region Variables
        UpdaterSettingsHelper updaterSettingsHelper = new UpdaterSettingsHelper();

        ThemeSettingsHelper themeSettingsHelper = new ThemeSettingsHelper();
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="Utilities"/> class.
        /// </summary>
        public Utilities()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Explores the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public bool ExploreFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            filePath = Path.GetFullPath(filePath);

            Process.Start("explorer.exe", $"/select,\"{ filePath }\"");

            return true;
        }

        /// <summary>
        /// Checks the state of the Internet connection.
        /// </summary>
        /// <param name="pingAddress">The ping address.</param>
        /// <param name="timeOut">The time out.</param>
        /// <returns></returns>
        public bool CheckInternetConnectionState(string pingAddress = null, int timeOut = 1000)
        {
            Ping ping = new Ping();

            if (pingAddress != null)
            {
                try
                {
                    PingReply reply = ping.Send(IPAddress.Parse(pingAddress), timeOut);

                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception exc)
                {
                    KryptonMessageBox.Show($"Failed to connect to server: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                try
                {
                    // Ping http://www.google.com
                    PingReply reply = ping.Send(IPAddress.Parse("208.69.34.231"), timeOut);

                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception exc)
                {
                    KryptonMessageBox.Show($"Failed to connect to server: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
        }

        /// <summary>
        /// Sets the state of the internet connection.
        /// </summary>
        /// <param name="state">The state.</param>
        public void SetInternetConnectionState(InternetConnectionState state)
        {
            switch (state)
            {
                case InternetConnectionState.CONNECTED:
                    updaterSettingsHelper.SetIsConnectedToTheInternet(true);
                    break;
                case InternetConnectionState.NOTCONNECTED:
                    updaterSettingsHelper.SetIsConnectedToTheInternet(false);
                    break;
                case InternetConnectionState.LIMITEDCONNECTIVITY:
                    break;
            }

            updaterSettingsHelper.SaveUpdaterSettings();
        }

        /// <summary>
        /// Gets the internet protocol address.
        /// </summary>
        /// <param name="pingURL">The ping URL.</param>
        /// <returns></returns>
        public string GetInternetProtocolAddress(string pingURL)
        {
            IPAddress[] addresses = Dns.GetHostAddresses(pingURL);

            return addresses.ToString();
        }

        //public KryptonTheme GetCurrentKryptonTheme()
        //{
        //    KryptonTheme currentTheme, tempTheme;

        //    if (themeSettingsHelper.GetUseCustomTheme())
        //    {
        //        tempTheme = KryptonTheme.CUSTOM;
        //    }

        //    currentTheme = tempTheme;

        //    return currentTheme;
        //}
        #endregion
    }
}