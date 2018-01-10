// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a DockspaceSeparatorResize event.
	/// </summary>
    public class DockspaceSeparatorResizeEventArgs : DockspaceSeparatorEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockspaceSeparatorResizeEventArgs class.
		/// </summary>
        /// <param name="separator">Reference to separator control instance.</param>
        /// <param name="element">Reference to dockspace docking element that is managing the separator.</param>
        /// <param name="resizeRect">Initial resizing rectangle.</param>
        public DockspaceSeparatorResizeEventArgs(KryptonSeparator separator,
                                                 KryptonDockingDockspace element,
                                                 Rectangle resizeRect)
            : base(separator, element)
		{
            ResizeRect = resizeRect;
		}
		#endregion

		#region Public
        /// <summary>
        /// Gets and sets the rectangle that limits resizing of the dockspace using the separator.
        /// </summary>
        public Rectangle ResizeRect { get; set; }

	    #endregion
	}
}
