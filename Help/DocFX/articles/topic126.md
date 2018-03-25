Docking Persistence Events  
  
Persistence Events:  
        GlobalSaving  
        GlobalLoading

        PageSaving  
        PageLoading  
        RecreateLoadingPage  
        OrphanedPages 

 

**GlobalSaving**  
Called during the save configuration process and allows custom data to be added
into the persisted data. You are provided with an *XmlWriter* reference that
should be used for saving your own information. Custom data can be structured by
adding new elements and attributes as needed so that the XML is structured in a
logical way.  
  
**GlobalLoading**  
Called during the load configuration process and allows previously saved data to
be reloaded. An *XmlReader* reference is provided and should be used to navigate
and process the incoming information. It is recommended that you persist a
version number into the custom data so that on loading you can recognize which
version of your application saved the data. This makes future compatibility
issues easier to handle.  
  
**PageSaving**  
Each time a page is saved this event is called and provided with a reference to
the page along with an *XmlWriter*. Use the text writer to save any additional
information you require associated with the page. For example, you might use
this to save the name of a file that the page was displaying. This allows you to
reload the file during loading so that the file is reconstructed with the same
contents.  
  
**PageLoading**  
Each time a page is loaded this event is fired and provided a reference to the
page along with an *XmlReader*. Load additional information using the text
reader and then perform page setup actions such as creating controls for the
page. You can override the page reference in order to change the page that will
be added to the docking system. So you can create an entirely new page and
modify the event page reference so that the new page you just created is used in
place of the one provided. If you modify the event page reference to be *null*
then the load process will not add any page to the docking system. This is
useful if your application needs to reject the loading of individual pages.  
  
**RecreateLoadingPage**  
If the loading process cannot find an existing page with the same *UniqueName*
as the page detailed in the configuration then this event is fired. This gives
you a chance to recreate the required page. If this event is ignored, or you
return *null* from the event, then the incoming page configuration is ignored
and no page is added to the docking system. If you do create a page and return
it from the event then the loading process continues as normal and the
*PageLoading* event will then be fired for the newly created page.  
  
**OrphanedPages**  
At the end of the loading process there might be pages that were present in the
docking system at the start of loading but are not referenced in the incoming
configuration. Without hooking into this event those orphan pages are disposed
and removed from the docking system. If you want to preserve some or all of
those orphan pages then use this event to catch the pages and store them as
appropriate.
