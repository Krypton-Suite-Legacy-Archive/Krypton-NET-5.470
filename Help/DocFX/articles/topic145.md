Tutorial – Expanding HeaderGroups (Stack)

 

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

**5) Drag a KryptonPanel from the toolbox and drop it in the centre of the
form**  


When dropped it should look like the following picture.

**6) Use the KryptonPanel smart tag and click ‘Dock in parent container’**  


The panel will now occupy the entire client area even when the form is resized.

**7) Modify the Padding property for the new KryptonPanel to 5 on all sides**  


We need to add padding because another control will be placed inside and we want
a nice border around the contained control.

**8) Drag a KryptonHeaderGroup from the toolbox and drop onto the panel**  


**9) Use the KryptonHeaderGroup smart tag and click ‘Hide secondary header'**  
This will result in the following picture with the header at the bottom removed
from view.

**10) Use the smart tag again and change the 'BackStyle' to 'Panel -
Alternate'**  
This gives the client area of the control the dark blue background as seen here.  
  
  
  
**11) Click the client area to select the header groups inner panel and set
Padding to be 5**  
By clicking in the center of the header groups client area you will change the
properties window to show the properties of the contained inner panel. Once
selected you then alter the padding for this inner panel to be 5 on all sides.

  
  


**12) Drag a KryptonLabel into the client area of the KryptonHeaderGroup**  
Our example is going to use just a single label as the example content of the
header group.  
  


 

**13) Select the KryptonHeaderGroup and set the 'Dock' property to 'Top'**  
We want the header group always placed at the top of the client area.

**14) Now set the property 'AutoSize' to 'True'**  
This ensures that as the header expands and collapses the size automatically
changes to reflect this. In our example the size will shrink down so that the
content of the header group is shown with a 5 pixel border around it.

  
  
**15) Find the 'ButtonSpecs' property and click the ellipses button**  
We we will use the collection property to define the header button we need.  
  
  
  
**16) Add one instance to the collection and set the 'Type' to 'Arrow Up'**  
Use the 'Add' button on the collection editor to add a new
*ButtonSpec* entry. Then set the 'Type' property of the entry to be 'Arrow Up'.
The new entry should look like the following. Because the header group
defaults the 'AutoCollapseArrow' property to 'True' is means then at runtime the
user can press this button specification in order to toggle the expand/collapse
setting automatically.  
   
  


 

**17) Drag another KryptonHeaderGroup from the toolbox and drop onto the panel**

  
  


**18) Use the KryptonHeaderGroup smart tag and click ‘Hide secondary header'**  
This will result in the following picture with the header at the bottom removed
from view.

**19) Use the smart tag again and change the 'BackStyle' to 'Panel -
Alternate'**  
This gives the client area of the control the dark blue background as seen here.

 

**20) Use the smart tag and change the 'Position' of the 'Primary Header' to
'Bottom'**  
As below the primary header should be moved to the bottom of the header group
control.  
  
  
**21) Click the client area to select the header groups inner panel and set
Padding to be 5**  
By clicking in the center of the header groups client area you will change the
properties window to show the properties of the contained inner panel. Once
selected you then alter the padding for this inner panel to be 5 on all sides.

  
  
**22) Drag a KryptonLabel into the client area of the KryptonHeaderGroup**  
Just as with the first header group,  we use just a single label as the example
content of the header group.  
  
  


**23) Select the KryptonHeaderGroup and set the 'Dock' property to 'Bottom'**  
We want this header group always placed at the bottom of the client area.

**24) Now set the property 'AutoSize' to 'True'**  
This ensures that as the header expands and collapses the size automatically
changes to reflect this. In our example the size will shrink down so that the
content of the header group is shown with a 5 pixel border around it.

  
**25) Find the 'ButtonSpecs' property and click the ellipses button**  
We we will use the collection property to define the header button we need.  
  
  
  
**26) Add one instance to the collection and set the 'Type' to 'Arrow Up'**  
Use the 'Add' button on the collection editor to add a new
*ButtonSpec* entry. Then set the 'Type' property of the entry to be 'Arrow
Down'. Because the header group defaults the 'AutoCollapseArrow' property to
'True' is means then at runtime the user can press this button specification in
order to toggle the expand/collapse setting automatically.  
  
  
**27) Drag a KryptonGroup from the toolbox and drop onto the center of the
client area**  
  
  
  
**28) Update the 'StateCommon -\> Border -\> DrawBorders' property to
'Top,Bottom'**  
Because the centre group will always have a header group above and below we do
not need the top and bottom borders just the let and right need drawing. The
picture below shows the property that needs altering.  
  
  
**29) Last of all set the 'Dock' property to 'Fill'**  
We always want the group to fill up whatever space is left over after
positioning and sizing the top and bottom header group.

Now run the application and without writing a single line of code the top and
bottom groups will collapse/expand as you click the appropriate header buttons.
