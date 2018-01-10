// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Represents the base class for all ribbon group containers.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public abstract class KryptonRibbonGroupContainer : KryptonRibbonGroupItem,
                                                        IRibbonGroupContainer
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KryptonRibbonGroupContainer class.
        /// </summary>
        public KryptonRibbonGroupContainer()
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
        public virtual KryptonRibbonGroup RibbonGroup { get; set; }

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
