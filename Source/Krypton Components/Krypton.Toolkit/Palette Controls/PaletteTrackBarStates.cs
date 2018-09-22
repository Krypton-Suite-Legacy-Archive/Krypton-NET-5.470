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
using System.Diagnostics;

namespace Krypton.Toolkit
{
	/// <summary>
	/// Implement storage for a track bar state.
	/// </summary>
	public class PaletteTrackBarStates : Storage
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PaletteTrackBarStates class.
		/// </summary>
        /// <param name="redirect">Source for inheriting values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTrackBarStates(PaletteTrackBarRedirect redirect,
                                     NeedPaintHandler needPaint)
            : this(redirect.Tick, redirect.Track, redirect.Position, needPaint)
        {
        }

		/// <summary>
        /// Initialize a new instance of the PaletteTrackBarStates class.
		/// </summary>
        /// <param name="inheritTick">Source for inheriting tick values.</param>
        /// <param name="inheritTrack">Source for inheriting track values.</param>
        /// <param name="inheritPosition">Source for inheriting position values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteTrackBarStates(IPaletteElementColor inheritTick,
                                     IPaletteElementColor inheritTrack,
                                     IPaletteElementColor inheritPosition,
                                     NeedPaintHandler needPaint)
		{
            Debug.Assert(inheritTick != null);
            Debug.Assert(inheritTrack != null);
            Debug.Assert(inheritPosition != null);

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create storage that maps onto the inherit instances
            Tick = new PaletteElementColor(inheritTick, needPaint);
            Track = new PaletteElementColor(inheritTrack, needPaint);
            Position = new PaletteElementColor(inheritPosition, needPaint);
        }
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (Tick.IsDefault &&
		                                   Track.IsDefault &&
		                                   Position.IsDefault);

	    #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        /// <param name="inheritTick">Source for inheriting tick values.</param>
        /// <param name="inheritTrack">Source for inheriting track values.</param>
        /// <param name="inheritPosition">Source for inheriting position values.</param>
        public void SetInherit(IPaletteElementColor inheritTick,
                               IPaletteElementColor inheritTrack,
                               IPaletteElementColor inheritPosition)
        {
            Tick.SetInherit(inheritTick);
            Track.SetInherit(inheritTrack);
            Position.SetInherit(inheritPosition);
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public void PopulateFromBase(PaletteState state)
        {
            Tick.PopulateFromBase(state);
            Track.PopulateFromBase(state);
            Position.PopulateFromBase(state);
        }
        #endregion

        #region Tick
        /// <summary>
        /// Gets access to the tick appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining tick appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteElementColor Tick { get; }

	    private bool ShouldSerializeTick()
        {
            return !Tick.IsDefault;
        }
        #endregion

        #region Track
        /// <summary>
        /// Gets access to the track appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining track appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteElementColor Track { get; }

	    private bool ShouldSerializeTrack()
        {
            return !Track.IsDefault;
        }
        #endregion

        #region Position
        /// <summary>
        /// Gets access to the position appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining position appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteElementColor Position { get; }

	    private bool ShouldSerializePosition()
        {
            return !Position.IsDefault;
        }
        #endregion
	}
}
