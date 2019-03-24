// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Megakraken & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Displays editable text information in a KryptonDataGridView control.
    /// </summary>
    public class KryptonDataGridViewCustomCell : DataGridViewTextBoxCell
    {
        #region Static Fields
        [ThreadStatic]
        private static KryptonTextBox _paintingTextBox;
        private static readonly Type _defaultEditType = typeof(KryptonDataGridViewCustomEditingControl);
        private static readonly Type _defaultValueType = typeof(System.String);
        private static readonly Size _sizeLarge = new Size(10000, 10000);
        #endregion

        #region Identity
        /// <summary>
        /// Constructor for the KryptonDataGridViewCustomCell cell type
        /// </summary>
        public KryptonDataGridViewCustomCell()
        {
            // Create a thread specific KryptonTextBox control used for the painting of the non-edited cells
            if (_paintingTextBox == null)
            {
                _paintingTextBox = new KryptonTextBox();
                _paintingTextBox.StateCommon.Border.Width = 0;
                _paintingTextBox.StateCommon.Border.Draw = InheritBool.False;
                _paintingTextBox.StateCommon.Back.Color1 = Color.Empty;
            }
        }

        /// <summary>
        /// Returns a standard textual representation of the cell.
        /// </summary>
        public override string ToString()
        {
            return "KryptonDataGridViewCustomCell { ColumnIndex=" + ColumnIndex.ToString(CultureInfo.CurrentCulture) +
                   ", RowIndex=" + RowIndex.ToString(CultureInfo.CurrentCulture) + " }";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public
        /// <summary>
        /// Define the type of the cell's editing control
        /// </summary>
        public override Type EditType
        {
            get { return _defaultEditType; }
        }

        /// <summary>
        /// Returns the type of the cell's Value property
        /// </summary>
        public override Type ValueType
        {
            get
            {
                Type valueType = base.ValueType;

                if (valueType != null)
                    return valueType;

                return _defaultValueType;
            }
        }

        /// <summary>
        /// DetachEditingControl gets called by the DataGridView control when the editing session is ending
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public override void DetachEditingControl()
        {
            DataGridView dataGridView = DataGridView;
            if (dataGridView == null || dataGridView.EditingControl == null)
                throw new InvalidOperationException("Cell is detached or its grid has no editing control.");

            KryptonTextBox kryptonTextBox = dataGridView.EditingControl as KryptonTextBox;
            if (kryptonTextBox != null)
            {
                KryptonDataGridViewCustomColumn customColumn = OwningColumn as KryptonDataGridViewCustomColumn;
                if (customColumn != null)
                {
                    foreach (ButtonSpec bs in kryptonTextBox.ButtonSpecs)
                        bs.Click -= new EventHandler(OnButtonClick);

                    //kryptonTextBox.ButtonSpecs.Clear();

                    TextBox textBox = kryptonTextBox.Controls[0] as TextBox;
                    if (textBox != null)
                        textBox.ClearUndo();
                }
            }

            base.DetachEditingControl();
        }

        /// <summary>
        /// Custom implementation of the InitializeEditingControl function. This function is called by the DataGridView control 
        /// at the beginning of an editing session. It makes sure that the properties of the KryptonTextBox editing control are 
        /// set according to the cell properties.
        /// </summary>
        public override void InitializeEditingControl(int rowIndex,
            object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            KryptonTextBox textBox = DataGridView.EditingControl as KryptonTextBox;
            if (textBox != null)
            {
                string initialFormattedValueStr = initialFormattedValue as string;
                if (initialFormattedValueStr == null)
                    textBox.Text = string.Empty;
                else
                    textBox.Text = initialFormattedValueStr;

                DataGridViewTriState wrapMode = this.Style.WrapMode;
                if (wrapMode == DataGridViewTriState.NotSet)
                    wrapMode = this.OwningColumn.DefaultCellStyle.WrapMode;

                textBox.WordWrap = textBox.Multiline = (wrapMode == DataGridViewTriState.True);

                KryptonDataGridViewCustomColumn customColumn = OwningColumn as KryptonDataGridViewCustomColumn;
                if (customColumn != null)
                {
                    // Set this cell as the owner of the buttonspecs
                    //textBox.ButtonSpecs.Clear();
                    //textBox.ButtonSpecs.Owner = DataGridView.Rows[rowIndex].Cells[ColumnIndex];
                    //foreach (ButtonSpec bs in textBoxColumn.ButtonSpecs) {
                    //    bs.Click += new EventHandler(OnButtonClick);
                    //    textBox.ButtonSpecs.Add(bs);
                    //}
                }
            }
        }

        /// <summary>
        /// Custom implementation of the PositionEditingControl method called by the DataGridView control when it
        /// needs to relocate and/or resize the editing control.
        /// </summary>
        public override void PositionEditingControl(bool setLocation,
            bool setSize,
            Rectangle cellBounds,
            Rectangle cellClip,
            DataGridViewCellStyle cellStyle,
            bool singleVerticalBorderAdded,
            bool singleHorizontalBorderAdded,
            bool isFirstDisplayedColumn,
            bool isFirstDisplayedRow)
        {
            Rectangle editingControlBounds = PositionEditingPanel(cellBounds, cellClip, cellStyle,
                singleVerticalBorderAdded, singleHorizontalBorderAdded,
                isFirstDisplayedColumn, isFirstDisplayedRow);

            editingControlBounds = GetAdjustedEditingControlBounds(editingControlBounds, cellStyle);
            DataGridView.EditingControl.Location = new Point(editingControlBounds.X, editingControlBounds.Y);
            DataGridView.EditingControl.Size = new Size(editingControlBounds.Width, editingControlBounds.Height);
        }
        #endregion

        #region Protected
        /// <summary>
        /// Customized implementation of the GetErrorIconBounds function in order to draw the potential 
        /// error icon next to the up/down buttons and not on top of them.
        /// </summary>
        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex)
        {
            const int ButtonsWidth = 16;

            Rectangle errorIconBounds = base.GetErrorIconBounds(graphics, cellStyle, rowIndex);
            if (DataGridView.RightToLeft == RightToLeft.Yes)
                errorIconBounds.X = errorIconBounds.Left + ButtonsWidth;
            else
                errorIconBounds.X = errorIconBounds.Left - ButtonsWidth;

            return errorIconBounds;
        }

        /// <summary>
        /// Custom implementation of the GetPreferredSize function.
        /// </summary>
        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize)
        {
            if (DataGridView == null)
                return new Size(-1, -1);

            Size preferredSize = base.GetPreferredSize(graphics, cellStyle, rowIndex, constraintSize);
            if (constraintSize.Width == 0)
            {
                const int ButtonsWidth = 16; // Account for the width of the up/down buttons.
                const int ButtonMargin = 8;  // Account for some blank pixels between the text and buttons.
                preferredSize.Width += ButtonsWidth + ButtonMargin;
            }

            return preferredSize;
        }
        #endregion

        #region Private
        private void OnButtonClick(object sender, EventArgs e)
        {
            KryptonDataGridViewCustomColumn customColumn = OwningColumn as KryptonDataGridViewCustomColumn;
            DataGridViewButtonSpecClickEventArgs args = new DataGridViewButtonSpecClickEventArgs(customColumn, this, (ButtonSpecAny)sender);
            customColumn.PerfomButtonSpecClick(args);
        }

        private KryptonDataGridViewCustomEditingControl EditingTextBox
        {
            get { return DataGridView.EditingControl as KryptonDataGridViewCustomEditingControl; }
        }

        private Rectangle GetAdjustedEditingControlBounds(Rectangle editingControlBounds,
            DataGridViewCellStyle cellStyle)
        {
            // Adjust the vertical location of the editing control:
            int preferredHeight = DataGridView.EditingControl.GetPreferredSize(new Size(editingControlBounds.Width, 10000)).Height;
            if (preferredHeight < editingControlBounds.Height)
            {
                switch (cellStyle.Alignment)
                {
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.MiddleRight:
                        editingControlBounds.Y += (editingControlBounds.Height - preferredHeight) / 2;
                        break;
                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.BottomRight:
                        editingControlBounds.Y += editingControlBounds.Height - preferredHeight;
                        break;
                }
            }

            return editingControlBounds;
        }

        private void OnCommonChange()
        {
            if (DataGridView != null && !DataGridView.IsDisposed && !DataGridView.Disposing)
            {
                if (RowIndex == -1)
                    DataGridView.InvalidateColumn(ColumnIndex);
                else
                    DataGridView.UpdateCellValue(ColumnIndex, RowIndex);
            }
        }

        private bool OwnsEditingTextBox(int rowIndex)
        {
            if (rowIndex == -1 || DataGridView == null)
                return false;

            KryptonDataGridViewCustomEditingControl control = DataGridView.EditingControl as KryptonDataGridViewCustomEditingControl;
            return (control != null) && (rowIndex == ((IDataGridViewEditingControl)control).EditingControlRowIndex);
        }

        private static bool PartPainted(DataGridViewPaintParts paintParts, DataGridViewPaintParts paintPart)
        {
            return (paintParts & paintPart) != 0;
        }
        #endregion
    }
}