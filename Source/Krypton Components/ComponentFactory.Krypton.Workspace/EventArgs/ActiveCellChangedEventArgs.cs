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

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Data associated with a change in the active cell.
	/// </summary>
	public class ActiveCellChangedEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ActiveCellChangedEventArgs class.
		/// </summary>
        /// <param name="oldCell">Previous active cell value.</param>
        /// <param name="newCell">New active cell value.</param>
        public ActiveCellChangedEventArgs(KryptonWorkspaceCell oldCell,
                                          KryptonWorkspaceCell newCell)
		{
            OldCell = oldCell;
            NewCell = newCell;
        }
		#endregion

		#region Public
		/// <summary>
        /// Gets the old cell reference.
		/// </summary>
        public KryptonWorkspaceCell OldCell { get; }

	    /// <summary>
        /// Gets the new cell reference.
        /// </summary>
        public KryptonWorkspaceCell NewCell { get; }

	    #endregion
	}
}
