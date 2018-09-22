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

namespace Krypton.Toolkit
{
	/// <summary>
	/// Override the contained child to present a fixed size.
	/// </summary>
    public class ViewDecoratorFixedSize : ViewDecorator
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the ViewBase class.
		/// </summary>
        public ViewDecoratorFixedSize(ViewBase child, Size fixedSize)
            : base(child)
		{
            FixedSize = fixedSize;

		}

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewDecoratorFixedSize:" + Id;
		}
		#endregion

        #region FixedSize
        /// <summary>
        /// Gets and sets the fixed size for laying out the contained child element.
        /// </summary>
        public Size FixedSize { get; set; }

	    #endregion

        #region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            // Always provide the requested fixed size
            return FixedSize;
        }
        #endregion
    }
}
