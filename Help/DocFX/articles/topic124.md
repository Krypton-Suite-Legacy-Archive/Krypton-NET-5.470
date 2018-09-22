Docking Persistence

 

Applicable Methods:  
        SaveConfigToArray, LoadConfigFromArray  
        SaveConfigToFile, LoadConfigFromFile  
        SaveConfigToXml, LoadConfigFromXml  
        SaveConfigToStream, LoadConfigFromStream

  
  
**Persistence Formats**  
You can save and load the docking configuration in a variety of different
formats in order to suit the needs of your application. Use the
*SaveConfigToFile* and *LoadConfigFromFile* methods in order to persist to files
in the XML format. This is useful if you need to retain a configuration when an
application exits in order to restore it again when next run. Alternatively you
can use the *SaveConfigToArray* and *LoadConfigFromArray* pair of methods that
persist as an array of bytes. This makes it easy to place the data into a
database, transfer it over a network connection or just store it within your
application. For greater control you can use the *SaveConfigToXml* and
*LoadConfigFromXml* pair that expect *XmlTextWriter* and *XmlTextReader*
instances. Finally the last pair *SaveConfigToStream* and *LoadConfigFromStream*
provide maximum flexibility because they accept a generic stream for the
storage. This allows you to easily integrate the configuration information into
your own persistence mechanism.

**Information Stored**  
The dynamic contents of the docking hierarchy are saved into the configuration
but the static elements are not. So if your docking hierarchy has a floating
capability at save time but that docking element is not present at the reload
then the floating ability is not recreated. This is because the
*KryptonDockingFloating* is a static element that manages a capability and is 
only ever created by the programmer. Floating windows are dynamic content and
details of each floating window are saved into the configuration. On reload the
floating windows will be recreated as long an appropriate
*KryptonDockingFloating* is present that can contain the recreated floating
window definitions.

Only basic information about each page are persisted. The *UnqiueName* of the
page and the *Visible* state are saved but no other page details. This is
because at load time an existing page with a matching *UniqueName* is expected
to be found and then positioned at the location indicated by the loading state.
If the page does not exist then you need to hook into the *RecreateLoadingPage*
event and create the page so it can be positioned.

**Global Custom Data**  
You may need to store additional application specific data along with the
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
*null* to reject it from being added into the docking hierarchy.

**Recreating Pages**  
When the load process is stared the current set of pages within the
docking hierarchy are added into a list. When a page is encountered in the
loading configuration that list is scanned to see if an existing page matches
the same *UniqueName* as the one defined in the configuration. If a match is
found then the existing page reference is used and added back into the
hierarchy. When there is no match it means the page needs to be recreated so it
can then be added into the appropriate location of the docking hierarchy. To do
this the *RecreateLoadingPage* event is fired. If the programmer does not hook
into this event and provide a recreated page then the loading page is ignored.

**Orphan Pages**  
When the load process is stared the current set of pages within the
docking hierarchy are added into a list. At the end of the loading process the
docking hierarchy will have been cleared and recreated with the configuration
that has been loaded. Any page that is in the list but has not been loaded is
called an orphan because it is no longer part of the docking hierarchy. To
process these orphan pages you need to hook into the *OrphanedPages* event. You
might do this to add the orphan pages back into the docking system and prevent
them being lost. If you ignore the event then the orphan pages will be disposed.
