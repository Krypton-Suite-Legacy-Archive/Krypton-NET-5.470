// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;


namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Expose a global set of strings used within Krypton and that are localizable.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
    public class GlobalStrings : GlobalId
    {
        #region Static Fields

        private const string DEFAULT_OK = "OK";
        private const string DEFAULT_CANCEL = "Cancel";
        private const string DEFAULT_YES = "Yes";
        private const string DEFAULT_NO = "No";
        private const string DEFAULT_ABORT = "Abort";
        private const string DEFAULT_RETRY = "Retry";
        private const string DEFAULT_IGNORE = "Ignore";
        private const string DEFAULT_CLOSE = "Close";
        private const string DEFAULT_TODAY = "Today";

        #endregion

        #region Instance Fields

        #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the Clipping class.
		/// </summary>
        public GlobalStrings()
        {
            Reset();
        }

        /// <summary>
        /// Returns a string that represents the current defaulted state.
        /// </summary>
        /// <returns>A string that represents the current defaulted state.</returns>
        public override string ToString()
        {
            if (!IsDefault)
            {
                return "Modified";
            }

            return string.Empty;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets a value indicating if all the strings are default values.
        /// </summary>
        /// <returns>True if all values are defaulted; otherwise false.</returns>
        [Browsable(false)]
        public bool IsDefault => OK.Equals(DEFAULT_OK) &&
                                 Cancel.Equals(DEFAULT_CANCEL) &&
                                 Yes.Equals(DEFAULT_YES) &&
                                 No.Equals(DEFAULT_NO) &&
                                 Abort.Equals(DEFAULT_ABORT) &&
                                 Retry.Equals(DEFAULT_RETRY) &&
                                 Ignore.Equals(DEFAULT_IGNORE) &&
                                 Close.Equals(DEFAULT_CLOSE) &&
                                 Today.Equals(DEFAULT_CLOSE);

        /// <summary>
        /// Reset all strings to default values.
        /// </summary>
        public void Reset()
        {
            OK = DEFAULT_OK;
            Cancel = DEFAULT_CANCEL;
            Yes = DEFAULT_YES;
            No = DEFAULT_NO;
            Abort = DEFAULT_ABORT;
            Retry = DEFAULT_RETRY;
            Ignore = DEFAULT_IGNORE;
            Close = DEFAULT_CLOSE;
            Today = DEFAULT_TODAY;
        }

        /// <summary>
        /// Gets and sets the OK string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("OK string used for message box buttons.")]
        [DefaultValue("OK")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string OK { get; set; }

        /// <summary>
        /// Gets and sets the Cancel string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Cancel string used for message box buttons.")]
        [DefaultValue("Cancel")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Cancel { get; set; }

        /// <summary>
        /// Gets and sets the Yes string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Yes string used for message box buttons.")]
        [DefaultValue("Yes")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Yes { get; set; }

        /// <summary>
        /// Gets and sets the No string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("No string used for message box buttons.")]
        [DefaultValue("No")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string No { get; set; }

        /// <summary>
        /// Gets and sets the Abort string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Abort string used for message box buttons.")]
        [DefaultValue("Abort")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Abort { get; set; }

        /// <summary>
        /// Gets and sets the Retry string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Retry string used for message box buttons.")]
        [DefaultValue("Retry")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Retry { get; set; }

        /// <summary>
        /// Gets and sets the Ignore string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Ignore string used for message box buttons.")]
        [DefaultValue("Ignore")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Ignore { get; set; }

        /// <summary>
        /// Gets and sets the Close string used in message box buttons.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Close string used for message box buttons.")]
        [DefaultValue("Close")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Close { get; set; }

        /// <summary>
        /// Gets and sets the Close string used in calendars.
        /// </summary>
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Today string used for calendars.")]
        [DefaultValue("Today")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public string Today { get; set; }

        #endregion
    }
}
