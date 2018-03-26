Drag Enabling Controls

To enable page dragging from your control you need to add calls to the
*IDragPageNotify* interface. If you require your control to be a page dragging
target then you need to expose and implement the *IDragTargetProvider*
interface. Both interface needs to be handled if you require dragging from as
well as dropping onto the same control. A sample of how to achieve both of these
is shown by deriving a class from *TreeView* and allowing individual tree nodes
to be dragged away as well as new nodes added when pages are dropped onto it.
You can find the full source code in the *Advanced Page Drag + Drop* sample that
is contained in the *Krypton Workspace Examples* solution that comes with
*Krypton*. You can quickly find this solution by running the *Krypton Explorer*
and selecting the *Resources* tab.

 

Implementing IDragPageNotify

**Derive class from TreeView**  
Derive a new class from *TreeView* called *PageDragTreeView* that has the
following simple definition.

   /// \<summary\>  
   /// TreeView customized to work with KryptonPage drag and drop.  
   /// \</summary\>  
   public class PageDragTreeView : TreeView  
   {  
      /// \<summary\>  
      /// Initialize a new instance of the PageDragTreeView class.  
      /// \</summary\>  
      public PageDragTreeView()  
      {  
      }  
   }

 

**Store a IDragPageNotify reference using a property**  
Add the following private field and exposed property so that a developer can
assign a *IDragPageNotify* instance to the control. Notice that we give the
exposed property a *Browsable(false)* setting as we do not want the property
exposed in the properties window at design time. Another property called
*DesignerSerializationVisiblity* is used to prevent any generated code being
produced for the property when the form it is contained inside is saved.

   private IDragPageNotify \_dragPageNotify;

   /// \<summary\>  
   /// Gets and sets the interface for receiving page drag notifications.  
   /// \</summary\>  
   [Browsable(false)]  
   [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]  
   public IDragPageNotify DragPageNotify  
   {  
      get { return \_dragPageNotify; }  
      set { \_dragPageNotify = value; }  
   }

 

**Add Node drag support**  
We need to intercept the mouse down, mouse move and mouse up events so that we
can detect and process the user trying to drag an individual tree node. To start
we need some extra private fields that are used to cache dragging information
during the dragging process. A boolean \_*dragging* is used to remember if we
are currently dragging or not. The \_*dragRect* and \_*dragNode* are updated
when the mouse is pressed down to remember the rectangle the mouse has to move
outside of before the drag starts, along with the node that the user has pressed
down on. Finally the \_dragPage is a temporary *KryptonPage* instance created
for the duration of the drag operation.

The *OnMouseDown* code is simple and looks to see when the left mouse button is
pressed as the hint that dragging might start when the mouse moves.

   /// \<summary\>  
   /// Raises the MouseDown event.  
   /// \</summary\>  
   /// \<param name="e"\>A MouseEventArgs that contains the event
data.\</param\>  
   protected override void OnMouseDown(MouseEventArgs e)  
   {  
      // Grab the node under the mouse  
      Point pt = new Point(e.X, e.Y);  
      TreeNode nodeDown = GetNodeAt(pt);

      // Try and ensure the node is selected on the mouse down  
      if ((nodeDown != null) && (SelectedNode != nodeDown))  
         SelectedNode = nodeDown;

      // Mouse down could be a prelude to a drag operation  
      if (e.Button == MouseButtons.Left)  
      {  
         // Remember the node as a potential drag node  
         \_dragNode = nodeDown;

         // Create the rectangle that moving outside causes a drag operation  
         \_dragRect = new Rectangle(pt, Size.Empty);  
         \_dragRect.Inflate(SystemInformation.DragSize);  
      }  
  
      base.OnMouseDown(e);  
   }

 

The *OnMouseMove* is responsible for deciding if dragging can be started and if
already started if it should generate a drag move. The implementation of the
actual *PageDragMove* and *PageDragStart* will be shown in a moment.

   /// \<summary\>  
   /// Raises the MouseMove event.  
   /// \</summary\>  
   /// \<param name="e"\>A MouseEventArgs that contains the event
data.\</param\>  
   protected override void OnMouseMove(MouseEventArgs e)  
   {  
      Point pt = new Point(e.X, e.Y);

      // Are we monitoring for drag operations?  
      if (_dragNode != null)  
      {  
         // If currently dragging  
         if (Capture && \_dragging)  
            PageDragMove(pt);  
         else if (!_dragRect.Contains(pt))  
            PageDragStart(pt);  
      }  
  
      base.OnMouseMove(e);  
   }

 

The *OnMouseUp* always ends the dragging operation if it is taking place.
Depending on if the left mouse is released or not determines if the drag is
completed with success or aborted. Implementation of the actual *PageDragEnd*
and *PageDragQuit* will be shown in a moment.

   /// \<summary\>  
   /// Raises the MouseUp event.  
   /// \</summary\>  
   /// \<param name="e"\>A MouseEventArgs that contains the event
