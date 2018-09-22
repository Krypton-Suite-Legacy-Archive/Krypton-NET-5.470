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

using System.ComponentModel;
using Krypton.Toolkit;

namespace Krypton.Ribbon
{
	/// <summary>
	/// Implement storage for a gallery palette state. 
	/// </summary>
    public class PaletteGalleryState : Storage
	{
		#region Instance Fields
        private readonly PaletteRibbonBack _ribbonBack;
        private readonly PaletteRibbonBack _ribbonBorder;
        #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteGalleryState class.
		/// </summary>
        /// <param name="inherit">Source for inheriting values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteGalleryState(PaletteGalleryRedirect inherit,
                                   NeedPaintHandler needPaint)
		{
			// Create storage that maps onto the inherit instances
            _ribbonBack= new PaletteRibbonBack(inherit.RibbonGalleryBack, needPaint);
            _ribbonBorder = new PaletteRibbonBack(inherit.RibbonGalleryBorder, needPaint);
        }
		#endregion

        #region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (RibbonGalleryBack.IsDefault &
		                                   RibbonGalleryBorder.IsDefault);

	    #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">The palette state to populate with.</param>
        public virtual void PopulateFromBase(PaletteState state)
        {
            _ribbonBack.PopulateFromBase(state);
            _ribbonBorder.PopulateFromBase(state);
        }
        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        public virtual void SetInherit(PaletteGalleryRedirect inherit)
        {
            _ribbonBack.SetInherit(inherit.RibbonGalleryBack);
            _ribbonBorder.SetInherit(inherit.RibbonGalleryBorder);
        }
        #endregion

        #region RibbonGalleryBack
        /// <summary>
        /// Gets access to the gallery background palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining gallery background appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBack => _ribbonBack;

	    private bool ShouldSerializeRibbonGalleryBack()
        {
            return !_ribbonBack.IsDefault;
        }
        #endregion

        #region RibbonGalleryBorder
        /// <summary>
        /// Gets access to the gallery border palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining gallery border appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBorder => _ribbonBorder;

	    private bool ShouldSerializeRibbonGalleryBorder()
        {
            return !_ribbonBorder.IsDefault;
        }
        #endregion
    }
}
