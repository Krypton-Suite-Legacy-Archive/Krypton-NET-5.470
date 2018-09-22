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

namespace Krypton.Workspace
{
	/// <summary>
	/// Workspace cell event data.
	/// </summary>
	public class WorkspaceCellEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the WorkspaceCellEventArgs class.
		/// </summary>
        /// <param name="cell">Workspace cell associated with the event.</param>
        public WorkspaceCellEventArgs(KryptonWorkspaceCell cell)
		{
            Cell = cell;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the cell reference.
		/// </summary>
        public KryptonWorkspaceCell Cell { get; }

	    #endregion
	}
}
