using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Classes;
using KryptonToolkitUpdater.Enumerations;
using System;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    internal partial class UpdaterOptionsForm : KryptonForm
    {
        #region Variables
        bool _settingsChanged;

        UpdaterSettingsHelper updaterSettingsHelper = new UpdaterSettingsHelper();

        Timer optionsTimer = new Timer();

        ControlController controlController = new ControlController();

        Utilities utilities = new Utilities();

        ThemeSettingsHelper themeSettingsHelper = new ThemeSettingsHelper();

        ThemingManager themingManager = new ThemingManager();
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

        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterOptionsForm"/> class.
        /// </summary>
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
            if (utilities.CheckInternetConnectionState())
            {
                klblCurrentStatus.Text = $"Current Status: Connected";
            }
            else
            {
                klblCurrentStatus.Text = $"Current Status: Not Connected";
            }
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
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.OFFICE2013THEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseOffice2013SilverTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2013SILVER, kMan);
        }

        private void kradUseOffice2013WhiteTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2013WHITE, kMan);
        }

        private void kchkUseOffice2010ThemePalette_CheckedChanged(object sender, EventArgs e)
        {
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseOffice2010BlackTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2010BLACK, kMan);
        }

        private void kradUseOffice2010BlueTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2010BLUE, kMan);
        }

        private void kradUseOffice2010SilverTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2010SILVER, kMan);
        }

        private void kchkUseOffice2007ThemePalette_CheckedChanged(object sender, EventArgs e)
        {
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.OFFICE2007THEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseOffice2007BlackTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2007BLACK, kMan);
        }

        private void kradUseOffice2007BlueTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2007BLUE, kMan);
        }

        private void kradUseOffice2007SilverTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.OFFICE2007SILVER, kMan);
        }

        private void kchkUseProfessionalThemePalette_CheckedChanged(object sender, EventArgs e)
        {
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.PROFESSIONALTHEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseOffice2003Theme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.PROFESSIONALOFFICE2003, kMan);
        }

        private void kradUseSystemTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.PROFESSIONALSYSTEM, kMan);
        }

        private void kchkUseSparkleThemePalette_CheckedChanged(object sender, EventArgs e)
        {
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.SPARKLETHEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseSparkleBlueTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.SPARKLEBLUE, kMan);
        }

        private void kradUseSparkleOrangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.SPARKLEORANGE, kMan);
        }

        private void kradUseSparklePurpleTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.SPARKLEPURPLE, kMan);
        }

        private void kchkUseOtherThemePalettes_CheckedChanged(object sender, EventArgs e)
        {
            controlController.ToggleControlStates(SuppotedKryptonThemePalettes.OTHERTHEMEPALETTE, kchkUseOffice2013ThemePalette, kradUseOffice2013SilverTheme, kradUseOffice2013WhiteTheme, kchkUseOffice2010ThemePalette, kradUseOffice2010BlackTheme, kradUseOffice2010BlueTheme, kradUseOffice2010SilverTheme, kchkUseOffice2007ThemePalette, kradUseOffice2007BlackTheme, kradUseOffice2007BlueTheme, kradUseOffice2007SilverTheme, kchkUseProfessionalThemePalette, kradUseOffice2003Theme, kradUseSystemTheme, kchkUseSparkleThemePalette, kradUseSparkleBlueTheme, kradUseSparkleOrangeTheme, kradUseSparklePurpleTheme, kchkUseOtherThemePalettes, kradUseCustomTheme);
        }

        private void kradUseCustomTheme_CheckedChanged(object sender, EventArgs e)
        {
            themingManager.ApplyTheme(KryptonTheme.CUSTOM, kMan);

            if (kradUseCustomTheme.Checked)
            {

            }
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

        private void kllCurrentTheme_LinkClicked(object sender, EventArgs e)
        {
            if (!kllCurrentTheme.Text.Contains("{"))
            {
                if (File.Exists(kllCurrentTheme.Text))
                {
                    utilities.ExploreFile(kllCurrentTheme.Text);
                }
            }
        }
    }
}