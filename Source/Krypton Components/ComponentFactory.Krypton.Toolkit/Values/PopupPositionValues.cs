// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2019 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ComponentFactory.Krypton.Toolkit.Values
{
    /// <summary>
    ///Be More WPF like...
    /// https://docs.microsoft.com/en-us/dotnet/framework/wpf/controls/popup-placement-behavior?view=netframework-4.7.2
    /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.tooltip.placement?view=netframework-4.7.2
    /// 
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ComVisible(true)]
    public class PopupPositionValues : Storage
    {
        #region Identity
        /// <summary>
        /// 
        /// </summary>
        public PopupPositionValues()
        {
            PlacementMode = PlacementMode.Mouse;
            PlacementTarget = null;
            PlacementRectangle = new Rectangle();
        }
        #endregion Identity

        /// <summary>
        /// 
        /// </summary>
        [Description("Describes the placement of where a Popup control appears on the screen.")]
        [DefaultValue(typeof(PlacementMode), "Mouse")]
        public PlacementMode PlacementMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("The element relative to which the Popup is positioned when it opens.")]
        public ViewBase PlacementTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("The rectangle relative to which the Popup control is positioned when it opens.")]
        public Rectangle PlacementRectangle { get; set; }

        #region Default Values
        /// <summary>
        /// 
        /// </summary>
        public override bool IsDefault => ((PlacementMode == PlacementMode.Mouse)
                                             && (PlacementTarget == null)
                                             && PlacementRectangle.IsEmpty
                                            );
        #endregion Default Values
    }
}
