// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Allows the developer to easily access the entire array of supported themes for custom controls.
    /// </summary>
    public class ThemeManager
    {
        #region Theme Array        
        /// <summary>
        /// The supported themes
        /// </summary>
        private static string[] _supportedThemes = new string[]
        {
             "Professional - System",

            "Professional - Office 2003",

            "Office 2007 - Black",

            "Office 2007 - Blue",

            "Office 2007 - Silver",

            "Office 2007 - White",

            "Office 2010 - Black",

            "Office 2010 - Blue",

            "Office 2010 - Silver",

            "Office 2010 - White",

            "Office 2013",

            "Office 2013 - White",

            "Office 365 - Black",

            "Office 365 - Blue",

            "Office 365 - Silver",

            "Office 365 - White",

            "Sparkle - Blue",

            "Sparkle - Orange",

            "Sparkle - Purple",

            "Custom"
        };
        #endregion

        #region Properties        
        /// <summary>
        /// Gets the supported theme array.
        /// </summary>
        /// <value>
        /// The supported theme array.
        /// </value>
        public static string[] SupportedThemeArray { get => _supportedThemes; }
        #endregion

        #region Methods        
        /// <summary>
        /// Applies the theme.
        /// </summary>
        /// <param name="themeName">Name of the theme.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PaletteModeManager ApplyTheme(string themeName)
        {
            if (themeName == "Custom") return PaletteModeManager.Custom;

            if (themeName == "") return PaletteModeManager.ProfessionalSystem;

            if (themeName == "") return PaletteModeManager.ProfessionalOffice2003;

            if (themeName == "") return PaletteModeManager.Office2007Blue;

            if (themeName == "") return PaletteModeManager.Office2007Silver;

            if (themeName == "") return PaletteModeManager.Office2007White;

            if (themeName == "") return PaletteModeManager.Office2007Black;

            if (themeName == "") return PaletteModeManager.Office2010Blue;

            if (themeName == "") return PaletteModeManager.Office2010Silver;

            if (themeName == "") return PaletteModeManager.Office2010White;

            if (themeName == "") return PaletteModeManager.Office2010Black;

            if (themeName == "") return PaletteModeManager.Office2013;

            if (themeName == "") return PaletteModeManager.Office2013White;

            if (themeName == "") return PaletteModeManager.SparkleBlue;

            if (themeName == "") return PaletteModeManager.SparkleOrange;

            if (themeName == "") return PaletteModeManager.SparklePurple;

            if (themeName == "") return PaletteModeManager.Office365Black;

            if (themeName == "") return PaletteModeManager.Office365Blue;

            if (themeName == "") return PaletteModeManager.Office365Silver;

            if (themeName == "") return PaletteModeManager.Office365White;

            if (string.IsNullOrEmpty(themeName))
            {
                throw new ArgumentNullException();

                return PaletteModeManager.Office2010Blue;
            }

            return PaletteModeManager.Office2010Blue;
        }
        #endregion
    }
}