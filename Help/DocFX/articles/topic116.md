Workspace Sizing

  
**StarSize Property**  
Both the *KryptonWorkspaceCell* and the *KryptonWorkspaceSequence* have a
property called *StarSize* that is used to define the sizing for that part of
the workspace layout. You can define the cell/sequence to have either a fixed
size or a proportional sizing value. The *StarSize* is a string type that is
expected to contain two values separated by a comma. The 'Star' in *StarSize*
refers to the notation used when providing a proportional sizing value. This is
best explained using a series of pictures. Figure shows two cells that are both
defined to have a width of '1\*'.

 

    
*  Figure 1 - Two cells with '1\*' as the width*

The available width is first allocated to whatever fixed size cells are defined.
We have none in this example and so the entire width is then allocated to the
cells with stars defined. The total number of stars is 2 and so each cell gets
half the available width as they each have half the number of total stars. As we
increase the size of the Workspace control we get the following change in
appearance as seen in Figure 2.

   
   
*  Figure 2 - Two cells with '1\*' as the width*

Both still get half the total width. If we update the first cell to have a value
of '3\*' for the width we can see Figure 3 showing the resultant change.

   
   
*  Figure 3 - Two cells with '3\*' and '1\*' for the widths*

The total number of stars is 4 and so the first cell is given 3/4 of the space
and the second cell just 1/4. Using star sizing makes it very easy for you to
indicate the relative proportions of each cell. These examples only show the
width changing but the height works in the same way when the cells are placed in
a vertical sequence. Note that in a horizontal sequence the width is defined by
using the width of the *StarSize* and in a vertical sequence the height is
defined from the height of the *StarSize*. The opposite direction from the
sequence is always defined as whatever is needed to fill sequence. So in our
above examples we are using a horizontal sequence and so the height of each cell
is always the entire height of the sequence itself.

  
**Fixed and Proportional**  
Most real world scenarios will likely include fixed as well as proportional
cells. To show this we define three cell with widths defined as '100', '1\*' and
'1\*' respectively. Figure 4 shows how this will appear at runtime.

   
   
*  Figure 4 - Three cells with '100', '1\*' and '1\*' for the widths*

The first cell is fixed in width and so allocated the full 100 pixels with the
remaining space split evenly between the other two cells. If we expand the
Workspace to be be wider we get the change as seen in Figure 5.

   
*  Figure 5 - Three cells with '100', '1\*' and '1\*' for the widths*  
  
As expected the first cell has stayed the same fixed width and the others have
split up the larger space between themselves. If we change the width of the
third cell to be '4\*' we get the Figure 6 appearance.

   
*  Figure 6 - Three cells with '100', '1\*' and '4\*' for the widths*  
  
The last cell takes up 4/5 of the remainder space and the second cell just 1/5.
Shrinking the window changes the appearance as seen in Figure 7.

   
  *Figure 7 - Three cells with '100', '1\*' and '4\*' for the widths*

The combination of fixed and proportional sizing gives the flexibility you need
to construct just about any scenario you are likely to need. When you use the
splitter to change th sizing it will automatically update the star and fixed
sizes correctly to reflect the change. Calling the size fixed only refers to a
fixed layout and does not mean the users cannot change the size using the
splitter. You prevent a cell from being resized by the user you should set the
*KryptonWorkspaceCell.AllowResizing* property to *False*.
