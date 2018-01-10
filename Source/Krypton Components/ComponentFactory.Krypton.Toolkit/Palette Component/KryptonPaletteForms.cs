// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Storage for form palette settings.
    /// </summary>
    public class KryptonPaletteForms : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteForms class.
        /// </summary>
        /// <param name="redirector">Palette redirector for sourcing inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KryptonPaletteForms(PaletteRedirect redirector,
                                     NeedPaintHandler needPaint)
        {
            Debug.Assert(redirector != null);

            // Create the form style specific and common palettes
            FormCommon = new KryptonPaletteForm(redirector, PaletteBackStyle.FormMain, PaletteBorderStyle.FormMain, needPaint);
            FormMain = new KryptonPaletteForm(redirector, PaletteBackStyle.FormMain, PaletteBorderStyle.FormMain, needPaint);
            FormCustom1 = new KryptonPaletteForm(redirector, PaletteBackStyle.FormCustom1, PaletteBorderStyle.FormCustom1, needPaint);

            // Create redirectors for inheriting from style specific to style common
            PaletteRedirectDouble redirectCommon = new PaletteRedirectDouble(redirector, FormCommon.StateInactive, FormCommon.StateActive);

            // Inform the form style to use the new redirector
            FormMain.SetRedirector(redirectCommon);
            FormCustom1.SetRedirector(redirectCommon);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        public override bool IsDefault => FormCommon.IsDefault &&
                                          FormMain.IsDefault &&
                                          FormCustom1.IsDefault;

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        public void PopulateFromBase(KryptonPaletteCommon common)
        {
            // Populate only the designated styles
            common.StateCommon.BackStyle = PaletteBackStyle.FormMain;
            common.StateCommon.BorderStyle = PaletteBorderStyle.FormMain;
            FormMain.PopulateFromBase();
        }
        #endregion

        #region FormCommon
        /// <summary>
        /// Gets access to the common form appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining common form appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteForm FormCommon { get; }

        private bool ShouldSerializeFormCommon()
        {
            return !FormCommon.IsDefault;
        }
        #endregion

        #region FormMain
        /// <summary>
        /// Gets access to the main form appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining main form appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteForm FormMain { get; }

        private bool ShouldSerializeFormMain()
        {
            return !FormMain.IsDefault;
        }
        #endregion

        #region FormCustom1
        /// <summary>
        /// Gets access to the first custom form appearance.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining the first custom form appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public KryptonPaletteForm FormCustom1 { get; }

        private bool ShouldSerializeFormCustom1()
        {
            return !FormCustom1.IsDefault;
        }
        #endregion
    }
}
