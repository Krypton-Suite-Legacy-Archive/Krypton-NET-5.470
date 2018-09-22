﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace Krypton.Toolkit
{
	/// <summary>
	/// Implement storage for month calendar appearance states.
	/// </summary>
    public class PaletteMonthCalendarStateRedirect : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteMonthCalendarStateRedirect class.
		/// </summary>
        public PaletteMonthCalendarStateRedirect()
            : this(null, null)
        {
        }

            /// <summary>
        /// Initialize a new instance of the PaletteMonthCalendarStateRedirect class.
		/// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteMonthCalendarStateRedirect(PaletteRedirect redirect,
                                                 NeedPaintHandler needPaint) 
		{
            Day = new PaletteTripleRedirect(redirect, 
                                                    PaletteBackStyle.ButtonCalendarDay, 
                                                    PaletteBorderStyle.ButtonCalendarDay, 
                                                    PaletteContentStyle.ButtonCalendarDay, 
                                                    needPaint);
        }
        #endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => Day.IsDefault;

        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            Day.SetRedirector(redirect);
        }
        #endregion

        #region Styles
        internal ButtonStyle DayStyle
        {
            set => Day.SetStyles(value);
        }
        #endregion

        #region Day
        /// <summary>
        /// Gets access to the day appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining day appearance entries.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect Day { get; }

        private bool ShouldSerializeContent()
        {
            return !Day.IsDefault;
        }
        #endregion
    }
}
