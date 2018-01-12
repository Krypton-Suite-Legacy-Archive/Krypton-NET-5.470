// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.1.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Details for context menu related events.
	/// </summary>
	public class ViewControlHitTestArgs : CancelEventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the ViewControlHitTestArgs class.
        /// </summary>
        /// <param name="pt">Point associated with hit test message.</param>
        public ViewControlHitTestArgs(Point pt)
            : base(true)
        {
            Point = pt;
            Result = IntPtr.Zero;
        }
        #endregion

		#region Public
		/// <summary>
		/// Gets access to the point.
		/// </summary>
        public Point Point { get; }

	    /// <summary>
        /// Gets and sets the result.
        /// </summary>
        public IntPtr Result { get; set; }

	    #endregion
	}
}
