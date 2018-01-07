// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Storage for input control palette settings.
    /// </summary>
    public class KryptonPaletteInputControls : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteInputControls class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KryptonPaletteInputControls(PaletteRedirect redirector,
                                             NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the input control style specific and common palettes
            InputControlCommon = new KryptonPaletteInputControl(redirector, PaletteBackStyle.InputControlStandalone, PaletteBorderStyle.InputControlStandalone, PaletteContentStyle.InputControlStandalone, needPaint);
            InputControlStandalone = new KryptonPaletteInputControl(redirector, PaletteBackStyle.InputControlStandalone, PaletteBorderStyle.InputControlStandalone, PaletteContentStyle.InputControlStandalone, needPaint);
            InputControlRibbon = new KryptonPaletteInputControl(redirector, PaletteBackStyle.InputControlRibbon, PaletteBorderStyle.InputControlRibbon, PaletteContentStyle.InputControlRibbon, needPaint);
            InputControlCustom1 = new KryptonPaletteInputControl(redirector, PaletteBackStyle.InputControlCustom1, PaletteBorderStyle.InputControlCustom1, PaletteContentStyle.InputControlCustom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectTriple redirectCommon = new PaletteRedirectTriple(redirector, InputControlCommon.StateDisabled, InputControlCommon.StateNormal, InputControlCommon.StateActive);

            // Inform the input control style to use the new redirector
            InputControlStandalone.SetRedirector(redirectCommon);
            InputControlRibbon.SetRedirector(redirectCommon);
            InputControlCustom1.SetRedirector(redirectCommon);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault => InputControlCommon.IsDefault &&
                                          InputControlStandalone.IsDefault &&
                                          InputControlRibbon.IsDefault &&
                                          InputControlCustom1.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KryptonPaletteCommon common)
        {
            // Populate only the designated styles
            common.StateCommon.BackStyle = PaletteBackStyle.InputControlStandalone;
            common.StateCommon.BorderStyle = PaletteBorderStyle.InputControlStandalone;
            common.StateCommon.ContentStyle = PaletteContentStyle.InputControlStandalone;
            InputControlStandalone.PopulateFromBase();
            common.StateCommon.BackStyle = PaletteBackStyle.InputControlRibbon;
            common.StateCommon.BorderStyle = PaletteBorderStyle.InputControlRibbon;
            common.StateCommon.ContentStyle = PaletteContentStyle.InputControlRibbon;
            InputControlRibbon.PopulateFromBase();
        }
        #endregion

        #region InputControlCommon
        /// <summary>
        /// Gets access to the common input control appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common input control appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteInputControl InputControlCommon { get; }

        private bool ShouldSerializeInputControlCommon()
        {
            return !InputControlCommon.IsDefault;
        }
        #endregion

        #region InputControlStandalone
        /// <summary>
        /// Gets access to the standalone input control appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining standalone input control appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteInputControl InputControlStandalone { get; }

        private bool ShouldSerializeInputControlStandalone()
        {
            return !InputControlStandalone.IsDefault;
        }
        #endregion

        #region InputControlRibbon
        /// <summary>
        /// Gets access to the input control ribbon style appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining input control ribbon style appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteInputControl InputControlRibbon { get; }

        private bool ShouldSerializeInputControlRibbon()
        {
            return !InputControlRibbon.IsDefault;
        }
        #endregion

        #region InputControlCustom1
        /// <summary>
        /// Gets access to the custom input control appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining the custom input control appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteInputControl InputControlCustom1 { get; }

        private bool ShouldSerializeInputControlCustom1()
        {
            return !InputControlCustom1.IsDefault;
        }
        #endregion
    }
}
