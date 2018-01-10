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
	/// Storage for palette ribbon group button text states.
	/// </summary>
    public class KryptonPaletteRibbonGroupButtonText : KryptonPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteRibbonGroupButtonText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KryptonPaletteRibbonGroupButtonText(PaletteRedirect redirect,
                                                   NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupButtonText, needPaint)
		{
        }
        #endregion
    }
}
