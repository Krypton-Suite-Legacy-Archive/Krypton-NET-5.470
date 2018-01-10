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
using System.Drawing.Text;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Encapsulate the information needed to draw text using the AccurateText class.
	/// </summary>
    public class AccurateTextMemento : GlobalId,
                                       IDisposable
	{
		#region Static Fields
		private static AccurateTextMemento _empty;
		#endregion

		#region Instance Fields
        private readonly bool _disposeFont;
	    private TextRenderingHint _hint;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the TextMemento class.
		/// </summary>
        /// <param name="text">Text to draw.</param>
        /// <param name="font">Drawing font.</param>
        /// <param name="sizeF">Size of measured text.</param>
        /// <param name="format">String formatting.</param>
        /// <param name="hint">Drawing hint.</param>
        /// <param name="disposeFont">Should the font be disposed.</param>
        internal AccurateTextMemento(string text,
                                     Font font,
                                     SizeF sizeF,
                                     StringFormat format,
                                     TextRenderingHint hint,
                                     bool disposeFont)
		{
            Text = text;
            Size = new Size((int)sizeF.Width + 1, (int)sizeF.Height + 1);
            Font = font;
            Format = format;
            _hint = hint;
            _disposeFont = disposeFont;
		}

        /// <summary>
        /// Dispose of the memento resources.
        /// </summary>
        public void Dispose()
        {
            if (_disposeFont && (Font != null))
            {
                Font.Dispose();
                Font = null;
            }
        }
		#endregion

		#region Public Properties
        /// <summary>
        /// Gets the text to draw.
        /// </summary>
        public string Text { get; }

	    /// <summary>
        /// Gets the drawing font.
        /// </summary>
        public Font Font { get; set; }

	    /// <summary>
        /// Gets the pixel size of the text area.
        /// </summary>
        public Size Size { get; }

	    /// <summary>
        /// Gets the pixel size of the text area.
        /// </summary>
        public StringFormat Format { get; }

	    /// <summary>
        /// Gets a value indicating if the memento represents nothing that can be drawn.
        /// </summary>
        public bool IsEmpty => (Size == Size.Empty);

	    #endregion

		#region Internal Static Properties
		/// <summary>
		/// Get access to an empty TextMemento instance.
		/// </summary>
		/// <remarks>
		/// Only create the single instance when first requested
		/// </remarks>
		internal static AccurateTextMemento Empty => _empty ?? (_empty = new AccurateTextMemento(string.Empty,
		                                                 null,
		                                                 Size.Empty,
		                                                 StringFormat.GenericDefault,
		                                                 TextRenderingHint.SystemDefault,
		                                                 false));

	    #endregion
    }
}
