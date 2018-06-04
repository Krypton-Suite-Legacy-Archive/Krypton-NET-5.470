Workspace Events  
  
Applicable Events:  
        WorkspaceCellAdding  
        WorkspaceCellRemoved  
        ActiveCellChanged  
        ActivePageChanged  
        MaximizedCellChanged  
        BeginPageDrag  
        AfterPageDrag  
        PageDrop  
        GlobalSaving  
        GlobalLoading  
        PageSaving  
        PageLoading  
        RecreateLoadingPage  
        PagesUnmatched  
        CellCountChanged  
        CellVisibleCountChanged

 

**WorkspaceCellAdding**  
Each time a new *KryptonWorkspaceCell* is added to the workspace controls
collection this event is fired so that you can customize the settings of that
cell. As the cell is a class derived from the *KryptonNavigator* you might want
to consult the [Navigator](topic94.md) documentation to see the full range of
available modes and appearance options. As well as changing the appearance you
are recommend to use this event for attaching to any cell events. You should use
the *WorkspaceCellRemoved* event to unhook from those events you attach to here.
This is required so that there are no references to the cell once it is removed
and so it is eligable for garbage collection.

**WorkspaceCellRemoved**  
Fired when the *KryptonWorkspaceCell* instance is removed from the controls
collection. Use this event to unhook from any events you attached to in the
*WorkspaceCellAdding* event. If the cell has the *DisposeOnRemove* property
defined as *True* then the cell will have been disposed before this event is
generated.

**ActiveCellChanged**  
This event is fired each time the value of the *ActiveCell* property changes.
This can happens in several ways, most commonly when the user selects a page on
a different cell. It also occurs if you drag and drop a page to create a new
cell or when you update the layout using a method such as *ApplySingleCell*. Use
this event if you want to alter the appearance of the active cell so the user
can more easily see which cell is active within the workspace layout. For
example you might change the tab drawing style so the active cell is more
prominent.

**ActivePageChanged**  
Generated when the value of the *ActivePage* property changes. Each time the
user selects a new page using the mouse or a keyboard combination the property
is updated.

**MaximizedCellChanged**  
Fired when the value of the *MaximizedCell* property changes. Note that this
property can change from user interactions and not just because of a
programmatic change to the property.

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

  
**GlobalSaving**  
Called during the save layout process and allows custom data to be added into
the persisted data. You are provided with an *XmlWriter* reference that should
be used for saving your information. Custom data can be structured by adding new
elements and attributes as needed so that the XML is structured in a logical
way.

**GlobalLoading**  
Called during the load layout process and allows previously saved data to be
handled. An *XmlReader* reference is provided and should be used to navigate and
process the incoming information.

**PageSaving**  
Each time a page is saved this event is called and provided with a reference to
the page along with an *XmlWriter*. Use the text writer to save any additional
information you require associated with the page.

**PageLoading**  
Each time a page is loaded this event is fired and provided a reference to the
page along with an *XmlReader*. Load additional information using the text
reader and then perform page setup actions such as creating controls for the
page. You can override the page reference in order to change the page that will
be added to the workspace. So you can create an entirely new page and modify
the event page reference so that the new page you just created is used in place
of the one provided. If you modify the event page reference to be *null* then
the load process will not add any page to the workspace. This is useful if your
application needs to reject the loading of individual pages.

**RecreateLoadingPage**  
During the load process the incoming pages are matched against pages that
already exist inside the workspace. If the incoming page has the same unique
name as an existing page then the existing page is used and loaded with the
incoming details and then positioned appropriately. If the incoming page does
not already exist in the workspace then this event is fired so that the page can
be recreated. At the end of the event processing the page details will be loaded
into the provided page and then added into the workspace.

**PagesUnmatched**  
Fired at the very end of the loading process this event provides a list of pages
that were present in the workspace before the load occurred but were not matched
by and loading page details. Without further action these unmatched pages will
be removed from the workspace. Use this event if you want to prevent some or all
of these pages being removed. You must use code to add them back into the
workspace hierarchy and into a cell in order for them to be retained not
automatically removed.  
  
  
**CellCountChanged**  
At the end of the workspace layout phase this event is fired if the number of
cells within the workspace has changed since the last layout phase. Firing the
event at the end of a layout allows the developer to make multiple changes to
the hierarchy of the control without each individual operation causing the event
to be fired. Instead the event will be fired only if the aggregate of the
operations results in a changed value for the number of cells once the layout
process has finished.

**CellVisibleCountChanged**  
If the number of visible cells has changed at the end of the control layout
phase then this event is fired. Note that the number of actual cells might be
constant but if the number of the cells that are visible changes then the event
is still fired. Conversely if the number  of cells changes but the number of
those visible is the same then the event will not be fired.
