﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.470)
//  Version 5.470.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
// ReSharper disable MemberCanBeInternal
// ReSharper disable EventNeverSubscribedTo.Global

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Hosts a collection of KryptonDataGridViewTextBoxCell cells.
    /// </summary>
    [Designer(typeof(KryptonTextBoxColumnDesigner))]
    [ToolboxBitmap(typeof(KryptonDataGridViewTextBoxColumn), "ToolboxBitmaps.KryptonTextBox.bmp")]
    public class KryptonDataGridViewTextBoxColumn : DataGridViewColumn
    {
        #region Instance Fields

        #endregion

        #region Events
        /// <summary>
        /// Occurs when the user clicks a button spec.
        /// </summary>
        public event EventHandler<DataGridViewButtonSpecClickEventArgs> ButtonSpecClick;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonDataGridViewTextBoxColumn class.
        /// </summary>
        public KryptonDataGridViewTextBoxColumn()
            : base(new KryptonDataGridViewTextBoxCell())
        {
            ButtonSpecs = new DataGridViewColumnSpecCollection(this);
            SortMode = DataGridViewColumnSortMode.Automatic;
        }

        /// <summary>
        /// Returns a String that represents the current Object.
        /// </summary>
        /// <returns>A String that represents the current Object.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(0x40);
            builder.Append("KryptonDataGridViewTextBoxColumn { Name=");
            // ReSharper disable RedundantBaseQualifier
            builder.Append(base.Name);
            builder.Append(", Index=");
            builder.Append(base.Index.ToString(CultureInfo.CurrentCulture));
            // ReSharper restore RedundantBaseQualifier
            builder.Append(" }");
            return builder.ToString();
        }

        /// <summary>
        /// Create a cloned copy of the column.
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            KryptonDataGridViewTextBoxColumn cloned = base.Clone() as KryptonDataGridViewTextBoxColumn;

            // Move the button specs over to the new clone
            foreach (ButtonSpec bs in ButtonSpecs)
            {
                cloned.ButtonSpecs.Add(bs.Clone());
            }

            return cloned;
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
        /// Gets or sets the maximum number of characters that can be entered into the text box.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(typeof(int), "32767")]
        public int MaxInputLength
        {
            get
            {
                if (TextBoxCellTemplate == null)
                {
                    throw new InvalidOperationException("KryptonDataGridViewTextBoxColumn cell template required");
                }

                return TextBoxCellTemplate.MaxInputLength;
            }

            set
            {
                if (MaxInputLength != value)
                {
                    TextBoxCellTemplate.MaxInputLength = value;
                    if (DataGridView != null)
                    {
                        DataGridViewRowCollection rows = DataGridView.Rows;
                        int count = rows.Count;
                        for (int i = 0; i < count; i++)
                        {
                            if (rows.SharedRow(i).Cells[Index] is DataGridViewTextBoxCell cell)
                            {
                                cell.MaxInputLength = value;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the sort mode for the column.
        /// </summary>
        [DefaultValue(typeof(DataGridViewColumnSortMode), "Automatic")]
        public new DataGridViewColumnSortMode SortMode
        {
            get => base.SortMode;
            set => base.SortMode = value;
        }

        /// <summary>
        /// Gets or sets the template used to model cell appearance.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;

            set
            {
                if ((value != null) && !(value is KryptonDataGridViewTextBoxCell))
                {
                    throw new InvalidCastException("Can only assign a object of type KryptonDataGridViewTextBoxCell");
                }

                base.CellTemplate = value;
            }
        }

        /// <summary>
        /// Gets the collection of the button specifications.
        /// </summary>
        [Category("Data")]
        [Description("Set of extra button specs to appear with control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataGridViewColumnSpecCollection ButtonSpecs { get; }

        #endregion

        #region Private
        private KryptonDataGridViewTextBoxCell TextBoxCellTemplate => (KryptonDataGridViewTextBoxCell)CellTemplate;

        #endregion

        #region Internal
        internal void PerfomButtonSpecClick(DataGridViewButtonSpecClickEventArgs args)
        {
            ButtonSpecClick?.Invoke(this, args);
        }
        #endregion
    }
}