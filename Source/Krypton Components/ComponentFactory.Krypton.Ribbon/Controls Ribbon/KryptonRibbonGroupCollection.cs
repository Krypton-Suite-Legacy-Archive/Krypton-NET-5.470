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

using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Specialise the generic collection with type specific rules for group item accessor.
    /// </summary>
    public class KryptonRibbonGroupCollection : TypedCollection<KryptonRibbonGroup>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon group instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KryptonRibbonGroup this[string name]
        {
            get
            {
                // Search for a group with the same text as that requested.
                foreach (KryptonRibbonGroup group in this)
                {
                    if ((@group.TextLine1 == name) ||
                        (@group.TextLine2 == name) ||
                        ((@group.TextLine1 + " " + @group.TextLine2) == name))
                    {
                        return @group;
                    }
                }

                // Let base class perform standard processing
                return base[name];
            }
        }
        #endregion
    }
}
