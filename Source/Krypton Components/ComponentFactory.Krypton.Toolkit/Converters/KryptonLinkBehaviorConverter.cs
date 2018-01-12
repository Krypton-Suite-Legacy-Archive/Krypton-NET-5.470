// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.1.0 	www.ComponentFactory.com
// *****************************************************************************

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Custom type converter so that KryptonLinkBehavior values appear as neat text at design time.
    /// </summary>
    internal class KryptonLinkBehaviorConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonLinkBehaviorConverter clas.
        /// </summary>
        public KryptonLinkBehaviorConverter()
            : base(typeof(KryptonLinkBehavior))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(KryptonLinkBehavior.AlwaysUnderline,  "Always Underline"),
            new Pair(KryptonLinkBehavior.HoverUnderline,   "Hover Underline"),
            new Pair(KryptonLinkBehavior.NeverUnderline,   "Never Underline") };

        #endregion
    }
}
