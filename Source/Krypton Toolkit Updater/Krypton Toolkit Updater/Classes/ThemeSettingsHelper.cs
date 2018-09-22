using Krypton.Toolkit;
using KryptonToolkitUpdater.Enumerations;
using KryptonToolkitUpdater.Settings;
using System.Windows.Forms;

namespace KryptonToolkitUpdater.Classes
{
    /// <summary>
    /// Modifies values in <see cref="ThemeSettings"/>.
    /// </summary>
    public class ThemeSettingsHelper
    {
        #region Variables
        ThemeSettings _themeSettings = new ThemeSettings();
        #endregion

        #region Constructors        
        /// <summary>
        /// Initialises a new instance of the <see cref="ThemeSettingsHelper"/> class.
        /// </summary>
        public ThemeSettingsHelper()
        {

        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ThemeSettingsHelper"/> class.
        /// </summary>
        /// <param name="theme">The theme.</param>
        public ThemeSettingsHelper(KryptonTheme theme)
        {
            SetTheme(theme);
        }
        #endregion

        #region Setters & Getters

        #region Booleans
        /// <summary>
        /// Sets the UseOffice2013ThemePalette to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2013ThemePalette.</param>
        public void SetUseOffice2013ThemePalette(bool value)
        {
            _themeSettings.UseOffice2013ThemePalette = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2013ThemePalette.
        /// </summary>
        /// <returns>The value of the UseOffice2013ThemePalette.</returns>
        public bool GetUseOffice2013ThemePalette()
        {
            return _themeSettings.UseOffice2013ThemePalette;
        }

        /// <summary>
        /// Sets the UseOffice2013SilverTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2013SilverTheme.</param>
        public void SetUseOffice2013SilverTheme(bool value)
        {
            _themeSettings.UseOffice2013SilverTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2013SilverTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2013SilverTheme.</returns>
        public bool GetUseOffice2013SilverTheme()
        {
            return _themeSettings.UseOffice2013SilverTheme;
        }

        /// <summary>
        /// Sets the UseOffice2013WhiteTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2013WhiteTheme.</param>
        public void SetUseOffice2013WhiteTheme(bool value)
        {
            _themeSettings.UseOffice2013WhiteTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2013WhiteTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2013WhiteTheme.</returns>
        public bool GetUseOffice2013WhiteTheme()
        {
            return _themeSettings.UseOffice2013WhiteTheme;
        }

        /// <summary>
        /// Sets the UseOffice2010ThemePalette to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2010ThemePalette.</param>
        public void SetUseOffice2010ThemePalette(bool value)
        {
            _themeSettings.UseOffice2010ThemePalette = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2010ThemePalette.
        /// </summary>
        /// <returns>The value of the UseOffice2010ThemePalette.</returns>
        public bool GetUseOffice2010ThemePalette()
        {
            return _themeSettings.UseOffice2010ThemePalette;
        }

        /// <summary>
        /// Sets the UseOffice2010BlackTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2010BlackTheme.</param>
        public void SetUseOffice2010BlackTheme(bool value)
        {
            _themeSettings.UseOffice2010BlackTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2010BlackTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2010BlackTheme.</returns>
        public bool GetUseOffice2010BlackTheme()
        {
            return _themeSettings.UseOffice2010BlackTheme;
        }

        /// <summary>
        /// Sets the UseOffice2010BlueTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2010BlueTheme.</param>
        public void SetUseOffice2010BlueTheme(bool value)
        {
            _themeSettings.UseOffice2010BlueTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2010BlueTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2010BlueTheme.</returns>
        public bool GetUseOffice2010BlueTheme()
        {
            return _themeSettings.UseOffice2010BlueTheme;
        }

        /// <summary>
        /// Sets the UseOffice2010SilverTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2010SilverTheme.</param>
        public void SetUseOffice2010SilverTheme(bool value)
        {
            _themeSettings.UseOffice2010SilverTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2010SilverTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2010SilverTheme.</returns>
        public bool GetUseOffice2010SilverTheme()
        {
            return _themeSettings.UseOffice2010SilverTheme;
        }

        /// <summary>
        /// Sets the UseOffice2007ThemePalette to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2007ThemePalette.</param>
        public void SetUseOffice2007ThemePalette(bool value)
        {
            _themeSettings.UseOffice2007ThemePalette = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2007ThemePalette.
        /// </summary>
        /// <returns>The value of the UseOffice2007ThemePalette.</returns>
        public bool GetUseOffice2007ThemePalette()
        {
            return _themeSettings.UseOffice2007ThemePalette;
        }

        /// <summary>
        /// Sets the UseOffice2007BlackTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2007BlackTheme.</param>
        public void SetUseOffice2007BlackTheme(bool value)
        {
            _themeSettings.UseOffice2007BlackTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2007BlackTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2007BlackTheme.</returns>
        public bool GetUseOffice2007BlackTheme()
        {
            return _themeSettings.UseOffice2007BlackTheme;
        }

        /// <summary>
        /// Sets the UseOffice2007BlueTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2007BlueTheme.</param>
        public void SetUseOffice2007BlueTheme(bool value)
        {
            _themeSettings.UseOffice2007BlueTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2007BlueTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2007BlueTheme.</returns>
        public bool GetUseOffice2007BlueTheme()
        {
            return _themeSettings.UseOffice2007BlueTheme;
        }

        /// <summary>
        /// Sets the UseOffice2007SilverTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOffice2007SilverTheme.</param>
        public void SetUseOffice2007SilverTheme(bool value)
        {
            _themeSettings.UseOffice2007SilverTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseOffice2007SilverTheme.
        /// </summary>
        /// <returns>The value of the UseOffice2007SilverTheme.</returns>
        public bool GetUseOffice2007SilverTheme()
        {
            return _themeSettings.UseOffice2007SilverTheme;
        }

        /// <summary>
        /// Sets the UseProfessionalThemePalette to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseProfessionalThemePalette.</param>
        public void SetUseProfessionalThemePalette(bool value)
        {
            _themeSettings.UseProfessionalThemePalette = value;
        }

        /// <summary>
        /// Returns the value of the UseProfessionalThemePalette.
        /// </summary>
        /// <returns>The value of the UseProfessionalThemePalette.</returns>
        public bool GetUseProfessionalThemePalette()
        {
            return _themeSettings.UseProfessionalThemePalette;
        }

        /// <summary>
        /// Sets the UseProfessionalOffice2003Theme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseProfessionalOffice2003Theme.</param>
        public void SetUseProfessionalOffice2003Theme(bool value)
        {
            _themeSettings.UseProfessionalOffice2003Theme = value;
        }

        /// <summary>
        /// Returns the value of the UseProfessionalOffice2003Theme.
        /// </summary>
        /// <returns>The value of the UseProfessionalOffice2003Theme.</returns>
        public bool GetUseProfessionalOffice2003Theme()
        {
            return _themeSettings.UseProfessionalOffice2003Theme;
        }

        /// <summary>
        /// Sets the UseProfessionalSystemTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseProfessionalSystemTheme.</param>
        public void SetUseProfessionalSystemTheme(bool value)
        {
            _themeSettings.UseProfessionalSystemTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseProfessionalSystemTheme.
        /// </summary>
        /// <returns>The value of the UseProfessionalSystemTheme.</returns>
        public bool GetUseProfessionalSystemTheme()
        {
            return _themeSettings.UseProfessionalSystemTheme;
        }

        /// <summary>
        /// Sets the UseSparkleThemePalette to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseSparkleThemePalette.</param>
        public void SetUseSparkleThemePalette(bool value)
        {
            _themeSettings.UseSparkleThemePalette = value;
        }

        /// <summary>
        /// Returns the value of the UseSparkleThemePalette.
        /// </summary>
        /// <returns>The value of the UseSparkleThemePalette.</returns>
        public bool GetUseSparkleThemePalette()
        {
            return _themeSettings.UseSparkleThemePalette;
        }

        /// <summary>
        /// Sets the UseSparkleBlueTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseSparkleBlueTheme.</param>
        public void SetUseSparkleBlueTheme(bool value)
        {
            _themeSettings.UseSparkleBlueTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseSparkleBlueTheme.
        /// </summary>
        /// <returns>The value of the UseSparkleBlueTheme.</returns>
        public bool GetUseSparkleBlueTheme()
        {
            return _themeSettings.UseSparkleBlueTheme;
        }

        /// <summary>
        /// Sets the UseSparkleOrangeTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseSparkleOrangeTheme.</param>
        public void SetUseSparkleOrangeTheme(bool value)
        {
            _themeSettings.UseSparkleOrangeTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseSparkleOrangeTheme.
        /// </summary>
        /// <returns>The value of the UseSparkleOrangeTheme.</returns>
        public bool GetUseSparkleOrangeTheme()
        {
            return _themeSettings.UseSparkleOrangeTheme;
        }

        /// <summary>
        /// Sets the UseSparklePurpleTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseSparklePurpleTheme.</param>
        public void SetUseSparklePurpleTheme(bool value)
        {
            _themeSettings.UseSparklePurpleTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseSparklePurpleTheme.
        /// </summary>
        /// <returns>The value of the UseSparklePurpleTheme.</returns>
        public bool GetUseSparklePurpleTheme()
        {
            return _themeSettings.UseSparklePurpleTheme;
        }

        /// <summary>
        /// Sets the UseOtherThemePalettes to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseOtherThemePalettes.</param>
        public void SetUseOtherThemePalettes(bool value)
        {
            _themeSettings.UseOtherThemePalettes = value;
        }

        /// <summary>
        /// Returns the value of the UseOtherThemePalettes.
        /// </summary>
        /// <returns>The value of the UseOtherThemePalettes.</returns>
        public bool GetUseOtherThemePalettes()
        {
            return _themeSettings.UseOtherThemePalettes;
        }

        /// <summary>
        /// Sets the UseCustomTheme to the value of value.
        /// </summary>
        /// <param name="value">The desired value of UseCustomTheme.</param>
        public void SetUseCustomTheme(bool value)
        {
            _themeSettings.UseCustomTheme = value;
        }

        /// <summary>
        /// Returns the value of the UseCustomTheme.
        /// </summary>
        /// <returns>The value of the UseCustomTheme.</returns>
        public bool GetUseCustomTheme()
        {
            return _themeSettings.UseCustomTheme;
        }
        #endregion

        #region Strings
        /// <summary>
        /// Sets the CustomThemePaletteFileLocation to the value of fileLocation.
        /// </summary>
        /// <param name="fileLocation">The desired value of CustomThemePaletteFileLocation.</param>
        public void SetCustomThemePaletteFileLocation(string fileLocation)
        {
            _themeSettings.CustomThemePaletteFileLocation = fileLocation;
        }

        /// <summary>
        /// Returns the value of the CustomThemePaletteFileLocation.
        /// </summary>
        /// <returns>The value of the CustomThemePaletteFileLocation.</returns>
        public string GetCustomThemePaletteFileLocation()
        {
            return _themeSettings.CustomThemePaletteFileLocation;
        }
        #endregion

        #endregion

        #region Methods        
        /// <summary>
        /// Sets the theme.
        /// </summary>
        /// <param name="theme">The theme.</param>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void SetTheme(KryptonTheme theme, bool showConfirmationDialogue = false)
        {
            switch (theme)
            {
                case KryptonTheme.OFFICE2013SILVER:
                    SetUseOffice2013ThemePalette(true);

                    SetUseOffice2013SilverTheme(true);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2013WHITE:
                    SetUseOffice2013ThemePalette(true);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(true);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2010BLACK:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(true);

                    SetUseOffice2010BlackTheme(true);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2010BLUE:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(true);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(true);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2010SILVER:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(true);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(true);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2007BLACK:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(true);

                    SetUseOffice2007BlackTheme(true);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2007BLUE:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(true);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(true);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.OFFICE2007SILVER:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(true);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(true);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.PROFESSIONALOFFICE2003:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(true);

                    SetUseProfessionalOffice2003Theme(true);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.PROFESSIONALSYSTEM:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(true);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(true);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.SPARKLEBLUE:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(true);

                    SetUseSparkleBlueTheme(true);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.SPARKLEORANGE:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(true);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(true);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.SPARKLEPURPLE:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(true);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(true);

                    SetUseOtherThemePalettes(false);

                    SetUseCustomTheme(false);
                    break;
                case KryptonTheme.CUSTOM:
                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2013SilverTheme(false);

                    SetUseOffice2013WhiteTheme(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2010BlackTheme(false);

                    SetUseOffice2010BlueTheme(false);

                    SetUseOffice2010SilverTheme(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseOffice2007BlackTheme(false);

                    SetUseOffice2007BlueTheme(false);

                    SetUseOffice2007SilverTheme(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseProfessionalOffice2003Theme(false);

                    SetUseProfessionalSystemTheme(false);

                    SetUseSparkleThemePalette(false);

                    SetUseSparkleBlueTheme(false);

                    SetUseSparkleOrangeTheme(false);

                    SetUseSparklePurpleTheme(false);

                    SetUseOtherThemePalettes(true);

                    SetUseCustomTheme(true);
                    break;
            }

            SaveThemeSettings(showConfirmationDialogue);
        }

        /// <summary>
        /// Sets the theme palette.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void SetThemePalette(SuppotedKryptonThemePalettes palette, bool showConfirmationDialogue = false)
        {
            switch (palette)
            {
                case SuppotedKryptonThemePalettes.OTHERTHEMEPALETTE:
                    SetUseOtherThemePalettes(true);

                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(false);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2013THEMEPALETTE:
                    SetUseOtherThemePalettes(false);

                    SetUseOffice2013ThemePalette(true);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(false);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2010THEMEPALETTE:
                    SetUseOtherThemePalettes(false);

                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2010ThemePalette(true);

                    SetUseOffice2007ThemePalette(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(false);
                    break;
                case SuppotedKryptonThemePalettes.OFFICE2007THEMEPALETTE:
                    SetUseOtherThemePalettes(false);

                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2007ThemePalette(true);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(false);
                    break;
                case SuppotedKryptonThemePalettes.PROFESSIONALTHEMEPALETTE:
                    SetUseOtherThemePalettes(true);

                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(false);
                    break;
                case SuppotedKryptonThemePalettes.SPARKLETHEMEPALETTE:
                    SetUseOtherThemePalettes(false);

                    SetUseOffice2013ThemePalette(false);

                    SetUseOffice2010ThemePalette(false);

                    SetUseOffice2007ThemePalette(false);

                    SetUseProfessionalThemePalette(false);

                    SetUseSparkleThemePalette(true);
                    break;
            }

            SaveThemeSettings(showConfirmationDialogue);
        }

        /// <summary>
        /// Saves the theme settings.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void SaveThemeSettings(bool showConfirmationDialogue = true)
        {
            if (showConfirmationDialogue)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current values?", "Save Current Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    _themeSettings.Save();
                }
            }
            else
            {
                _themeSettings.Save();
            }
        }

        /// <summary>
        /// Resets the theme settings back to default.
        /// </summary>
        /// <param name="showConfirmationDialogue">if set to <c>true</c> [show confirmation dialogue].</param>
        public void ResetThemeSettingsBackToDefault(bool showConfirmationDialogue = true)
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

            SaveThemeSettings(showConfirmationDialogue);
        }

        //public KryptonTheme GetCurrentTheme()
        //{
        //    KryptonTheme theme;



        //    return theme;
        //}
        #endregion
    }
}