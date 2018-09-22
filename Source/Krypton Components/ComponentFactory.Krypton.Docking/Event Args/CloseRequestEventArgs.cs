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

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for the PageCloseRequest event.
	/// </summary>
    public class CloseRequestEventArgs : UniqueNameEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the CloseRequestEventArgs class.
		/// </summary>
        /// <param name="uniqueName">Unique name of the page associated with the event.</param>
        /// <param name="closeRequest">Initial close action to use.</param>
        public CloseRequestEventArgs(string uniqueName, DockingCloseRequest closeRequest)
            : base(uniqueName)
		{
            CloseRequest = closeRequest;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets and sets the close action to be performed.
        /// </summary>
        public DockingCloseRequest CloseRequest { get; set; }

	    #endregion
	}
}
