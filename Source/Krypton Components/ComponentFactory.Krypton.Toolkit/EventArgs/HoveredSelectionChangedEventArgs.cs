﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Megakraken & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
// ReSharper disable MemberCanBeInternal
// ReSharper disable UnusedMember.Global

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Hovered Selection Changed event data.
    /// </summary>
    public class HoveredSelectionChangedEventArgs : EventArgs
    {
        #region Instance Fields
        private readonly Rectangle _bounds;
        private readonly int _index;
        private readonly object _item;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the HoveredSelectionChangedEventArgs class.
        /// </summary>
        /// <param name="bounds">The bounds of the selected dropdown item.</param>
        /// <param name="index">The index within the dropdown items collection.</param>
        /// <param name="item">The item within the dropdown items collection.</param>
        public HoveredSelectionChangedEventArgs(Rectangle bounds, int index, object item)
        {
            _bounds = bounds;
            _index = index;
            _item = item;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets the bounds.
        /// </summary>
        public Rectangle Bounds => _bounds;

        /// <summary>
        /// Gets the item index.
        /// </summary>
        public int Index=> _index;

        /// <summary>
        /// Gets the item.
        /// </summary>
        public object Item => _item; 

        #endregion
    }
}
