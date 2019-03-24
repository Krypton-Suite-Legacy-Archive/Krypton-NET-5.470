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
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Displays byte arrays in hexadecimal, ANSI, and Unicode formats.
    /// </summary>
    /// <remarks>
    /// This is based off <see cref="System.ComponentModel.Design.ByteViewer"/> with a couple
    /// of cosmetic changes to make it look at least a little less Win3.11-ish.
    /// </remarks>
    [ToolboxItem(false)]
    [DesignTimeVisible(false)]
    public class KryptonByteViewer : TableLayoutPanel
    {
        #region Private Classes
        /// <summary>
        /// VScrollBar is a simple wrapper for the ancient WINAPI scrollbar from the early
        /// 90s which has the annoying property of blinking like a cursor when selected. I don't
        /// know why they thought this was a good idea because it looks ridiculous and there is
        /// not even a way to turn it off, so we need to work around it as so often with WinForms.
        /// </summary>
        class VScrollBarEx : VScrollBar
        {
            public void _OnMouseWheel(MouseEventArgs e)
            {
                base.OnMouseWheel(e);
            }

            public void _OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
            }
        }
        #endregion

        #region Private Constants
        private const int DEFAULT_COLUMN_COUNT = 16;
        private const int DEFAULT_ROW_COUNT = 25;
        private const int COLUMN_COUNT = 16;
        private const int BORDER_GAP = 2;
        private const int INSET_GAP = 3;
        private const int CELL_HEIGHT = 21;
        private const int CELL_WIDTH = 25;
        private const int CHAR_WIDTH = 8;
        private const int ADDRESS_WIDTH = 69;
        private const int HEX_WIDTH = 400;
        private const int DUMP_WIDTH = 128;
        private const int HEX_DUMP_GAP = 5;
        private const int ADDRESS_START_X = 5;
        private const int CLIENT_START_Y = 5;
        private const int LINE_START_Y = 7;
        private const int HEX_START_X = 74;
        private const int DUMP_START_X = 479;
        private const int SCROLLBAR_START_X = 612;
        #endregion

        #region Static Fields
        private static readonly Font ADDRESS_FONT = new Font("Microsoft Sans Serif", 8f);
        private static readonly Font HEXDUMP_FONT = new Font("Consolas", 9.75f);
        #endregion

        #region Instance Fields
        private readonly int SCROLLBAR_HEIGHT = SystemInformation.HorizontalScrollBarHeight;
        private readonly int SCROLLBAR_WIDTH = SystemInformation.VerticalScrollBarWidth;

        private VScrollBarEx scrollBar;
        private TextBox edit;
        private int columnCount = 16;
        private int rowCount = 25;
        private byte[] dataBuf;
        private int startLine;
        private int displayLinesCount;
        private int linesCount;
        private DisplayMode displayMode;
        private DisplayMode realDisplayMode;
        #endregion

        #region Identity
        /// <summary>
        /// Initializes a new instance of the ByteViewer class.
        /// </summary>
        public KryptonByteViewer()
        {
            SuspendLayout();
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            ColumnCount = 1;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            InitUI();
            ResumeLayout();
            displayMode = DisplayMode.Hexdump;
            realDisplayMode = DisplayMode.Hexdump;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, value: true);
            SetBytes(new byte[] { });
        }
        #endregion

        #region Private
        private static int AnalizeByteOrderMark(byte[] buffer, int index)
        {
            int c = (buffer[index + 0] << 8) | buffer[index + 1];
            int c2 = (buffer[index + 2] << 8) | buffer[index + 3];
            int encodingIndex = GetEncodingIndex(c);
            int encodingIndex2 = GetEncodingIndex(c2);
            int[,] array = new int[13, 13]
            {
            {
                1,
                5,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                1,
                1,
                11,
                1,
                10,
                4,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                2,
                9,
                5,
                2,
                2,
                2,
                2,
                2,
                2,
                2,
                2,
                2,
                2
            },
            {
                3,
                7,
                3,
                7,
                3,
                3,
                3,
                3,
                3,
                3,
                3,
                3,
                3
            },
            {
                14,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                6,
                1,
                1,
                1,
                1,
                1,
                3,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                8,
                1,
                1,
                1,
                1,
                1,
                1,
                2,
                1,
                1,
                1,
                1
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                13,
                1,
                1
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                12
            },
            {
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1
            }
            };
            return array[encodingIndex, encodingIndex2];
        }

        private int CellToIndex(int column, int row)
        {
            return row * columnCount + column;
        }

        private byte[] ComposeLineBuffer(int startLine, int line)
        {
            int num = startLine * columnCount;
            byte[] array = (num + (line + 1) * columnCount <= dataBuf.Length) ? new byte[columnCount] : new byte[dataBuf.Length % columnCount];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = dataBuf[num + CellToIndex(i, line)];
            }
            return array;
        }

        private void DrawAddress(Graphics g, int startLine, int line)
        {
            string s = ((startLine + line) * columnCount).ToString("X8", CultureInfo.InvariantCulture);
            Brush brush = new SolidBrush(ForeColor);
            try
            {
                g.DrawString(s, ADDRESS_FONT, brush, 5f, 7 + line * 21);
            }
            finally
            {
                brush?.Dispose();
            }
        }

        private void DrawClient(Graphics g)
        {
            using (Brush brush = new SolidBrush(SystemColors.ControlLightLight))
            {
                g.FillRectangle(brush, new Rectangle(74, 5, 538, rowCount * 21));
            }
            using (Pen pen = new Pen(SystemColors.ControlDark))
            {
                g.DrawRectangle(pen, new Rectangle(74, 5, 537, rowCount * 21 - 1));
                g.DrawLine(pen, 474, 5, 474, 5 + rowCount * 21 - 1);
            }
        }

        private static bool CharIsPrintable(char c)
        {
            UnicodeCategory unicodeCategory = char.GetUnicodeCategory(c);
            switch (unicodeCategory)
            {
                case UnicodeCategory.Control:
                    return unicodeCategory == UnicodeCategory.OtherNotAssigned;
                default:
                    return true;
            }
        }

        private void DrawDump(Graphics g, byte[] lineBuffer, int line)
        {
            StringBuilder stringBuilder = new StringBuilder(lineBuffer.Length);
            for (int i = 0; i < lineBuffer.Length; i++)
            {
                char c = Convert.ToChar(lineBuffer[i]);
                if (CharIsPrintable(c))
                {
                    stringBuilder.Append(c);
                }
                else
                {
                    stringBuilder.Append('.');
                }
            }
            Brush brush = new SolidBrush(ForeColor);
            try
            {
                g.DrawString(stringBuilder.ToString(), HEXDUMP_FONT, brush, 479f, 7 + line * 21);
            }
            finally
            {
                brush?.Dispose();
            }
        }

        private void DrawHex(Graphics g, byte[] lineBuffer, int line)
        {
            StringBuilder stringBuilder = new StringBuilder(lineBuffer.Length * 3 + 1);
            for (int i = 0; i < lineBuffer.Length; i++)
            {
                stringBuilder.Append(lineBuffer[i].ToString("X2", CultureInfo.InvariantCulture));
                stringBuilder.Append(" ");
                if (i == columnCount / 2 - 1)
                {
                    stringBuilder.Append(" ");
                }
            }

            Brush brush = new SolidBrush(ForeColor);
            try
            {
                g.DrawString(stringBuilder.ToString(), HEXDUMP_FONT, brush, 76f, 7 + line * 21);
            }
            finally
            {
                brush?.Dispose();
            }
        }

        private void DrawLines(Graphics g, int startLine, int linesCount)
        {
            for (int i = 0; i < linesCount; i++)
            {
                byte[] lineBuffer = ComposeLineBuffer(startLine, i);
                DrawAddress(g, startLine, i);
                DrawHex(g, lineBuffer, i);
                DrawDump(g, lineBuffer, i);
            }
        }

        private DisplayMode GetAutoDisplayMode()
        {
            int num = 0;
            int num2 = 0;
            if (dataBuf != null && (dataBuf.Length < 0 || dataBuf.Length >= 8))
            {
                switch (AnalizeByteOrderMark(dataBuf, 0))
                {
                    case 2:
                        return DisplayMode.Hexdump;
                    case 3:
                        return DisplayMode.Unicode;
                    case 4:
                    case 5:
                        return DisplayMode.Hexdump;
                    case 6:
                    case 7:
                        return DisplayMode.Hexdump;
                    case 8:
                    case 9:
                        return DisplayMode.Hexdump;
                    case 10:
                    case 11:
                        return DisplayMode.Hexdump;
                    case 12:
                        return DisplayMode.Hexdump;
                    case 13:
                        return DisplayMode.Ansi;
                    case 14:
                        return DisplayMode.Ansi;
                    default:
                        {
                            int num3 = (dataBuf.Length <= 1024) ? (dataBuf.Length / 2) : 512;
                            for (int i = 0; i < num3; i++)
                            {
                                char c = (char)dataBuf[i];
                                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                                {
                                    num++;
                                }
                            }
                            for (int j = 0; j < num3; j += 2)
                            {
                                char[] array = new char[1];
                                Encoding.Unicode.GetChars(dataBuf, j, 2, array, 0);
                                if (CharIsPrintable(array[0]))
                                {
                                    num2++;
                                }
                            }
                            if (num2 * 100 / (num3 / 2) > 80)
                            {
                                return DisplayMode.Unicode;
                            }
                            if (num * 100 / num3 > 80)
                            {
                                return DisplayMode.Ansi;
                            }
                            return DisplayMode.Hexdump;
                        }
                }
            }
            return DisplayMode.Hexdump;
        }

        private static int GetEncodingIndex(int c1)
        {
            switch (c1)
            {
                case 0:
                    return 1;
                case 65279:
                    return 2;
                case 65534:
                    return 3;
                case 61371:
                    return 4;
                case 15360:
                    return 5;
                case 60:
                    return 6;
                case 16128:
                    return 7;
                case 63:
                    return 8;
                case 15423:
                    return 9;
                case 30829:
                    return 10;
                case 19567:
                    return 11;
                case 42900:
                    return 12;
                default:
                    return 0;
            }
        }

        private void InitAnsi()
        {
            int num = dataBuf.Length;
            char[] array = new char[num + 1];
            num = MultiByteToWideChar(0, 0, dataBuf, num, array, num);
            array[num] = '\0';
            for (int i = 0; i < num; i++)
            {
                if (array[i] == '\0')
                {
                    array[i] = '\v';
                }
            }
            edit.Text = new string(array);
        }

        private void InitUnicode()
        {
            char[] array = new char[dataBuf.Length / 2 + 1];
            Encoding.Unicode.GetChars(dataBuf, 0, dataBuf.Length, array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '\0')
                {
                    array[i] = '\v';
                }
            }
            array[array.Length - 1] = '\0';
            edit.Text = new string(array);
        }

        private void InitUI()
        {
            Size = new Size(612 + SCROLLBAR_WIDTH + 2 + 3, 10 + rowCount * 21);
            scrollBar = new VScrollBarEx();
            scrollBar.ValueChanged += ScrollChanged;
            scrollBar.TabStop = false;
            scrollBar.Dock = DockStyle.Right;
            scrollBar.Visible = false;
            edit = new TextBox()
            {
                AutoSize = false,
                BorderStyle = BorderStyle.None,
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Both,
                AcceptsTab = true,
                AcceptsReturn = true,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                WordWrap = true,
                Visible = false,
                Font = HEXDUMP_FONT
            };
            Controls.Add(scrollBar, 0, 0);
            Controls.Add(edit, 0, 0);
        }

        private void InitState()
        {
            linesCount = (dataBuf.Length + columnCount - 1) / columnCount;
            startLine = 0;
            if (linesCount > rowCount)
            {
                displayLinesCount = rowCount;
                scrollBar.Hide();
                scrollBar.Maximum = linesCount - 1;
                scrollBar.LargeChange = rowCount;
                scrollBar.Show();
                scrollBar.Enabled = true;
            }
            else
            {
                displayLinesCount = linesCount;
                scrollBar.Hide();
                scrollBar.Maximum = rowCount;
                scrollBar.LargeChange = rowCount;
                scrollBar.Show();
                scrollBar.Enabled = false;
            }
            //            scrollBar.Select();
            // Select the panel instead so we can forward its Key and Mousewheel events
            // to the scrollbar.
            Select();
            Invalidate();
        }

        private static bool IsEnumValid(Enum enumValue, int value, int minValue, int maxValue)
        {
            return value >= minValue && value <= maxValue;
        }
        #endregion

        #region Protected Overrides
        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.
        /// </param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            //         scrollBar.Select();
            if (scrollBar.Enabled)
                scrollBar._OnKeyDown(e);
        }

        /// <summary>
        /// Raises the MouseWheel event.
        /// </summary>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (scrollBar.Enabled)
                scrollBar._OnMouseWheel(e);
        }

        /// <summary>
        /// Paints the background of the panel.
        /// </summary>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var palette = KryptonManager.CurrentGlobalPalette;
            if (palette == null)
                return;
            // We use the background color of KryptonPanels.
            var backColor = palette.GetBackColor1(PaletteBackStyle.PanelClient,
                PaletteState.Normal);
            using (var backBrush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(backBrush, e.ClipRectangle);
        }

        /// <param name="e">
        /// A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.
        /// </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            switch (realDisplayMode)
            {
                case DisplayMode.Hexdump:
                    SuspendLayout();
                    edit.Hide();
                    scrollBar.Show();
                    ResumeLayout();
                    DrawClient(graphics);
                    DrawLines(graphics, startLine, displayLinesCount);
                    break;
                case DisplayMode.Ansi:
                    edit.Invalidate();
                    break;
                case DisplayMode.Unicode:
                    edit.Invalidate();
                    break;
            }
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            int num = (ClientSize.Height - 10) / 21;
            if (num >= 0 && num != rowCount)
            {
                rowCount = num;
                if (Dock == DockStyle.None)
                {
                    Size = new Size(612 + SCROLLBAR_WIDTH + 2 + 3, 10 + rowCount * 21);
                }
                if (scrollBar != null)
                {
                    if (linesCount > rowCount)
                    {
                        scrollBar.Hide();
                        scrollBar.Maximum = linesCount - 1;
                        scrollBar.LargeChange = rowCount;
                        scrollBar.Show();
                        scrollBar.Enabled = true;
                        //             scrollBar.Select();
                        Select();
                    }
                    else
                    {
                        scrollBar.Enabled = false;
                    }
                }
                displayLinesCount = ((startLine + rowCount < linesCount) ? rowCount : (linesCount - startLine));
            }
        }
        #endregion

        #region Protected Virtual
        /// <summary>Handles the <see cref="E:System.Windows.Forms.ScrollBar.ValueChanged" /> event on the <see cref="T:System.ComponentModel.Design.ByteViewer" /> control's <see cref="T:System.Windows.Forms.ScrollBar" />.</summary>
        /// <param name="source">The source of the event. </param>
        /// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data. </param>
        protected virtual void ScrollChanged(object source, EventArgs e)
        {
            startLine = scrollBar.Value;
            Invalidate();
        }
        #endregion

        #region Public Virtual
        /// <summary>Gets the bytes in the buffer.</summary>
        /// <returns>The unsigned byte array reference.</returns>
        public virtual byte[] GetBytes()
        {
            return dataBuf;
        }

        /// <summary>Gets the display mode for the control.</summary>
        /// <returns>The display mode that this control uses. The returned value is defined in <see cref="T:System.ComponentModel.Design.DisplayMode" />.</returns>
        public virtual DisplayMode GetDisplayMode()
        {
            return displayMode;
        }

        /// <summary>Writes the raw data from the data buffer to a file.</summary>
        /// <param name="path">The file path to save to. </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="path" /> is null. </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters. </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
        /// <exception cref="T:System.IO.IOException">The file write failed. </exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The access requested is not permitted by the operating system for the specified <paramref name="path" />, such as when access is Write or ReadWrite and the file or directory is set for read-only access. </exception>
        public virtual void SaveToFile(string path)
        {
            if (dataBuf != null)
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                try
                {
                    fileStream.Write(dataBuf, 0, dataBuf.Length);
                    fileStream.Close();
                }
                catch
                {
                    fileStream.Close();
                    throw;
                }
            }
        }

        /// <summary>Sets the byte array to display in the viewer.</summary>
        /// <param name="bytes">The byte array to display. </param>
        /// <exception cref="T:System.ArgumentNullException">The specified byte array is null. </exception>
        public virtual void SetBytes(byte[] bytes)
        {
            if (dataBuf != null)
            {
                dataBuf = null;
            }
            dataBuf = bytes ?? throw new ArgumentNullException("bytes");
            InitState();
            SetDisplayMode(displayMode);
        }

        /// <summary>Sets the current display mode.</summary>
        /// <param name="mode">The display mode to set. </param>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified display mode is not from the <see cref="T:System.ComponentModel.Design.DisplayMode" /> enumeration. </exception>
        public virtual void SetDisplayMode(DisplayMode mode)
        {
            if (!IsEnumValid(mode, (int)mode, 1, 4))
            {
                throw new InvalidEnumArgumentException("mode", (int)mode, typeof(DisplayMode));
            }
            displayMode = mode;
            realDisplayMode = ((mode == DisplayMode.Auto) ? GetAutoDisplayMode() : mode);
            switch (realDisplayMode)
            {
                case DisplayMode.Ansi:
                    InitAnsi();
                    SuspendLayout();
                    edit.Show();
                    scrollBar.Hide();
                    ResumeLayout();
                    Invalidate();
                    break;
                case DisplayMode.Unicode:
                    InitUnicode();
                    SuspendLayout();
                    edit.Show();
                    scrollBar.Hide();
                    ResumeLayout();
                    Invalidate();
                    break;
                case DisplayMode.Hexdump:
                    SuspendLayout();
                    edit.Hide();
                    if (linesCount > rowCount)
                    {
                        if (!scrollBar.Visible)
                        {
                            scrollBar.Show();
                            ResumeLayout();
                            scrollBar.Invalidate();
                            //               scrollBar.Select();
                            Select();

                        }
                        else
                        {
                            ResumeLayout();
                        }
                    }
                    else
                    {
                        ResumeLayout();
                    }
                    break;
            }
        }

        /// <summary>Sets the file to display in the viewer.</summary>
        /// <param name="path">The file path to load from. </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="path" /> is null. </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters. </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
        /// <exception cref="T:System.IO.IOException">The file load failed. </exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The access requested is not permitted by the operating system for the specified <paramref name="path" />, such as when access is Write or ReadWrite and the file or directory is set for read-only access. </exception>
        public virtual void SetFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                int num = (int)fileStream.Length;
                byte[] array = new byte[num + 1];
                fileStream.Read(array, 0, num);
                SetBytes(array);
                fileStream.Close();
            }
            catch
            {
                fileStream.Close();
                throw;
            }
        }

        /// <summary>Sets the current line for the <see cref="F:System.ComponentModel.Design.DisplayMode.Hexdump" /> view.</summary>
        /// <param name="line">The current line to display from. </param>
        public virtual void SetStartLine(int line)
        {
            if (line < 0 || line >= linesCount || line > dataBuf.Length / columnCount)
            {
                startLine = 0;
            }
            else
            {
                startLine = line;
            }
        }
        #endregion

        #region Internal
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int MultiByteToWideChar(int CodePage, int dwFlags, byte[] lpMultiByteStr,
            int cchMultiByte, char[] lpWideCharStr, int cchWideChar);
        #endregion
    }
}