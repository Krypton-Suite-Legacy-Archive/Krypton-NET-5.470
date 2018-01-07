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
    /// Event arguments for a DockableWorkspaceRemoved event.
	/// </summary>
	public class DockableWorkspaceEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockableWorkspaceEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to dockable workspace control instance.</param>
        /// <param name="element">Reference to docking workspace element that is managing the dockable workspace control.</param>
        public DockableWorkspaceEventArgs(KryptonDockableWorkspace workspace,
                                          KryptonDockingWorkspace element)
		{
            DockableWorkspaceControl = workspace;
            DockingWorkspaceElement = element;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonDockableWorkspace control.
        /// </summary>
        public KryptonDockableWorkspace DockableWorkspaceControl { get; }

	    /// <summary>
        /// Gets a reference to the KryptonDockingWorkspace that is managing the dockable workspace control.
        /// </summary>
        public KryptonDockingWorkspace DockingWorkspaceElement { get; }

	    #endregion
	}
}
