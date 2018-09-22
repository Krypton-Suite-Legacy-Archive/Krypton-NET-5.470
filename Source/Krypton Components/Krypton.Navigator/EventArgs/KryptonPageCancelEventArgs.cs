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

namespace Krypton.Navigator
{
	/// <summary>
	/// Details for page related events that can be cancelled.
	/// </summary>
	public class KryptonPageCancelEventArgs : KryptonPageEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KryptonCancelPageEventArgs class.
		/// </summary>
		/// <param name="page">Page effected by event.</param>
		/// <param name="index">Index of page in the owning collection.</param>
		public KryptonPageCancelEventArgs(KryptonPage page, int index)
			: base(page, index)
		{
		}
		#endregion

		#region Cancel
		/// <summary>
		/// Gets the page associated with the event.
		/// </summary>
		public bool Cancel { get; set; }

	    #endregion
	}
}
