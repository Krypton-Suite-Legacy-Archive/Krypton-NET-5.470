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
using System.Collections.Generic;
using ComponentFactory.Krypton.Navigator;

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Event data for listing pages unmatched during the load process.
	/// </summary>
	public class PagesUnmatchedEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PagesUnmatchedEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="unmatched">List of pages unmatched during the load process.</param>
        public PagesUnmatchedEventArgs(KryptonWorkspace workspace,
                                       List<KryptonPage> unmatched)
		{
            Workspace = workspace;
            Unmatched = unmatched;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the workspace reference.
		/// </summary>
        public KryptonWorkspace Workspace { get; }

	    /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public List<KryptonPage> Unmatched { get; }

	    #endregion
	}
}
