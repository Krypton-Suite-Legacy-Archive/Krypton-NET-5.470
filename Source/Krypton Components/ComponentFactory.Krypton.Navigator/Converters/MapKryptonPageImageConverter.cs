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

using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
    /// <summary>
    /// Custom type converter so that MapKryptonPageImage values appear as neat text at design time.
    /// </summary>
    public class MapKryptonPageImageConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the MapKryptonPageImageConverter clas.
        /// </summary>
        public MapKryptonPageImageConverter()
            : base(typeof(MapKryptonPageImage))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(MapKryptonPageImage.None,             "None (Null image)"),
            new Pair(MapKryptonPageImage.Small,            "Small"),
            new Pair(MapKryptonPageImage.SmallMedium,      "Small - Medium"), 
            new Pair(MapKryptonPageImage.SmallMediumLarge, "Small - Medium - Large"),
            new Pair(MapKryptonPageImage.Medium,           "Medium"), 
            new Pair(MapKryptonPageImage.MediumSmall,      "Medium - Small"), 
            new Pair(MapKryptonPageImage.MediumLarge,      "Medium - Large"),
            new Pair(MapKryptonPageImage.Large,            "Large"),
            new Pair(MapKryptonPageImage.LargeMedium,      "Large - Medium"),
            new Pair(MapKryptonPageImage.LargeMediumSmall, "Large - Medium - Small"),
            new Pair(MapKryptonPageImage.ToolTip,          "ToolTip") };

        #endregion
    }
}
