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
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
    /// Redirect storage for KryptonContextMenu common values.
	/// </summary>
	public class PaletteContextMenuRedirect : Storage
	{
		#region Instance Fields

	    #endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteContextMenuRedirect class.
		/// </summary>
        /// <param name="redirect">Inheritence redirection.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PaletteContextMenuRedirect(PaletteRedirect redirect,
                                          NeedPaintHandler needPaint)
		{
            Debug.Assert(redirect != null);

            // Create the palette storage
            ControlInner = new PaletteDoubleRedirect(redirect, PaletteBackStyle.ContextMenuInner, PaletteBorderStyle.ContextMenuInner, needPaint);
            ControlOuter = new PaletteDoubleRedirect(redirect, PaletteBackStyle.ContextMenuOuter, PaletteBorderStyle.ContextMenuOuter, needPaint);
            Heading = new PaletteTripleRedirect(redirect, PaletteBackStyle.ContextMenuHeading, PaletteBorderStyle.ContextMenuHeading, PaletteContentStyle.ContextMenuHeading, needPaint);
            ItemHighlight = new PaletteDoubleMetricRedirect(redirect, PaletteBackStyle.ContextMenuItemHighlight, PaletteBorderStyle.ContextMenuItemHighlight, needPaint);
            ItemImage = new PaletteTripleJustImageRedirect(redirect, PaletteBackStyle.ContextMenuItemImage, PaletteBorderStyle.ContextMenuItemImage, PaletteContentStyle.ContextMenuItemImage, needPaint);
            ItemImageColumn = new PaletteDoubleRedirect(redirect, PaletteBackStyle.ContextMenuItemImageColumn, PaletteBorderStyle.ContextMenuItemImageColumn, needPaint);
            ItemShortcutTextRedirect = new PaletteContentInheritRedirect(redirect, PaletteContentStyle.ContextMenuItemShortcutText);
            ItemShortcutText = new PaletteContentJustShortText(ItemShortcutTextRedirect, needPaint);
            ItemSplit = new PaletteDoubleRedirect(redirect, PaletteBackStyle.ContextMenuItemSplit, PaletteBorderStyle.ContextMenuItemSplit, needPaint);
            ItemTextAlternateRedirect = new PaletteContentInheritRedirect(redirect, PaletteContentStyle.ContextMenuItemTextAlternate);
            ItemTextAlternate = new PaletteContentJustText(ItemTextAlternateRedirect, needPaint);
            ItemTextStandardRedirect = new PaletteContentInheritRedirect(redirect, PaletteContentStyle.ContextMenuItemTextStandard);
            ItemTextStandard = new PaletteContentJustText(ItemTextStandardRedirect, needPaint);
            Separator = new PaletteDoubleRedirect(redirect, PaletteBackStyle.ContextMenuSeparator, PaletteBorderStyle.ContextMenuSeparator, needPaint);
        }
		#endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (ControlInner.IsDefault &&
		                                   ControlOuter.IsDefault &&
		                                   Heading.IsDefault &&
		                                   ItemHighlight.IsDefault &&
		                                   ItemImage.IsDefault &&
		                                   ItemImageColumn.IsDefault &&
		                                   ItemShortcutText.IsDefault &&
		                                   ItemSplit.IsDefault &&
		                                   ItemTextAlternate.IsDefault &&
		                                   ItemTextStandard.IsDefault &&
		                                   Separator.IsDefault);

	    #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="common">Reference to common settings.</param>
        /// <param name="state">State to inherit.</param>
        public void PopulateFromBase(KryptonPaletteCommon common,
                                     PaletteState state)
        {
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuInner;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuInner;
            ControlInner.PopulateFromBase(state);
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuOuter;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuOuter;
            ControlOuter.PopulateFromBase(state);
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuHeading;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuHeading;
            common.StateCommon.ContentStyle = PaletteContentStyle.ContextMenuHeading;
            Heading.PopulateFromBase(state);
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuItemImageColumn;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuItemImageColumn;
            ItemImageColumn.PopulateFromBase(state);
            common.StateCommon.BackStyle = PaletteBackStyle.ContextMenuSeparator;
            common.StateCommon.BorderStyle = PaletteBorderStyle.ContextMenuSeparator;
            Separator.PopulateFromBase(state);
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public void SetRedirector(PaletteRedirect redirect)
        {
            ControlInner.SetRedirector(redirect);
            ControlOuter.SetRedirector(redirect);
            Heading.SetRedirector(redirect);
            ItemHighlight.SetRedirector(redirect);
            ItemImage.SetRedirector(redirect);
            ItemImageColumn.SetRedirector(redirect);
            ItemShortcutTextRedirect.SetRedirector(redirect);
            ItemSplit.SetRedirector(redirect);
            ItemTextAlternateRedirect.SetRedirector(redirect);
            ItemTextStandardRedirect.SetRedirector(redirect);
            Separator.SetRedirector(redirect);
        }
        #endregion

        #region ControlInner
        /// <summary>
        /// Gets access to the inner control window appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining inner control window appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect ControlInner { get; }

	    private bool ShouldSerializeControlInner()
        {
            return !ControlInner.IsDefault;
        }
        #endregion

        #region ControlOuter
        /// <summary>
        /// Gets access to the outer control window appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining outer control window appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect ControlOuter { get; }

	    private bool ShouldSerializeControlOuter()
        {
            return !ControlOuter.IsDefault;
        }
        #endregion

        #region Heading
        /// <summary>
		/// Gets access to the heading entry appearance entries.
		/// </summary>
        [KryptonPersist]
        [Category("Visuals")]
		[Description("Overrides for defining header entry appearance.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleRedirect Heading { get; }

	    private bool ShouldSerializeHeading()
		{
            return !Heading.IsDefault;
		}
		#endregion

        #region ItemHighlight
        /// <summary>
        /// Gets access to the item highlight appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining item highlight appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleMetricRedirect ItemHighlight { get; }

	    private bool ShouldSerializeItemHighlight()
        {
            return !ItemHighlight.IsDefault;
        }
        #endregion

        #region ItemImage
        /// <summary>
        /// Gets access to the item image appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining item image appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteTripleJustImageRedirect ItemImage { get; }

	    private bool ShouldSerializeItemImage()
        {
            return !ItemImage.IsDefault;
        }
        #endregion

        #region ItemImageColumn
        /// <summary>
        /// Gets access to the item image column appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining item image column appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect ItemImageColumn { get; }

	    private bool ShouldSerializeItemImageColumn()
        {
            return !ItemImageColumn.IsDefault;
        }
        #endregion

        #region ItemShortcutText
        /// <summary>
        /// Gets access to the item shortcut text appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining item shortcut text appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteContentJustShortText ItemShortcutText { get; }

	    private bool ShouldSerializeItemShortcutText()
        {
            return !ItemShortcutText.IsDefault;
        }
        #endregion

        #region ItemSplit
        /// <summary>
        /// Gets access to the item split appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining item split appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect ItemSplit { get; }

	    private bool ShouldSerializeItemItemSplit()
        {
            return !ItemSplit.IsDefault;
        }
        #endregion

        #region ItemTextAlternate
        /// <summary>
        /// Gets access to the alternate item text appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining alternate item text appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteContentJustText ItemTextAlternate { get; }

	    private bool ShouldSerializeItemTextAlternate()
        {
            return !ItemTextAlternate.IsDefault;
        }
        #endregion

        #region ItemTextStandard
        /// <summary>
        /// Gets access to the standard item text appearance entries.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining standard item text appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteContentJustText ItemTextStandard { get; }

	    private bool ShouldSerializeItemTextStandard()
        {
            return !ItemTextStandard.IsDefault;
        }
        #endregion

        #region Separator
        /// <summary>
        /// Gets access to the separator items appearance entries.
        /// </summary>
        [KryptonPersist]
        [Category("Visuals")]
        [Description("Overrides for defining separator items appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PaletteDoubleRedirect Separator { get; }

	    private bool ShouldSerializeSeparator()
        {
            return !Separator.IsDefault;
        }
        #endregion

        #region Internal
        internal PaletteContentInheritRedirect ItemShortcutTextRedirect { get; }

	    internal PaletteContentInheritRedirect ItemTextStandardRedirect { get; }

	    internal PaletteContentInheritRedirect ItemTextAlternateRedirect { get; }

	    #endregion
    }
}
