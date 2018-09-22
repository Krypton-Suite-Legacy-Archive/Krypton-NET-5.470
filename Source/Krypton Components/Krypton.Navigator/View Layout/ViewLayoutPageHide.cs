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

using System.Drawing;
using System.Diagnostics;
using Krypton.Toolkit;

namespace Krypton.Navigator
{
	/// <summary>
	/// View element that positions the selected page so it cannot be seen.
	/// </summary>
    internal class ViewLayoutPageHide : ViewLayoutNull
	{
        #region Static Fields

	    private const int HIDDEN_OFFSET = 1000000;

	    #endregion

		#region Instance Fields
		private readonly KryptonNavigator _navigator;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the ViewLayoutPageHide class.
		/// </summary>
        public ViewLayoutPageHide(KryptonNavigator navigator)
		{
			Debug.Assert(navigator != null);

			// Remember back reference
			_navigator = navigator;
		}

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewLayoutPageHide:" + Id;
		}
		#endregion

		#region Layout
		/// <summary>
		/// Discover the preferred size of the element.
		/// </summary>
		/// <param name="context">Layout context.</param>
		public override Size GetPreferredSize(ViewLayoutContext context)
		{
			Debug.Assert(context != null);
            return Size.Empty;
		}

		/// <summary>
		/// Perform a layout of the elements.
		/// </summary>
		/// <param name="context">Layout context.</param>
		public override void Layout(ViewLayoutContext context)
		{
			Debug.Assert(context != null);

			// We take on all the available display area
			ClientRectangle = context.DisplayRectangle;

            // Are we allowed to layout child controls?
            if (!context.ViewManager.DoNotLayoutControls)
            {
                // Are we allowed to actually layout the pages?
                if (_navigator.InternalCanLayout)
                {
                    // Do not position the child panel if it is borrowed
                    if (!_navigator.IsChildPanelBorrowed)
                    {
                        // Position the child panel for showing page information
                        _navigator.ChildPanel.SetBounds(HIDDEN_OFFSET,
                                                        HIDDEN_OFFSET,
                                                        ClientWidth,
                                                        ClientHeight);
                    }
                }
            }
		}
		#endregion
	}
}
