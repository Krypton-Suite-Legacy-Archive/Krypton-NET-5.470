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

using System;
using System.ComponentModel.Design;

namespace ComponentFactory.Krypton.Ribbon
{
	internal class KryptonRibbonQATButtonCollectionEditor : CollectionEditor
	{
		/// <summary>
        /// Initialize a new instance of the KryptonRibbonQATButtonCollectionEditor class.
		/// </summary>
        public KryptonRibbonQATButtonCollectionEditor()
            : base(typeof(KryptonRibbonQATButtonCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
			return new Type[] { typeof(KryptonRibbonQATButton) };
		}

		/// <summary>
		/// Sets the specified array as the items of the collection.
		/// </summary>
		/// <param name="editValue">The collection to edit.</param>
		/// <param name="value">An array of objects to set as the collection items.</param>
		/// <returns>The newly created collection object.</returns>
		protected override object SetItems(object editValue, object[] value)
		{
			// Cast the context into the expected control type
            KryptonRibbon ribbon = (KryptonRibbon)Context.Instance;

			// Suspend changes until collection has been updated
		    ribbon?.SuspendLayout();

		    // Let base class update the collection
			object ret = base.SetItems(editValue, value);

		    ribbon?.ResumeLayout(true);

		    return ret;
		}
	}
}
