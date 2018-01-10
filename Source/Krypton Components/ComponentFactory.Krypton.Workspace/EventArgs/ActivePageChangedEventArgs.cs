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
using ComponentFactory.Krypton.Navigator;

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Data associated with a change in the active page.
	/// </summary>
	public class ActivePageChangedEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ActivePageChangedEventArgs class.
		/// </summary>
        /// <param name="oldPage">Previous active page value.</param>
        /// <param name="newPage">New active page value.</param>
        public ActivePageChangedEventArgs(KryptonPage oldPage,
                                          KryptonPage newPage)
		{
            OldPage = oldPage;
            NewPage = newPage;
        }
		#endregion

		#region Public
		/// <summary>
        /// Gets the old page reference.
		/// </summary>
        public KryptonPage OldPage { get; }

	    /// <summary>
        /// Gets the new page reference.
        /// </summary>
        public KryptonPage NewPage { get; }

	    #endregion
	}
}
