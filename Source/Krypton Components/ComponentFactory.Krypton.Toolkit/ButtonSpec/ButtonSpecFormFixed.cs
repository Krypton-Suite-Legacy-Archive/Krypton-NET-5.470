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

using System.ComponentModel;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Implementation for the fixed navigator buttons.
    /// </summary>
    [TypeConverter(typeof(ButtonSpecFormFixedConverter))]
    public abstract class ButtonSpecFormFixed : ButtonSpec
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ButtonSpecFormFixed class.
        /// </summary>
        /// <param name="form">Reference to owning krypton form.</param>
        /// <param name="fixedStyle">Fixed style to use.</param>
        public ButtonSpecFormFixed(KryptonForm form,
                                   PaletteButtonSpecStyle fixedStyle)
        {
            Debug.Assert(form != null);

            // Remember back reference to owning navigator.
            KryptonForm = form;

            // Fix the type
            ProtectedType = fixedStyle;
        }      
        #endregion   

        #region AllowComponent
        /// <summary>
        /// Can a component be associated with the view.
        /// </summary>
        public override bool AllowComponent => false;

        #endregion

        #region KryptonForm
        /// <summary>
        /// Gets access to the owning krypton form.
        /// </summary>
        protected KryptonForm KryptonForm { get; }

        #endregion

        #region ButtonSpecType
        /// <summary>
        /// Gets and sets the actual type of the button.
        /// </summary>
        public virtual PaletteButtonSpecStyle ButtonSpecType
        {
            get => ProtectedType;
            set => ProtectedType = value;
        }
        #endregion
    }
}
