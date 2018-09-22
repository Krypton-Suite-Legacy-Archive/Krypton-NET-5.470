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
using Krypton.Toolkit;

namespace Krypton.Navigator
{
	/// <summary>
	/// Implement storage for other navigator appearance states.
	/// </summary>
    public class PaletteNavigatorOtherEx : PaletteNavigatorOther
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteNavigatorOtherEx class.
		/// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteNavigatorOtherEx(PaletteNavigatorRedirect redirect,
                                       NeedPaintHandler needPaint)
            : base(redirect, needPaint)
		{
            // Create the palette storage
            Separator = new PaletteSeparatorPadding(redirect.Separator, redirect.Separator, needPaint);
        }
        #endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => base.IsDefault && 
		                                  Separator.IsDefault;

        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        /// <param name="inheritNavigator">Source for inheriting.</param>
        public override void SetInherit(PaletteNavigator inheritNavigator)
        {
            Separator.SetInherit(inheritNavigator.Separator);
            base.SetInherit(inheritNavigator);
        }
        #endregion

        #region Separator
        /// <summary>
        /// Get access to the overrides for defining separator appearance.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteSeparatorPadding Separator { get; }

        private bool ShouldSerializeSeparator()
        {
            return !Separator.IsDefault;
        }
        #endregion
    }
}
