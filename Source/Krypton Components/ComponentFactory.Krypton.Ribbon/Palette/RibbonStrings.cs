// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Storage for string related properties.
	/// </summary>
    public class RibbonStrings : Storage
    {
        #region Static Fields

        private const string DEFAULT_APP_BUTTON_KEY_TIP = "F";
        private const string DEFAULT_CUSTOMIZE_QUICK_ACCESS_TOOLBAR = "Customize Quick Access Toolbar";
        private const string DEFAULT_MINIMIZE = "Mi&nimize the Ribbon";
        private const string DEFAULT_MORE_COLORS = "&More Colors...";
        private const string DEFAULT_NO_COLOR = "&No Color";
        private const string DEFAULT_RECENT_DOCUMENTS = "Recent Documents";
        private const string DEFAULT_RECENT_COLORS = "Recent Colors";
        private const string DEFAULT_SHOW_QAT_ABOVE_RIBBON = "&Show Quick Access Toolbar Above the Ribbon";
        private const string DEFAULT_SHOW_QAT_BELOW_RIBBON = "&Show Quick Access Toolbar Below the Ribbon";
        private const string DEFAULT_SHOW_ABOVE_RIBBON = "&Show Above the Ribbon";
        private const string DEFAULT_SHOW_BELOW_RIBBON = "&Show Below the Ribbon";
        private const string DEFAULT_STANDARD_COLORS = "Standard Colors";
        private const string DEFAULT_THEME_COLORS = "Theme Colors";

        #endregion

        #region Instance Fields
        private string _appButtonKeyTip;
        private string _customizeQuickAccessToolbar;
        private string _minimize;
        private string _moreColors;
        private string _noColor;
        private string _recentDocuments;
        private string _recentColors;
        private string _showAboveRibbon;
        private string _showBelowRibbon;
        private string _showQATAboveRibbon;
        private string _showQATBelowRibbon;
        private string _standardColors;
        private string _themeColors;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the RibbonStrings class.
		/// </summary>
        public RibbonStrings()
		{
            // Default values
            _appButtonKeyTip = DEFAULT_APP_BUTTON_KEY_TIP;
            _customizeQuickAccessToolbar = DEFAULT_CUSTOMIZE_QUICK_ACCESS_TOOLBAR;
            _minimize = DEFAULT_MINIMIZE;
            _moreColors = DEFAULT_MORE_COLORS;
            _noColor = DEFAULT_NO_COLOR;
            _recentDocuments = DEFAULT_RECENT_DOCUMENTS;
            _recentColors = DEFAULT_RECENT_COLORS;
            _showAboveRibbon = DEFAULT_SHOW_ABOVE_RIBBON;
            _showBelowRibbon = DEFAULT_SHOW_BELOW_RIBBON;
            _showQATAboveRibbon = DEFAULT_SHOW_QAT_ABOVE_RIBBON;
            _showQATBelowRibbon = DEFAULT_SHOW_QAT_BELOW_RIBBON;
            _standardColors = DEFAULT_STANDARD_COLORS;
            _themeColors = DEFAULT_THEME_COLORS;
        }
		#endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return (AppButtonKeyTip.Equals(DEFAULT_APP_BUTTON_KEY_TIP)) &&
                       (CustomizeQuickAccessToolbar.Equals(DEFAULT_CUSTOMIZE_QUICK_ACCESS_TOOLBAR)) &&
                       (Minimize.Equals(DEFAULT_MINIMIZE)) &&
                       (MoreColors.Equals(DEFAULT_MORE_COLORS)) &&
                       (NoColor.Equals(DEFAULT_NO_COLOR)) &&
                       (RecentDocuments.Equals(DEFAULT_RECENT_DOCUMENTS)) &&
                       (RecentColors.Equals(DEFAULT_RECENT_COLORS)) &&
                       (ShowAboveRibbon.Equals(DEFAULT_SHOW_ABOVE_RIBBON)) &&
                       (ShowBelowRibbon.Equals(DEFAULT_SHOW_BELOW_RIBBON)) &&
                       (ShowQATAboveRibbon.Equals(DEFAULT_SHOW_QAT_ABOVE_RIBBON)) &&
                       (ShowQATBelowRibbon.Equals(DEFAULT_SHOW_QAT_BELOW_RIBBON)) &&
                       (StandardColors.Equals(DEFAULT_STANDARD_COLORS)) &&
                       (ThemeColors.Equals(DEFAULT_THEME_COLORS));
            }
        }
        #endregion

        #region AppButtonKeyTip
        /// <summary>
        /// Gets and sets the application button key tip string.
        /// </summary>
        [Localizable(true)]
        [Category("Values")]
        [Description("Application button key tip string.")]
        [DefaultValue("F")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string AppButtonKeyTip
        {
            get { return _appButtonKeyTip; }

            set
            {
                // We only allow uppercase strings of minimum 1 character length
                if (!string.IsNullOrEmpty(value))
                {
                    _appButtonKeyTip = value.ToUpper();
                }
            }
        }
        #endregion

        #region CustomizeQuickAccessToolbar
        /// <summary>
        /// Gets and sets the heading for the quick access toolbar menu.
        /// </summary>
        [Localizable(true)]
        [Category("Values")]
        [Description("Heading for quick access toolbar menu.")]
        [DefaultValue("Customize Quick Access Toolbar")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string CustomizeQuickAccessToolbar
        {
            get { return _customizeQuickAccessToolbar; }
            set { _customizeQuickAccessToolbar = value; }
        }
        #endregion

        #region Minimize
        /// <summary>
        /// Gets and sets the menu string for minimizing the ribbon option.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for minimizing the ribbon option.")]
        [DefaultValue("Mi&nimize the Ribbon")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Minimize
        {
            get { return _minimize; }
            set { _minimize = value; }
        }
        #endregion

        #region MoreColors
        /// <summary>
        /// Gets and sets the menu string for a 'more colors' entry.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for a 'more colors' entry.")]
        [DefaultValue("&More Colors...")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string MoreColors
        {
            get { return _moreColors; }
            set { _moreColors = value; }
        }
        #endregion

        #region NoColor
        /// <summary>
        /// Gets and sets the menu string for a 'no color' entry.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for a 'no color' entry.")]
        [DefaultValue("&No Color")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string NoColor
        {
            get { return _noColor; }
            set { _noColor = value; }
        }
        #endregion

        #region RecentDocuments     
        /// <summary>
        /// Gets and sets the title for the recent documents section of the application menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for recent documents section of the application menu.")]
        [DefaultValue("Recent Documents")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string RecentDocuments
        {
            get { return _recentDocuments; }
            set { _recentDocuments = value; }
        }
        #endregion

        #region RecentColors
        /// <summary>
        /// Gets and sets the title for the recent colors section of the color button menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for recent colors section of the color button menu.")]
        [DefaultValue("Recent Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string RecentColors
        {
            get { return _recentColors; }
            set { _recentColors = value; }
        }
        #endregion

        #region ShowAboveRibbon
        /// <summary>
        /// Gets and sets the menu string for showing above the ribbon.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for showing above the ribbon.")]
        [DefaultValue("&Show Above the Ribbon")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ShowAboveRibbon
        {
            get { return _showAboveRibbon; }
            set { _showAboveRibbon = value; }
        }
        #endregion

        #region ShowBelowRibbon
        /// <summary>
        /// Gets and sets the menu string for showing below the ribbon.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for showing below the ribbon.")]
        [DefaultValue("&Show Below the Ribbon")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ShowBelowRibbon
        {
            get { return _showBelowRibbon; }
            set { _showBelowRibbon = value; }
        }
        #endregion

        #region ShowQATAboveRibbon
        /// <summary>
        /// Gets and sets the menu string for showing QAT above the ribbon.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for showing QAT above the ribbon.")]
        [DefaultValue("&Show Quick Access Toolbar Above the Ribbon")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ShowQATAboveRibbon
        {
            get { return _showQATAboveRibbon; }
            set { _showQATAboveRibbon = value; }
        }
        #endregion

        #region ShowQATBelowRibbon
        /// <summary>
        /// Gets and sets the menu string for showing QAT below the ribbon.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Menu string for showing QAT below the ribbon.")]
        [DefaultValue("&Show Quick Access Toolbar Below the Ribbon")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ShowQATBelowRibbon
        {
            get { return _showQATBelowRibbon; }
            set { _showQATBelowRibbon = value; }
        }
        #endregion

        #region StandardColors
        /// <summary>
        /// Gets and sets the title for the standard colors section of the application menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for standard colors section of the color button menu.")]
        [DefaultValue("Standard Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string StandardColors
        {
            get { return _standardColors; }
            set { _standardColors = value; }
        }
        #endregion

        #region ThemeColors
        /// <summary>
        /// Gets and sets the title for the theme colors section of the application menu.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Title for theme colors section of the color button menu.")]
        [DefaultValue("Theme Colors")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string ThemeColors
        {
            get { return _themeColors; }
            set { _themeColors = value; }
        }
        #endregion
    }
}
