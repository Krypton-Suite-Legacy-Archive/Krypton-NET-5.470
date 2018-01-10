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
    /// Custom type converter so that PaletteMode values appear as neat text at design time.
    /// </summary>
    internal class PaletteModeConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteMode.ProfessionalSystem,    "Professional - System"),
                                             new Pair(PaletteMode.ProfessionalOffice2003,"Professional - Office 2003"),
                                             new Pair(PaletteMode.Office2007Blue,        "Office 2007 - Blue"),
                                             new Pair(PaletteMode.Office2007Silver,      "Office 2007 - Silver"),
                                             new Pair(PaletteMode.Office2007Black,       "Office 2007 - Black"),
                                             new Pair(PaletteMode.Office2010Blue,        "Office 2010 - Blue"),
                                             new Pair(PaletteMode.Office2010Silver,      "Office 2010 - Silver"),
                                             new Pair(PaletteMode.Office2010Black,       "Office 2010 - Black"),
                                             new Pair(PaletteMode.Office2013White,       "Office 2013 - White"),
                                             new Pair(PaletteMode.SparkleBlue,           "Sparkle - Blue"),
                                             new Pair(PaletteMode.SparkleOrange,         "Sparkle - Orange"),
                                             new Pair(PaletteMode.SparklePurple,         "Sparkle - Purple") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteModeConverter clas.
        /// </summary>
        public PaletteModeConverter()
            : base(typeof(PaletteMode))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs 
        {
            get { return _pairs; }
        }
        #endregion
    }
}
