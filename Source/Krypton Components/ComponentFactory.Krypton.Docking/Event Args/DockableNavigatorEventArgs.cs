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

using System;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a DockableNavigatorEventArgs event.
	/// </summary>
	public class DockableNavigatorEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockableNavigatorEventArgs class.
		/// </summary>
        /// <param name="navigator">Reference to dockable navigator control instance.</param>
        /// <param name="element">Reference to docking navigator element that is managing the dockable workspace control.</param>
        public DockableNavigatorEventArgs(KryptonDockableNavigator navigator,
                                          KryptonDockingNavigator element)
		{
            DockableNavigatorControl = navigator;
            DockingNavigatorElement = element;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonDockableNavigator control.
        /// </summary>
        public KryptonDockableNavigator DockableNavigatorControl { get; }

	    /// <summary>
        /// Gets a reference to the KryptonDockingNavigator that is managing the dockable workspace control.
        /// </summary>
        public KryptonDockingNavigator DockingNavigatorElement { get; }

	    #endregion
	}
}
