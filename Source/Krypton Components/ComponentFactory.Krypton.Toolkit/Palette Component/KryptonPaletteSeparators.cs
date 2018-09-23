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

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Storage for separator palette settings.
    /// </summary>
    public class KryptonPaletteSeparators : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteSeparators class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KryptonPaletteSeparators(PaletteRedirect redirector,
                                          NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the button style specific and common palettes
            SeparatorCommon = new KryptonPaletteSeparator(redirector, PaletteBackStyle.SeparatorLowProfile, PaletteBorderStyle.SeparatorLowProfile, needPaint);
            SeparatorLowProfile = new KryptonPaletteSeparator(redirector, PaletteBackStyle.SeparatorLowProfile, PaletteBorderStyle.SeparatorLowProfile, needPaint);
            SeparatorHighProfile = new KryptonPaletteSeparator(redirector, PaletteBackStyle.SeparatorHighProfile, PaletteBorderStyle.SeparatorHighProfile, needPaint);
            SeparatorHighInternalProfile = new KryptonPaletteSeparator(redirector, PaletteBackStyle.SeparatorHighInternalProfile, PaletteBorderStyle.SeparatorHighInternalProfile, needPaint);
            SeparatorCustom1 = new KryptonPaletteSeparator(redirector, PaletteBackStyle.SeparatorCustom1, PaletteBorderStyle.SeparatorCustom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectDouble redirectCommon = new PaletteRedirectDouble(redirector, 
                                                                             SeparatorCommon.StateDisabled, SeparatorCommon.StateNormal,
                                                                             SeparatorCommon.StatePressed, SeparatorCommon.StateTracking);

            // Inform the button style to use the new redirector
            SeparatorLowProfile.SetRedirector(redirectCommon);
            SeparatorHighProfile.SetRedirector(redirectCommon);
            SeparatorHighInternalProfile.SetRedirector(redirectCommon);
            SeparatorCustom1.SetRedirector(redirectCommon);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault => SeparatorCommon.IsDefault &&
                                          SeparatorLowProfile.IsDefault &&
                                          SeparatorHighProfile.IsDefault &&
                                          SeparatorHighInternalProfile.IsDefault &&
                                          SeparatorCustom1.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KryptonPaletteCommon common)
        {
            // Populate only the designated styles
            common.StateCommon.BackStyle = PaletteBackStyle.SeparatorLowProfile;
            common.StateCommon.BorderStyle = PaletteBorderStyle.SeparatorLowProfile;
            SeparatorLowProfile.PopulateFromBase(PaletteMetricPadding.SeparatorPaddingLowProfile);
            common.StateCommon.BackStyle = PaletteBackStyle.SeparatorHighProfile;
            common.StateCommon.BorderStyle = PaletteBorderStyle.SeparatorHighProfile;
            SeparatorHighProfile.PopulateFromBase(PaletteMetricPadding.SeparatorPaddingHighProfile);
            common.StateCommon.BackStyle = PaletteBackStyle.SeparatorHighInternalProfile;
            common.StateCommon.BorderStyle = PaletteBorderStyle.SeparatorHighInternalProfile;
            SeparatorHighInternalProfile.PopulateFromBase(PaletteMetricPadding.SeparatorPaddingHighInternalProfile);
        }
        #endregion

        #region SeparatorCommon
        /// <summary>
        /// Gets access to the common separator appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteSeparator SeparatorCommon { get; }

        private bool ShouldSerializeSeparatorCommon()
        {
            return !SeparatorCommon.IsDefault;
        }
        #endregion

        #region SeparatorLowProfile
        /// <summary>
        /// Gets access to the low profile separator appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining low profile separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteSeparator SeparatorLowProfile { get; }

        private bool ShouldSerializeSeparatorLowProfile()
        {
            return !SeparatorLowProfile.IsDefault;
        }
        #endregion

        #region SeparatorHighProfile
        /// <summary>
        /// Gets access to the high profile separator appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining high profile separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteSeparator SeparatorHighProfile { get; }

        private bool ShouldSerializeSeparatorHighProfile()
        {
            return !SeparatorHighProfile.IsDefault;
        }
        #endregion

        #region SeparatorHighInternalProfile
        /// <summary>
        /// Gets access to the high profile for internal separator appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining high profile for internal separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteSeparator SeparatorHighInternalProfile { get; }

        private bool ShouldSerializeSeparatorHighInternalProfile()
        {
            return !SeparatorHighInternalProfile.IsDefault;
        }
        #endregion

        #region SeparatorCustom1
        /// <summary>
        /// Gets access to the first custom separator appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining first custom separator appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteSeparator SeparatorCustom1 { get; }

        private bool ShouldSerializeSeparatorCustom1()
        {
            return !SeparatorCustom1.IsDefault;
        }
        #endregion
    }
}
