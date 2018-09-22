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

using System.Windows.Forms;
using System.Drawing;

namespace Krypton.Toolkit
{
	/// <summary>
	/// Details for an cancellable event that provides a position, offset and control value.
	/// </summary>
    public class DragStartEventCancelArgs : PointEventCancelArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DragStartEventCancelArgs class.
		/// </summary>
        /// <param name="point">Point associated with event.</param>
        /// <param name="offset">Offset associated with event.</param>
        /// <param name="c">Control that is generating the drag start.</param>
        public DragStartEventCancelArgs(Point point, Point offset, Control c)
            : base(point)
		{
            Offset = offset;
            Control = c;
		}
		#endregion

        #region Point
        /// <summary>
		/// Gets and sets the offset.
		/// </summary>
        public Point Offset { get; set; }

	    #endregion

        #region Point
        /// <summary>
        /// Gets the control starting the drag.
        /// </summary>
        public Control Control { get; }

	    #endregion
    }
}
