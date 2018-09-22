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

using Krypton.Toolkit;

namespace Krypton.Ribbon
{
    /// <summary>
    /// Specialise the generic collection with type specific rules for tab item accessor.
    /// </summary>
    public class KryptonRibbonTabCollection : TypedCollection<KryptonRibbonTab>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon tab instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KryptonRibbonTab this[string name]
        {
            get
            {
                // Search for a tab with the same text as that requested.
                foreach(KryptonRibbonTab tab in this)
                {
                    if (tab.Text == name)
                    {
                        return tab;
                    }
                }

                // Let base class perform standard processing
                return base[name];
            }
        }
        #endregion
    }
}
