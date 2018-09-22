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

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Provide a KryptonPageFlags enumeration with event details.
	/// </summary>
	public class KryptonPageFlagsEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the KryptonPageFlagsEventArgs class.
		/// </summary>
        /// <param name="flags">KryptonPageFlags enumeration.</param>
        public KryptonPageFlagsEventArgs(KryptonPageFlags flags)
		{
			// Remember parameter details
            Flags = flags;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the KryptonPageFlags enumeration value.
		/// </summary>
        public KryptonPageFlags Flags { get; }

	    #endregion
	}
}
