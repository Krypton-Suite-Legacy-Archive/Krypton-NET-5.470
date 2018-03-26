Tutorial – Embedding Palette Definitions  
  
**Deploying Palette Definition Files**  
  
Rather than distribute palette definition files as separate XML files you might
prefer to embed them as resources inside your compiled assembly. This prevents
the risk of the user accidentally deleting them and so preventing your
application operating as expected. The following steps show how to embed any
palette definition as a resource and then how to use just a couple of lines of
code to load it at runtime for use.

**1) Right click your project and select the 'Add -\> Existing Item...'**  
We are using this option in order to add out palette XML file to the project.

 

**2) Select the palette definition file you want to embed**  
For this example we are going to choose a palette called, 'Blogger.xml'.

**3) Right click the new project item and select 'Properties'**

 

**4) Change the 'Build Action' to 'Embedded Resource'**  
Changing the build action will cause the XML file to be saved in the built
assembly.

 

**5) Add the following code when you need to load the palette definition.**  
You might choose the load the resource at the time your form is loaded, or maybe
wait until the user chooses any appropriate action. Whatever the case may be you
only need the following three lines of code to load the palette XML file from
resources into a KryptonPalette instance.

    // Get the assembly that this type is inside  
    Assembly a = Assembly.GetAssembly(typeof(Form1));

    // Load the named resource as a stream  
    Stream s = a.GetManifestResourceStream("WindowsApplication1.Blogger.xml");

    // Import the stream into the KryptonPalette instance  
    kryptonPalette1.Import(s);

Of course, you will need to alter the 'typeof(Form1)' to be a type that is
defined in the assembly that contains the embedded resource. Then you will also
need to change the 'WindowsApplication1.Blogger.xml' string so that it has the
correct path to the embedded resource.  
  
In our simple example the palette XML file was added as a top level item of the
project. Therefore the string is constructed by placing the assembly namespace
followed with the name of the file. If your assembly has a namespace of
'MyCompany.MyProject' then the string would have been
'MyCompany.MyProject.Blogger.xml'. You can discover the namespace used by
looking at the project properties.

 

Note that if the resource is added inside a folder then you need to include the
folder name in the created resource path. So if your project has a 'Resources'
folder that you place the palette inside then your path would become
'MyCompany.MyProject.Resources.Blogger.xml'. If you have trouble getting the
path correct then use the 'ildasm' command line utility on your built assembly
to discover the stored path inside the assembly.
