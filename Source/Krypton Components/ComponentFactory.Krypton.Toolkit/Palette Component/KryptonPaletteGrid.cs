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

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Storage of palette grid states.
	/// </summary>
    public class KryptonPaletteGrid : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteGrid class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="gridStyle">Grid style.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KryptonPaletteGrid(PaletteRedirect redirect,
                                  GridStyle gridStyle,
                                  NeedPaintHandler needPaint) 
		{
            // Create the storage objects
            StateCommon = new PaletteDataGridViewRedirect(redirect, needPaint);
            StateDisabled = new PaletteDataGridViewAll(StateCommon, needPaint);
            StateNormal = new PaletteDataGridViewAll(StateCommon, needPaint);
            StateTracking = new PaletteDataGridViewHeaders(StateCommon, needPaint);
            StatePressed = new PaletteDataGridViewHeaders(StateCommon, needPaint);
            StateSelected = new PaletteDataGridViewCells(StateCommon, needPaint);
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            StateCommon.SetRedirector(redirect);
        }
        #endregion

        #region IsDefault
        /// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => StateCommon.IsDefault &&
		                                  StateDisabled.IsDefault &&
		                                  StateNormal.IsDefault &&
		                                  StateTracking.IsDefault &&
		                                  StatePressed.IsDefault &&
		                                  StateSelected.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        /// <param name="gridStyle">Grid style to use for populating.</param>
        public void PopulateFromBase(KryptonPaletteCommon common,
                                     GridStyle gridStyle)
        {
            // Populate only the designated styles
            StateDisabled.PopulateFromBase(common, PaletteState.Disabled, gridStyle);
            StateNormal.PopulateFromBase(common, PaletteState.Normal, gridStyle);
            StateTracking.PopulateFromBase(common, PaletteState.Tracking, gridStyle);
            StatePressed.PopulateFromBase(common, PaletteState.Pressed, gridStyle);
            StateSelected.PopulateFromBase(common, PaletteState.CheckedNormal, gridStyle);
        }
        #endregion

        #region StateCommon
        /// <summary>
        /// Gets access to the common grid appearance that other states can override.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common grid appearance that other states can override.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewRedirect StateCommon { get; }

        private bool ShouldSerializeStateCommon()
        {
            return !StateCommon.IsDefault;
        }
        #endregion

        #region StateDisabled
        /// <summary>
        /// Gets access to the disabled grid appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining disabled grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewAll StateDisabled { get; }

        private bool ShouldSerializeStateDisabled()
        {
            return !StateDisabled.IsDefault;
        }
        #endregion

        #region StateNormal
        /// <summary>
        /// Gets access to the normal grid appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining normal grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewAll StateNormal { get; }

        private bool ShouldSerializeStateNormal()
        {
            return !StateNormal.IsDefault;
        }
        #endregion

        #region StateTracking
        /// <summary>
        /// Gets access to the hot tracking grid appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining hot tracking grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewHeaders StateTracking { get; }

        private bool ShouldSerializeStateTracking()
        {
            return !StateTracking.IsDefault;
        }
        #endregion

        #region StatePressed
        /// <summary>
        /// Gets access to the pressed grid appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining pressed grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewHeaders StatePressed { get; }

        private bool ShouldSerializeStatePressed()
        {
            return !StatePressed.IsDefault;
        }
        #endregion

        #region StateSelected
        /// <summary>
        /// Gets access to the selected grid appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining selected grid appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDataGridViewCells StateSelected { get; }

        private bool ShouldSerializeStateSelected()
        {
            return !StateSelected.IsDefault;
        }
        #endregion
    }
}
