// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// View element that draws empty content.
	/// </summary>
    public class ViewDrawEmptyContent : ViewDrawContent,
                                        IContentValues
    {
        #region Instance Fields
        private readonly IPaletteContent _paletteContentNormal;
        private readonly IPaletteContent _paletteContentDisabled;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ViewDrawEmptyContent class.
		/// </summary>
        /// <param name="paletteContentDisabled">Palette source for the disabled content.</param>
        /// <param name="paletteContentNormal">Palette source for the normal content.</param>
        public ViewDrawEmptyContent(IPaletteContent paletteContentDisabled,
                                    IPaletteContent paletteContentNormal)
            : base(paletteContentNormal, null, VisualOrientation.Top)
		{
            Values = this;
            _paletteContentDisabled = paletteContentDisabled;
            _paletteContentNormal = paletteContentNormal;
        }

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewDrawEmptyContent:" + Id;
		}
		#endregion

        #region Layout
        /// <summary>
		/// Discover the preferred size of the element.
		/// </summary>
		/// <param name="context">Layout context.</param>
		public override Size GetPreferredSize(ViewLayoutContext context)
		{
			Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (Enabled)
            {
                base.SetPalette(_paletteContentNormal);
            }
            else
            {
                base.SetPalette(_paletteContentDisabled);
            }

            return base.GetPreferredSize(context);
        }

		/// <summary>
		/// Perform a layout of the elements.
		/// </summary>
		/// <param name="context">Layout context.</param>
		public override void Layout(ViewLayoutContext context)
		{
			Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (Enabled)
            {
                base.SetPalette(_paletteContentNormal);
            }
            else
            {
                base.SetPalette(_paletteContentDisabled);
            }

            base.Layout(context);
        }
		#endregion

		#region Paint
		/// <summary>
		/// Perform rendering before child elements are rendered.
		/// </summary>
		/// <param name="context">Rendering context.</param>
		public override void RenderBefore(RenderContext context) 
		{
			Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (Enabled)
            {
                base.SetPalette(_paletteContentNormal);
            }
            else
            {
                base.SetPalette(_paletteContentDisabled);
            }

            base.RenderBefore(context);
		}
		#endregion

        #region IContentValues
        /// <summary>
        /// Gets the content image.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Image value.</returns>
        public Image GetImage(PaletteState state)
        {
            return null;
        }

        /// <summary>
        /// Gets the image color that should be transparent.
        /// </summary>
        /// <param name="state">The state for which the image is needed.</param>
        /// <returns>Color value.</returns>
        public Color GetImageTransparentColor(PaletteState state)
        {
            return Color.Empty;
        }

        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetShortText()
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets the content long text.
        /// </summary>
        /// <returns>String value.</returns>
        public string GetLongText()
        {
            return string.Empty;
        }
        #endregion
    }
}
