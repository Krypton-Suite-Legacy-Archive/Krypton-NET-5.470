Workspace Overview  
  
**Workspace Properties**  
The *KryptonWorkspace* specific properties are shown in Figure 1.  
  
  
*   Figure 1 - Workspace properties*

 

**AllowPageDrag**  
A boolean property that determines if the user is allowed to drag pages in order
to change the workspace layout.

**AllowResizing**  
Determines if the user is allowed to resize cells by moving the separators that
are positioned between cells. Also note that there is an *AllowResizing*
property on each of the *KryptonWorkspaceCell* instances that can prevent
resizing on a per-cell basis. In order to move a separator this property must be
*True* as well as the cell on on either side of the separator.

**CompactFlags**  
Just before the workspace is sized and positioned a compacting phase is run
to optimize the structure of the workspace hierarchy definition. This set of
flags determine the compacting actions that are allowed to take place. For more
detail read the [Compacting](topic115.md) section that describes reach of the
flags.

**ContainerBackStyle**  
Use this style to determine the appearance of the workspace background. The
background can be seen when you have no contents visible or between the cells
when the separator style chooses not to draw any separator element.

**ContextMenus**  
This is a collection of properties that specify the display text and keyboard
shortcuts used for the context menu that appears when you right click a page
header. Try right click on a page header in the workspace and a context menu is
shown with a set of options for modifying the layout. For example you can use
*Move Next* and *Move Previous* to transfer the page to the next/previous cell.

**MaximizedCell**  
Assign a KryptonWorkspaceCell that exists inside the workspace hierarchy to
order to have that cell maximized and showing as the only cell in the workspace
client area. This is useful if you want to allow the user to concentrate on a
single cell for a period of time. Set the property to *null* to remove the
maximized setting.

**Palette, PaletteMode**  
These properties allow you to define the palette for use when drawing the
control. By default it will use the global palette as defined by the
*KryptonManager* instance.

**Root**  
This is a *KryptonWorkspaceSequence* instance that represents the starting point
for defining the workspace definition. You can add *KryptonWorkspaceCell* and
*KryptonWorkspaceSequence* instances into a sequence in order to create a tree
like hierarchy. For more details you should read the [Layout](topic114.md)
section followed by the related [Sizing](topic116.md) section.

**SeparatorStyle**  
Style used for drawing the separators that exist between the individual cell
entries.

**ShowMaximizeButtin**  
Use this property to determine if an extra button should be added to each
workspace cell that is used to toggle between maximized and restored states.

**SplitterWidth**  
Pixel width of the separators that exist between the individual cell entries.

**Four States**  
The separator can be in one of four possible states, *Disabled*, *Normal*,
*Tracking* and *Pressed*. When resizing is allowed for the separator it will be
in the *Normal* state until the user moves the mouse over the separator area at
which point it enters the *Tracking* state. If the user presses the left mouse
button whilst over the separator then it enters the *Pressed* state. If the
workspace control has been disabled then each separator is also placed in the
*Disabled* state.

**Common State**    
To speed up the customization process an extra *StateCommon* property has been
provided. The settings from this are used if no override has been defined for
the state specific entry. Note that the specific state values always take
precedence and so if you define the border width in *StateNormal* and
*StateCommon* then the *StateNormal* value will be used whenever the control is
in the *Normal* state. Only if the *StateNormal* value is not overridden will it
look in *StateCommon*..
