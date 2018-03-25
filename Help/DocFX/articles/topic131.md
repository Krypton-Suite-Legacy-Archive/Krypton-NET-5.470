Page Dragging

Krypton provides its own drag and drop mechanism for moving *KryptonPage*
instances between compatible controls. Note this is entirely separate from the
standard drag and drop system that is exposed in Windows Forms using
*DoDragDrop* and *IDropTarget*. Why provide a separate mechanism when windows
already has a standard approach? Krypton provides more sophisticated visual
feedback to the user that would be very difficult to achieve using the standard
approach. It also allows us to provide something that is designed to be easy to
use with Krypton controls.

**Overview**  
You need three elements to perform page dragging. First you need a set of drop
targets and for that we have the *IDragTargetProvider*. Any control that wants
to act as a drop target needs to expose *IDragTargetProvider* so the drop
targets for that control can be discovered. Second you need to allow drag
operations to be initiated and for that we have the *IDragPageNotify* interface.
Any control that wants to start a drag operation needs to take an instance of
that *IDragPageNotify* interface and call its methods as required. Finally we
need to an object that can orchestrate the operation. Krypton provides a class
called *DragManager* that performs this orchestration for you.

**IDragTargetProvider**  
Any control that needs to act as a drop target needs to expose this simple
interface. The interface only has a single method called *GenerateDragTargets*
that is called each time the set of drop targets is needed. Note that this means
it is called each time a page drag operation is started so you could return a
different set of targets for each drag operation. Passed into the method is a
reference to the *PageDragEndData* instance which contains a list of all the
pages being dragged. So you can examine the set of pages being dragged and
decide which targets are relevant to those pages. Returned from the
*GenerateDragTargets* call is a list of targets so you can provide none, one or
many.

The Navigator implements this interface by returning just a single drop target.
When the user drops on that target all the dragged pages are added to the end of
the Navigator page list. Workspace also implements this interface but returns
many different targets. The Workspace has many potential drop points such as the
workspace edges or edges for each individual workspace cell and so the returned
list of targets could be quite extensive. When the drop occurs the relevant
target then performs the appropriate action.

For more detailed information see the [Drag Enabling
Controls](topic133.md) section.

**IDragPageNotify**  
Any control that needs to initiate dragging needs to do so my making calls into
this interface. The interface exposes several methods such as *PageDragStart*,
*PageDragMove*, *PageDragEnd* and *PageDragQuit* that are called by the source
control as various actions occur. When the source control notices the left mouse
button being pressed it would call *PageDragStart*. It would then call
*PageDragMove* as the mouse is moved up until the release of the left button at
which point *PageDragEnd* is called. If at any time the operation needs to be
aborted then *PageDragQuit* is used.

Note that the control does not implement this interface but only makes calls
into it. In order to do this the control needs to be provided with an instance
of the *IDragPageNotify* interface. Both the Navigator and Workspace controls
expose the *DragPageNotify* property for this very purpose. You can provide the
same instance of the *IDragPageNotify* interface to more than one control as
only one control at a time can be performing a drag operation.

For more detailed information see the [Drag Enabling
Controls](topic133.md) section.

**DragManager**  
Use the *DragManager* to orchestrate page dragging with the targets and provide
visual feedback during the operation. Once you have created an instance of the
class you can attach target providers by using the *DragTargetProviders*
collection. For example you can add Navigator and Workspace instances that
implement the IDragTargetProvider interface in the following way:-

      DragManager dm = new DragManager();  

      dm.DragTargetProviders.Add(kryptonNavigator1);  
      dm.DragTargetProviders.Add(kryptonWorkspace1);

The *DragManager* also implements the *IDragPageNotify* interface and so can be
attached directly to the Navigator and Workspace controls like so:-

      kryptonNavigator1.DragPageNotify = dm;  
      kryptonWorkspace1.DragPageNotify = dm;  
  
For more detailed information see the [DragManager](topic132.md) section.
