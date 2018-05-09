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

using System.ComponentModel;

namespace Krypton.Ribbon
{
    /// <summary>
    /// Represents the base class for all ribbon group containers.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public abstract class Krypton.RibbonGroupContainer : Krypton.RibbonGroupItem,
                                                        IRibbonGroupContainer
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the Krypton.RibbonGroupContainer class.
        /// </summary>
        public Krypton.RibbonGroupContainer()
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the parent group instance.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Krypton.RibbonGroup RibbonGroup { get; set; }

        /// <summary>
        /// Gets an array of all the contained components.
        /// </summary>
        /// <returns>Array of child components.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Component[] GetChildComponents()
        {
            return new Component[] { };
        }
        #endregion
    }
}
