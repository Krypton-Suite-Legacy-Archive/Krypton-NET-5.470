// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.1.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteTextTrim values appear as neat text at design time.
    /// </summary>
    internal class PaletteTextTrimConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteTextTrimConverter clas.
        /// </summary>
        public PaletteTextTrimConverter()
            : base(typeof(PaletteTextTrim))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(PaletteTextTrim.Inherit,              "Inherit"),
            new Pair(PaletteTextTrim.Hide,                 "Hide"),
            new Pair(PaletteTextTrim.Character,            "Character"),
            new Pair(PaletteTextTrim.Word,                 "Word"),
            new Pair(PaletteTextTrim.EllipsisCharacter,    "Ellipsis Character"),
            new Pair(PaletteTextTrim.EllipsisWord,         "Ellipsis Word"),
            new Pair(PaletteTextTrim.EllipsisPath,         "Ellipsis Path") };

        #endregion
    }
}
