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

namespace Krypton.Docking
{
	/// <summary>
    /// Event arguments for events that need to provide a unique name.
	/// </summary>
	public class UniqueNameEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the UniqueNameEventArgs class.
		/// </summary>
        /// <param name="uniqueName">Unique name of page.</param>
        public UniqueNameEventArgs(string uniqueName)
		{
            UniqueName = uniqueName;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets the unique name of a page.
        /// </summary>
        public string UniqueName { get; }

	    #endregion
	}
}
