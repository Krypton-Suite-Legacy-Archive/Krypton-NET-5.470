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
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Details for button specification related events.
	/// </summary>
	public class ButtonSpecEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ButtonSpecEventArgs class.
		/// </summary>
        /// <param name="spec">Button spec effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
        public ButtonSpecEventArgs(ButtonSpec spec, int index)
		{
            Debug.Assert(spec != null);
			Debug.Assert(index >= 0);

			// Remember parameter details
            ButtonSpec = spec;
			Index = index;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the navigator button spec associated with the event.
		/// </summary>
		public ButtonSpec ButtonSpec { get; }

	    /// <summary>
		/// Gets the index of ButtonSpec associated with the event.
		/// </summary>
		public int Index { get; }

	    #endregion
	}
}
