# ![Krypton](/help/logo.png)-NET-4.7 

=======

## NOTE: In order to **design** within the IDE with this toolkit, please ensure that you reference the `ComponentFactory.Krypton.Design.dll` in ALL of your projects at ALL times!

# ["Toolkit help index"](https://rawgit.com/Smurf-IV/Krypton-NET-4.7/master/Help/index.html)

=======

## 2018-02-11 Rename and add help
* Rename the ToolKit Examples to 2018
* Add the start of structured help and links

=======

## 2018-02-10 Fix Issue #28 and add help
* Fix issue #28 - Undo changes that checked for null, and then would use a null, rather than return a null.. 
* Add initial API Help from `DocFX`

## 2018-01-27pm New Nuget package release
* New Nuget package, version `4.70.544` (build date January 27th, 2018) has been released

=======

## 2018-01-27am Help file migration/update
* Decompiled `chm` file ready for migration/updates
* New 7z file/directory in `Help` labeled `Help File Data` containing the contents of the `chm` file
* Remove duplicate information in `README.md`

=======

## 2018-01-26 `TrackMouse####`
* Add the `designer events` to describe the controls that have `TrackMouse Enter` and `Leave`
* Rename the projects to reflect year, to prevent confusion with old .net 4.5 projects
* Update test app to demonstrate `TrackMouse#### Events`

=======

## 2018-01-24pm KryptonTextBox.cs descriptions
* Added descriptions to `OnTrackMouseEnter` and `OnTrackMouseLeave` events to make more sense

=======

## 2018-01-24am Designer bug fix
* Fixed bug with ComponentFactory.Krypton.Design.dll to version `4.70.0.0` due to hard coded values in toolkit code. Thanks to Smurf-IV for pointing this out to me.
* New Nuget package, version `4.70.524`, relating to the version of ComponentFactory.Krypton.Designer.dll (build date January 24th, 2018) will be uploaded to incorporate this fix.

=======

## 2018-01-23 Repository changes
* Releases tab is now enabled!
* New branch called LTSR for long term stable releases.

=======

