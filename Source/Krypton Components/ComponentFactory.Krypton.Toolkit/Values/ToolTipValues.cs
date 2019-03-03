// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ComponentFactory.Krypton.Toolkit.Values
{
    /// <summary>
    /// What will be displayed in the designer
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public class ToolTipValues : HeaderValues
    {
        /// <summary>
        /// </summary>
        /// <param name="needPaint"></param>
        public ToolTipValues(NeedPaintHandler needPaint)
            : base(needPaint)
        {
            ToolTipStyle = LabelStyle.SuperTip;
            ToolTipPosition = new PopupPositionValues();
        }

        /// <summary>
        /// Make sure default values are         
        /// Gets and sets the EnableToolTips
        /// </summary>
        [DefaultValue(false)]
        public bool EnableToolTips { get; set; }

        /// <summary>
        /// Gets and sets the EnableToolTips
        /// </summary>
        [Description("The orientation of the ToolTip control when it opens, and specifies how the ToolTip control behaves when it overlaps screen boundaries.")]
        public PopupPositionValues ToolTipPosition { get; set; }

        #region ToolTipStyle
        /// <summary>
        /// Gets and sets the tooltip label style.
        /// </summary>
        [Description("Button tooltip label style.")]
        [DefaultValue(typeof(LabelStyle), "SuperTip")]
        public LabelStyle ToolTipStyle { get; set; }

        private bool ShouldSerializeToolTipStyle()
        {
            return ToolTipStyle != LabelStyle.SuperTip;
        }

        /// <summary>
        /// Resets the ToolTipStyle property to its default value.
        /// </summary>
        public void ResetToolTipStyle()
        {
            ToolTipStyle = LabelStyle.SuperTip;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => (!EnableToolTips
                                           && (ToolTipStyle == LabelStyle.SuperTip)
                                           && ToolTipPosition.IsDefault
                                           && base.IsDefault
            );


        #endregion

    }
}
