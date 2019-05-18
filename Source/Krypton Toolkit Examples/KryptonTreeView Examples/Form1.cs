// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ComponentFactory.Krypton.Toolkit;

namespace KryptonTreeViewExamples
{
    public partial class Form1 : KryptonForm
    {
        private int _next = 1;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kryptonTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kryptonTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonInsert_Click(null, EventArgs.Empty);
            kryptonTreeView.SelectedNode = null;
            buttonAppend_Click(null, EventArgs.Empty);
            buttonAppend_Click(null, EventArgs.Empty);
        }

        private KryptonTreeNode CreateNewItem()
        {
            KryptonTreeNode item = new KryptonTreeNode
            {
                Text = $"Item {(_next++)}",
                ImageIndex = _rand.Next(imageList.Images.Count - 1)
            };
            item.SelectedImageIndex = item.ImageIndex;
            return item;
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            TreeNode node = CreateNewItem();
            kryptonTreeView.Nodes.Add(node);

            // If nothing currently selected, then select the new one
            if (kryptonTreeView.SelectedNode == null)
            {
                kryptonTreeView.SelectedNode = node;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Can only insert if something is already selected
            if (kryptonTreeView.SelectedNode != null)
            {
                kryptonTreeView.SelectedNode.Nodes.Add(CreateNewItem());
                kryptonTreeView.SelectedNode.Expand();
            }
            else
            {
                buttonAppend_Click(null, EventArgs.Empty);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Can only remove if something is selected
            if (kryptonTreeView.SelectedNode != null)
            {
                if (kryptonTreeView.SelectedNode.Parent != null)
                {
                    kryptonTreeView.SelectedNode.Parent.Nodes.Remove(kryptonTreeView.SelectedNode);
                }
                else
                {
                    kryptonTreeView.Nodes.Remove(kryptonTreeView.SelectedNode);
                }
            }
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            kryptonTreeView.Nodes.Clear();
        }

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (kryptonCheckSet.CheckedButton == check2007Blue)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
            else if (kryptonCheckSet.CheckedButton == check2010Blue)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (kryptonCheckSet.CheckedButton == checkSparkle)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            else if (kryptonCheckSet.CheckedButton == checkSystem)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnToggleNodeCheckBox_Click(object sender, EventArgs e)
        {
            if (kryptonTreeView.SelectedNode is KryptonTreeNode kryptonNode)
            {
                kryptonNode.IsCheckBoxVisible = !kryptonNode.IsCheckBoxVisible;
            }
        }

        private void KryptonTreeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (kryptonTreeView.SelectedNode is KryptonTreeNode kryptonNode)
            {
                // If the CheckBox is hidden then prevent the checking change event
                e.Cancel = !kryptonNode.IsCheckBoxVisible;
            }
        }
    }
}
