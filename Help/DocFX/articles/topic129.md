Docking Drag & Drop Events

Drag & Drop Events:  
        DoDragDropEnd  
        DoDragDropQuit

 

**Event Firing**  
At the end of a page drag and drop action within the docking system one of these
events will be fired. If the drop occurred with success then the *DoDragDropEnd*
event will be fired to indicate success. If the drag operation was cancelled for
any reason then the *DoDragDropQuit* event will be fired instead. Note that only
one of these events is fired at the end of an operation and never both.

**External Event Usage**  
The most likely scenario for needing these events is if you are starting off a
drag and drop operation manually from outside the docking system and then need
to know when the operation has been completed. For example, you might have a
*TreeView* that contains a set of nodes. When the user starts dragging one of
these tree nodes you want to create a floating window as part of the docking
system and allow that floating window to be dragged just like any other docking
content. The creation of a new docking page and associated floating window is
very simple and shown in example code below. Once the floating window is created
you would call the docking manager *DoDragDrop* method in order to request that
a drag operation occur with the newly created floating window. You will need to
know when this drag operation completes so you can update the status of your
*TreeView* control. By hooking both the *DoDragDropEnd* and *DoDragDropQuit* you
can update as needed when the operation completes. The following sample code
shows how this might look in practice.

 

protected override void OnMouseMove(MouseEventArgs e)  
{  
   Point pt = new Point(e.X, e.Y);

   // Has a node been selected from dragging?  
   if (_dragNode != null)  
   {

      // Create a new page for the docking system  
      KryptonPage dp =  new KryptonPage("New Page");

      // Create a floating window that contains the new page  
      KryptonDockingFloatingWindow fw =
kryptonDockingManager.AddFloatingWindow("Floating", new KryptonPage[] { dp });

      // Spin message loop so new window appears  
      Application.DoEvents();

      // We want to know when the drag drop operating is finished  
      kryptonDockingManager.DoDragDropEnd += new
EventHandler(kryptonDockingManager_DoDragDropFinished);  
      kryptonDockingManager.DoDragDropQuit += new
EventHandler(kryptonDockingManager_DoDragDropFinished);

      // Drag the new floating window around  
      kryptonDockingManager.DoDragDrop(MousePosition, pt, dp, fw);  
   }

   base.OnMouseMove(e);

}

 

private void kryptonDockingManager_DoDragDropFinished(object sender, EventArgs
e)  
{

   // Remember to unhook from no longer needed events  
   kryptonDockingManager.DoDragDropEnd -= new
EventHandler(kryptonDockingManager_DoDragDropFinished);  
   kryptonDockingManager.DoDragDropQuit -= new
EventHandler(kryptonDockingManager_DoDragDropFinished);

   // Drag has finished so set drag node back to null  
   \_dragNode = null;  
}