data.\</param\>  
   protected override void OnMouseUp(MouseEventArgs e)  
   {  
      if (_dragging)  
      {  
         if (e.Button == MouseButtons.Left)  
            PageDragEnd(new Point(e.X, e.Y));  
         else  
            PageDragQuit();  
      }

      // Any released mouse means we have ended drag monitoring  
      \_dragNode = null;

      base.OnMouseUp(e);  
   }

 

So far the code has been concerned with the specifics of detecting and operating
a drag in the context of the *TreeView* control. Your own version of this code
will vary depending on what is relevant for your own control. Something like a
*Button* control would be simpler as you do not need to remember which node the
drag is related to. Finally we have the actual implementation of the four helper
methods that the above code calls into. The most complex of these is the
*PageDragStart*.

   private void PageDragStart(Point pt)  
   {  
      if (DragPageNotify != null)  
      {  
         // Create a page that will be dragged  
         \_dragPage = new KryptonPage();  
         \_dragPage.Text = \_dragNode.Text;  
  
         // Give the notify interface a chance to reject the attempt to drag  
         PageDragCancelEventArgs de = new
PageDragCancelEventArgs(PointToScreen(pt), new KryptonPage[] { \_dragPage });  
         DragPageNotify.PageDragStart(this, null, de);  
         if (de.Cancel)  
         {  
            // No longer need the temporary drag page  
            \_dragPage.Dispose();  
            \_dragPage = null;  
         }  
         else  
         {  
            \_dragging = true;  
            Capture = true;  
         }  
      }  
   }

*PageDragStart* creates a new *KryptonPage* instance that will passed into the
dragging operation. Your own implementation would need to populate the page
fields in a way appropriate for your application but in this example we only set
the *Text* property of the page to match the *Node* text. It then calls into the
*IDragPageNotify.PageDragStart* method and only if the method has not been
cancelled does the drag then *Capture* the mouse to guarantee mouse input until
the operation ends. If the drag start is cancelled it disposes of the temporary
page.

The *PageDragMove routine* is very simple and just informs the *IDragPageNotify*
interface of the new screen location of the mouse.

   private void PageDragMove(Point pt)  
   {  
      if (DragPageNotify != null)  
         DragPageNotify.PageDragMove(this, new
PointEventArgs(PointToScreen(pt)));  
   }

 

Implementation of the *PageDragEnd* and *PageDragQuit* are almost identical. The
only difference is the *PageDragQuit* disposes of the temporary page because the
drag failed and so the page was not transferred to the drop target, whereas the
*PageDragEnd* does not dispose of the page but does remove the *Node* associated
with the drag. Your own control might not want to remove the *Node* that caused
the drag because you want it to be dragged over and over again for creating
multiple new pages.

   private void PageDragEnd(Point pt)  
   {  
      if (DragPageNotify != null)  
      {  
         // Let the target transfer the page across  
         DragPageNotify.PageDragEnd(this, new
PointEventArgs(PointToScreen(pt)));

         // Remove the node that caused the transfer  
         Nodes.Remove(_dragNode);

         // Transferred the page to the target, so do not dispose it  
         \_dragPage = null;

         // No longer dragging  
         \_dragging = false;  
         Capture = false;  
      }  
   }

   private void PageDragQuit()  
   {  
      if (DragPageNotify != null)  
      {

         DragPageNotify.PageDragQuit(this);  
  
         // Did not transfer the page to the target, so dispose it  
         \_dragPage.Dispose();  
         \_dragPage = null;

         // No longer dragging

         \_dragging = false;  
         Capture = false;  
      }  
   }

 

You now have a *TreeView* that can be used to drag nodes so they become pages
inside the *Navigator*, *Workspace* or other compatible controls.

 

 

Implementing IDragTargetProvider

**Add the IDragTargetProvider to the class definition**  
We are going to add to the previous class we created above by adding the ability
to drop pages onto the *TreeView* in order to add extra *Node* instances at the
root level. To begin we need to modify the class so that it exposes the
*IDragTargetProvider* interface.

   public class PageDragTreeView : TreeView, IDragTargetProvider

 

**Implement the GenerateDragTargets method**  
Our new interface has just a single method called *GenerateDragTargets* that
returns a list of drag targets for the control. In our case we are going to
return just a single target that represents the entire control client area. We
need to create a drag target class that knows how to take a *KryptonPage* and
process it for our control which we will do by simply creating a new *Node* and
adding it to the end of the root nodes collection. Here is the trivial
implementation of the *GenerateDragTargets*.

   /// \<summary\>  
   /// Generate a list of drag targets that are relevant to the provided end
data.  
   /// \</summary\>  
   /// \<param name="dragEndData"\>Pages data being dragged.\</param\>  
   /// \<returns\>List of drag targets.\</returns\>  
   public DragTargetList GenerateDragTargets(PageDragEndData dragEndData)  
   {  
      DragTargetList targets = new DragTargetList();  
      targets.Add(new
DragTargetTreeViewTransfer(RectangleToScreen(ClientRectangle), this));  
      return targets;  
   }

If you wanted to provide different actions depending on where in the control the
drop occurs then you would create multiple drag targets and return the whole set
from this method. For example you might want to create a drop target per visible
node so that the drop action is to add the page as a new child of that
particular node.

