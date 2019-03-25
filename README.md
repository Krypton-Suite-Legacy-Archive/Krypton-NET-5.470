# <img src="https://github.com/Wagnerp/Krypton-NET-4.70/blob/master/Assets/PNG/Square%20Design/Main%20Icon/64%20x%2064/Square%20Design%2064%20x%2064%20New%20Green.png"> .NET 5.470

=======

| NuGet | Current NuGet Version | Github License |
|---|---|---|
| [![NuGet](https://img.shields.io/badge/NuGet-Krypton%20.NET%205.470-green.svg)](https://www.nuget.org/packages/KryptonToolkitSuite5470/) | ![Nuget](https://img.shields.io/nuget/v/KryptonToolkitSuite5470.svg)| ![GitHub](https://img.shields.io/github/license/Wagnerp/Krypton-NET-5.470.svg) | 

# ["Toolkit help index"](https://rawgit.com/Wagnerp/Krypton-NET-4.7/master/Help/Output/index.html)

=======

## NOTE: With the advent of Windows 10 1803 being released to the general public, I am pleased to announce the availability of a 5.472 release that will support the .NET 4.7.2 framework. You can follow the project [here](https://github.com/Wagnerp/Krypton-NET-5.472).

=======

## 2019-03-25 Build 826 - MegaKarken Contributions
* Update example program for AllowDecimals
* Introduced an IconSpec definition for all KryptonDataGridViewColumn types so that icons can be drawn in KryptonDataGridView column header cells
* Adding a Multiline String Editor much like in VS' property grid to the KryptonTextBox control.
* Add Multiline String Editor in KryptonDataGridViewTextBox cells for multiline text editing
* Make MultilineStringEditor resizable.
* Adding KryptonDataGridViewCustomColumn type for DataGridViews
* Adding new KryptonDataGridViewBinaryColumn type for displaying and viewing binary data in GridViews.
* Make Hex-Mode default mode and add a button for exporting the data to a file.
* Slide panels instantly like Visual Studio
* Ignore DBNull.Value as well in GetFormattedValue
* Make the checkbox look a little nicer
* contextMenuStrip gradient color
* Adding a PaletteBackStyle.PanelCustom2 and PaletteBackStyle.PanelCustom3 for more theming flexibility
	* Continue to add custom numbers for the others custom# styles as well !
* Adding HoveredSelectionChanged event to KryptonComboBox
* Make KryptonDataGridViewComboBox accept objects rather than strings only
* Prop up KryptonComboBox with optional tooltips for items
* Extend support for DataGridView icons to Text & data cells
* Build 826 (build date Monday 25th March, 2019) is now available on NuGet

=======

## 2019-03-18 Build 794
* Fixes to `KryptonDockingManager`, issue [#98](https://github.com/Wagnerp/Krypton-NET-5.470/issues/98)
* Build 794 (build date Monday 18th March, 2019) is now available on NuGet

=======

## 2019-03-13 Build 791.1
* Add `*.xml` files to NuGet package, as per [#97](https://github.com/Wagnerp/Krypton-NET-5.470/issues/97)

=======

## 2019-03-11 Build 791
* Fix for [#39](https://github.com/Wagnerp/Krypton-NET-5.470/issues/39)
* Fix for [#74](https://github.com/Wagnerp/Krypton-NET-5.470/issues/74)
* Fix for [#93](https://github.com/Wagnerp/Krypton-NET-5.470/issues/93)
* Fix for [#97](https://github.com/Wagnerp/Krypton-NET-5.470/issues/97)
* Now you are required to accept the license agreement when downloading new NuGet package versions
* Build 791 (build date Monday 11th March, 2019) is now available on NuGet

=======

## 2019-03-04 Build 770
* You can now use `Krypton Tooltips` on listboxes and treeviews [#90](https://github.com/Wagnerp/Krypton-NET-5.470/issues/90)
* `ThemeManager.cs` is now available for ribbon controls
* Build 770 (build date Monday 4th March, 2019) is now available on NuGet

=======

## 2019-02-25 Build 741 - Tooltips & **`ThemeManager.cs`**
* You can now use `Krypton Tooltips` on every Krypton control [#85](https://github.com/Wagnerp/Krypton-NET-5.470/issues/85)
* `ThemeManager.cs` now makes it easier for developers to access the true theme names, without relying on nonsensical enumerations.
* NuGet package build 741 (build date Monday 25th February, 2019) is now available

=======

## 2019-02-11 Build 720 - Fix for drop shadow while using the ribbon component
* Fix for [#56](https://github.com/Wagnerp/Krypton-NET-5.470/issues/56) courtesy of [richterAI](https://github.com/richterAl)
* Build 720 (build date Tuesday 12th February, 2019) is now available on NuGet

=======

## 2019-01-29 **`AccurateText.cs`** - Issue #75
* Bugfix for [#75](https://github.com/Wagnerp/Krypton-NET-5.470/issues/75) courtesy of [nickfinch71](https://github.com/nickfinch71)
* For more information about this issue on NT 6.0 systems, please read thread [#75](https://github.com/Wagnerp/Krypton-NET-5.470/issues/75)
* NuGet package build 717 (build date Tuesday 29th January, 2019) will be made available

=======

## 2019-01-06 New Palettes - `Office 365`
* Build 715 (build date Sunday 6th January, 2019) is now available through NuGet
* Ribbon fixes
* New built-in palette `Office 365` in black, blue, silver and white colours ~~(note to `Office 2013` palette users, please temporarily change your theme before upgrading, as this code has been discontinued)~~
* Office 2007 & 2010 white themes are in the works along with Access Red, Powerpoint Red, Excel/Publisher Green, Outlook Orange/Blue

=======

## 2019-01-03 Year Change
* Changed `2018` to `2019` in code

=======

## 2018-12-03 Build 701
* Build 701 (build date Monday 3rd December, 2018) is now available through NuGet
* Minor changes

=======

## 2018-09-28 Version **`4`** now becomes version **`5`**
* Major version number changed from `4` to `5` after experimenting successfully with NuGet packages
- Known bug if installing via NuGet, ToolBox images will not be displayed properly
- A backup copy of the `4.70` version has been uploaded to the **Version-4.70** branch
* A new NuGet package can be obtained [here](https://www.nuget.org/packages/KryptonToolkitSuite5470/5.470.700) or by typing `KryptonToolkitSuite5470` in the package manager
* Build 700 (build date Friday 28th September, 2018) is now available through the **releases** tab
* Repository name change to reflect version changes

========

## 2018-09-25 Build 643
* Build 643 (build date Tuesday 25th September, 2018) is now available through the **releases** tab, or as a NuGet package (note, this may not work)

=======

## 2018-09-23 Add `design time` and `nullable bool` for feature #67
* Allow the developer to override the `Ctrl+c to copy` text in the Caption

=======

## 2018-09-17 Release of Build 641
* Build 641 (build date Monday 17th September, 2018) is now available through the **releases** tab

=======

## 2018-09-16 `KryptonPalette` changes (build 641)
* The `Import()` and `Export()` methods will now use the native `KryptonMessageBox` instead of a system one
* Removed the phantom `KryptonPalette` component
* Now you can access the full `FilePath` of the loaded palette XML file

=======

## 2018-08-08 Build 633
* Build 633 (build date Wednesday 8th August, 2018) is now available through the **releases** tab
* New icon (not propagated through all the example applications yet)
* General bug fixes

=======

## 2018-07-17 Build 632
* Build 632 (released Tuesday 17th July, 2018) is now available through the **releases** tab

=======

## 2018-07-15 Fix KryptonForm does not respect Minimum Size set in designer #57
* And sort out some spelling mistakes in the `VisualForm.cs`

=======

## 2018-07-03 `SeparatorController.cs` & `DragObject` bug fix, #79
* Fix for bug Issue, #79, courtesy of [James Simms](https://github.com/jwsimms)

=======

## 2018-06-15 Palette Example Application
* Now you can export your custom palette creation in the `Krypton Palette Example` application.

=======

## 2018-06-11 Build 620 + Bugfixes
* Build 620 (build date Monday 11th June 2018) is now obtainable through the `releases` tab.
* Fixed references that blocked demo applications from launching.

=======

## 2018-06-10 System Themes
* Start work on getting the system themes to display the extras. Issue #37 & #38
  * Not perfect but at least the "Chrome" displays the intended buttons and text(s).
* Removal of "not needed" casts.

=======

## 2018-05-25 Updater Fix
* Fix `Close` button

=======

## 2018-05-21 Build 593
* Build 593 (build date Monday 21st May 2018) is now obtainable through the `releases` tab.

=======

## 2018-05-20 Fix the designer for _All_
* Remove the Designer dll (Project / code moved in Git)
* Place designers into actual dlls (Small size increase)
* Fix fallout from Designer dll removal from other projects
  * Fix build path output, and Demo Apps Ref path import and Output

=======

## 2018-05-15 Namespace changes
* Updated namespaces to reflect assembly names, these are found in the `Experimental` folder
* New HTML5 & CSS3 based changelog (not live yet)

=======

## 2018-04-29 Build 572
* Build 572 (build date Sunday 29th April 2018) is now obtainable through the `releases` tab.

=======

## 2018-04-28 Fix build path output, and Demo Apps Ref path import and Output
* Remove hard-coded directory offsets for Component outputs
* Use offset location for components in Demo Apps 
* Remove Release GAC'ing
* Fix explorer for the copied target names

=======

## 2018-04-22 Version 569, build path output changes, repo rename & re-structuring changes
* Build 569 (build date Sunday 22nd April 2018) is now available. It is recommended that you uninstall/remove previous versions first before using this version.
* DLL assembly names have been renamed to `Krypton Design`, `Krypton Docking`, `Krypton Navigator`, `Krypton Ribbon`, `Krypton Toolkit` and `Krypton Workspace`,  these changes do also apply to other binaries in this repo. However these changes does **NOT** affect the namespace names of `ComponentFactory.Krypton.xx`.
* Build output paths have been changed for easier installer authoring and synchronisation.
* Renamed repo title to `Krypton-NET-4.70` to better reflect versioning.
* Removed different architectures folder for easier navigation.

=======

## 2018-04-16 New distribution method, version 568
* All binaries, applications, tools etc. in this project will now be installed by one installer, powered by Advanced Installer. This is to allow easier distribution, and easier end-user updating.
* New folder `Updates` to contain files needed for the new update distribution.

=======

## 2018-04-11 Adjust Ctrl+C display in MessageBox's
* Don't forget to add the TextExtra into the title width calculation
* Only Display "Ctrl+C..." for Error and Exclamation icon's
* Created #39

=======

## 2018-04-10 Version 565
* Build **565** (build date Tuesday 10th April, 2018) is now available from the **releases** tab.

=======

## 2018-04-09 Use All `C#` features
* Change the projects to at least recognise C#7.2 features and enhancements - _to be applied in the future_
* Some tinkering with spelling corrections - _to be applied in the future_

=======

## 2018-03-27 **`KryptonRibbon.cs`** version 562
* Build 562 (build date 27th March, 2017) fixes the issue as noted in #35

=======

## 2018-03-26 Version 561
* Build 561 (build date Monday 26th March, 2018) is now available from the **releases** tab.

=======

## 2018-03-25 More work on the help pages
* Make the Help relevant to the Actual Code #17
* Change `bmp`'s to `png`'s
* Fix location of source for Help
* Change output to be clearer
* Remove previous output *leftovers*
* Add instructions on how to generate

=======

## 2018-03-24pm Fix Issue #29
* MessageBox taking a Null window owner (via default API's / null start / No KryptonManager loaded)
* Sort out the Toolkit examples to use the new dll locations
* Remove `BootstrapperPackage` .Net 3.5 nonsense from projects
* Remove hard coded build `Output Paths`

=======

## 2018-03-24am Palette upgrade tool
* The palette upgrade tool is now back! Enhancements over previous commercial version 4.4.0 include:
- Ability to export upgraded palette XML files
- Check to see if the output palette file is not saved before closing
* Exploration into a console version is in the works

=======

## 2018-03-19 Renderer class changes (Version 556, build date 19th March, 2018)
* Changed some classes from `internal` to `public` for easier accessibility for the **Extended Toolkit**

=======

## 2018-02-22 Toolkit build changes
* All AMD64/x64 solutions should now build into correct directories
* TODO: Rework Krypton Explorer (x64 and Any CPU) code to launch correct binaries

=======

## 2018-02-21 New release
* New build 555 (build date 21st February, 2018) this is the very first time DLLs built for 64-bit architectures have been released. No new Nuget package will be available, due to install issues and this build is very much experimental. Head to the releases tab to download it. If you don't know how to build your application for 64-bit, please look at the `issues` tab for more information.

=======

## 2018-02-20 Toolkit changes
* Renamed everything labelled `2015` to `2018`
* Each solution now has its own binary folder
* Groundwork for supporting AMD64/x64, x86 and 'Any CPU' architectures

=======
## 2018-02-16 New Nuget package release
* Build 553 (build date 15th February, 2018) has been released.
* Palette designer has been included with this release and future releases.

=======

## 2018-02-11 Rename and add help
* Rename the ToolKit Examples to 2018
* Add the start of structured help and links

=======

## 2018-02-10 Fix Issue #28 and add help
* Fix issue #28 - Undo changes that checked for null, and then would use a null, rather than return a null.. 
* Add initial API Help from `DocFX`

=======

## 2018-01-27pm New Nuget package release
* New Nuget package, version `4.70.544` (build date January 27th, 2018) has been released

=======

## 2018-01-27am Help file migration/update
* Decompiled `chm` file ready for migration/updates
* New 7z file/directory in `Help` labelled `Help File Data` containing the contents of the `chm` file
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
* Changed year of all classes, controls etc from `2017` to `2018`
* Mass rebuild of solution
* Eradicated all references of `4.5.0.0` to `5.470.0.0`

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
* Change Get Set functions to be `inlined`
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
  - Adjust some logic to test `bool` before cast
  - Use of switch if necessary
* Variable declaration can be `inlined`
* Null check can be simplified
  - null-propagating code
* Local Variable can be `const` (And rename to upper case to follow the rest of the codebase.)
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
* Change Get Set functions to be `inlined`
* Merge Sequential Checks
* Clarify precedence with brackets
