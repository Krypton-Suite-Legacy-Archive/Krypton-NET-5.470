DragManager

If you want to enable dragging of *KryptonPages* between different controls you
need to create an instance of the *DragManager* class. This class links together
a set of target providers so that they are all available during a drag
operation. Using the class is very easy. First of all create an instance using
the default constructor. Second you add to the *DragTargetProviders* collection
each of the dragging targets. Third and last you assign the *DragManager* to the
*DragPageNotify* property of each control that can start a drag.

 

Properties

**DragTargetProviders**  
This collection is used to store a list of *IDragTargetProvider* instances. A
call to *DragStart* begins the dragging process and this list is used to
generate the drop targets for use during the entire drag operation.

**Palette**  
If you provide a *KryptonPalette* instance to this property it will be used as
the source for appearance values when drawing the visual feedback.

**PaletteMode**  
A default of *GlobalPalette* causes the global palette defined by the
*KryptonManager* to be used for appearance values. If you provide a *Palette*
property value then this will be updated to *Custom* to reflect the use of a
directly provided palette instance. To alter values for just this *DragManager*
you should update the values contained within the *StateCommon* property.

**StateCommon**  
Overrides for altering the appearance of the drag feedback. The most significant
of these is called *Feedback* and is an enumeration of possible feedback drawing
methods. The values are defined as follows:-

-   Block - As the mouse moves our hot areas a semi-transparent block of color
    indicates the drop area.

-   Square - Visual Studio 2005 style square indicators are shown.

-   Rounded - Visual Studio 2008 style rounded indicators are shown.

**DocumentCursor**  
If you define the *StateCommon.Feedback* property to be *Block* then this
property is used to determine if the cursor should be updated to show a
document. When over a drop target a document cursor is used and when not over a
hot area a document with cross is provided. You should not alter this property
whilst dragging is occuring.

**IsDragging**  
A 'get' only property used to discover if a drag operation is currently
occuring.

 

Methods

**DragStart**  
You should call this when you want a drag operation to be started. The first
parameter is the screen position of the mouse when the drag started. A second
parameter of type *PageDragEndData* is used to specify the set of pages that are
being dragged. It also contains a reference to the control that is initiating
the operation and allows the targets to make decisions about the eligibility of
the drag based of the source and set of pages involved.

**DragMove**  
Each time the mouse moves during the drag operation you should call this method
in order to have the visual feedback updated. It takes just a single parameter
which is the new screen point of the cursor. The targets are tested each time to
determine which now best matches the updated mouse position.

**DragEnd**  
When dragging has finished with success this method is called so that any
appropriate target can be invoked. You need to provide the new screen point of
the cursor.

**DragQuit**  
To cancel the current dragging operation call this method without any
parameters.

  
**NOTE**: These methods are all virtual and so you can customize the
implementation by deriving from the *DragManager* and then overriding the
methods. You might want to do this if you have special logic you want to apply
in the *DragStart* that decides if the dragging is allowed to continue based on
the actual pages being dragged.
