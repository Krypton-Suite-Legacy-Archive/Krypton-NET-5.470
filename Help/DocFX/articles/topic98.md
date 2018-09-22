Navigator Page Dragging  
  
Applicable Properties:  
        AllowPageDrag  
        DragPageNotify

Applicable Events:  
        BeginPageDrag  
        AfterPageDrag

 

**AllowPageDrag**  
A default value of *False* prevents the user from dragging pages away from the
Navigator. Note that setting this property on its own is not enough to cause
dragging to occur because you also have to set the *DragPageNotify* property so
that the drag operation can actually occur.

**DragPageNotify**  
In order to orchestrate a page dragging operation you need to interact with an
object that knows how to provide visual feedback and is also aware of the
potential drop targets. Any object that provides this ability can be attached to
the Navigator by providing the *IDragPageNotify* interface to this property. You
do not need to implement this yourself as Krypton comes with a class called
*DragManager* that implements the interface and provides palette based feedback
drawing for you. For example, to allow two Navigator instances to have pages
dragged between them you can use the following simple code:-

      DragManager dm = new DragManager();  

      // Add page dragging sources  
      kryptonNavigator1.DragPageNotify = dm;  
      kryptonNavigator2.DragPageNotify = dm;  
  
      // Add page drop targets  
      dm.DragTargetProviders.Add(kryptonNavigator1);  
      dm.DragTargetProviders.Add(kryptonNavigator2);

For a more detailed explanation for how page dragging occurs within Krypton you
should read the top-level [Page Dragging](topic131.md) section.

**BeginPageDrag, AfterPageDrag**  
These events are fired before and after the page drag operation. For more
details see [Other Events](topic111.md).
