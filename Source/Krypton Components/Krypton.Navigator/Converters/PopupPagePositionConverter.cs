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

using Krypton.Toolkit;

namespace Krypton.Navigator
{
    /// <summary>
    /// Custom type converter so that PopupPagePosition values appear as neat text at design time.
    /// </summary>
    public class PopupPagePositionConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the PopupPagePositionConverter clas.
        /// </summary>
        public PopupPagePositionConverter()
            : base(typeof(PopupPagePosition))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(PopupPagePosition.ModeAppropriate,    "Mode Appropriate"),
            new Pair(PopupPagePosition.AboveFar,           "Above Element - Far Aligned"),
            new Pair(PopupPagePosition.AboveMatch,         "Above Element - Element Width"),
            new Pair(PopupPagePosition.AboveNear,          "Above Element - Near Aligned"),
            new Pair(PopupPagePosition.BelowFar,           "Below Element - Far Aligned"),
            new Pair(PopupPagePosition.BelowMatch,         "Below Element - Element Width"),
            new Pair(PopupPagePosition.BelowNear,          "Below Element - Near Aligned"),
            new Pair(PopupPagePosition.FarBottom,          "Far Side of Element - Bottom Aligned"),
            new Pair(PopupPagePosition.FarMatch,           "Far Side of Element - Element Height"),
            new Pair(PopupPagePosition.FarTop,             "Far Side of Element - Top Aligned"),
            new Pair(PopupPagePosition.NearBottom,         "Near Side of Element - Bottom Aligned"),
            new Pair(PopupPagePosition.NearMatch,          "Near Side of Element - Element Height"),
            new Pair(PopupPagePosition.NearTop,            "Near Side of Element - Top Aligned") };

        #endregion
    }
}
