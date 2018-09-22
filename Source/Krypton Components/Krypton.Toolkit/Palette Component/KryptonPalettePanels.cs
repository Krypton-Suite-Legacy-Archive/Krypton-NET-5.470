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
    /// Storage for panel palette settings.
    /// </summary>
    public class KryptonPalettePanels : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPalettePanels class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KryptonPalettePanels(PaletteRedirect redirector,
                                      NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the button style specific and common palettes
            PanelCommon = new KryptonPalettePanel(redirector, PaletteBackStyle.PanelClient, needPaint);
            PanelClient = new KryptonPalettePanel(redirector, PaletteBackStyle.PanelClient, needPaint);
            PanelAlternate = new KryptonPalettePanel(redirector, PaletteBackStyle.PanelAlternate, needPaint);
            PanelRibbonInactive = new KryptonPalettePanel(redirector, PaletteBackStyle.PanelRibbonInactive, needPaint);
            PanelCustom1 = new KryptonPalettePanel(redirector, PaletteBackStyle.PanelCustom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectBack redirectCommon = new PaletteRedirectBack(redirector, PanelCommon.StateDisabled, PanelCommon.StateNormal);

            // Inform the button style to use the new redirector
            PanelClient.SetRedirector(redirectCommon);
            PanelAlternate.SetRedirector(redirectCommon);
            PanelRibbonInactive.SetRedirector(redirectCommon);
            PanelCustom1.SetRedirector(redirectCommon);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault => PanelCommon.IsDefault &&
                                          PanelClient.IsDefault &&
                                          PanelAlternate.IsDefault &&
                                          PanelRibbonInactive.IsDefault &&
                                          PanelCustom1.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KryptonPaletteCommon common)
        {
            // Populate only the designated styles
            common.StateCommon.BackStyle = PaletteBackStyle.PanelClient;
            PanelClient.PopulateFromBase();
            common.StateCommon.BackStyle = PaletteBackStyle.PanelAlternate;
            PanelAlternate.PopulateFromBase();
            common.StateCommon.BackStyle = PaletteBackStyle.PanelRibbonInactive;
            PanelRibbonInactive.PopulateFromBase();
        }
        #endregion

        #region PanelCommon
        /// <summary>
        /// Gets access to the common panel appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPalettePanel PanelCommon { get; }

        private bool ShouldSerializePanelCommon()
        {
            return !PanelCommon.IsDefault;
        }
        #endregion

        #region PanelClient
        /// <summary>
        /// Gets access to the client panel appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining a client panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPalettePanel PanelClient { get; }

        private bool ShouldSerializePanelClient()
        {
            return !PanelClient.IsDefault;
        }
        #endregion

        #region PanelAlternate
        /// <summary>
        /// Gets access to the alternate panel appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining alternate panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPalettePanel PanelAlternate { get; }

        private bool ShouldSerializePanelAlternate()
        {
            return !PanelAlternate.IsDefault;
        }
        #endregion

        #region PanelRibbonInactive
        /// <summary>
        /// Gets access to the ribbon inactive panel appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining ribbon inactive panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPalettePanel PanelRibbonInactive { get; }

        private bool ShouldSerializePanelRibbonInactive()
        {
            return !PanelRibbonInactive.IsDefault;
        }
        #endregion

        #region PanelCustom1
        /// <summary>
        /// Gets access to the first custom panel appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining the first custom panel appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPalettePanel PanelCustom1 { get; }

        private bool ShouldSerializePanelCustom1()
        {
            return !PanelCustom1.IsDefault;
        }
        #endregion
    }
}
