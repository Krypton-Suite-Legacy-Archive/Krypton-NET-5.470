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

namespace Krypton.Ribbon
{
	/// <summary>
    /// Extends the ViewLayoutRibbonQATContents by providing the definitions from the ribbon control itself.
	/// </summary>
    internal class ViewLayoutRibbonQATFromRibbon : ViewLayoutRibbonQATContents
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewLayoutRibbonQATFromRibbon class.
		/// </summary>
        /// <param name="ribbon">Owning ribbon control instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        /// <param name="showExtraButton">Should the extra button be shown.</param>
        public ViewLayoutRibbonQATFromRibbon(KryptonRibbon ribbon,
                                             NeedPaintHandler needPaint,
                                             bool showExtraButton)
            : base(ribbon, needPaint, showExtraButton)
        {
        }
        #endregion

        #region DisplayButtons
        /// <summary>
        /// Returns a collection of all the quick access toolbar definitions.
        /// </summary>
        public override IQuickAccessToolbarButton[] QATButtons 
        { 
            get 
            {
                IQuickAccessToolbarButton[] qatButtons = new IQuickAccessToolbarButton[Ribbon.QATButtons.Count];

                // Copy all the entries into the new array 
                Ribbon.QATButtons.CopyTo(qatButtons, 0);

                return qatButtons;
            }
        }
        #endregion
    }
}
