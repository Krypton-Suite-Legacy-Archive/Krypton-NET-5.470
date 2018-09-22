Workspace Persistence

Applicable Methods:  
        SaveLayoutToArray, LoadLayoutFromArray  
        SaveLayoutToFile, LoadLayoutFromFile  
        SaveLayoutToXml, LoadLayoutFromXml  
        SaveLayoutToStream, LoadLayoutFromStream

  
  
**Persistence Formats**  
You can save and load the workspace layout in a variety of different formats in
order to suit the needs of your application. Use the *SaveLayoutToFile* and
*LoadLayoutFromFile* methods in order to persist to files in the XML format.
This is useful if you need to retain a layout when an application exits in order
to restore it again when next run. Alternatively you can use the
*SaveLayoutToArray* and *LoadLayoutFromArray* pair of methods that persist as an
array of bytes. This makes it easy to place the data into a database, transfer
it over a network connection or just store it within your application. For
greater control you can use the *SaveLayoutToXml* and *LoadLayoutFromXml* pair
that expect *XmlTextWriter* and *XmlTextReader* instances. Finally the last pair
*SaveLayoutToStream* and *LoadLayoutFromStream* provide maximum flexibility
because they accept a generic stream for the storage. This allows you to easily
integrate the configuration information into your own persistence mechanism.

**Information Stored**  
The hierarchy of the workspace is saved which consists of the tree of workspace
sequences and workspace cells. On loading it will remove the existing hierarchy
and create a new one that matches the loaded configuration. For each cell it
also stores the list of pages that it contains. On loading it will either create
a new page to match the one that was saved or actually reuse the existing page
if it still exists in the workspace. It determines if the same page exists by
comparing the *UniqueName* of the page that was saved with the *UniqueName* of
all the existing pages.

When an existing page matches the incoming name it uses the existing page rather
than create an entirely new page. This is ideal when you want to rearrange the
existing set of pages as you can save and later reload the layout and it will
rearrange those pages to the saved organization. Ensure you use consistent
*KryptonPage.UniqueName* values for the pages so that the saved information
continues to match the current pages.

In a dynamic scenario you will have different sets of pages over time and so you
will not always have the saved page already present in the workspace. In this
case the loading will not find a match and so create a new page instance. It
will restore the basic information about the page including the text, tool tip
and image values. But it does not persist the set of child controls that exist
on the page or the visual information such as modified *StateCommon* values. To
recreate the set of child controls and any other page specific information you
need to hook into the *PageSaving* and *PageLoading* events.

**Global Custom Data**  
You may need to store additional application specific data along with the layout
configuration for use when reloading. You can do this quite easily by hooking
into the *GlobalSaving* and *GlobalLoading* events. The saving event will
provide an *XmlWriter *reference that should be used to save your extra
information. Create additional XML elements with whatever information you need
to persist. Loading provides an *XmlReader* that can be used to traverse and
load back that same information.

We recommend saving your own version number into the custom data so that in the
future you can recognize a change in the way you have stored the data. This
makes it easier to change the storage and then still be able to recognize older
formats and be able to process them.

**Page Custom Data**  
Handling per-page custom data is similar to the above global custom data method.
Use the *PageSaving* and *PageLoading* events to hook into the process and use
the event parameters to get a reference to the actual page that is being
saved/loaded. You are given a *XmlWriter* for saving and *XmlReader* for loading
the data. An extra feature of the loading event is the ability to modify the
page reference provided as an event parameter and have that new page reference
used instead of the instance passed into the event. This allows you to override
the loading process and force the use of your own designated page. If you
override the page reference with *null* then you will prevent any page being
added at all. So you can dynamically decide if a loading page is desired and use
*null* to reject it from being added into the workspace.
