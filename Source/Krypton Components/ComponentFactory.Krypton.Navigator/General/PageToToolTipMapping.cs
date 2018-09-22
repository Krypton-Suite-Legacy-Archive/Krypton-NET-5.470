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
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
    /// <summary>
    /// Map tooltip values from a source page.
    /// </summary>
    internal class PageToToolTipMapping : IContentValues
    {
        #region Instance Fields
        private readonly KryptonPage _page;
        private readonly MapKryptonPageImage _mapImage;
        private readonly MapKryptonPageText _mapText;
        private readonly MapKryptonPageText _mapExtraText;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PageToToolTipMapping class.
        /// </summary>
        /// <param name="page">Page to source values from.</param>
        /// <param name="mapImage">How to map the image from the page to the tooltip.</param>
        /// <param name="mapText">How to map the text from the page to the tooltip.</param>
        /// <param name="mapExtraText">How to map the extra text from the page to the tooltip.</param>
        public PageToToolTipMapping(KryptonPage page,
                                    MapKryptonPageImage mapImage,
                                    MapKryptonPageText mapText,
                                    MapKryptonPageText mapExtraText)
        {
            Debug.Assert(page != null);
            
            _page = page;
            _mapImage = mapImage;
            _mapText = mapText;
            _mapExtraText = mapExtraText;
        }
        #endregion

        #region HasContent
        /// <summary>
        /// Gets a value indicating if the mapping produces any content.
        /// </summary>
        public bool HasContent => (GetImage(PaletteState.Normal) != null) ||
                                  !string.IsNullOrEmpty(GetShortText()) ||
                                  !string.IsNullOrEmpty(GetLongText());

        #endregion

        #region IContentValues
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return _page.GetImageMapping(_mapImage);
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return _page.ToolTipImageTransparentColor;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return _page.GetTextMapping(_mapText);
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return _page.GetTextMapping(_mapExtraText);
        }
        #endregion
    }
}
