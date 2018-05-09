// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using Krypton.Toolkit;

namespace Krypton.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to a ribbon group triple container.
    /// </summary>
    public class Krypton.RibbonGroupTripleCollection : TypedRestrictCollection<Krypton.RibbonGroupItem>
    {
        #region Static Fields
        private static readonly Type[] _types = { typeof(Krypton.RibbonGroupButton),
                                                             typeof(Krypton.RibbonGroupColorButton),
                                                             typeof(Krypton.RibbonGroupCheckBox),
                                                             typeof(Krypton.RibbonGroupComboBox),
                                                             typeof(Krypton.RibbonGroupCustomControl),
                                                             typeof(Krypton.RibbonGroupDateTimePicker),
                                                             typeof(Krypton.RibbonGroupDomainUpDown),
                                                             typeof(Krypton.RibbonGroupLabel),
                                                             typeof(Krypton.RibbonGroupNumericUpDown),
                                                             typeof(Krypton.RibbonGroupRadioButton),
                                                             typeof(Krypton.RibbonGroupRichTextBox),
                                                             typeof(Krypton.RibbonGroupTextBox),
                                                             typeof(Krypton.RibbonGroupTrackBar),
                                                             typeof(Krypton.RibbonGroupMaskedTextBox)
                                                           };
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes => _types;

        #endregion

        #region IList
        /// <summary>
        /// Append an item to the collection.
        /// </summary>
        /// <param name="value">Object reference.</param>
        /// <returns>The position into which the new item was inserted.</returns>
        public override int Add(object value)
        {
            // Restrict contents to three items max
            if (Count == 3)
            {
                throw new ArgumentException("Collection can only contain 3 entries.");
            }

            return base.Add(value);
        }

        /// <summary>
        /// Inserts an item to the collection at the specified index.
        /// </summary>
        /// <param name="index">Insert index.</param>
        /// <param name="value">Object reference.</param>
        public override void Insert(int index, object value)
        {
            // Restrict contents to three items max
            if (Count == 3)
            {
                throw new ArgumentException("Collection can only contain 3 entries.");
            }

            base.Insert(index, value);
        }
        #endregion

        #region IList<Krypton.RibbonGroupItem>
        /// <summary>
        /// Inserts an item to the collection at the specified index.
        /// </summary>
        /// <param name="index">Insert index.</param>
        /// <param name="item">Item reference.</param>
        public override void Insert(int index, Krypton.RibbonGroupItem item)
        {
            // Restrict contents to three items max
            if (Count == 3)
            {
                throw new ArgumentException("Collection can only contain 3 entries.");
            }

            base.Insert(index, item);
        }
        #endregion

        #region ICollection<Krypton.RibbonGroupItem>
        /// <summary>
        /// Append an item to the collection.
        /// </summary>
        /// <param name="item">Item reference.</param>
        public override void Add(Krypton.RibbonGroupItem item)
        {
            // Restrict contents to three items max
            if (Count == 3)
            {
                throw new ArgumentException("Collection can only contain 3 entries.");
            }

            base.Add(item);
        }
        #endregion
    }
}
