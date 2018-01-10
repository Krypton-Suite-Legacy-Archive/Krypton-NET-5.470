// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;

namespace ComponentFactory.Krypton.Toolkit
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
