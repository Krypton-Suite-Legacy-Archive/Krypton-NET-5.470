// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace Krypton.Navigator
{
	/// <summary>
	/// Details for control tabbing events.
	/// </summary>
	public class CtrlTabCancelEventArgs : CancelEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the CtrlTabCancelEventArgs class.
		/// </summary>
        /// <param name="forward">Tabbing in forward or backwards direction.</param>
        public CtrlTabCancelEventArgs(bool forward)
		{
            Forward = forward;
		}
		#endregion

		#region Forward
		/// <summary>
		/// Gets a value indicating if control tabbing forward.
		/// </summary>
		public bool Forward { get; }

	    #endregion
    }
}