## 2018-01-20 Nuget package update
* Fixed Nuget package specification to show the true file assembly number, i.e `4.70.522.0` (build date January 16th, 2018) [Issue, #13](https://github.com/Wagnerp/Krypton-NET-4.7/issues/13)
* All new releases of packages will no longer have a dedicated changelog. Instead, it will point users back to [this repository](https://github.com/Wagnerp/Krypton-NET-4.7) for more information.
* All new releases of packages will no longer ship with the '.chm' help file. This is to reduce file size from 70+ MB to 5 - 6 MB. If the help file is needed, then please refer to [this link](https://github.com/Wagnerp/Krypton-NET-4.7/raw/master/Help/KryptonHelp.chm) to download it.
* New versions of Nuget packages can be obtained via [this link](https://www.nuget.org/packages/KryptonToolkitSuite47/) or via your package manager with the following command 'Install-Package KryptonToolkitSuite47 -Version 4.70.xxx' (replace the x's with version number) or by searching KryptonToolkitSuite47 in your package manager.

=======

## 2018-01-15 Minor changes
* Renamed `GetCreateParams()` method to `DrawDropShadow()` in 'KryptonForm.cs' to avoid confusion
* Added/update documentation/comments for drop shadow methods in `KryptonForm.cs` to make functions clearer

=======

## 2018-01-14 Toolkit Solution changes
* Convert to `'?:` expression
  * `null-coalescing` if applicable
  * Then to `Expression body` if simplified enough
* Fix some spelling mistakes along the way
* Add Ctrl+c text to `KryptonCommand`

=======

## 2018-01-13 Minor changes in `SeparatorController.cs`
* Fixed bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79) courtesy of Cocotteseb

=======

## 2018-01-12 Master branch changes
* Removed binaries due to merge issues
* Attempt at including drop shadow around the form
* Begin work on fixing bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79)
* Groundwork for Visual Studio project & item templates

=======

## 2018-01-11a Fix the KryptonMessageBox clipping
* Fix `AssemblyCopyright` information date ranges
* Create a Test project demonstrating MessageBox usage
  * Fix Mangled Caption that may contain carriage returns
  * Fix Box clipping on long and short text combinations
  * Add Extra text showing that Ctrl+C works in a `KryptonMessageBox`

=======
  
## 2018-01-11 Fix the Code Header and __nameof__ in Exceptions
* Code Headers changed:
  * Add correct license term and date range for ComponentFactory
  * Moved Wagnerp and Smurf-IV to later
* Use `nameof` for exception parameter references
* Add /// comments (on some public API's) stating that an exception can be returned if it explicitly __throws new__

=======
 
## 2018-10-10 Assembly values modifications
* Updated values as suggested in issue #7
* Refreshed Nuget package data to reflect changes

=======

## 2018-01-09 Incremental versioning
* To reflect the .Net version move to Major.Minor of `4.70`
* Build will increment, with the final useless installable number left at zero
* Use "[Automatic Versions](https://marketplace.visualstudio.com/items?itemName=PrecisionInfinity.AutomaticVersions)" to perform the update build number action

=======

## 2018-01-08 Repository changes
* Nuget package upload
* Chocolatey package is in the works

=======

## 2018-01-07 pm Toolkit Solution changes
* Reupload of fresh binaries after a good fight!
* Changed year of all classes, controls et.c from 2017 to 2018
* Mass rebuild of solution
* Eradicated all references of `4.5.0.0` to `4.7.0.0`

=======

## 2018-01-07 Toolkit Solution
* Message content size adjustment in `KryptonTaskDialog`; ComponentFactory commit [5463f83](https://github.com/ComponentFactory/Krypton/commit/5463f835bcdbfffbafc9002923e0bea831bed211)
* Remove "Assignment is not used"
* Initialise orientation in mementos correctly
* CherryPick Merges from [Cocotteseb ](https://github.com/Cocotteseb/Krypton)
  * Docking : Get the KryptonWorkspaceCell from a page; commit [ea42f5f](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Improvements to Krypton Workspace; commit [fe2e778](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Draw text without a glowing background, for use on a composition element; commit [0286bd1](https://github.com/Cocotteseb/Krypton/commit/d3876704ad0ec24f5379a7febc1e3c3a1844e8af)
  * Modifications required for Krypton OutlookGrid; commit [d387670](https://github.com/Cocotteseb/Krypton/commit/7adde64817cfaa3967da1773774949a37d4b4a84)
  * Fixed an exception crash in KryptonTreeView; commit [7adde64](https://github.com/Cocotteseb/Krypton/commit/8d529d7a624c71c3ce22a7205f9116f0d443bb64)
  * Improvements Office2010 Black and first try Render Office 2013; commit [8d529d7](https://github.com/Cocotteseb/Krypton/commit/f85b69403a2e4359c546fb7d959dfd2c737491f1)
  * Windows 10 1511 enhancements + maximized windows bug fix trying; commit [71e5f32](https://github.com/Cocotteseb/Krypton/commit/621ab7c5ca1d7cd47f2c527ae1c18731b622b846)
  * Added KryptonMenuImageSelect click event; commit [621ab7c](https://github.com/Cocotteseb/Krypton/commit/ef4a415b84ac4ce9b145db9d723701a0099ce0f1)
  * Trying to fixed rare crashed in KryptonRibbon Composition; commit [ef4a415](https://github.com/Cocotteseb/Krypton/commit/c55aeadc2224ed68a7446bf3986eb02bf0415751)
  * Add DPI Awareness for Tab images (Mixture of commits)
* Update a few test to use Office 2013 palettes
* Remove Binaries from Git

=======

## 2018-01-06 Toolkit solution and Examples II changes:
* Remove "redundant delegate constructors" for callbacks
* Fix `OnClick` routing for 
  - ListBox
  - CheckedListBox
  - TextBox
  - TreeView
* Update the test project to see if click on TextBox's work as expected 
* Set some private fields to `readonly`
* Fix AddToWorkspace in KryptonDockingManager

=======

## 2017-11-12 Toolkit Examples II solution changes:
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, Labels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove `Severity Code Description Project File Line Suppression State` Warning CS0618 `SecurityAction.RequestMinimum` is obsolete: `Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.` Basic Events 2015 [Source Path]\Krypton-NET-4.7\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active
 
=======
## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7 Target framework
* Add designer Dll to test apps to allow visual design and testing without GAC'ing

=======

## 2017-11-12 Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets

=======

 ## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects

=======

## 2017-11-04 Toolkit solution only:
* Add braces to if statements
* Use explicit types instead of `vars`
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching 
  - Adjust some logic to test bool before cast
  - Use of switch if necessary
* Variable declaration can be inlined
* Null check can be simplified
  - null-propagating code
* Local Variable can be const (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment

=======

## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7.0 Target framework
* Add designer Dll to test apps to allow visual design and testing without GAC'ing

=======
## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects

=======

## 2017-11-12 pm Toolkit solution changes:
* Work out why clipping is the default for `DrawText` 
  - Applies to buttons, Labels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity Code Description Project File Line Suppression State Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.7\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active

=======
 
## 2017-11-12 am Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets


