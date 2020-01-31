using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitHub.Properties;
using System.Windows.Forms;

namespace KryptonToolkitHub.Classes
{
    public class SettingsManager
    {
        #region Variables
        private Settings _mySettings = new Settings();
        #endregion

        #region Constructor
        public SettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the BetaVersion to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetBetaVersion(bool value)
        {
            _mySettings.BetaVersion = value;
        }

        /// <summary>
        /// Gets the BetaVersion value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetBetaVersion()
        {
            return _mySettings.BetaVersion;
        }

        /// <summary>
        /// Sets the FirstLaunch to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetFirstLaunch(bool value)
        {
            _mySettings.FirstLaunch = value;
        }

        /// <summary>
        /// Gets the FirstLaunch value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetFirstLaunch()
        {
            return _mySettings.FirstLaunch;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Saves the settings.
        /// </summary>
        /// <param name="useConfirmationPrompt">if set to <c>true</c> [use confirmation prompt].</param>
        public void SaveSettings(bool useConfirmationPrompt = false)
        {
            if (useConfirmationPrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to store and save the application settings with the current values?", "Save Current Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _mySettings.Save();
                }
            }
            else
            {
                _mySettings.Save();
            }
        }
        #endregion
    }
}