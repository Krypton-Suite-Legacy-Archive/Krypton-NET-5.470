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

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a FloatingWindowAdding/FloatingWindowRemoved event.
	/// </summary>
	public class FloatingWindowEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the FloatingWindowEventArgs class.
		/// </summary>
        /// <param name="floatingWindow">Reference to floating window instance.</param>
        /// <param name="element">Reference to docking floating winodw element that is managing the floating window.</param>
        public FloatingWindowEventArgs(KryptonFloatingWindow floatingWindow,
                                       KryptonDockingFloatingWindow element)
		{
            FloatingWindow = floatingWindow;
            FloatingWindowElement = element;
		}
		#endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonFloatingWindow control.
        /// </summary>
        public KryptonFloatingWindow FloatingWindow { get; }

	    /// <summary>
        /// Gets a reference to the KryptonDockingFloatingWindow that is managing the dockspace.
        /// </summary>
        public KryptonDockingFloatingWindow FloatingWindowElement { get; }

	    #endregion
	}
}
