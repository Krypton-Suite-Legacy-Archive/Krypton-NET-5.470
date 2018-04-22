Docking Controls Events

**Control Resizing Events:**  
        AutoHiddenSeparatorResize  
        DockspaceSeparatorResize

 

**AutoHiddenSeparatorResize**  
When an auto hidden slides out to be displayed there is a resize bar displayed
at one edge. When you left click that resize bar this event is fired and allows
you to modify the limits of the resizing operation. So you can restrict the
resizing action to whatever is appropriate for your application needs.  
  
**DockspaceSeparatorResize**  
Each dockspace has a resize bar displayed at one edge. When you left click that
resize bar this event is fired and allows you to modify the limits of the
resizing operation. So you can restrict the resizing action to whatever is
appropriate for your application needs.

**Control Adding/Removing Events:**  
        AutoHiddenGroupAdding  
        AutoHiddenGroupRemoved  
        AutoHiddenGroupPanelAdding  
        AutoHiddenGroupPanelRemoved  
        DockableNavigatorAdding  
        DockableNavigatorRemoved  
        DockableWorkspaceAdding  
        DockableWorkspaceRemoved  
        DockableWorkspaceCellAdding  
        DockableWorkspaceCellRemoved  
        DockspaceAdding  
        DockspaceRemoved          
        DockspaceCellAdding  
        DockspaceCellRemoved          
        DockspaceSeparatorAdding  
        DockspaceSeparatorRemoved  
        FloatspaceAdding  
        FloatspaceRemoved          
        FloatspaceCellAdding  
        FloatspaceCellRemoved          
        FloatingWindowAdding  
        FloatingWindowRemoved        

 

**xxxxAdding**  
There are many different custom controls involved in the docking system. Each
type of custom control has an event that is fired when that control type is
created so that you can then customize the control if required. You might
customize the control by changing the palette setting, changing state specific
property values or hooking into events. If you hook into the adding event you
should careful consider if you also need to hook the removing event as well.
Ensure that any actions you perform are appropriately reversed in the removing
event to prevent memory leaks occuring.  
  
**xxxxRemoving**  
There are many different custom controls involved in the docking system. Each
type of custom control has an event that is fired when that control type is
destroyed so that you can reverse any customizations made during the matching
adding event. If you hooked into the adding event you should careful consider if
you also need to hook the removing event as well. Ensure that any actions you
perform are appropriately reversed in the removing event to prevent memory leaks
occuring.

 
