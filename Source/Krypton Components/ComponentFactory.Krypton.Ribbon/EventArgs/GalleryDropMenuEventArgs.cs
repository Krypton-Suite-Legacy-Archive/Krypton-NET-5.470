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
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	/// <summary>
	/// Event arguments for the drop down menu of a gallery.
	/// </summary>
	public class GalleryDropMenuEventArgs : CancelEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the GalleryDropMenuEventArgs class.
		/// </summary>
        /// <param name="contextMenu">Context menu.</param>
        public GalleryDropMenuEventArgs(KryptonContextMenu contextMenu)
		{
            KryptonContextMenu = contextMenu;
		}
		#endregion

		#region Public
		/// <summary>
		/// KryptonContextMenu for display.
		/// </summary>
        public KryptonContextMenu KryptonContextMenu { get; }

	    #endregion
	}
}
