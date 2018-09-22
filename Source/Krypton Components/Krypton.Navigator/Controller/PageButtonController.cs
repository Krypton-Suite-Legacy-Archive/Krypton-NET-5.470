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

using Krypton.Toolkit;

namespace Krypton.Navigator
{
	/// <summary>
	/// Handle a button by ensuring that contained button specs are not treated as part of the button itself.
	/// </summary>
    public class PageButtonController : ButtonController
	{
		#region Identity
		/// <summary>
		/// Initialize a new instance of the PageButtonController class.
		/// </summary>
		/// <param name="target">Target for state changes.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public PageButtonController(ViewBase target, NeedPaintHandler needPaint)
            : base(target, needPaint)
        {
        }
		#endregion

        #region Protected
        /// <summary>
        /// Discovers if the provided view is part of the button.
        /// </summary>
        /// <param name="next">View to investigate.</param>
        /// <returns>True is part of button; otherwise false.</returns>
        protected override bool ViewIsPartOfButton(ViewBase next)
        {
            // Do we need to investigate if the 'next' view might be a contained button?
            if ((next != null) && (Target != next))
            {
                // Climb the view chain and stop when we get to the target itself
                while((next != null) && (next != Target))
                {
                    // If this is a button then we return 'false' cause the mouse is no longer in the target button
                    // Search for a layout docker as that is always the top of any button
                    if (next is ViewLayoutDocker docker)
                    {
                        if (docker.Tag is ViewDrawButton)
                        {
                            return false;
                        }
                    }


                    next = next.Parent;
                }
            }

            return base.ViewIsPartOfButton(next);
        }
        #endregion
    }
}
