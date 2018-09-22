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

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Provides a movement rectangle that will be used to limit separator movement.
	/// </summary>
	public class SplitterMoveRectMenuArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the SplitterMoveRectMenuArgs class.
        /// </summary>
        /// <param name="moveRect">Initial movement rectangle that limits separator movements.</param>
        public SplitterMoveRectMenuArgs(Rectangle moveRect)
        {
            MoveRect = moveRect;
        }
        #endregion

        #region Public
        /// <summary>
		/// Gets and sets the movement box for a separator.
		/// </summary>
        public Rectangle MoveRect { get; set; }

	    #endregion
	}
}
