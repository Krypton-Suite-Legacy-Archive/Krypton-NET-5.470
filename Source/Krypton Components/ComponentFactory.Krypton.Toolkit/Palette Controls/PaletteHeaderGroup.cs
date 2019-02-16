﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Implement storage for HeaderGroup states.
	/// </summary>
	public class PaletteHeaderGroup : PaletteDouble,
                                      IPaletteMetric
	{
		#region Instance Fields
        private IPaletteMetric _inherit;

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteHeaderGroup class.
		/// </summary>
        /// <param name="inheritHeaderGroup">Source for inheriting palette defaulted values.</param>
        /// <param name="inheritHeaderPrimary">Source for inheriting primary header defaulted values.</param>
        /// <param name="inheritHeaderSecondary">Source for inheriting secondary header defaulted values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteHeaderGroup(PaletteHeaderGroupRedirect inheritHeaderGroup,
                                  PaletteHeaderPaddingRedirect inheritHeaderPrimary,
                                  PaletteHeaderPaddingRedirect inheritHeaderSecondary,
                                  NeedPaintHandler needPaint)
            : base(inheritHeaderGroup, needPaint)
		{
            Debug.Assert(inheritHeaderGroup != null);
            Debug.Assert(inheritHeaderPrimary != null);
            Debug.Assert(inheritHeaderSecondary != null);

            // Remember the inheritance
            _inherit = inheritHeaderGroup;

			// Create the palette storage
            HeaderPrimary = new PaletteTripleMetric(inheritHeaderPrimary, needPaint);
            HeaderSecondary = new PaletteTripleMetric(inheritHeaderSecondary, needPaint);
        }
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (base.IsDefault &&
		                                   HeaderPrimary.IsDefault &&
		                                   HeaderSecondary.IsDefault);

	    #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        /// <param name="inheritHeaderGroup">Source for inheriting.</param>
        public void SetInherit(PaletteHeaderGroup inheritHeaderGroup)
        {
            base.SetInherit(inheritHeaderGroup);
            _inherit = inheritHeaderGroup;
            HeaderPrimary.SetInherit(inheritHeaderGroup.HeaderPrimary);
            HeaderSecondary.SetInherit(inheritHeaderGroup.HeaderSecondary);
        }
        #endregion

        #region HeaderPrimary
        /// <summary>
		/// Gets access to the primary header appearance entries.
		/// </summary>
		[Category("Visuals")]
		[Description("Overrides for defining primary header appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleMetric HeaderPrimary { get; }

	    private bool ShouldSerializeHeaderPrimary()
		{
			return !HeaderPrimary.IsDefault;
		}
		#endregion

        #region HeaderSecondary
        /// <summary>
		/// Gets access to the secondary header appearance entries.
		/// </summary>
		[Category("Visuals")]
		[Description("Overrides for defining secondary header appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleMetric HeaderSecondary { get; }

	    private bool ShouldSerializeHeaderSecondary()
		{
			return !HeaderSecondary.IsDefault;
		}
		#endregion

        #region IPaletteMetric
        /// <summary>
        /// Gets an integer metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>Integer value.</returns>
        public int GetMetricInt(PaletteState state, PaletteMetricInt metric)
        {
            // Pass onto the inheritance
            return _inherit.GetMetricInt(state, metric);
        }

        /// <summary>
        /// Gets a boolean metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>InheritBool value.</returns>
        public InheritBool GetMetricBool(PaletteState state, PaletteMetricBool metric)
        {
            // Pass onto the inheritance
            return _inherit.GetMetricBool(state, metric);
        }

        /// <summary>
        /// Gets a padding metric value.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <param name="metric">Requested metric.</param>
        /// <returns>Padding value.</returns>
        public Padding GetMetricPadding(PaletteState state, PaletteMetricPadding metric)
        {
            // Always pass onto the inheritance
            return _inherit.GetMetricPadding(state, metric);
        }
        #endregion
    }
}
