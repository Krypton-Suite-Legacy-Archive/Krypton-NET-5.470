// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Drawing;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Create a default value attribute for color property.
    /// </summary>
    public sealed class KryptonDefaultColorAttribute : DefaultValueAttribute
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonDefaultColorAttribute class.
        /// </summary>
        public KryptonDefaultColorAttribute()
            : base(Color.Empty)
        {
        }
        #endregion
    }
}
