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
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Storage for application button related properties.
	/// </summary>
    public class PaletteRibbonImages : Storage
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteRibbonImages class.
		/// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Paint delegate.</param>
        public PaletteRibbonImages(PaletteRedirect redirect,
                                   NeedPaintHandler needPaint)
		{
            Debug.Assert(redirect != null);
            Debug.Assert(needPaint != null);

            CheckBox = new CheckBoxImages(needPaint);
            RadioButton = new RadioButtonImages(needPaint);
            InternalCheckBox = new PaletteRedirectCheckBox(redirect, CheckBox);
            InternalRadioButton = new PaletteRedirectRadioButton(redirect, RadioButton);
        }
		#endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => (CheckBox.IsDefault &&
                                           RadioButton.IsDefault);

        #endregion

        #region CheckBox
        /// <summary>
        /// Gets and sets the ribbon check box images.
        /// </summary>
        [Category("Values")]
        [Description("Ribbon check box images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CheckBoxImages CheckBox { get; }

        private bool ShouldSerializeCheckBox()
        {
            return !CheckBox.IsDefault;
        }
        #endregion

        #region RadioButton
        /// <summary>
        /// Gets and sets the ribbon radio button images.
        /// </summary>
        [Category("Values")]
        [Description("Ribbon radio button images.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RadioButtonImages RadioButton { get; }

        private bool ShouldSerializeRadioButton()
        {
            return !RadioButton.IsDefault;
        }
        #endregion

        #region Implementation
        internal PaletteRedirectCheckBox InternalCheckBox { get; }

        internal PaletteRedirectRadioButton InternalRadioButton { get; }

        #endregion
    }
}
