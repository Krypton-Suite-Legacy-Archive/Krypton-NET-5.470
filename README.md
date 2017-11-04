# Krypton-NET-4.7

## The 2017-10-17 Commit is:
* An update to Component factory's KryptonToolkit to support the .NET 4.7 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7 Target framework
* Add designer dll to test apps to allow visual design and testing without GAC'ing


## The 2017-11-04 to toolkit solution only:
* Add braces to if statements
* Use explicit types instead of "vars"
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching 
  * Adjust some logic to test bool before cast
  * Use of switch if necessary
* Variable declaration can be inlined
* Null check can be simplified
  * null-propogating code
* Local Variable can be const (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment
* Now you can add the pre-compiled binary files straight to your projects

## Next (No particular order)
* Remove Severity	Code	Description	Project	File	Line	Suppression State
Warning	CS0618	'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.'	Basic Events 2015	#Path to source code#\Krypton-NET-4.7\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs	35	Active
* Change Get Set functions to be inlined
* Some syntactic sugar for initialisers
* Usage of Lync


