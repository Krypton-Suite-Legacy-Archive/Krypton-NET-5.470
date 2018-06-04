using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Enumerations;

namespace KryptonToolkitUpdater.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class ControlController
    {
        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="ControlController"/> class.
        /// </summary>
        public ControlController()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Toggles the control states.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="office2013ThemePalette">The office 2013 theme palette.</param>
        /// <param name="office2013SilverTheme">The office 2013 silver theme.</param>
        /// <param name="office2013WhiteTheme">The office 2013 white theme.</param>
        /// <param name="office2010ThemePalette">The office 2010 theme palette.</param>
        /// <param name="office2010BlackTheme">The office 2010 black theme.</param>
        /// <param name="office2010BlueTheme">The office 2010 blue theme.</param>
        /// <param name="office2010SilverTheme">The office 2010 silver theme.</param>
        /// <param name="office2007ThemePalette">The office 2007 theme palette.</param>
        /// <param name="office2007BlackTheme">The office 2007 black theme.</param>
        /// <param name="office2007BlueTheme">The office 2007 blue theme.</param>
        /// <param name="office2007SilverTheme">The office 2007 silver theme.</param>
        /// <param name="professionalThemePalette">The professional theme palette.</param>
        /// <param name="professionalOffice2003Theme">The professional office2003 theme.</param>
        /// <param name="professionalSystemTheme">The professional system theme.</param>
        /// <param name="sparkleThemePalette">The sparkle theme palette.</param>
        /// <param name="sparkleBlueTheme">The sparkle blue theme.</param>
        /// <param name="sparkleOrangeTheme">The sparkle orange theme.</param>
        /// <param name="sparklePurpleTheme">The sparkle purple theme.</param>
        /// <param name="otherThemePalettes">The other theme palettes.</param>
        /// <param name="customTheme">The custom theme.</param>
        public void ToggleControlStates(SuppotedKryptonThemePalettes palette, KryptonCheckBox office2013ThemePalette, KryptonRadioButton office2013SilverTheme, KryptonRadioButton office2013WhiteTheme, KryptonCheckBox office2010ThemePalette, KryptonRadioButton office2010BlackTheme, KryptonRadioButton office2010BlueTheme, KryptonRadioButton office2010SilverTheme, KryptonCheckBox office2007ThemePalette, KryptonRadioButton office2007BlackTheme, KryptonRadioButton office2007BlueTheme, KryptonRadioButton office2007SilverTheme, KryptonCheckBox professionalThemePalette, KryptonRadioButton professionalOffice2003Theme, KryptonRadioButton professionalSystemTheme, KryptonCheckBox sparkleThemePalette, KryptonRadioButton sparkleBlueTheme, KryptonRadioButton sparkleOrangeTheme, KryptonRadioButton sparklePurpleTheme, KryptonCheckBox otherThemePalettes, KryptonRadioButton customTheme)
        {
            switch (palette)
            {
                case SuppotedKryptonThemePalettes.OTHERTHEMEPALETTE:
                    office2013ThemePalette.Checked = false;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = false;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = false;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = false;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = false;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = true;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.OTHERTHEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2013THEMEPALETTE:
                    office2013ThemePalette.Checked = true;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = false;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = false;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = false;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = false;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = false;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.OFFICE2013THEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE:
                    office2013ThemePalette.Checked = false;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = false;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = true;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = false;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = false;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = false;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2007THEMEPALETTE:
                    office2013ThemePalette.Checked = false;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = true;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = false;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = false;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = false;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = false;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
                case SuppotedKryptonThemePalettes.PROFESSIONALTHEMEPALETTE:
                    office2013ThemePalette.Checked = false;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = false;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = false;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = true;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = false;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = false;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.PROFESSIONALTHEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
                case SuppotedKryptonThemePalettes.SPARKLETHEMEPALETTE:
                    office2013ThemePalette.Checked = false;

                    office2013SilverTheme.Checked = false;

                    office2013WhiteTheme.Checked = false;

                    office2007ThemePalette.Checked = false;

                    office2007BlackTheme.Checked = false;

                    office2007BlueTheme.Checked = false;

                    office2007SilverTheme.Checked = false;

                    office2010ThemePalette.Checked = false;

                    office2010BlackTheme.Checked = false;

                    office2010BlueTheme.Checked = false;

                    office2010SilverTheme.Checked = false;

                    professionalThemePalette.Checked = false;

                    professionalOffice2003Theme.Checked = false;

                    professionalSystemTheme.Checked = false;

                    sparkleThemePalette.Checked = true;

                    sparkleBlueTheme.Checked = false;

                    sparkleOrangeTheme.Checked = false;

                    sparklePurpleTheme.Checked = false;

                    otherThemePalettes.Checked = false;

                    customTheme.Checked = false;

                    ToggleThemingControls(SuppotedKryptonThemePalettes.SPARKLETHEMEPALETTE, office2013SilverTheme, office2013WhiteTheme, office2010BlackTheme, office2010BlueTheme, office2010SilverTheme, office2007BlackTheme, office2007BlueTheme, office2007SilverTheme, professionalOffice2003Theme, professionalSystemTheme, sparkleBlueTheme, sparkleOrangeTheme, sparklePurpleTheme, customTheme);
                    break;
            }
        }

        /// <summary>
        /// Toggles the theming controls.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="office2013SilverTheme">The office2013 silver theme.</param>
        /// <param name="office2013WhiteTheme">The office2013 white theme.</param>
        /// <param name="office2010BlackTheme">The office2010 black theme.</param>
        /// <param name="office2010BlueTheme">The office2010 blue theme.</param>
        /// <param name="office2010SilverTheme">The office2010 silver theme.</param>
        /// <param name="office2007BlackTheme">The office2007 black theme.</param>
        /// <param name="office2007BlueTheme">The office2007 blue theme.</param>
        /// <param name="office2007SilverTheme">The office2007 silver theme.</param>
        /// <param name="professionalOffice2003Theme">The professional office2003 theme.</param>
        /// <param name="professionalSystemTheme">The professional system theme.</param>
        /// <param name="sparkleBlueTheme">The sparkle blue theme.</param>
        /// <param name="sparkleOrangeTheme">The sparkle orange theme.</param>
        /// <param name="sparklePurpleTheme">The sparkle purple theme.</param>
        /// <param name="customTheme">The custom theme.</param>
        private void ToggleThemingControls(SuppotedKryptonThemePalettes palette, KryptonRadioButton office2013SilverTheme, KryptonRadioButton office2013WhiteTheme, KryptonRadioButton office2010BlackTheme, KryptonRadioButton office2010BlueTheme, KryptonRadioButton office2010SilverTheme, KryptonRadioButton office2007BlackTheme, KryptonRadioButton office2007BlueTheme, KryptonRadioButton office2007SilverTheme, KryptonRadioButton professionalOffice2003Theme, KryptonRadioButton professionalSystemTheme, KryptonRadioButton sparkleBlueTheme, KryptonRadioButton sparkleOrangeTheme, KryptonRadioButton sparklePurpleTheme, KryptonRadioButton customTheme)
        {
            switch (palette)
            {
                case SuppotedKryptonThemePalettes.OTHERTHEMEPALETTE:
                    office2013SilverTheme.Enabled = false;

                    office2013WhiteTheme.Enabled = false;

                    office2007BlackTheme.Enabled = false;

                    office2007BlueTheme.Enabled = false;

                    office2007SilverTheme.Enabled = false;

                    office2010BlackTheme.Enabled = false;

                    office2010BlueTheme.Enabled = false;

                    office2010SilverTheme.Enabled = false;

                    professionalOffice2003Theme.Enabled = false;

                    professionalSystemTheme.Enabled = false;

                    sparkleBlueTheme.Enabled = false;

                    sparkleOrangeTheme.Enabled = false;

                    sparklePurpleTheme.Enabled = false;

                    customTheme.Enabled = true;

                    customTheme.Checked = true;
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2013THEMEPALETTE:
                    office2013SilverTheme.Enabled = true;

                    office2013SilverTheme.Checked = true;

                    office2013WhiteTheme.Enabled = true;

                    office2007BlackTheme.Enabled = false;

                    office2007BlueTheme.Enabled = false;

                    office2007SilverTheme.Enabled = false;

                    office2010BlackTheme.Enabled = false;

                    office2010BlueTheme.Enabled = false;

                    office2010SilverTheme.Enabled = false;

                    professionalOffice2003Theme.Enabled = false;

                    professionalSystemTheme.Enabled = false;

                    sparkleBlueTheme.Enabled = false;

                    sparkleOrangeTheme.Enabled = false;

                    sparklePurpleTheme.Enabled = false;

                    customTheme.Enabled = false;
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE:
                    office2013SilverTheme.Enabled = false;

                    office2013WhiteTheme.Enabled = false;

                    office2007BlackTheme.Enabled = false;

                    office2007BlueTheme.Enabled = false;

                    office2007SilverTheme.Enabled = false;

                    office2010BlackTheme.Enabled = true;

                    office2010BlackTheme.Checked = true;

                    office2010BlueTheme.Enabled = true;

                    office2010SilverTheme.Enabled = true;

                    professionalOffice2003Theme.Enabled = false;

                    professionalSystemTheme.Enabled = false;

                    sparkleBlueTheme.Enabled = false;

                    sparkleOrangeTheme.Enabled = false;

                    sparklePurpleTheme.Enabled = false;

                    customTheme.Enabled = false;
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2007THEMEPALETTE:
                    office2013SilverTheme.Enabled = false;

                    office2013WhiteTheme.Enabled = false;

                    office2007BlackTheme.Enabled = true;

                    office2007BlackTheme.Checked = true;

                    office2007BlueTheme.Enabled = true;

                    office2007SilverTheme.Enabled = true;

                    office2010BlackTheme.Enabled = false;

                    office2010BlueTheme.Enabled = false;

                    office2010SilverTheme.Enabled = false;

                    professionalOffice2003Theme.Enabled = false;

                    professionalSystemTheme.Enabled = false;

                    sparkleBlueTheme.Enabled = false;

                    sparkleOrangeTheme.Enabled = false;

                    sparklePurpleTheme.Enabled = false;

                    customTheme.Enabled = false;
                    break;
                case SuppotedKryptonThemePalettes.PROFESSIONALTHEMEPALETTE:
                    office2013SilverTheme.Enabled = false;

                    office2013WhiteTheme.Enabled = false;

                    office2007BlackTheme.Enabled = false;

                    office2007BlueTheme.Enabled = false;

                    office2007SilverTheme.Enabled = false;

                    office2010BlackTheme.Enabled = false;

                    office2010BlueTheme.Enabled = false;

                    office2010SilverTheme.Enabled = false;

                    professionalOffice2003Theme.Enabled = true;

                    professionalOffice2003Theme.Checked = true;

                    professionalSystemTheme.Enabled = true;

                    sparkleBlueTheme.Enabled = false;

                    sparkleOrangeTheme.Enabled = false;

                    sparklePurpleTheme.Enabled = false;

                    customTheme.Enabled = false;
                    break;
                case SuppotedKryptonThemePalettes.SPARKLETHEMEPALETTE:
                    office2013SilverTheme.Enabled = false;

                    office2013WhiteTheme.Enabled = false;

                    office2007BlackTheme.Enabled = false;

                    office2007BlueTheme.Enabled = false;

                    office2007SilverTheme.Enabled = false;

                    office2010BlackTheme.Enabled = false;

                    office2010BlueTheme.Enabled = false;

                    office2010SilverTheme.Enabled = false;

                    professionalOffice2003Theme.Enabled = false;

                    professionalSystemTheme.Enabled = false;

                    sparkleBlueTheme.Enabled = true;

                    sparkleBlueTheme.Checked = true;

                    sparkleOrangeTheme.Enabled = true;

                    sparklePurpleTheme.Enabled = true;

                    customTheme.Enabled = false;
                    break;
            }
        }
        #endregion
    }
}