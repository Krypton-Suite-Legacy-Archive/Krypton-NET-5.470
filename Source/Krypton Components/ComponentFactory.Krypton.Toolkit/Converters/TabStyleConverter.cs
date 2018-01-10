// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Custom type converter so that TabStyle values appear as neat text at design time.
    /// </summary>
    internal class TabStyleConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the TabStyleConverter clas.
        /// </summary>
        public TabStyleConverter()
            : base(typeof(TabStyle))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(TabStyle.HighProfile,     "High Profile"),
            new Pair(TabStyle.StandardProfile, "Standard Profile"),
            new Pair(TabStyle.LowProfile,      "Low Profile"),
            new Pair(TabStyle.OneNote,         "OneNote"),
            new Pair(TabStyle.Dock,            "Dock"),
            new Pair(TabStyle.DockAutoHidden,  "Dock AutoHidden"),
            new Pair(TabStyle.Custom1,         "Custom1"),
            new Pair(TabStyle.Custom2,         "Custom2"),
            new Pair(TabStyle.Custom3,         "Custom3") };

        #endregion
    }
}
