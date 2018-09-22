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

namespace Krypton.Toolkit
{
	/// <summary>
	/// Details about the context menu that has been closed up on a KryptonDateTimePicker.
	/// </summary>
	public class DateTimePickerCloseArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the DateTimePickerCloseArgs class.
        /// </summary>
        /// <param name="kcm">KryptonContextMenu that can be examined.</param>
        public DateTimePickerCloseArgs(KryptonContextMenu kcm)
        {
            KryptonContextMenu = kcm;
        }
        #endregion

		#region Public
        /// <summary>
        /// Gets access to the KryptonContextMenu instance.
        /// </summary>
        public KryptonContextMenu KryptonContextMenu { get; }

	    #endregion
	}
}
