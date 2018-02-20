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

using System;
using System.Drawing;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Details for a tooltip related event.
	/// </summary>
	public class ToolTipEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ButtonSpecEventArgs class.
		/// </summary>
        /// <param name="target">Reference to view element that requires tooltip.</param>
        /// <param name="screenPt">Screen location of mouse when tooltip was required.</param>
        public ToolTipEventArgs(ViewBase target, Point screenPt)
		{
            Debug.Assert(target != null);

			// Remember parameter details
            Target = target;
            ScreenPt = screenPt;
		}
		#endregion

		#region Public
		/// <summary>
		/// Gets the view element that is related to the tooltip.
		/// </summary>
        public ViewBase Target { get; }

	    /// <summary>
		/// Gets the screen point of the mouse where tooltip is required.
		/// </summary>
        public Point ScreenPt { get; }

	    #endregion
	}
}
