Tutorial – Expanding HeaderGroups (DockStyle)

 

**1) Create a new Windows Forms project**  


This will automatically create a form in design mode as below.

 

 

 

 

**2) Add a reference to the ComponentFactory.Krypton.Toolkit assembly**  
  
**C\#** : Right click the 'References' group in your project and select the 'Add
Reference...' option. Use the 'Browse' tab of the shown dialog box to navigate
to the location you installed the library and choose the
'\\bin\\ComponentFactory.Krypton.Toolkit.dll' file. This will then add the
toolkit assembly to the list of references for the project.  
  
*VB.NET* : Right click the project in the 'Solution Explorer' window and choose
the 'Add Reference' option. Use the 'Browse' tab of the shown dialog box to
navigate to the location you installed the library and choose the
'\\bin\\ComponentFactory.Krypton.Toolkit.dll' file. This will then add the
toolkit assembly to the list of references for the project.

 

 

**3) Ensure that the Krypton Toolkit components are in the Toolbox**  
If not the [Using Krypton in VS2005](Using%20Krypton%20in%20VS2005.md)
tutorial can be used to add them.  
  
 

**4) Open the code view for the form and change the base class.**  


Change the base class from the default of 'Form' to be
'ComponentFactory.Krypton.Toolkit.KryptonForm'. Your new definition for C\#
would be: -

public partial class Form1 : ComponentFactory.Krypton.Toolkit.KryptonForm

If using VB.NET then your new definition should like this: -

Partial Class Form1  
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

Recompile the project and then show the form in design mode again, this time you
should see custom chrome applied to the form.

 

 

 

**5) Drag a MenuStrip from the toolbox and drop it on the form**  


This will automatically dock itself to the top of the form.

 

 

  
**6) Use the MenuStrip smart tag and click ‘Insert Standard Items’**  


Click the small box on the top right of the MenuStrip to open the smart tag.

 

 

**7) Drag a ToolStrip from the toolbox and drop it on the form**  
This will automatically dock itself underneath the MenuStrip

 

**8) Use the ToolStrip smart tag and click ‘Embed in ToolStripContainer’**  
This will create a box with four edge markers and a tool bar area at the top.

 

 

 

**9) Drag a StatusStrip from the toolbox and drop it on the form**  
This will automatically be docked to the bottom of the form as shown here.

 

 

 

 

**10) Use the StatusStrip smart tag and change the 'RenderMode' to
‘ManagerRenderMode'**  
By default the StatusStrip uses the system renderer but Krypton needs to have
all tool strips use the global ToolStripManager renderer in order to ensure a
consistent look and feel across all the strips. So we change the rendering mode
to ensure the consistent appearance.

 

 

 

**11) Use the properties window to select the 'toolStripContainer1'**  
You cannot select the tool strip container by clicking on the container itself
in the designer and so we need to use the properties window to manually cause
the selection to change. Once selected you will notice the designer view change
to show the entire tool strip container selected with the smart tag button
displayed.

 

 

**12) Use the ToolStripContainer smart tag and select ‘Dock Fill in Form'**  
We do this so the container takes up all the space left over after positioning
the menu and status strips.

 

 

**13) Select the tool strip and use the smart tag to select 'Insert Standard
Items'**  
Click the small box on the top right of the ToolStrip to open the smart tag.

** **  
  
  
**14) Click center of the client area then use properties window to set
'RenderMode' to 'ManagerRenderMode'**  
By default the content panel in the center of the tool strip container uses the
system renderer but Krypton needs to have all tool strips use the global
ToolStripManager renderer in order to ensure a consistent look and feel across
all areas. So we change the rendering mode to ensure the consistent appearance.

 

 

You should now have the following appearance which is the starting point for
building the specific functionality of this tutorial.

 

 

**15) Modify the Padding property for the ‘toolStripContainer1.ContentPanel’ to
5 on all sides**

You should still have the content panel of the tool strip container selected in
the properties window, if not then just click in the center of the client area
and the content panel will be selected again. Then alter the padding property as
shown here. This adds padding around the four form edges otherwise all the
panels would be placed hard against the edges.

 

  
**16) Drag a KryptonHeaderGroup from the toolbox and drop it onto the main
panel.**

 

 

**17) Use the KryptonHeaderGroup smart tag and click ‘Hide secondary Header’**  
We only need the top header for this example and so we need to hide the bottom
header.

 

 

 

 

**18) Use smart tag again to set the 'Back Style' to 'Panel - Alternate'**

This changes to background from white to a complimentary panel style.

 

 

**19) Select the kryptonHeaderGroup1.Panel property and set 'MinimumSize' to
'50,50'**

Click on the center of the header group client area to select the
kryptonHeaderGroup1.Panel that is contained inside the header group. Then use
the property window to alter the 'MinimumSize' to be '50,50'. This size will be
enforced when the group is expanded and auto sized.

 

**20) Select the  kryptonHeaderGroup and change the 'Dock' property to 'Top' and
the 'AutoSize' to 'True'**  
Click the header section of the header group control to show its properties
again in the property window. Our example is going to place the header group at
the top of the client area by using the 'Dock' property but your application
could just as easily position it against any of the other edges instead. The
'AutoSize' is needed so that the header group automatically resizes
appropriately when the collapsed state changes.

 

 

**21) Drag a KryptonPanel from the toolbox and drop it onto the main panel.**

** **  
  
**22) Set the panels 'Dock' property to be 'Top' and 'Size' to '5,5'**  
We are using the panel as spacer between the header group and the rest of the
client area. So setting the 'Dock' to 'Top' places the spacer immediately below
the header group and a 'Size' of '5,5' ensures the height of the spacer is 5
pixels.

**23) Drag a KryptonGroup from the toolbox and drop it onto the main panel.**

This is the group we are going to use to fill the remainder of the client area.

 

 

**24) Use smart tag for the KryptonGroup and click 'Dock to parent container'**  
We want the group to take up all the space not used by the top header group.

   
  
**25) Select the KryptonHeaderGroup and edit the 'ButtonSpecs' collection.**  
Click the KryptonHeaderGroup to show the control properties in the property
window. Then find the 'ButtonSpecs' property and click the edit button on the
right hand side of the property, as shown below.

**26) Use the 'Add' button on the collection editor create a new button
specification.**  
This should create an entry in the left hand list and show a set of properties
on the right.

 

**27) Modify the 'Type' property to be 'Arrow Up'**  
Using this predefined type ensures the correct image is shown and pressing the
button toggles the collapsed state.

**28) Compile and run the code and you will have an expanding header group.**  
  
**     **  

