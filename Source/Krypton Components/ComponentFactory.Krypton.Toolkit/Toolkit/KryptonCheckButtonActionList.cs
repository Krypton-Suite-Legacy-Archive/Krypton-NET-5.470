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
using System.ComponentModel;
using System.ComponentModel.Design;

namespace ComponentFactory.Krypton.Toolkit
{
    internal class KryptonCheckButtonActionList : KryptonButtonActionList
    {
        #region Instance Fields
        private readonly KryptonCheckButton _checkButton;
        private readonly IComponentChangeService _service;
        private string _action;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonCheckButtonActionList class.
        /// </summary>
        /// <param name="owner">Designer that owns this action list instance.</param>
        public KryptonCheckButtonActionList(KryptonCheckButtonDesigner owner) 
            : base(owner)
        {
            // Remember the button instance
            _checkButton = owner.Component as KryptonCheckButton;

            // Assuming we were correctly passed an actual component...
            if (_checkButton != null)
            {
                // Get access to the actual Orientation property
                PropertyDescriptor checkedProp = TypeDescriptor.GetProperties(_checkButton)["Checked"];

                // If we succeeded in getting the property
                if (checkedProp != null)
                {
                    // Decide on the next action to take given the current setting
                    _action = (bool) checkedProp.GetValue(_checkButton) ? "Uncheck the button" : "Check the button";
                }
            }

            // Cache service used to notify when a property has changed
            _service = (IComponentChangeService)GetService(typeof(IComponentChangeService));
        }
        #endregion
        
        #region Public
        /// <summary>
        /// Gets and sets the checked state.
        /// </summary>
        public bool Checked
        {
            get => _checkButton.Checked;

            set
            {
                if (_checkButton.Checked != value)
                {
                    _service.OnComponentChanged(_checkButton, null, _checkButton.Checked, value);
                    _checkButton.Checked = value;
                }
            }
        }
        #endregion

        #region Public Override
        /// <summary>
        /// Returns the collection of DesignerActionItem objects contained in the list.
        /// </summary>
        /// <returns>A DesignerActionItem array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            // Create a new collection for holding the single item we want to create
            DesignerActionItemCollection actions = new DesignerActionItemCollection();

            // This can be null when deleting a control instance at design time
            if (_checkButton != null)
            {
                // Add the list of button specific actions
                actions.Add(new DesignerActionHeaderItem("Appearance"));
                actions.Add(new KryptonDesignerActionItem(new DesignerVerb(_action, OnCheckedClick), "Appearance"));
                actions.Add(new DesignerActionPropertyItem("ButtonStyle", "Style", "Appearance", "Button style"));
                actions.Add(new DesignerActionPropertyItem("Orientation", "Orientation", "Appearance", "Button orientation"));
                actions.Add(new DesignerActionHeaderItem("Values"));
                actions.Add(new DesignerActionPropertyItem("Text", "Text", "Values", "Button text"));
                actions.Add(new DesignerActionPropertyItem("ExtraText", "ExtraText", "Values", "Button extra text"));
                actions.Add(new DesignerActionPropertyItem("Image", "Image", "Values", "Button image"));
                actions.Add(new DesignerActionHeaderItem("Visuals"));
                actions.Add(new DesignerActionPropertyItem("PaletteMode", "Palette", "Visuals", "Palette applied to drawing"));
            }
            
            return actions;
        }
        #endregion

        #region Implementation
        private void OnCheckedClick(object sender, EventArgs e)
        {
            // Cast to the correct type

            // Double check the source is the expected type
            if (sender is DesignerVerb verb)
            {
                // Decide on the new orientation required
                bool isChecked = verb.Text.Equals("Uncheck the button");

                // Decide on the next action to take given the new setting
                _action = isChecked ? "Uncheck the button" : "Check the button";

                // Get access to the actual Orientation property
                PropertyDescriptor checkedProp = TypeDescriptor.GetProperties(_checkButton)["Checked"];

                // If we succeeded in getting the property
                // Update the actual property with the new value
                checkedProp?.SetValue(_checkButton, !isChecked);

                // Get the user interface service associated with actions

                // If we managed to get it then request it update to reflect new action setting
                if (GetService(typeof(DesignerActionUIService)) is DesignerActionUIService service)
                {
                    service.Refresh(_checkButton);
                }
            }
        }
        #endregion
    }
}
