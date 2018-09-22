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

using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
    /// <summary>
    /// Dictionary lookup from unique name to the KryptonPage.
    /// </summary>
    public class UniqueNameToPage : Dictionary<string, KryptonPage> { };

    /// <summary>
    /// Specialise the generic collection event args with specific type.
    /// </summary>
    public class KryptonPageEventArgs : TypedCollectionEventArgs<KryptonPage> 
    {
        #region Public
        /// <summary>
        /// Initialize a new instance of the KryptonPageEventArgs class.
        /// </summary>
        /// <param name="item">Page effected by event.</param>
        /// <param name="index">Index of page in the owning collection.</param>
        public KryptonPageEventArgs(KryptonPage item, int index)
            : base(item, index)
        {
        }
        #endregion
    }

    /// <summary>
    /// Specialise the generic collection with type specific rules for item accessor.
    /// </summary>
    public class KryptonPageCollection : TypedCollection<KryptonPage>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon tab instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KryptonPage this[string name]
        {
            get
            {
                // First priority is the UniqueName
                foreach (KryptonPage page in this)
                {
                    if (page.UniqueName == name)
                    {
                        return page;
                    }
                }

                // Second priority is the design time Name
                foreach (KryptonPage page in this)
                {
                    if (page.Name == name)
                    {
                        return page;
                    }
                }

                // Third priority is the Text of the page
                foreach (KryptonPage page in this)
                {
                    if (page.Text == name)
                    {
                        return page;
                    }
                }

                // Let base class perform standard processing
                return base[name];
            }
        }

        /// <summary>
        /// Gets the number of visible pages in the collection.
        /// </summary>
        public int VisibleCount
        {
            get
            {
                int visibleCount = 0;

                // Count the number of pages that are visible
                foreach (KryptonPage page in this)
                {
                    if (page.LastVisibleSet)
                    {
                        visibleCount++;
                    }
                }

                return visibleCount;
            }
        }
        #endregion
    }
}

