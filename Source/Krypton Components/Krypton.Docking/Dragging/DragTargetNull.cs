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
using Krypton.Navigator;

namespace Krypton.Docking
{
    /// <summary>
    /// Target that never matches and so acts as a null drag target.
    /// </summary>
    public class DragTargetNull : DragTarget
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the DragTargetNull class.
        /// </summary>
        public DragTargetNull()
            : base(Rectangle.Empty, Rectangle.Empty, Rectangle.Empty, DragTargetHint.None, KryptonPageFlags.All)
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Perform the drop action associated with the target.
        /// </summary>
        /// <param name="screenPt">Position in screen coordinates.</param>
        /// <param name="data">Data to pass to the target to process drop.</param>
        /// <returns>Drop was performed and the source can perform any removal of pages as required.</returns>
        public override bool PerformDrop(Point screenPt, PageDragEndData data)
        {
            return true;
        }
        #endregion
    }
}