**Inherit a class from DragTarget**  
All drag target implementations must derive from the base class *DragTarget*.
Our class will take and store an incoming reference to the owning instance so
that we can access the control during the processing of the drag methods that we
also need to implement. Here is the beginning of our class.

   public class DragTargetTreeViewTransfer : DragTarget  
   {  
      private PageDragTreeView \_treeView;

      /// \<summary\>  
      /// Initialize a new instance of the DragTargetTreeViewTransfer class.  
      /// \</summary\>  
      /// \<param name="rect"\>Rectangle for screen/hot/draw areas.\</param\>  
      /// \<param name="navigator"\>Control instance for drop.\</param\>  
      public DragTargetTreeViewTransfer(Rectangle rect, PageDragTreeView
treeView)  
         : base(rect, rect, rect, DragTargetHint.Transfer)  
      {  
         \_treeView = treeView;  
      }

Notice that the base constructor takes three rectangles and a drag hint value.
If creating your own drag targets you will need to understand the relationship
between these three rectangles and how the hint is also used to enable useful
visual feedback. The three rectangles are:-

-   **Screen Rect**  
    Rectangle of the entire control area in screen coordinates. If you add
    several targets for the same control then this rectangle should be same
    value for all of those targets. This allows the drag manager to recognize
    that the set of targets are all related and allows the drag manager to
    aggregate them together when providing visual feedback to the user. For
    example the *Square* and *Rounded* feedback settings often show a graphic
    with left/right/top/bottom indicators all grouped together. It can do this
    because this property is the same for all the left/right/top/bottom targets
    and so it knows it can aggregate them together visually.

-   **Hot Rect**  
    Screen coordinates of the rectangle that should activate the target. So when
    the user moves the mouse over this rectangle the drag manager can then
    highlight the screen to show that this target is the current one. Note that
    this rectangle is only used for the *Block* feedback setting and ignored
    otherwise. The *Square* and *Rounded* feedback settings calculate their own
    hot rectangles instead.

-   **Draw Rect**  
    This is the rectangle in screen coordinates that is highlighted on the
    screen when the target becomes the current target.

The final base constructor parameter is a *DragTargetHint* enumeration value and
is used to inform the feedback drawing about the type of operation this target
will perform. In our case we provide the *Transfer* value because we will
transfer the source pages into ourself. This hint allows the visual feedback to
show an appropriate graphic to the user.

 

**Implement IsMatch**  
As the mouse moves around the screen each target is asked if the new mouse
position is a match for the target. The first target that returns *True* will
become the current target for a drop. By default the base class implementation
compares the incoming point against the hot rectangle that was provided in the
constructor. In our case we want to add a little extra logic to prevent the
dragging of a *Node* from ourself being dropped back onto us again. Here is the
code that rejects the drop onto the same instance of our *PageDragTreeView* as
the source of the drag.

   /// \<summary\>  
   /// Is this target a match for the provided screen position.  
   /// \</summary\>  
   /// \<param name="screenPt"\>Position in screen coordinates.\</param\>  
   /// \<param name="dragEndData"\>Data to be dropped at destination.\</param\>  
   /// \<returns\>True if a match; otherwise false.\</returns\>  
   public override bool IsMatch(Point screenPt, PageDragEndData dragEndData)  
   {  
      // Cannot drag back to ourself  
      if ((dragEndData.Source != null) &&   
          (dragEndData.Source is PageDragTreeView) &&   
          (dragEndData.Source == \_treeView))  
         return false;  
      else  
         return base.IsMatch(screenPt, dragEndData);  
   }

The *PageDragEndData* parameter contains information about the dragged pages as
well as a reference to the source control of the drag operation.

 

**Implement PerformDrop**  
Finally we need to implement the action to take when the drop occurs on our
target. We just enumerate over all the pages being dragged and create a new
*Node* for each one that is then added to the end of the root nodes collection.
As a final action the last node is selected.

   /// \<summary\>  
   /// Perform the drop action associated with the target.  
   /// \</summary\>  
   /// \<param name="screenPt"\>Position in screen coordinates.\</param\>  
   /// \<param name="data"\>Data to pass to the target to process
drop.\</param\>  
   /// \<returns\>True if the drop was performed and the source can remove any
pages.\</returns\>  
   public override bool PerformDrop(Point screenPt, PageDragEndData data)  
   {  
      // Create a node for each page  
      foreach (KryptonPage page in data.Pages)  
      {  
         // Create node and populate with page details  
         TreeNode node = new TreeNode();  
         node.Text = page.Text;

         // Add to end of root nodes  
         \_treeView.Nodes.Add(node);  
      }

      // Take focus and select the last node added  
      if (_treeView.Nodes.Count \> 0)  
      {  
         \_treeView.SelectedNode = \_treeView.Nodes[_treeView.Nodes.Count - 1];  
         \_treeView.Select();  
      }  
       
      return true;  
   }

 

You now have a fully functional *TreeView* that can interact with other
*KryptonPage* dragging source and targets.
