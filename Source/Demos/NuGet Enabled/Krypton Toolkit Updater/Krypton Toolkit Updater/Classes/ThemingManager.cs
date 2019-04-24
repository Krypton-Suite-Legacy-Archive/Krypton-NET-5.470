using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitUpdater.Enumerations;

namespace KryptonToolkitUpdater.Classes
{
    /// <summary>
    /// Manages theme palettes.
    /// </summary>
    public class ThemingManager
    {
        #region Variables
        ThemeSettingsHelper _themeSettingsHelper = new ThemeSettingsHelper();
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="ThemingManager"/> class.
        /// </summary>
        public ThemingManager()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Applies the theme.
        /// </summary>
        /// <param name="theme">The theme.</param>
        /// <param name="manager">The manager.</param>
        public void ApplyTheme(KryptonTheme theme, KryptonManager manager)
        {
            _themeSettingsHelper.SetTheme(theme);

            switch (theme)
            {
                case KryptonTheme.OFFICE2013SILVER:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case KryptonTheme.OFFICE2013WHITE:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case KryptonTheme.OFFICE2010BLACK:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case KryptonTheme.OFFICE2010BLUE:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case KryptonTheme.OFFICE2010SILVER:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case KryptonTheme.OFFICE2007BLACK:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case KryptonTheme.OFFICE2007BLUE:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case KryptonTheme.OFFICE2007SILVER:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case KryptonTheme.PROFESSIONALOFFICE2003:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case KryptonTheme.PROFESSIONALSYSTEM:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case KryptonTheme.SPARKLEBLUE:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case KryptonTheme.SPARKLEORANGE:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case KryptonTheme.SPARKLEPURPLE:
                    manager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
                    break;
                case KryptonTheme.CUSTOM:
                    manager.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
            }
        }
        #endregion
    }
}