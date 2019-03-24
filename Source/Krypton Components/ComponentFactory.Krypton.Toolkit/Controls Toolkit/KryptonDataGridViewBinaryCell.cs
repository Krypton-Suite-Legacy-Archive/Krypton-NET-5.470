﻿// *****************************************************************************
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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Displays viewable binary information in a KryptonDataGridView control.
    /// </summary>
    public class KryptonDataGridViewBinaryCell : DataGridViewTextBoxCell
    {
        #region Instance Fields
        private static Type defaultValueType = typeof(object);
        private Type _editorType;
        #endregion

        #region Identity

        /// <summary>
        /// Returns a standard textual representation of the cell.
        /// </summary>
        public override string ToString()
        {
            return "KryptonDataGridViewBinaryCell { ColumnIndex=" + ColumnIndex.ToString(CultureInfo.CurrentCulture) +
                   ", RowIndex=" + RowIndex.ToString(CultureInfo.CurrentCulture) + " }";
        }

        /// <summary>
        /// Creates an exact copy of this cell.
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            KryptonDataGridViewBinaryCell cloned = base.Clone() as KryptonDataGridViewBinaryCell;
            cloned._editorType = _editorType;
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
        /// Define the type of the cell's editing control
        /// </summary>
        public override Type EditType => null;

        /// <summary>
        /// Returns the type of the cell's Value property
        /// </summary>
        public override Type ValueType
        {
            get
            {
                Type valueType = base.ValueType;

                if (valueType != null)
                {
                    return valueType;
                }

                return defaultValueType;
            }
        }

        /// <summary>
        /// Gets or sets the type of the editor-widget to use. If this is null, the default editor will be used-
        /// </summary>
        public Type EditorType
        {
            get => _editorType;
            set
            {
                if (_editorType != value)
                {
                    if (value != null && !value.IsSubclassOf(typeof(Form)))
                    {
                        throw new InvalidOperationException(
                            "The assigned type must inherit from System.Windows.Forms.Form");
                    }

                    SetEditorType(RowIndex, value);
                    OnCommonChange();
                }
            }
        }


        #endregion

        #region Protected Override
        /// <summary>
        /// Customized implementation of the GetFormattedValue function in order to include  the decimal and thousand separator 
        /// characters in the formatted representation of the cell value.
        /// </summary>
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle,
            TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter,
            DataGridViewDataErrorContexts context)
        {
            if (value is byte[] bytes)
            {
                byte[] firstBytes = new byte[128];
                int count = Math.Min(bytes.Length, firstBytes.Length);
                Array.Copy(bytes, firstBytes, count);
                string strval = BitConverter.ToString(firstBytes, 0, count).Replace("-", " ");
                return Regex.Replace(strval, "(.{23})", "$1" + Environment.NewLine);
            }
            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter,
                formattedValueTypeConverter, context);
        }

        /// <summary>
        /// Called when the cell is clicked.
        /// </summary>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            base.OnClick(e);
            Form editor;
            // If the user has provided a custom editor type, use that instead of the default
            // form.
            if (_editorType != null)
            {
                editor = Activator.CreateInstance(_editorType) as Form;
            }
            else
            {
                editor = new ByteViewerForm();
            }
            // We re-use the Tag property as input/output mechanism, so we don't have to create
            // a new interface just for that. Kind of a hack, I know.
            editor.Tag = Value;
            if (editor.ShowDialog(DataGridView) == DialogResult.OK)
            {
                object result = editor.Tag;
                Value = result;
            }
        }
        #endregion

        #region Private


        private void OnCommonChange()
        {
            if (DataGridView != null && !DataGridView.IsDisposed && !DataGridView.Disposing)
            {
                if (RowIndex == -1)
                {
                    DataGridView.InvalidateColumn(ColumnIndex);
                }
                else
                {
                    DataGridView.UpdateCellValue(ColumnIndex, RowIndex);
                }
            }
        }
        #endregion

        #region Internal

        internal void SetEditorType(int rowIndex, Type editorType)
        {
            _editorType = editorType;
        }
        #endregion
    }
}