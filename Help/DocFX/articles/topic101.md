Navigator Other Properties  
  
Applicable Properties:  
        AllowTabReorder  
        AllowTabFocus  
        AllowTabSelect  
        AutoHiddenSlideSize

 

  
**AllowTabReorder**  
With a default of *True* this property allows the user to change the order of
the pages by using the mouse to drag the page headers to new positions. This
works for all the modes that show individual tabs or check buttons for each page
that is present.

 

**AllowTabFocus**  
The default value of *True* causes the Navigator to act like a traditional
Windows Forms TabControl. This means that the page header becomes part of the
tabbing sequence and this can be seen as you tab around your Form that contains
the Navigator. You will notice that the focus stops at the page header before
moving on to the first control on the page itself. Clicking on a page header
will cause the focus to be placed on the page header. Sometimes this
default behavior is not appropriate for your application. It you set the
property to False then the page headers do not take the focus. This means that
clicking on the page header causes the focus to go straight to the first control
on the page itself. Also using Tab will move straight onto the first control on
the page and will not stop at the page header. When the Navigator is used
inside the Workspace the property is set to be False as this is more appropriate
for that environment.

 

**AllowTabSelect**  
This property determines if any page is allowed to become selected. Use of this
property is only recommend in combination with a tab strip style mode. Tab strip
modes do not display any page contents and so having no selected page will not
cause strange drawing. The main use of this property is within the
*KryptonDocking* component where the auto hidden groups are displayed using a
*Navigator* with this setting defined.

 

**AutoHiddenSlideSize**  
Use this property when the page is being used in the *KryptonDocking* component.
It defines the size to use for the page when it slides into view from an auto
hidden group.  
  
 
