using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Classes;
using KryptonToolkitUpdater.Enumerations;
using System;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    public partial class UpdaterOptionsForm : KryptonForm
    {
        #region Variables
        bool _settingsChanged;

        UpdaterSettingsHelper updaterSettingsHelper = new UpdaterSettingsHelper();

        Timer optionsTimer = new Timer();
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets SettingsModified.
        /// </summary>
        /// <value>
        /// _settingsChanged.
        /// </value>
        private bool SettingsModified
        {
            get
            {
                return _settingsChanged;
            }


            set
            {
                _settingsChanged = value;
            }
        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the SettingsModified to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SettingsModified.</param>
        private void SetSettingsModified(bool value)
        {
            SettingsModified = value;
        }

        /// <summary>
        /// Returns the value of the SettingsModified.
        /// </summary>
        /// <returns>The value of the SettingsModified.</returns>
        private bool GetSettingsModified()
        {
            return SettingsModified;
        }
        #endregion

        public UpdaterOptionsForm()
        {
            InitializeComponent();

            optionsTimer.Interval = 250;

            optionsTimer.Enabled = true;

            optionsTimer.Tick += OptionsTimer_Tick;
        }

        #region Event Handlers
        private void OptionsTimer_Tick(object sender, EventArgs e)
        {

        }

        private void kbtnApply_Click(object sender, EventArgs e)
        {

        }

        private void UpdaterOptionsForm_Load(object sender, EventArgs e)
        {
            LoadSettingValues();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void kbtnReset_Click(object sender, EventArgs e)
        {
            updaterSettingsHelper.ResetUpdaterSettingsBackToDefault();
        }

        private void kbtnCheckNow_Click(object sender, EventArgs e)
        {

        }

        private void kchkCheckInternetConnection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkAlwaysAskForDownloadLocation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ktxtDownloadPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void kchkShowProgressInTaskbar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkVerifyDownload_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkLaunchUpdatePackageUponDownload_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkAlwaysShowTrayNotificationIcon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseGarbageCollection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseOffice2013ThemePalette_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2013SilverTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2013WhiteTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseOffice2010ThemePalette_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2010BlackTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2010BlueTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2010SilverTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseOffice2007ThemePalette_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2007BlackTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2007BlueTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2007SilverTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseProfessionalThemePalette_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseOffice2003Theme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseSystemTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseSparkleThemePalette_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseSparkleBlueTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseSparkleOrangeTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseSparklePurpleTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kchkUseOtherThemePalettes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kradUseCustomTheme_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods
        private void LoadSettingValues()
        {
            kchkCheckInternetConnection.Checked = updaterSettingsHelper.GetAlwaysCheckInternetConnection();

            kchkAlwaysAskForDownloadLocation.Checked = updaterSettingsHelper.GetAlwaysAskForDownloadLocation();

            klblCurrentDownloadPath.Text = $"Current download path: { updaterSettingsHelper.GetDownloadLocation() }";

            kchkShowProgressInTaskbar.Checked = updaterSettingsHelper.GetShowProgressBarInTaskbar();

            kchkVerifyDownload.Checked = updaterSettingsHelper.GetVerifyDownload();

            kchkLaunchUpdatePackageUponDownload.Checked = updaterSettingsHelper.GetLaunchUpdatePackageUponDownload();

            kchkAlwaysShowTrayNotificationIcon.Checked = updaterSettingsHelper.GetAlwaysShowTrayNotificationIcon();

            kchkUseGarbageCollection.Checked = updaterSettingsHelper.GetUseGarbageCollection();
        }

        /// <summary>
        /// Sets the theme.
        /// </summary>
        /// <param name="theme">The theme.</param>
        private void SetTheme(KryptonTheme theme)
        {
            switch (theme)
            {
                case KryptonTheme.OFFICE2013SILVER:
                    break;
                case KryptonTheme.OFFICE2013WHITE:
                    break;
                case KryptonTheme.OFFICE2010BLACK:
                    break;
                case KryptonTheme.OFFICE2010BLUE:
                    break;
                case KryptonTheme.OFFICE2010SILVER:
                    break;
                case KryptonTheme.OFFICE2007BLACK:
                    break;
                case KryptonTheme.OFFICE2007BLUE:
                    break;
                case KryptonTheme.OFFICE2007SILVER:
                    break;
                case KryptonTheme.PROFESSIONALOFFICE2003:
                    break;
                case KryptonTheme.PROFESSIONALSYSTEM:
                    break;
                case KryptonTheme.SPARKLEBLUE:
                    break;
                case KryptonTheme.SPARKLEORANGE:
                    break;
                case KryptonTheme.SPARKLEPURPLE:
                    break;
                case KryptonTheme.CUSTOM:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}