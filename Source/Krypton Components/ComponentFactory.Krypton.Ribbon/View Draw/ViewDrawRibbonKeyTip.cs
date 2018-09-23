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
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// View for drawing an individual key tip.
    /// </summary>
    internal class ViewDrawRibbonKeyTip : ViewDrawDocker,
                                          IContentValues
    {
        #region Instance Fields

        private readonly ViewDrawContent _drawContent;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawRibbonKeyTip class.
        /// </summary>
        /// <param name="keyTipInfo">Key tip information to display.</param>
        /// <param name="paletteBack">Background palette for appearance.</param>
        /// <param name="paletteBorder">Border palette for appearance.</param>
        /// <param name="paletteContent">Content palette for appearance.</param>
        public ViewDrawRibbonKeyTip(KeyTipInfo keyTipInfo,
                                    IPaletteBack paletteBack,
                                    IPaletteBorder paletteBorder,
                                    IPaletteContent paletteContent)
            : base(paletteBack, paletteBorder)
        {
            KeyTipInfo = keyTipInfo;

            // Create view for the key tip text
            _drawContent = new ViewDrawContent(paletteContent, this, VisualOrientation.Top);

            // Add content as filler for ourself
            Add(_drawContent, ViewDockStyle.Fill);
        }
        #endregion

        #region KeyTipInfo
        /// <summary>
        /// Gets the associated key tip info.
        /// </summary>
        public KeyTipInfo KeyTipInfo { get; }

        #endregion

        #region IContent
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return null;
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return Color.Empty;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return KeyTipInfo.KeyString;
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return string.Empty;
        }
        #endregion
    }
}
