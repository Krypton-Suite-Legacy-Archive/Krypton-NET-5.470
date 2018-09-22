Workspace Page Dragging  
  
Applicable Properties:  
        AllowPageDrag  
        DragPageNotify

Applicable Events:  
        BeginPageDrag  
        AfterPageDrag

 

**AllowPageDrag**  
A default value of *True* allows the user to drag pages around the workspace in
order to modify the layout of the contents. You can drag individual page headers
such as the tabs and check buttons that represents pages in a typical cell
appearance. If the cell has been modified to display in a header mode such as
*HeaderGroup* then you can drag all the pages it contains in one go by dragging
the primary header of the cell. Setting this property to *False* will prevent
any user dragging from occuring.

 

**DragPageNotify**  
When this property is left as the default *null* you can only drag and drop
pages within the individual Workspace instance. In order to combine this control
with other page dragging enabled controls you need to explicitly assign a
*IDragPageNotify* interface to this property. Krypton provides an implementation
of this interface called *DragManager* and it allows you to link together
multiple drag sources and targets. For example, to allow two Workspace instances
to have pages dragged between them you can use the following simple code:-

      DragManager dm = new DragManager();  

      // Add page dragging sources  
      kryptonWorkspace1.DragPageNotify = dm;  
      kryptonWorkspace2.DragPageNotify = dm;  
  
      // Add page drop targets  
      dm.DragTargetProviders.Add(kryptonWorkspace1);  
      dm.DragTargetProviders.Add(kryptonWorkspace2);

For a more detailed explanation for how page dragging occurs within Krypton you
should read the top-level [Page Dragging](topic131.md) section.

**BeginPageDrag, AfterPageDrag**  
These events are fired before and after the page drag operation. For more
details see [Events](topic119.md).
