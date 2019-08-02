// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="HatchStyleComboBox.cs" company="Zeroit Dev Technologies">
//    This program is that contains various editors for drawing and painting.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZeroitDevColorPicker.Helpers.Colors.WikiColors
{
    /// <summary>
    ///     Represents a ComboBox control from which the user can select a hatch style.
    /// </summary>
    public class AllWebColorsComboBox : ComboBox
    {

        #region Enums and Structs

        public enum DropBoxStyle
        {
            DropDown,
            DropDownList
        }

        public enum DrawingModes
        {
            Fixed,
            Variable
        }

        /// <summary>
        /// Enum PenStyles
        /// </summary>
        public enum PenStyles
        {
            /// <summary>
            /// The ps solid
            /// </summary>
            PS_SOLID = 0,
            /// <summary>
            /// The ps dash
            /// </summary>
            PS_DASH = 1,
            /// <summary>
            /// The ps dot
            /// </summary>
            PS_DOT = 2,
            /// <summary>
            /// The ps dashdot
            /// </summary>
            PS_DASHDOT = 3,
            /// <summary>
            /// The ps dashdotdot
            /// </summary>
            PS_DASHDOTDOT = 4
        }


        /// <summary>
        /// Struct COMBOBOXINFO
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct COMBOBOXINFO
        {
            /// <summary>
            /// The cb size
            /// </summary>
            public Int32 cbSize;
            /// <summary>
            /// The rc item
            /// </summary>
            public RECT rcItem;
            /// <summary>
            /// The rc button
            /// </summary>
            public RECT rcButton;
            /// <summary>
            /// The button state
            /// </summary>
            public ComboBoxButtonState buttonState;
            /// <summary>
            /// The HWND combo
            /// </summary>
            public IntPtr hwndCombo;
            /// <summary>
            /// The HWND edit
            /// </summary>
            public IntPtr hwndEdit;
            /// <summary>
            /// The HWND list
            /// </summary>
            public IntPtr hwndList;
        }

        /// <summary>
        /// Enum ComboBoxButtonState
        /// </summary>
        public enum ComboBoxButtonState
        {
            /// <summary>
            /// The state system none
            /// </summary>
            STATE_SYSTEM_NONE = 0,
            /// <summary>
            /// The state system invisible
            /// </summary>
            STATE_SYSTEM_INVISIBLE = 0x00008000,
            /// <summary>
            /// The state system pressed
            /// </summary>
            STATE_SYSTEM_PRESSED = 0x00000008
        }

        /// <summary>
        /// Struct RECT
        /// </summary>
        [Serializable, StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            /// <summary>
            /// The left
            /// </summary>
            public int Left;
            /// <summary>
            /// The top
            /// </summary>
            public int Top;
            /// <summary>
            /// The right
            /// </summary>
            public int Right;
            /// <summary>
            /// The bottom
            /// </summary>
            public int Bottom;

            /// <summary>
            /// Initializes a new instance of the <see cref="RECT"/> struct.
            /// </summary>
            /// <param name="left_">The left.</param>
            /// <param name="top_">The top.</param>
            /// <param name="right_">The right.</param>
            /// <param name="bottom_">The bottom.</param>
            public RECT(int left_, int top_, int right_, int bottom_)
            {
                Left = left_;
                Top = top_;
                Right = right_;
                Bottom = bottom_;
            }

            /// <summary>
            /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
            /// </summary>
            /// <param name="obj">Another object to compare to.</param>
            /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is RECT))
                {
                    return false;
                }
                return this.Equals((RECT)obj);
            }

            /// <summary>
            /// Equalses the specified value.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
            public bool Equals(RECT value)
            {
                return this.Left == value.Left &&
                       this.Top == value.Top &&
                       this.Right == value.Right &&
                       this.Bottom == value.Bottom;
            }

            /// <summary>
            /// Gets the height.
            /// </summary>
            /// <value>The height.</value>
            public int Height
            {
                get
                {
                    return Bottom - Top + 1;
                }
            }

            /// <summary>
            /// Gets the width.
            /// </summary>
            /// <value>The width.</value>
            public int Width
            {
                get
                {
                    return Right - Left + 1;
                }
            }

            /// <summary>
            /// Gets the size.
            /// </summary>
            /// <value>The size.</value>
            public Size Size { get { return new Size(Width, Height); } }

            /// <summary>
            /// Gets the location.
            /// </summary>
            /// <value>The location.</value>
            public Point Location { get { return new Point(Left, Top); } }

            // Handy method for converting to a System.Drawing.Rectangle
            /// <summary>
            /// To the rectangle.
            /// </summary>
            /// <returns>System.Drawing.Rectangle.</returns>
            public System.Drawing.Rectangle ToRectangle()
            {
                return System.Drawing.Rectangle.FromLTRB(Left, Top, Right, Bottom);
            }

            /// <summary>
            /// Froms the rectangle.
            /// </summary>
            /// <param name="rectangle">The rectangle.</param>
            /// <returns>RECT.</returns>
            public static RECT FromRectangle(Rectangle rectangle)
            {
                return new RECT(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom);
            }

            /// <summary>
            /// Inflates the specified width.
            /// </summary>
            /// <param name="width">The width.</param>
            /// <param name="height">The height.</param>
            public void Inflate(int width, int height)
            {
                this.Left -= width;
                this.Top -= height;
                this.Right += width;
                this.Bottom += height;
            }

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
            public override int GetHashCode()
            {
                return Left ^ ((Top << 13) | (Top >> 0x13))
                    ^ ((Width << 0x1a) | (Width >> 6))
                    ^ ((Height << 7) | (Height >> 0x19));
            }

            /// <summary>
            /// Performs an implicit conversion from <see cref="RECT"/> to <see cref="Rectangle"/>.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <returns>The result of the conversion.</returns>
            public static implicit operator Rectangle(RECT rect)
            {
                return System.Drawing.Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right, rect.Bottom);
            }

            /// <summary>
            /// Performs an implicit conversion from <see cref="Rectangle"/> to <see cref="RECT"/>.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <returns>The result of the conversion.</returns>
            public static implicit operator RECT(Rectangle rect)
            {
                return new RECT(rect.Left, rect.Top, rect.Right, rect.Bottom);
            }
        }


        #endregion

        #region Private Fields

        private static List<Color> colorValue = new List<Color>();

        private static List<string> colorName = new List<string>();

        private Color accentColor = Color.Green;

        private Color dividerColor = Color.Indigo;

        private Color focused = Color.Red;

        private Color unfocused = Color.Yellow;

        private Color dropDownBorder = Color.Red;

        private Color outerBorderColor = Color.Black;

        private int outerBorderWidth = 1;

        private bool drawOuterBorder = false;

        private PenStyles dropDownBorderStlye = PenStyles.PS_SOLID;

        /// <summary>
        /// The drop down check
        /// </summary>
        private Timer _dropDownCheck = new Timer();
        /// <summary>
        /// The font
        /// </summary>
        FontManager font = new FontManager();

        /// <summary>
        /// The button area
        /// </summary>
        private Rectangle _ButtonArea;



        private DrawingModes drawingMode = DrawingModes.Variable;

        private DropBoxStyle boxStyle = DropBoxStyle.DropDownList;


        #endregion

        #region DLL Imports

        [DllImport("user32.dll")]
        public static extern bool GetComboBoxInfo(IntPtr hWnd, ref COMBOBOXINFO pcbi);

        /// <summary>
        /// Gets the window rect.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <param name="lpRect">The lp rect.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        /// <summary>
        /// Gets the window dc.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <returns>IntPtr.</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        /// <summary>
        /// Releases the dc.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <param name="hDC">The h dc.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        /// <summary>
        /// Sets the focus.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <returns>IntPtr.</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        /// <summary>
        /// Excludes the clip rect.
        /// </summary>
        /// <param name="hdc">The HDC.</param>
        /// <param name="nLeftRect">The n left rect.</param>
        /// <param name="nTopRect">The n top rect.</param>
        /// <param name="nRightRect">The n right rect.</param>
        /// <param name="nBottomRect">The n bottom rect.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("gdi32.dll")]
        public static extern int ExcludeClipRect(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);


        /// <summary>
        /// Creates the pen.
        /// </summary>
        /// <param name="enPenStyle">The en pen style.</param>
        /// <param name="nWidth">Width of the n.</param>
        /// <param name="crColor">Color of the cr.</param>
        /// <returns>IntPtr.</returns>
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePen(PenStyles enPenStyle, int nWidth, int crColor);


        /// <summary>
        /// Selects the object.
        /// </summary>
        /// <param name="hdc">The HDC.</param>
        /// <param name="hObject">The h object.</param>
        /// <returns>IntPtr.</returns>
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);

        /// <summary>
        /// Deletes the object.
        /// </summary>
        /// <param name="hObject">The h object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        /// <summary>
        /// Rectangles the specified HDC.
        /// </summary>
        /// <param name="hdc">The HDC.</param>
        /// <param name="X1">The x1.</param>
        /// <param name="Y1">The y1.</param>
        /// <param name="X2">The x2.</param>
        /// <param name="Y2">The y2.</param>
        [DllImport("gdi32.dll")]
        public static extern void Rectangle(IntPtr hdc, int X1, int Y1, int X2, int Y2);

        #endregion

        #region Public Properties

        public List<Color> ColorValue
        {
            get { return colorValue; }
        }

        public List<string> ColorName
        {
            get { return colorName; }
        }

        public Color DividerColor
        {
            get
            {
                return dividerColor;
            }
            set
            {
                dividerColor = value;
                Invalidate();
            }
        }

        public Color FocusedColor
        {
            get
            {
                return focused;
            }
            set
            {
                focused = value;
                Invalidate();
            }
        }

        public Color UnFocusedColor
        {
            get
            {
                return unfocused;
            }
            set
            {
                unfocused = value;
                Invalidate();
            }
        }

        public Color AccentColor
        {
            get
            {
                return accentColor;
            }
            set
            {
                accentColor = value;
                Invalidate();
            }
        }

        public bool DrawOuterBorder
        {
            get { return drawOuterBorder; }
            set
            {
                drawOuterBorder = value;
                Invalidate();
            }
        }

        public Color OuterBorderColor
        {
            get { return outerBorderColor; }
            set
            {
                outerBorderColor = value;
                Invalidate();
            }
        }

        public PenStyles DropDownBorderStlye
        {
            get { return dropDownBorderStlye; }
            set
            {
                dropDownBorderStlye = value;
                Invalidate();
            }
        }

        public Color DropdownBorder
        {
            get { return dropDownBorder; }
            set
            {
                dropDownBorder = value;
                Invalidate();
            }
        }

        public DropBoxStyle BoxStyle
        {
            get { return boxStyle; }
            set
            {
                switch (value)
                {
                    case DropBoxStyle.DropDown:
                        base.DropDownStyle = ComboBoxStyle.DropDown;
                        break;
                    case DropBoxStyle.DropDownList:
                        base.DropDownStyle = ComboBoxStyle.DropDownList;
                        break;

                }
                boxStyle = value;
                Invalidate();
            }
        }

        public DrawingModes DrawingMode
        {
            get
            {
                return drawingMode;
            }
            set
            {
                switch (value)
                {
                    case DrawingModes.Fixed:
                        base.DrawMode = DrawMode.OwnerDrawFixed;
                        break;
                    case DrawingModes.Variable:
                        base.DrawMode = DrawMode.OwnerDrawVariable;
                        break;

                }

                drawingMode = value;
                Invalidate();
            }
        }
        
        /// <summary>
        /// The wm ctlcolorlistbox
        /// </summary>
        public const int WM_CTLCOLORLISTBOX = 0x0134;


        /// <summary>
        /// 	Gets list of selectable items.
        ///     Overridden member to prevent designer from re-adding list of hatch styles.
        /// </summary>
        /// <value>
        /// 	List of selectable items.
        /// </value>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new System.Windows.Forms.ComboBox.ObjectCollection Items
        {
            get { return base.Items; }
        }

        /// <summary>
		/// 	Gets the current drop down style.
        ///     Overridden to prevent changing drop down style.
        /// </summary>
        /// <value>
		/// 	The current drop down style.
        /// </value>
		[Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ComboBoxStyle DropDownStyle
        {
            get { return base.DropDownStyle; }
        }

        /// <summary>
        ///     Gets the current draw mode.
        /// 	Overridden to prevent changing draw mode.
        /// </summary>
        /// <value>
        ///     Current draw mode.
        /// </value>
		[Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DrawMode DrawMode
        {
            get { return base.DrawMode; }
        }

        /// <summary>
        ///     Gets index specifying the currently selected item.
        /// 	Overridden to prevent an index of -1.
        /// </summary>
		/// <value>
		/// 	Index specifying the currently selected item.
		/// </value>
		public new int SelectedIndex
        {
            get { return base.SelectedIndex; }
            set
            {
                base.SelectedIndex = Math.Min(Math.Max(0, value), colorValue.Count - 1);
            }
        }

        /// <summary>
        ///     Gets or sets currently selected hatch style.
        /// </summary>
        /// <value>
        ///     Currently selected hatch style.
        /// </value>
		public Color SelectedColor
        {
            get
            {
                if (base.SelectedItem == null)
                {
                    return Color.White;
                }
                return (Color)base.SelectedItem;
            }
            set
            {
                for (int i = 0; i < colorValue.Count; i++)
                {
                    if (value == colorValue[i])
                    {
                        base.SelectedIndex = i;
                        return;
                    }
                }
                base.SelectedIndex = 0;
            }
        }



        #region Smoothing Mode

        private SmoothingMode smoothing = SmoothingMode.HighQuality;

        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }
        #endregion


        #endregion
        
        #region Constructor
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public AllWebColorsComboBox()
        {
            //base.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.this_DrawItem);
            SetStyle(ControlStyles.UserPaint, true);

            base.DropDownStyle = ComboBoxStyle.DropDownList;
            base.DrawMode = DrawMode.OwnerDrawVariable;

            _ButtonArea = new Rectangle(ClientRectangle.X - 1, ClientRectangle.Y - 1, ClientRectangle.Width + 2, ClientRectangle.Height + 2);

            _dropDownCheck.Interval = 10;
            _dropDownCheck.Tick += new EventHandler(dropDownCheck_Tick);
            MeasureItem += new MeasureItemEventHandler(CustMeasureItem);
            DrawItems();


        }

        #endregion

        #region Private and Public Methods

        private void DrawItems()
        {
            base.BeginUpdate();

            base.Items.Clear();

            foreach (Color hs in WebColor.AllColors.Values)
            {
                base.Items.Add(hs);
            }

            foreach (KeyValuePair<string, Color> kvp in WebColor.AllColors)
            {
                colorValue.Add(kvp.Value);
            }

            foreach (KeyValuePair<string, Color> kvp in WebColor.AllColors)
            {

                for (int i = 1; i < kvp.Key.Length; i++)
                {
                    if (char.IsUpper(kvp.Key[i]))
                    {
                        //kvp.Key.Substring(i).Replace(kvp.Key[i].ToString(), string.Format(" {0}", kvp.Key[i].ToString()));

                    }

                }

                colorName.Add(kvp.Key);
            }

            base.SelectedIndex = 0;

            base.EndUpdate();
        }

        /// <summary>
        /// RGBs the specified r.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>System.Int32.</returns>
        public static int RGB(int R, int G, int B)
        {
            return (R | (G << 8) | (B << 16));
        }


        /// <summary>
        /// Non client area border drawing
        /// </summary>
        /// <param name="handle">The handle to the control</param>
        public void DrawNativeBorder(IntPtr handle)
        {
            // Define the windows frame rectangle of the control
            RECT controlRect;
            GetWindowRect(handle, out controlRect);
            controlRect.Right -= controlRect.Left; controlRect.Bottom -= controlRect.Top;
            controlRect.Top = controlRect.Left = 0;

            // Get the device context of the control
            IntPtr dc = GetWindowDC(handle);

            // Define the client area inside the control rect
            RECT clientRect = controlRect;
            clientRect.Left += 1;
            clientRect.Top += 1;
            clientRect.Right -= 1;
            clientRect.Bottom -= 1;
            ExcludeClipRect(dc, clientRect.Left, clientRect.Top, clientRect.Right, clientRect.Bottom);

            // Create a pen and select it
            Color borderColor = dropDownBorder;
            IntPtr border = CreatePen(DropDownBorderStlye, 1, RGB(borderColor.R, borderColor.G, borderColor.B));

            // Draw the border rectangle
            IntPtr borderPen = SelectObject(dc, border);
            Rectangle(dc, controlRect.Left, controlRect.Top, controlRect.Right, controlRect.Bottom);
            SelectObject(dc, borderPen);
            DeleteObject(border);

            // Release the device context
            ReleaseDC(handle, dc);
            SetFocus(handle);
        }


        /// <summary>
        /// Customers the measure item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MeasureItemEventArgs"/> instance containing the event data.</param>
        private void CustMeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {

            Graphics g = CreateGraphics();

            //SizeF fs = g.MeasureString(Items[SelectedIndex].ToString(), Font);

            e.ItemWidth = 260;


        }
        
        /// <summary>
        /// Creates a default WM_CTLCOLORLISTBOX message
        /// </summary>
        /// <param name="handle">The drop down handle</param>
        /// <returns>A WM_CTLCOLORLISTBOX message</returns>
        public Message GetControlListBoxMessage(IntPtr handle)
        {
            // Force non-client redraw for focus border
            Message m = new Message();
            m.HWnd = handle;
            m.LParam = GetListHandle(handle);
            m.WParam = IntPtr.Zero;
            m.Msg = WM_CTLCOLORLISTBOX;
            m.Result = IntPtr.Zero;
            return m;
        }

        /// <summary>
        /// Gets the list control of a combo box
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <returns>IntPtr.</returns>
        public static IntPtr GetListHandle(IntPtr handle)
        {
            COMBOBOXINFO info;
            info = new COMBOBOXINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            return GetComboBoxInfo(handle, ref info) ? info.hwndList : IntPtr.Zero;
        }


        #endregion

        #region WndProc

        /// <summary>
        /// Override window messages
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        protected override void WndProc(ref Message m)
        {
            // Filter window messages
            switch (m.Msg)
            {
                // Draw a custom color border around the drop down list cintaining popup
                case WM_CTLCOLORLISTBOX:
                    base.WndProc(ref m);
                    DrawNativeBorder(m.LParam);
                    break;

                default: base.WndProc(ref m); break;
            }
        }


        #endregion

        #region Events and Overrides

        /// <summary>
        /// Checks when the drop down is fully visible
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dropDownCheck_Tick(object sender, EventArgs e)
        {
            // If the drop down has been fully dropped
            if (DroppedDown)
            {
                // Stop the time, send a listbox update
                _dropDownCheck.Stop();
                Message m = GetControlListBoxMessage(this.Handle);
                WndProc(ref m);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {

            if (e.Index < 0)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(focused), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(unfocused), e.Bounds);
            }

            this_DrawItem(e);

            //base.OnDrawItem(e);            

        }

        private void this_DrawItem(DrawItemEventArgs e)
        {
            unfocused = BackColor;
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                Color hs = colorValue[e.Index];
                string text = colorName[e.Index];
                Rectangle colorRectangle = new Rectangle(e.Bounds.X + 2, e.Bounds.Y, 30, 12);
                RectangleF textRectangle = new RectangleF(colorRectangle.Width + colorRectangle.Width / 2, colorRectangle.Y, e.Bounds.Width - colorRectangle.Width, colorRectangle.Height);


                using (SolidBrush br = new SolidBrush(hs))
                {
                    g.FillRectangle(br, colorRectangle);
                }

                using (Pen pr = new Pen(Color.Black, 1))
                {
                    g.DrawRectangle(pr, colorRectangle);
                }



                using (SolidBrush txtbr = new SolidBrush(ForeColor))
                {
                    g.DrawString(text, Font, txtbr, textRectangle);
                }

            }

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Pen objPen = new Pen(DroppedDown ? accentColor : dividerColor, 1);
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;


            #region Added

            Color hs = colorValue[SelectedIndex];
            string text = colorName[SelectedIndex];
            Rectangle colorRectangle;

            if (DrawOuterBorder)
            {
                colorRectangle = new Rectangle(ClientRectangle.X + (3 * outerBorderWidth), ClientRectangle.Y + (3 * outerBorderWidth), 40 - (3 * outerBorderWidth), 15 - (3 * outerBorderWidth));
            }
            else
            {
                colorRectangle = new Rectangle(0, 1, 40, 15);
            }

            RectangleF textRectangle = new RectangleF(colorRectangle.Width + colorRectangle.Width / 2, colorRectangle.Y, Width - colorRectangle.Width, colorRectangle.Height);


            #endregion

            g.Clear(BackColor);
            if (DrawOuterBorder)
            {
                g.DrawLine(objPen, new Point(0 + (outerBorderWidth), Height - 2 - (2 * outerBorderWidth)), new Point(Width, Height - 2 - (2 * outerBorderWidth)));

            }
            else
            {
                g.DrawLine(objPen, new Point(0, Height - 2), new Point(Width, Height - 2));

            }


            Point[] objTriangle = new Point[3];

            objTriangle[0] = new Point(Width - 15, Convert.ToInt32(Height * (DroppedDown ? 0.6 : 0.3)));
            objTriangle[1] = new Point(Width - 10, Convert.ToInt32(Height * (DroppedDown ? 0.3 : 0.6)));
            objTriangle[2] = new Point(Width - 5, Convert.ToInt32(Height * (DroppedDown ? 0.6 : 0.3)));

            e.Graphics.FillPolygon(DroppedDown ? new SolidBrush(accentColor) : new SolidBrush(dividerColor), objTriangle);
            e.Graphics.DrawPolygon(new Pen(Color.Black), objTriangle);

            if (DrawOuterBorder)
            {
                g.DrawRectangle(new Pen(OuterBorderColor, outerBorderWidth), new Rectangle(ClientRectangle.X + outerBorderWidth, ClientRectangle.Y + outerBorderWidth, ClientRectangle.Width - (2 * outerBorderWidth), ClientRectangle.Height - (2 * outerBorderWidth)));

            }

            if (SelectedIndex >= 0)
            {

                SizeF fs = g.MeasureString(text, Font);

                SolidBrush br = new SolidBrush(hs);
                SolidBrush txtbr = new SolidBrush(ForeColor);

                e.Graphics.DrawString(text, Font, txtbr, textRectangle);

                e.Graphics.FillRectangle(br, colorRectangle);
                e.Graphics.DrawRectangle(new Pen(Color.Black), colorRectangle);


            }


            base.OnPaint(e);


        }

        /// <summary>
        /// On drop down
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);

            // Start checking for the dropdown visibility
            _dropDownCheck.Start();
        }

        #endregion

    }
}
