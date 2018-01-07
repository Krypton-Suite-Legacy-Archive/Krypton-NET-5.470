// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Manage the items that can be added to the top level of a ribbon group instance.
    /// </summary>
    public class KryptonRibbonGroupContainerCollection : TypedRestrictCollection<KryptonRibbonGroupContainer>
    {
        #region Static Fields
        private static readonly Type[] _types = { typeof(KryptonRibbonGroupLines),
                                                             typeof(KryptonRibbonGroupTriple),
                                                             typeof(KryptonRibbonGroupSeparator),
                                                             typeof(KryptonRibbonGroupGallery)};
        #endregion

        #region Restrict
        /// <summary>
        /// Gets an array of types that the collection is restricted to contain.
        /// </summary>
        public override Type[] RestrictTypes => _types;

        #endregion
    }
}
