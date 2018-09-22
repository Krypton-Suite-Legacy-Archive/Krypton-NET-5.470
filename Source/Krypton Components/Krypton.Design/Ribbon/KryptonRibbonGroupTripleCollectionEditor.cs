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
using System.ComponentModel.Design;

namespace Krypton.Ribbon
{
	internal class Krypton.RibbonGroupTripleCollectionEditor : CollectionEditor
	{
		/// <summary>
        /// Initialize a new instance of the Krypton.RibbonGroupTripleCollectionEditor class.
		/// </summary>
        public Krypton.RibbonGroupTripleCollectionEditor()
            : base(typeof(Krypton.RibbonGroupTripleCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
            return new Type[] { typeof(Krypton.RibbonGroupButton),
                                typeof(Krypton.RibbonGroupColorButton),
                                typeof(Krypton.RibbonGroupCheckBox),
                                typeof(Krypton.RibbonGroupComboBox),
                                typeof(Krypton.RibbonGroupCustomControl),
                                typeof(Krypton.RibbonGroupDateTimePicker),
                                typeof(Krypton.RibbonGroupLabel),
                                typeof(Krypton.RibbonGroupRadioButton),
                                typeof(Krypton.RibbonGroupRichTextBox),
                                typeof(Krypton.RibbonGroupTextBox),
                                typeof(Krypton.RibbonGroupMaskedTextBox)};
		}
	}
}
