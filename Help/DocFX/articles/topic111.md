Navigator Other Events  
  
Applicable Events:  
        TabCountChanged  
        TabVisibleCountChanged  
        TabDoubleClicked  
        TabMouseHoverStart  
        TabMouseHoverEnd  
        PrimaryHeaderLeftClicked  
        PrimaryHeaderRightClicked  
        PrimaryHeaderDoubleClicked  
        DisplayPopupPage  
        OutlookDropDown  
        ShowContextMenu  
        BeginPageDrag  
        AfterPageDrag  
        PageDrop  
        CtrlTabStart  
        CtrlTabWrap  
        TabClicked

 

**TabCountChanged**  
Fired when the number of pages in the control has changed.  
  
**TabVisibleCountChanged**  
Occurs when the number of visible pages has changed. This can occur when the
number of actual pages remains constant but the *Visible* state of the pages is
updated.  
  
**TabDoubleClicked**  
When the user double clicks a tab with the left mouse button this event is
fired.  
  
**TabMouseHoverStart**  
If the user moves the mouse over a tab and leaves the mouse static for a short
period of time then this event if fired. This is useful if you want to display
your own tool tip style feedback.  
  
**TabMouseHoverEnd**  
Generated when the mouse moves after a TabMouseHoverStart has been created.
These two events are always paired.  
  
**PrimaryHeaderLeftClicked**  
Fired when the user left mouse clicks on a primary header element.  
  
**PrimaryHeaderRightClicked**  
Fired when the user right mouse clicks on a primary header element.  
  
**PrimaryHeaderDoubleClicked**  
When the user double clicks with the left mouse button on a primary header
element.  
  
**DisplayPopupPage**  
This event is fired whenever a pop up page is about to be shown. It has a
*Cancel* property that allows you to prevent the pop up page from being shown by
setting the *Cancel* to be *True*. It also has a *ScreenRectangle* parameter
that you can inspect and modify to change the screen location and size of the
pop up. It will be populated with a calculated value that is used unless you
decide to override the value. Also provided is an *Item* property that gives you
a reference to the *KryptonPage* that is going to be shown.  
  
**OutlookDropDown**  
When using either the *Outlook - Full* or the *Outlook - Mini* mode there is a
small drop down arrow available in the overflow area of the control. When you
click this drop down this event is generated. It has a property called
*KryptonContextMenu* that contains the set of menu items for display to the
user. You can modify this list by adding your own custom items that you would
like presented to the user.  
  
**ShowContextMenu**  
If you right-click a page header then this event is generated as an attempt to
show a page specific context menu. By default the events *e.Cancel* property is
defined as *True* so that no context menu is shown. If you would like to show a
context menu for the page then you must set this property to *False* in the
event handler.

The event arguments have two properties called *ContextMenuStrip* and
*KryptonContextMenu* that are used to specify the context menu to be shown. Use
of *KryptonContextMenu* takes precedence. When the event is generated the value
of the context menu properties is defaulted to the settings from the actual
*KryptonPage*. So the event argument *KryptonContextMenu* property is defined as
the value of *KryptonPage.KryptonContextMenu* and the event
argument *ContextMenuStrip* is defined as the *KryptonPage.ContextMenuStrip*
value.

**BeginPageDrag**  
Just before page dragging occurs this event is fired to allow event handlers a
chance to either cancel the operation or modify the set of pages that are being
dragged. Note that *AllowPageDrag* must be set to *True* before any page
dragging can occur and so this event will not be fired unless that property is
set. Once this event has finished and has not been cancelled the
*PageDragNotify* interface, if present, will be used during the drag operation
for providing feedback.  
  
**AfterPageDrag**  
After the dragging operation has completed this event is fired so the event
handler can cleanup and reverse any actions they took during the
*BeginPageDrap*. It provides a property indicating if the drop was completed
with success, so the drop occurred, or if the operation was cancelled.  
  
**PageDrop**  
This event is fired when a page is being dropped into the navigator instance.
You can use this event to cancel the drop or alter the provided page reference
in order to alter the page actually dropped.  
  
**CtrlTabStart**  
When the user presses the *Ctrl+Tab* key combination this event is fired so that
you can cancel the event and prevent the normal action from occuring. Normally
this key combination will cause the selected page to shift to the next visible
and enabled page. *Ctrl+Shift+Tab* also fires the event and selected the
previous page instead of the next page. One of the event arguments indicates if
the shift key is pressed.  
  
**CtrlTabWrap**  
The *Ctrl+Tab* key combination causes the next appropriate page to become
selected. If the searching reaches the end of the page list it wraps around to
the first page again to continue the search. Hence using the *Ctrl+Tab*
combination rotates around all the pages continually. To prevent this wrapping
around of the page list you hook into this event and set the *Cancel* event
argument. One of the event arguments indicates if the shift key is pressed.  
  
**TabClicked**  
This event is generated when the user left mouse clicks on a page tab header.
Tab headers including the ribbon tabs, standard tabs and the check buttons that
are used for many of the available modes. This event is generated even if the
page is already the selected page.
