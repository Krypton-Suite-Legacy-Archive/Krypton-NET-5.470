KryptonDataGridView

 

The *KryptonDataGridView* control derives from the standard *DataGridView* that
comes with .NET 2.0. This allows you to take advantage of all the features
present in the *DataGridView* control but with the advantage of drawing in the
*Krypton* palette style. As with all *Krypton* controls you can customize the
appearance by providing a custom palette or by modifying the individual state
appearance properties. For information about non-appearance aspects of the
control you should refer to the *DataGridView* control documentation.

 

 

**Grid Styles** 

Select the *KryptonDataGridView* control at design time and using the properties
window you can navigate to the *GridStyles* compound property. This property is
used to specify the *Krypton* styles used for drawing the different elements of
the grid. There are three built-in styles called *List*, *Sheet* and *Custom1*.
Usually you would modify all the grid elements to use the same *List*, *Sheet*
or *Custom1* setting so that the appearance is consistent.

 

For example, if you look at the left image in *Figure 1* you can see the default
settings where each grid element is using the *List* setting. Changing just the
*Style* property will cause all the other properties to change to the correct
matching style. The right image of *Figure 1* shows where *Style* has been
updated to *Sheet*. So if you would like all the properties to be in sync then
use the *Style* property.

 

However, if you would like to mix and match the styles of the different grid
elements then you can modify them individually. For example you might change
*StyleDataCells* to be *Sheet* and then alter the *StyleRow* to be *List*. In
that scenario the *Style* property will automatically update itself to become
*Mixed* as the settings of the grid element properties are a mixture of styles
and not consistent.

 

*   Figure 1 - Style = List & Style - Sheet*  
  


You can see the visual different between the *List* and *Sheet* styles by
looking at *Figure 2*. The left image is the *List* style when the *Office 2007
- Blue* palette is used and the right image is the same palette but with the
*Sheet* style.

 

*   Figure 2 - Grid Appearance for List & Sheet styles*

 

 

**HideOuterBorders**

Unlike the standard *DataGridView* control the *Krypton* version never draws a
border around the entire control area. This is because the *DataGridView*
control does not provide an effective method of overriding the drawing of the
control border and so it has been always removed. Many developers may find that
they do need a *Krypton* appropriate border around the control. To achieve the
border you can simply place the *KryptonDataGridView* instance inside a
*KryptonGroup* instance and modify the grid to fill the entire group area by
setting the *Dock* property to *Fill*.

 

This solution does not always give an appropriate appearance. You can see in the
left image of *Figure 3* that the border around the entire control clashes with
the border around the grid cells. By setting the *HideOuterBorders* to True you
prevent the drawing of the cells borders where they are adjacent to the group
border. The right image in *Figure 3* shows the resulting more aesthetic result.

   
*   Figure 3 - HideOuterBorders = False & True*

 

 

**Five States** 

There are 5 different states that grid elements can be in at any given time.
These are *Normal*, *Disabled*, *Tracking*, *Pressed* and *Selected*. Note
however that not all the different elements use all the possible states. All the
grid elements of *DataCells*, *HeaderColumn*, *HeaderRow* and *Background* make
use of the *Normal* and *Disabled* states. All except the *Background* make use
of the *Selected* state. Only the *HeaderColumn* and *HeaderRow* use the
*Tracking* and *Pressed* states. To find the appearance properties for a given
state just look in the *Visuals* category of the properties window and expand
the relevant named compound property such as *StateNormal*.

 

To speed up the customization process an extra *StateCommon* property has been
provided. The settings from this are used if no override has been defined for
the state specific entry. Note that the specific state values always take
precedence and so if you define a text color in *StateNormal* and *StateCommon*
then the *StateNormal* value will be used whenever the control is in the
*Normal* state. Only if the *StateNormal* value is not overridden will it look
in *StateCommon*.

 

 

**Overriding Cell Styles**

It is common when using a grid control to override the appearance of individual
cells or whole columns of cells. For example you might have a column that
contains currency values and want to show the negative values in red and the
positive values in black. You can do this using the *KryptonDataGridView*
control in the same way that you would for the standard *DataGridView* control.

 

To modify the *Font*, *BackColor*, *ForeColor*, *SelectionBackColor* and
*SelectionForeColor* for a column you would use the properties window to find
and edit the *Columns* collection. After selecting the column instance of
interest you would alter the *DefaultCellStyle* from the editing dialog and then
alter the properties as required. This is exactly the same process as for the
standard *DataGridView* control.

 

Updating the cell style for an individual cell is done via code. You just access
the cell style associated with the individual cell and change the property of
interest. For example you could use the following code to change the text color
to red for the first cell in a grid instance.

 

   kryptonDataGridView1.Rows[0].Cells[0].Style.ForeColor = Colors.Red;

 

Overriding the cell styles works because the *KryptonDataGridView* only uses the
palette defined colors when the cell style for a cell has been explicitly
specified.

 

 

**Defining Grid Columns**

At design time you can specify the number and type of columns shown by the grid.
You should always us the Krypton specified version of the column type whenever
possible. For example, instead of using the *DataGridViewTextBoxColumn* instead
select the *KryptonDataGridViewTextBoxColumn*. This ensures the column cells are
drawn in a manner consistent with the Krypton palette. The nine possible Krypton
specific types are:-

 

-   *KryptonDataGridViewTextBoxColumn*

-   *KryptonDataGridViewMaskedTextBoxColumn*

-   *KryptonDataGridViewComboBoxColumn*

-   *KryptonDataGridViewNumericUpDownColumn*

-   *KryptonDataGridViewDomainUpDownColumn*

-   *KryptonDataGridViewDateTimePickerColumn*

-   *KryptonDataGridViewCheckBoxColumn*

-   *KryptonDataGridViewButtonColumn*

-   *KryptonDataGridViewLinkColumn*

 

When adding a new column definition at design time you will be presented with a
ComboBox that lists all available column types. Figure 4 shows an example of
this scenario and shows where the *Krypton* set of columns are displayed within
the available options.

 

 

*   Figure 4 - Krypton Specific Columns*
