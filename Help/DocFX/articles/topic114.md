Workspace Layout

  
**Cells and Sequences**  
You can create any complexity of workspace layout by combining the
*KryptonWorkspaceCell* and *KryptonWorkspaceSequences* elements. Each
*KryptonWorkspaceCell* represents a leaf node in the layout and is actually a
class derived from the *KryptonNavigator*. Leaf nodes are those that do not have
any children. As each cell is actually a specialized *Navigator* instance you
can customize the appearance with any of the *Navigator* capabilities. The
*KryptonWorkspaceSquence* is used to contain a set of child elements and by
combing sequences within sequences you can create a tree like structure that
defines the layout hierarchy.

 

**KryptonWorkspace.Root**  
The starting point for defining the layout is the *Root* property of the
*KryptonWorkspace* that is actually just a *KryptonWorkspaceSequence* instance.
Each sequence, including the *Root*, has a property called *Orientation* that
determines the direction that child elements are positioned. To demonstrate
Figure 1 has a *Root* sequence with three cells inside. The left image has a
*Root.Orientation* of *Horizontal* and the right image a value of *Vertical*.

 

     
  *Figure 1 - Horizontal and Vertical orientations*

  
Children within a sequence are always sized to fill the opposite direction. So
in the left image we have a horizontal sequence where each cell is automatically
defined to be the full height of the area. The height definition of the cell is
ignored as the height is auto generated. The opposite is true of the right
image. With the sequence being vertical the width is automatically defined to
fill the entire width of the sequence and the cell defined width value ignored.
The following hierarchy represents the left hand image:-

   Sequence  (Horizontal)  
        Cell (Page 1)  
        Cell (Page 2)  
        Cell (Page 3)

 

**Embedded Sequences**  
To create a more complex layout we need to embed sequence instances inside the
root sequence. Figure 2 shows a simple design where we have a cell on the left
and then on the right we have two cells that are arranged in a vertically
column.  
 

      
  *Figure 2 - Sequence with the Root sequence*

The hierarchy of elements looks like the following with the first sequence being
the *Root* sequence property of the *KryptonWorkspace*.

   Sequence       (Horizontal)  
        Cell      (Page 1)  
        Sequence  (Vertical)  
             Cell (Page 2)  
             Cell (Page 3)

 

We can keep going and place another sequence in the place of the third cell
above. In that case we would achieve Figure 3.

      
  *Figure 3 - Sequence within Sequence within Root sequence*

This hierarchy of elements now looks like the following.

   Sequence            (Horizontal)  
        Cell           (Page 1)  
        Sequence       (Vertical)  
             Cell      (Page 2)  
             Sequence  (Horizontal)  
                  Cell (Page 3)  
                  Cell (Page 4)

 

**Perform Layout**  
You can make as many changes as you like the workspace hierarchy but no change
will occur until the control performs a layout cycle. This happens when you
explicitly call the *PerformLayout* method or when the next windows message is
processed. So you are safe to make multiple changes to the workspace definition
without the changes actually occuring until windows messages are processed
again. As cells are added and removed from the child collection of controls only
during the layout processing it means you will not receive the
*WorkspacePageAdding* and *WorkspacePageRemoved* events during your changes to
the workspace definition. Instead they will occur some time afterwards once
layout processing is performed by the control.

 

**Compacting**  
As the user drags and drops pages around the workspace extra sequences are
created in order to create the appropriate appearance. After many such changes
the workspace definition would become very disorganized and inefficient. In
order to prevent this a compacting phase is performed just before the layout.
For this reason you will notice that if you add a sequence that has no children
the sequence is automatically removed from the definition because it is
redundant. To see a full list of the compacting actions you are recommend to
read the [compacting](topic115.md) section.
