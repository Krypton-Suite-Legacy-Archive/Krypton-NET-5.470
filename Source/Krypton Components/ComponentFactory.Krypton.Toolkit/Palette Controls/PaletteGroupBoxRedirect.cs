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
    /// Redirect storage for GroupBox states.
	/// </summary>
	public class PaletteGroupBoxRedirect : PaletteDoubleRedirect
	{
		#region Instance Fields

	    private readonly PaletteContentInheritRedirect _contentInherit;
        #endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the PaletteGroupBoxRedirect class.
		/// </summary>
		/// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteGroupBoxRedirect(PaletteRedirect redirect,
                                       NeedPaintHandler needPaint)
            : this(redirect, redirect, needPaint)
        {
        }

        /// <summary>
        /// Initialize a new instance of the PaletteGroupBoxRedirect class.
		/// </summary>
        /// <param name="redirectDouble">Inheritence redirection for group border/background.</param>
        /// <param name="redirectContent">Inheritence redirection for group header.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteGroupBoxRedirect(PaletteRedirect redirectDouble,
                                       PaletteRedirect redirectContent,
                                       NeedPaintHandler needPaint)
            : base(redirectDouble, PaletteBackStyle.ControlGroupBox, PaletteBorderStyle.ControlGroupBox, needPaint)
		{
            Debug.Assert(redirectDouble != null);
            Debug.Assert(redirectContent != null);

            _contentInherit = new PaletteContentInheritRedirect(redirectContent, PaletteContentStyle.LabelGroupBoxCaption);
            Content = new PaletteContent(_contentInherit, needPaint);
		}
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (base.IsDefault && Content.IsDefault);

	    #endregion

        #region Content
        /// <summary>
        /// Gets access to the content palette details.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining content appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteContent Content { get; }

	    private bool ShouldSerializeContent()
        {
            return !Content.IsDefault;
        }

        /// <summary>
        /// Gets the content palette.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IPaletteContent PaletteContent => Content;

	    /// <summary>
        /// Gets and sets the content palette style.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PaletteContentStyle ContentStyle
        {
            get => _contentInherit.Style;
            set => _contentInherit.Style = value;
        }
		#endregion
    }
}
