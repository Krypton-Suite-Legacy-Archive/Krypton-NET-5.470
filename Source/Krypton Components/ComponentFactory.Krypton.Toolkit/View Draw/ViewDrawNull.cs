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

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Draw a red rectangle in the location of the null element.
    /// </summary>
    public class ViewDrawNull : ViewLayoutNull
    {
        #region Instance Fields
        private readonly Color _fillColor;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawNull class.
		/// </summary>
        /// <param name="fillColor">Color to fill drawing area.</param>
        public ViewDrawNull(Color fillColor)
		{
            _fillColor = fillColor;
		}

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
            return "ViewDrawNull:" + Id;
		}
		#endregion

		#region Paint
		/// <summary>
		/// Perform rendering before child elements are rendered.
		/// </summary>
		/// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            using(SolidBrush fillBrush = new SolidBrush(_fillColor))
            {
                context.Graphics.FillRectangle(fillBrush, ClientRectangle);
            }
        }
        #endregion
    }
}
