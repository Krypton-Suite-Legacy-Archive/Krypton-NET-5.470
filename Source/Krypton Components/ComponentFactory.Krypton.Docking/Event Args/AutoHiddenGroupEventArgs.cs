// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a AutoHiddenGroupAdding/AutoHiddenGroupRemoved events.
	/// </summary>
	public class AutoHiddenGroupEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the AutoHiddenGroupEventArgs class.
		/// </summary>
        /// <param name="control">Reference to auto hidden group control instance.</param>
        /// <param name="element">Reference to docking auto hidden group element that is managing the control.</param>
        public AutoHiddenGroupEventArgs(KryptonAutoHiddenGroup control,
                                        KryptonDockingAutoHiddenGroup element)
		{
            AutoHiddenGroupControl = control;
            AutoHiddenGroupElement = element;
		}
		#endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonAutoHiddenGroup control.
        /// </summary>
        public KryptonAutoHiddenGroup AutoHiddenGroupControl { get; }

	    /// <summary>
        /// Gets a reference to the KryptonDockingAutoHiddenGroup that is managing the group.
        /// </summary>
        public KryptonDockingAutoHiddenGroup AutoHiddenGroupElement { get; }

	    #endregion
	}
}
