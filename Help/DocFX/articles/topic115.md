Workspace Compacting

  
**Compacting Flags**  
One of the unique features of the KryptonWorkspace is the hierarchical structure
of the layout definition. It means you can quickly and easily create complex
layouts for your document area. But dragging pages around could cause the
structure to become inefficient and leave redundant entries. To prevent this
happening there are some flags that indicate how to perform a compacting phase
just before the layout of the contents occur. Each of the compact flags is used
to resolve a potential inefficiency. The flags are exposed via the
*KryptonWorkspace.CompactFlags* property. Each of the flags is explained below
with an example of how they change the layout definition.

 

**RemoveEmptyCells**  
Using drag and drop you can transfer a page from one cell to another. If you
remove the last page in the cell you are left with a cell that has no pages.
Some applications may want this to happen but many others would prefer the cell
to be automatically removed as an empty cell is redundant. When this flag is set
the compacting phase will search for any cells that have no pages defined and
remove them from the definition.

 

**RemoveEmptySequences**  
Removing empty cells can result in a workspace sequence existing that has no
child elements. Once all the cells contained in the sequence have been removed
we are left with a redundant sequence. The user will not see the sequence as it
is likely to be zero sized but it still exists in the hierarchy. During
compacting this flag will search for sequences that have no children and
automatically remove them.

 

**PromoteLeafs**  
A more subtle scenario involves a sequence that contains just a single child. If
a sequence contains just a single child item then that sequence itself is
redundant as it only encloses one item. This flag will promote the single child
into the place of the sequence and delete the no longer needed sequence. This
situation occurs if you used drag and drop to move pages around. You can end up
with a sequence that contains a single sequence child that contains yet another
single sequence child and so forth. Although you would not see any visual impact
it is clearly inefficient to have long chains of single sequences.

 

**AtLeastOneVisibleCell**  
Use this flag to ensure you always have at least one visible cell in the
workspace. If the user deletes the last showing page in the last showing cell
then the *RemoveEmptyCells* flag above would remove the last cell and leave the
workspace area blank. Some applications require that there is always at least
one cell showing even if it has no pages in it. This flag will ensure that is
the case.

 

**Example**  
Imagine we have the following workspace definition in place when compacting
occurs.

   Sequence          (Horizontal)  
         Sequence    (Vertical)  
               Cell  (1 Page)  
         Sequence    (Vertical)  
               Cell  (No Pages)  
               Cell  (No Pages)

*RemoveEmptyCells* removes empty cells giving.

    Sequence          (Horizontal)  
          Sequence    (Vertical)  
                Cell  (1 Page)  
          Sequence    (Vertical)  
  
  
*RemoveEmptySequences* removes empty sequences giving.

    Sequence       (Horizontal)  
          Sequence (Vertical)  
             Cell  (1 Page)

*PromoteLeafs* replaces sequences with a single item giving.

    Sequence       (Horizontal)  
          Cell     (1 Page)
