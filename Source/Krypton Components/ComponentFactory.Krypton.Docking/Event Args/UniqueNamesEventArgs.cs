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
    /// Event arguments for events that need to provide a set of unique names.
	/// </summary>
	public class UniqueNamesEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the UniqueNamesEventArgs class.
		/// </summary>
        /// <param name="uniqueNames">Array of unique names.</param>
        public UniqueNamesEventArgs(string[] uniqueNames)
		{
            UniqueNames = uniqueNames;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets the array of unique names associated with the event.
        /// </summary>
        public string[] UniqueNames { get; }

	    #endregion
	}
}
