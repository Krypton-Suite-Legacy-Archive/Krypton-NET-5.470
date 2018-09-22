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
    /// Event arguments for events that need to provide a store page reference.
	/// </summary>
	public class StorePageEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the StorePageEventArgs class.
		/// </summary>
        /// <param name="storePage">Reference to store page that is associated with the event.</param>
        public StorePageEventArgs(KryptonStorePage storePage)
		{
            StorePage = storePage;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to store page that is associated with the event.
        /// </summary>
        public KryptonStorePage StorePage { get; }

	    #endregion
	}
}
