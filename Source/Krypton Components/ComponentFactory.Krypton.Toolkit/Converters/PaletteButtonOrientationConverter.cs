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

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteButtonOrientation values appear as neat text at design time.
    /// </summary>
    internal class PaletteButtonOrientationConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteButtonOrientation clas.
        /// </summary>
        public PaletteButtonOrientationConverter()
            : base(typeof(PaletteButtonOrientation))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(PaletteButtonOrientation.Inherit,     "Inherit"),
            new Pair(PaletteButtonOrientation.Auto,        "Auto"),
            new Pair(PaletteButtonOrientation.FixedTop,    "Fixed Top"),
            new Pair(PaletteButtonOrientation.FixedBottom, "Fixed Bottom"),
            new Pair(PaletteButtonOrientation.FixedLeft,   "Fixed Left"),
            new Pair(PaletteButtonOrientation.FixedRight,  "Fixed Right") };

        #endregion
    }
}
