Docking User Requests Events

User Request Events:  
        PageCloseRequest  
        PageDockedRequest  
        PageAutoHiddenRequest  
        PageFloatingRequest  
        PageNavigatorRequest  
        PageWorkspaceRequest  
        ShowPageContextMenu  
        ShowWorkspacePageContextMenu

 

 

**PageCloseRequest**  
This event is fired from within the *KryptonDockingManager.CloseRequest* method
and so calling this method programmatically will cause the event to be fired.
There are also three user actions that can occur at runtime that result in the
*CloseRequest* method being called and so the *PageCloseRequest* fired. If the
user presses the page close button or the user selects the hide option on the
docking context menu or the user closes a floating window then a *CloseRequest*
is generated. The *PageCloseRequest.CloseRequest* property can be updated by the
developers event handler in order to instruct the docking system what action
should be taken. Possible values are as follows...

-   **None** -no action is performed and so the close request is ignored

-   **RemovePage** - removes the page from the docking system but does not
    dispose it, so the page could be added back again later

-   **RemovePageAndDispose** - removes the page and also calls Dispose so the
    page could not be added back again later

-   **Hide** - leaves the page in the docking system but hides it from display

**PageDockedRequest**  
Fired by two different user actions. First is using the docking context menu to
request a page be switched to the docked state. Second is using the unpin button
for an auto hidden group to have the group switched to docked state. Also fired
if you programmatically use the
*MakeDockedRequest*, *SwitchFloatingToDockedRequest* or
*SwitchAutoHiddenGroupToDockedCellRequest* methods. You can cancel the event to
prevent the switch from occuring.  
  
**PageAutoHiddenRequest**  
Fired by two different user actions. First is using the docking context menu to
request a page be switched to the auto hidden state. Second is using the pin
button for a docked set of pages to have the pages switched to the auto hidden
state. Also fired if you programmatically use the *MakeAutoHiddenRequest* or
*SwitchDockedCellToAutoHiddenGroupRequest*  methods. You can cancel the event to
prevent the switch from occuring.  
  
**PageFloatingRequest**  
Fired by two different user actions. First is using the docking context menu to
request a page be switched to the floating state. Second is double clicking the
header for a docked set of pages to have the pages switched to the floating
state. Also fired if you programmatically use the *MakeFloatingRequest* or
*SwitchDockedToFloatingWindowRequest*  methods. You can cancel the event to
prevent the switch from occuring.

**PageWorkspaceRequest**  
Fired when the docking context menu is used by the user to request a page be
switched to the workspace (*Tabbed Document*) state. Also fired if you
programmatically use the *MakeWorkspaceRequest* method. You can cancel the event
to prevent the switch from occuring.

**PageNavigatorRequest**  
Fired when the docking context menu is used by the user to request a page be
switched to the navigator (*Tabbed Document*) state. Also fired if you
programmatically use the *MakeNavigatorRequest* method. You can cancel the event
to prevent the switch from occuring.  
  
**ShowPageContextMenu**  
A docking context menu is displayed for a page in response to three different
user actions. There is a drop down button on the page header that when pressed
shows the docking context menu. It also appears if you right click a page tab or
right click the page header. Before the context menu is displayed from any of
these user actions the *ShowPageContextMenu* event is fired and allows the
developer to customize the contents of the menu. You can add additional options
that are specific to your own application.  
  
**ShowWorkspacePageContextMenu**  
When you right click a tab in a dockable workspace that is part of the docking
hierarchy this event is fired. This allows you to customize the menu before it
is shown to the user. You can add additional options that are specific to your
own application.
