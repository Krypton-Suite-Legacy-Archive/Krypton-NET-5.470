// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *************************************************************************

using System;
using System.Diagnostics;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonExplorer
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            kryptonNavigator.SelectedIndex = 0;
            kryptonNavigatorToolkit.SelectedIndex = 0;
        }

        private void linkKryptonBorderEdge_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Border Edge Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Button Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonCheckBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton CheckBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonCheckButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton CheckButton Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonDropButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton DropButton Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonColorButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton ColorButton Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonCheckSet_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton CheckSet Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonContextMenu_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Context Menu Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonDataGridView_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Data GridView Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonForm_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Form Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonGroup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Group Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonGroupBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton GroupBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonHeader_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Header Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonHeaderGroup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Header Group Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Label Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonWrapLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Wrap Label Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonCommand_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Command Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Link Label Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonListBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton ListBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonCheckedListBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Checked ListBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonMaskedTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Masked TextBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonPalette_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Palette Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonPanel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Panel Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonSeparator_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Separator Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonRadioButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton RadioButton Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptobTrackBar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton TrackBar Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonSplitContainer_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Split Container Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonComboBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton ComboBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton TextBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonRichTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Rich TextBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonNumericUpDown_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Numeric UpDown Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonDomainUpDown_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Domain UpDown Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonBreadCrumb_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Bread Crumb Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonDateTimePicker_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton DateTimePicker Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonMonthCalendar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Month Calendar Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonInputBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton InputBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonMessageBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton MessageBox Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonTaskDialog_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton TaskDialog Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonTreeView_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton TreeView Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkInputForm_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Input Form.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkThreePaneApplicationBasic_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Three Pane Application Basic.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkThreePaneApplicationExtended_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Three Pane Application Extended.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkMDIApplication_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MDI Application.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkCustomControlUsingPalettes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Custom Control Using Palettes.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkCustomControlUsingRenderers_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Custom Control Using Renderers.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkExpandingSplitters_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Expanding Header Groups Splitters Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkExpandingDockStyle_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Expanding Header Groups DockStyle Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkExpandingHeaderStack_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Expanding Header Groups Stack Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkChildControlStack_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Child Control Stack.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkLabelButtonSpecPlayground_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Button Spec Playground.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorModes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator Modes.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorPalettes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator Palettes.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkOrientationAndAlignment_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Orientation Plus Alignment.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkSinglelineAndMultiline_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Singleline Plus Multiline.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkTabBorderStyles_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Tab Border Styles.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorPopupPages_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Popup Pages.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorPerTabButtons_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Per Tab Buttons.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorTooltips_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator Tool Tips.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorContextMenus_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator Context Menus.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorPlayground_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator Playground.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkContextualTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Contextual Tabs.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKeyTipsTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Key Tips And Keyboard Access.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void labelAutoShrinkingGroups_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Auto Shrinking Groups.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void labelQuickAccessToolbar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Quick Access Toolbar.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkRibbonGallery_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Ribbon Gallery.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkRibbonToolTips_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Ribbon Tool Tips.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkRibbonControls_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Ribbon Controls.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkKryptonGallery_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Krypton Gallery Examples.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkApplicationMenu_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Application Menu.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkOutlookMailClone_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Outlook Mail Clone.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkRibbonAndNavigator_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Ribbon And Navigator And Workspace.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkMDIRibbon_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MDI Ribbon.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkExpandingPages_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Expanding Pages.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorBasicEvents_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Basic Events.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorUserPageCreation_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\User Page Creation.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorOneNoteTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\OneNote Tabs.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkNavigatorOutlookMockup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Outlook Mockup.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkWorkspaceCellModes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Workspace Cell Modes.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkWorkspaceCellLayout_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Workspace Cell Layout.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkWorkspacePersistence_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\WorkspacePersistence.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkCellMaximizeAndRestore_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Cell Maximize And Restore.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkBasicPageDragAndDrop_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Basic Page Drag And Drop.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkAdvancedPageDragAndDrop_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Advanced Page Drag And Drop.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void memoEditor_Clicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Memo Editor.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkStandardDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Standard Docking.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkMultiControlDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Multi Control Docking.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkExternalDragToDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\External Drag To Docking.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void linkNavigatorAndFloatingWindows_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Navigator And Floating Windows.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkDockingPersistence_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Docking Persistence.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkDockingFlags_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Docking Flags.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkDockingCustomized_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Docking Customized.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkPaletteDesigner_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Palette Designer.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void linkPaletteUpgradeTool_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\Palette Upgrade Tool.exe"); }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, ex.Message, @"Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void kryptonButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
