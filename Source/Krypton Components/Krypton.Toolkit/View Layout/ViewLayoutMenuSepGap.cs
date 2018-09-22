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

using System.Drawing;
using System.Windows.Forms;

namespace Krypton.Toolkit
{
	/// <summary>
	/// Positions a separator to take up space without drawing.
	/// </summary>
    public class ViewLayoutMenuSepGap : ViewLayoutSeparator
    {
        #region Instance Fields
        private readonly PaletteContextMenuRedirect _stateCommon;
        private readonly bool _standardStyle;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutMenuSepGap class.
		/// </summary>
        /// <param name="stateCommon">Source of palette values.</param>
        /// <param name="standardStyle">Draw items with standard or alternate style.</param>
        public ViewLayoutMenuSepGap(PaletteContextMenuRedirect stateCommon,
                                    bool standardStyle)
            : base(0)
        {
            _stateCommon = stateCommon;
            _standardStyle = standardStyle;
        }

        /// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewLayoutMenuSepGap:" + Id;
		}
		#endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            // Grab the padding used for the text/extra content of a menu item
            Padding paddingText = _standardStyle
                ? _stateCommon.ItemTextStandard.GetContentPadding(PaletteState.Normal)
                : _stateCommon.ItemTextAlternate.GetContentPadding(PaletteState.Normal);

            // Get padding needed for the left edge of the item highlight
            Padding paddingHighlight = context.Renderer.RenderStandardBorder.GetBorderDisplayPadding(_stateCommon.ItemHighlight.Border, PaletteState.Normal, VisualOrientation.Top);

            // Our separator size is the left padding values added together
            SeparatorSize = new Size(paddingHighlight.Left + paddingText.Left, 0);

            return base.GetPreferredSize(context);
        }
        #endregion
    }
}
