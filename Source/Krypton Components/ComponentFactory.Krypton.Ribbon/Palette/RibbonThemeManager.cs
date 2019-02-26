using ComponentFactory.Krypton.Toolkit;
using System;

namespace ComponentFactory.Krypton.Ribbon 
{
    /// <summary>
    /// Allows the developer to easily access the entire array of supported themes for ribbon controls.
    /// </summary>
    public class RibbonThemeManager
    {
        #region Methods        
        /// <summary>
        /// Propagates the theme selector.
        /// </summary>
        /// <param name="target">The target.</param>
        public static void PropagateThemeSelector(KryptonRibbonGroupComboBox target)
        {
            try
            {
                foreach (string theme in Toolkit.ThemeManager.SupportedThemeArray)
                {
                    target.Items.Add(theme);
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        /// <summary>
        /// Propagates the theme selector.
        /// </summary>
        /// <param name="target">The target.</param>
        public static void PropagateThemeSelector(KryptonRibbonGroupDomainUpDown target)
        {
            try
            {
                foreach (string theme in Toolkit.ThemeManager.SupportedThemeArray)
                {
                    target.Items.Add(theme);
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        #region Built-in Redundancy
        /// <summary>
        /// Applies the theme.
        /// </summary>
        /// <param name="themeName">Name of the theme.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PaletteModeManager ApplyTheme(string themeName)
        {
            PaletteModeManager result = PaletteModeManager.Office2010Blue;

            if (themeName == "Custom") return PaletteModeManager.Custom;

            if (themeName == "Professional - System") return PaletteModeManager.ProfessionalSystem;

            if (themeName == "Professional - Office 2003") return PaletteModeManager.ProfessionalOffice2003;

            if (themeName == "Office 2007 - Blue") return PaletteModeManager.Office2007Blue;

            if (themeName == "Office 2007 - Silver") return PaletteModeManager.Office2007Silver;

            if (themeName == "Office 2007 - White") return PaletteModeManager.Office2007White;

            if (themeName == "Office 2007 - Black") return PaletteModeManager.Office2007Black;

            if (themeName == "Office 2010 - Blue") return PaletteModeManager.Office2010Blue;

            if (themeName == "Office 2010 - Silver") return PaletteModeManager.Office2010Silver;

            if (themeName == "Office 2010 - White") return PaletteModeManager.Office2010White;

            if (themeName == "Office 2010 - Black") return PaletteModeManager.Office2010Black;

            if (themeName == "Office 2013") return PaletteModeManager.Office2013;

            if (themeName == "Office 2013 - White") return PaletteModeManager.Office2013White;

            if (themeName == "Sparkle Blue") return PaletteModeManager.SparkleBlue;

            if (themeName == "Sparkle Orange") return PaletteModeManager.SparkleOrange;

            if (themeName == "Sparkle Purple") return PaletteModeManager.SparklePurple;

            if (themeName == "Office 365 - Black") return PaletteModeManager.Office365Black;

            if (themeName == "Office 365 - Blue") return PaletteModeManager.Office365Blue;

            if (themeName == "Office 365 - Silver") return PaletteModeManager.Office365Silver;

            if (themeName == "Office 365 - White") return PaletteModeManager.Office365White;

            if (string.IsNullOrEmpty(themeName))
            {
                throw new ArgumentNullException();
            }

            return result;
        }

        /// <summary>
        /// Applies the theme mode.
        /// </summary>
        /// <param name="themeName">Name of the theme.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PaletteMode ApplyThemeMode(string themeName)
        {
            PaletteMode result = PaletteMode.Office2010Blue;

            if (themeName == "Custom") return PaletteMode.Custom;

            if (themeName == "Global") return PaletteMode.Global;

            if (themeName == "Professional - System") return PaletteMode.ProfessionalSystem;

            if (themeName == "Professional - Office 2003") return PaletteMode.ProfessionalOffice2003;

            if (themeName == "Office 2007 - Blue") return PaletteMode.Office2007Blue;

            if (themeName == "Office 2007 - Silver") return PaletteMode.Office2007Silver;

            if (themeName == "Office 2007 - White") return PaletteMode.Office2007White;

            if (themeName == "Office 2007 - Black") return PaletteMode.Office2007Black;

            if (themeName == "Office 2010 - Blue") return PaletteMode.Office2010Blue;

            if (themeName == "Office 2010 - Silver") return PaletteMode.Office2010Silver;

            if (themeName == "Office 2010 - White") return PaletteMode.Office2010White;

            if (themeName == "Office 2010 - Black") return PaletteMode.Office2010Black;

            if (themeName == "Office 2013") return PaletteMode.Office2013;

            if (themeName == "Office 2013 - White") return PaletteMode.Office2013White;

            if (themeName == "Sparkle Blue") return PaletteMode.SparkleBlue;

            if (themeName == "Sparkle Orange") return PaletteMode.SparkleOrange;

            if (themeName == "Sparkle Purple") return PaletteMode.SparklePurple;

            if (themeName == "Office 365 - Black") return PaletteMode.Office365Black;

            if (themeName == "Office 365 - Blue") return PaletteMode.Office365Blue;

            if (themeName == "Office 365 - Silver") return PaletteMode.Office365Silver;

            if (themeName == "Office 365 - White") return PaletteMode.Office365White;

            if (string.IsNullOrEmpty(themeName))
            {
                throw new ArgumentNullException();
            }

            return result;
        }

        /// <summary>
        /// Returns the palette mode manager as string.
        /// </summary>
        /// <param name="paletteModeManager">The palette mode manager.</param>
        /// <param name="manager">The manager.</param>
        /// <returns></returns>
        public static string ReturnPaletteModeManagerAsString(PaletteModeManager paletteModeManager, KryptonManager manager = null)
        {
            string result = null;

            if (manager != null)
            {
                if (manager.GlobalPaletteMode == PaletteModeManager.Custom) result = "Custom";

                if (manager.GlobalPaletteMode == PaletteModeManager.ProfessionalSystem) result = "Professional - System";

                if (manager.GlobalPaletteMode == PaletteModeManager.ProfessionalOffice2003) result = "Professional - Office 2003";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2007Blue) result = "Office 2007 - Blue";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2007Silver) result = "Office 2007 - Silver";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2007White) result = "Office 2007 - White";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2007Black) result = "Office 2007 - Black";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2010Blue) result = "Office 2010 - Blue";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2010Silver) result = "Office 2010 - Silver";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2010White) result = "Office 2010 - White";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2010Black) result = "Office 2010 - Black";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2013) result = "Office 2013";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office2013White) result = "Office 2013 - White";

                if (manager.GlobalPaletteMode == PaletteModeManager.SparkleBlue) result = "Sparkle Blue";

                if (manager.GlobalPaletteMode == PaletteModeManager.SparkleOrange) result = "Sparkle Orange";

                if (manager.GlobalPaletteMode == PaletteModeManager.SparklePurple) result = "Sparkle Purple";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office365Blue) result = "Office 365 - Blue";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office365Silver) result = "Office 365 - Silver";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office365White) result = "Office 365 - White";

                if (manager.GlobalPaletteMode == PaletteModeManager.Office365Black) result = "Office 365 - Black";
            }
            else
            {
                if (paletteModeManager == PaletteModeManager.Custom) result = "Custom";

                if (paletteModeManager == PaletteModeManager.ProfessionalSystem) result = "Professional - System";

                if (paletteModeManager == PaletteModeManager.ProfessionalOffice2003) result = "Professional - Office 2003";

                if (paletteModeManager == PaletteModeManager.Office2007Blue) result = "Office 2007 - Blue";

                if (paletteModeManager == PaletteModeManager.Office2007Silver) result = "Office 2007 - Silver";

                if (paletteModeManager == PaletteModeManager.Office2007White) result = "Office 2007 - White";

                if (paletteModeManager == PaletteModeManager.Office2007Black) result = "Office 2007 - Black";

                if (paletteModeManager == PaletteModeManager.Office2010Blue) result = "Office 2010 - Blue";

                if (paletteModeManager == PaletteModeManager.Office2010Silver) result = "Office 2010 - Silver";

                if (paletteModeManager == PaletteModeManager.Office2010White) result = "Office 2010 - White";

                if (paletteModeManager == PaletteModeManager.Office2010Black) result = "Office 2010 - Black";

                if (paletteModeManager == PaletteModeManager.Office2013) result = "Office 2013";

                if (paletteModeManager == PaletteModeManager.Office2013White) result = "Office 2013 - White";

                if (paletteModeManager == PaletteModeManager.SparkleBlue) result = "Sparkle Blue";

                if (paletteModeManager == PaletteModeManager.SparkleOrange) result = "Sparkle Orange";

                if (paletteModeManager == PaletteModeManager.SparklePurple) result = "Sparkle Purple";

                if (paletteModeManager == PaletteModeManager.Office365Blue) result = "Office 365 - Blue";

                if (paletteModeManager == PaletteModeManager.Office365Silver) result = "Office 365 - Silver";

                if (paletteModeManager == PaletteModeManager.Office365White) result = "Office 365 - White";

                if (paletteModeManager == PaletteModeManager.Office365Black) result = "Office 365 - Black";
            }

            return result;
        }

        /// <summary>
        /// Returns the palette mode as string.
        /// </summary>
        /// <param name="paletteMode">The palette mode.</param>
        /// <returns></returns>
        public static string ReturnPaletteModeAsString(PaletteMode paletteMode)
        {
            string result = null;

            if (paletteMode == PaletteMode.Custom) result = "Custom";

            if (paletteMode == PaletteMode.Global) result = "Global";

            if (paletteMode == PaletteMode.ProfessionalSystem) result = "Professional - System";

            if (paletteMode == PaletteMode.ProfessionalOffice2003) result = "Professional - Office 2003";

            if (paletteMode == PaletteMode.Office2007Blue) result = "Office 2007 - Blue";

            if (paletteMode == PaletteMode.Office2007Silver) result = "Office 2007 - Silver";

            if (paletteMode == PaletteMode.Office2007White) result = "Office 2007 - White";

            if (paletteMode == PaletteMode.Office2007Black) result = "Office 2007 - Black";

            if (paletteMode == PaletteMode.Office2010Blue) result = "Office 2010 - Blue";

            if (paletteMode == PaletteMode.Office2010Silver) result = "Office 2010 - Silver";

            if (paletteMode == PaletteMode.Office2010White) result = "Office 2010 - White";

            if (paletteMode == PaletteMode.Office2010Black) result = "Office 2010 - Black";

            if (paletteMode == PaletteMode.Office2013) result = "Office 2013";

            if (paletteMode == PaletteMode.Office2013White) result = "Office 2013 - White";

            if (paletteMode == PaletteMode.SparkleBlue) result = "Sparkle Blue";

            if (paletteMode == PaletteMode.SparkleOrange) result = "Sparkle Orange";

            if (paletteMode == PaletteMode.SparklePurple) result = "Sparkle Purple";

            if (paletteMode == PaletteMode.Office365Blue) result = "Office 365 - Blue";

            if (paletteMode == PaletteMode.Office365Silver) result = "Office 365 - Silver";

            if (paletteMode == PaletteMode.Office365White) result = "Office 365 - White";

            if (paletteMode == PaletteMode.Office365Black) result = "Office 365 - Black";

            return result;
        }

        /// <summary>
        /// Applies the global theme.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="paletteModeManager">The palette mode manager.</param>
        public static void ApplyGlobalTheme(KryptonManager manager, PaletteModeManager paletteModeManager)
        {
            try
            {
                manager.GlobalPaletteMode = paletteModeManager;
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        /// <summary>
        /// Applies the global theme.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="mode">The theme mode.</param>
        public static void ApplyGlobalTheme(KryptonManager manager, PaletteMode mode)
        {
            try
            {
                manager.GlobalPaletteMode = (PaletteModeManager)mode;
            }
            catch (Exception exc)
            {

                throw;
            }
        }
        #endregion

        #endregion
    }
}