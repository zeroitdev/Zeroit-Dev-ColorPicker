#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#endregion


namespace ZeroitDevColorPicker.Helpers
{


    #region Control

    /// <summary>
    /// Provides data for a ColorSelected event.
    /// </summary>
    public class ColorSelectedEventArgs : EventArgs
    {

        private Color _color;
        /// <summary>
        /// Get the selected color value.
        /// </summary>
        public Color Color
        {
            get { return _color; }
        }

        internal ColorSelectedEventArgs(Color color)
        {
            _color = color;
        }

    }

    public delegate void ColorSelectedHandler(object sender, ColorSelectedEventArgs e);
    /// <summary>
    /// Summary description for ColorPaleteControl.
    /// </summary>
    /// 
    [DefaultEvent("ColorCellSelected")]
    [DefaultProperty("SelectedColor")]
    [ToolboxBitmap(typeof(ColorPaleteControl), "Editors.ColorPanel.ColorPaleteControl.bmp")]
    public class ColorPaleteControl : Control
    {

        #region privates variable

        private CellHelper _cellGen = new CellHelper();
        private Point _orgPoint = new Point(50, 50);
        private int _upperEdgeCount = 10;
        private int _lowerEdgeCount = 11;
        private int _edgeSize = 12;
        private float _halfEdgeSize = 6;
        private Cell _lastCell = Cell.Empty;
        private int _currentCell = -1;
        private int _oldCell = -1;
        private Color _selectedColor;
        private Color _darkColor = Color.Black;
        private Color _lightColor = Color.White;

        // controls
        private ToolTip colorTip;


        //Event
        /// <summary>
        /// Occurs when a color cell is selected.
        /// </summary>
        [Description("Occurs when a color cell is selected.")]
        public event ColorSelectedHandler ColorCellSelected;

        #endregion
        #region Properties
        /// <summary>
        /// Gets or set the light color of this control. 
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or set the light color of this control. ")]
        [DefaultValue(typeof(Color), "White")]
        public Color LightColor
        {
            get
            {
                return _lightColor;
            }
            set
            {
                if (_lightColor == value)
                {
                    return;
                }
                _lightColor = value;
                GenerateColorByCell();
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the dark color of this control.
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets the dark color of this control.")]
        [DefaultValue(typeof(Color), "Black")]
        public Color DarkColor
        {
            get
            {
                return _darkColor;
            }
            set
            {
                if (_darkColor == value)
                {
                    return;
                }
                _darkColor = value;
                GenerateColorByCell();
                Invalidate();
            }
        }

        /// <summary>
        /// Gets the color which is seclected. 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Behavior")]
        [Browsable(false)]
        public Color SelectedColor
        {
            get
            {
                return _selectedColor;
            }
        }

        /// <summary>
        /// Gets or sets the number of the lower edges connected to the graph vertex (undirected graph) 
        /// </summary>
        /// 
        [Category("Appearance")]
        [Description("Gets or sets the number of the lower edges connected to the graph vertex (undirected graph) ")]
        [DefaultValue(11)]
        public int LowerEdgeCount
        {
            get
            {
                return _lowerEdgeCount;
            }
            set
            {
                if (_lowerEdgeCount == value)
                {
                    return;
                }
                if ((_lowerEdgeCount <= 0) || (_lowerEdgeCount > 100))
                {
                    throw new ArgumentOutOfRangeException("LowerEdgeCount");
                }
                _lowerEdgeCount = value;
                GenerateCells();
                GenerateColorByCell();
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the number of the upper edges connected to the graph vertex (undirected graph) 
        /// </summary>
        /// 
        [Category("Appearance")]
        [Description("Gets or sets the number of the upper edges connected to the graph vertex (undirected graph) ")]
        [DefaultValue(10)]
        public int UpperEdgeCount
        {
            get
            {
                return _upperEdgeCount;
            }
            set
            {
                if (_upperEdgeCount == value)
                {
                    return;
                }
                if (_upperEdgeCount <= 0)
                {
                    throw new ArgumentOutOfRangeException("UpperEdgeCount");
                }
                if (_upperEdgeCount > 100)
                {
                    throw new ArgumentException("The value is too big. Please enter value less than 100");
                }
                _upperEdgeCount = value;
                GenerateCells();
                GenerateColorByCell();
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets size of the cell edge in pixel.
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets size of the cell edge in pixel.")]
        [DefaultValue(12)]
        public int EdgeSize
        {
            get
            {
                return _edgeSize;
            }
            set
            {
                if (_edgeSize == value)
                {
                    return;
                }
                if (value < 6)
                {
                    throw new ArgumentOutOfRangeException("EdgeSize", "The EdgeSize property can not be less than 6.");
                }
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("EdgeSize", "The EdgeSize property can not be greater than 100.");
                }
                _edgeSize = value;
                _halfEdgeSize = (float)value / 2;
                GenerateCells();
                GenerateColorByCell();
                Invalidate();
            }
        }

        #endregion
        #region Contrustors
        /// <summary>
        /// Initializes a new instance of the ColorPaleteControl class with default settings
        /// </summary>
        public ColorPaleteControl()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor,
                true);
            //
            // TODO: Add constructor logic here
            //			
            this.colorTip = new System.Windows.Forms.ToolTip();
            this.colorTip.Active = false;
            Size = new Size(256, 56);

        }
        #endregion
        #region methods
        /// <summary>
        /// Raises the Resize event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            this.GenerateCells();
            this.GenerateColorByCell();
            Invalidate();
            base.OnResize(e);
        }

        private void DrawSelection(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if ((_oldCell >= 0) && (_oldCell < _cellGen._cells.Length) && (_oldCell != _currentCell))
            {
                g.FillPolygon(new SolidBrush(_cellGen._cells[_oldCell]._color), _cellGen._cells[_oldCell].Points);
            }
            _oldCell = _currentCell;

            if ((_currentCell >= 0) && (_currentCell < _cellGen._cells.Length))
            {
                using (GraphicsPath pth = new GraphicsPath())
                {
                    Cell cc = _cellGen._cells[this._currentCell];
                    pth.AddPolygon(new Point[]{   new Point(cc.A.X + 1, cc.A.Y + 1),
                                                  new Point(cc.B.X, cc.B.Y + 1),
                                                  new Point(cc.C.X - 1, cc.C.Y + 1),
                                                  new Point(cc.D.X - 1, cc.D.Y - 1),
                                                  new Point(cc.E.X, cc.E.Y - 1),
                                                  new Point(cc.F.X + 1, cc.F.Y - 1)});
                    pth.CloseFigure();
                    g.DrawPath(Pens.Black, pth);
                }
            }
        }
        /// <summary>
        /// Raises the Paint event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_cellGen._lenght <= 0)
            {
                GenerateCells();
                GenerateColorByCell();
            }
            Rectangle clipRect = e.ClipRectangle;

            Graphics g = e.Graphics;
            SmoothingMode old = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 0; i < _cellGen._lenght; i++)
            {
                if (_cellGen._cells[i].IntersectWith(clipRect))
                {
                    g.FillPolygon(new SolidBrush(_cellGen._cells[i]._color), _cellGen._cells[i].Points);
                }
            }

            if ((_currentCell >= 0) && (_currentCell < _cellGen._cells.Length))
            {
                Cell cc = _cellGen._cells[this._currentCell];
                g.DrawPolygon(Pens.Black,
                    new Point[]{   new Point(cc.A.X + 1, cc.A.Y + 1),
                                   new Point(cc.B.X, cc.B.Y + 1),
                                   new Point(cc.C.X - 1, cc.C.Y + 1),
                                   new Point(cc.D.X - 1, cc.D.Y - 1),
                                   new Point(cc.E.X, cc.E.Y - 1),
                                   new Point(cc.F.X + 1, cc.F.Y - 1),
                                   new Point(cc.A.X + 1, cc.A.Y + 1)});
            }
            //Reset smoothing mode
            g.SmoothingMode = old;
            base.OnPaint(e);
        }

        /// <summary>
        /// Raises the MouseMove event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            int n = this._cellGen._cells.Length;
            Point pt = new Point(e.X, e.Y);
            for (int i = 0; i < n; i++)
            {
                if (_cellGen._cells[i].Contains(pt))
                {
                    if (!_lastCell.Equals(_cellGen._cells[i]))
                    {
                        this.colorTip.Active = false;
                        _lastCell = _cellGen._cells[i];

                        if (!_lastCell._color.ToString().Equals(colorTip.GetToolTip(this)))
                        {
                            this.colorTip.SetToolTip(this, _lastCell._color.ToString());
                        }
                        this.colorTip.Active = true;

                        this.Cursor = Cursors.Hand;
                        if (e.Button == MouseButtons.Left)
                        {
                            _selectedColor = _cellGen._cells[i]._color;
                            if (ColorCellSelected != null)
                            {
                                ColorCellSelected(this, new ColorSelectedEventArgs(_cellGen._cells[i]._color));
                            }
                            _currentCell = i;
                            using (Graphics g = this.CreateGraphics())
                            {
                                DrawSelection(g);
                            }
                        }
                    }
                    break;
                }
            }

            base.OnMouseMove(e);
        }
        /// <summary>
        /// Raises the MouseUp event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            int n = this._cellGen._cells.Length;
            Point pt = new Point(e.X, e.Y);
            for (int i = 0; i < n; i++)
            {
                if (_cellGen._cells[i].Contains(pt))
                {
                    _selectedColor = _cellGen._cells[i]._color;
                    if (ColorCellSelected != null)
                    {
                        ColorCellSelected(this, new ColorSelectedEventArgs(_cellGen._cells[i]._color));
                    }

                    _currentCell = i;
                    using (Graphics g = this.CreateGraphics())
                    {
                        DrawSelection(g);
                    }
                    break;
                }
            }
            base.OnMouseDown(e);
        }
        /// <summary>
        /// Unselects all items in this control.
        /// </summary>
        public void ClearSelected()
        {
            if ((_currentCell < 0) || (_currentCell >= _cellGen._cells.Length))
            {
                return;
            }

            //Reset value
            _oldCell = _currentCell;
            _currentCell = -1;
            _selectedColor = Color.Empty;
            using (Graphics g = this.CreateGraphics())
            {
                DrawSelection(g);
            }
        }
        private void GenerateCells()
        {

            //			int w, h;
            //			w = (int)(_upperEdgeCount* ((int)this._halfEdgeSize*Math.Sqrt(3)));
            //			h = (int)(Math.Sqrt(3)*_halfEdgeSize)*(Math.Abs(_upperEdgeCount - _lowerEdgeCount)+1);
            //			_orgPoint = new Point(Width/2 - w, Height/2 - h);

            //////////////////////////

            _cellGen._grab = 0;
            _cellGen._sizeper2 = this._halfEdgeSize;

            Cell orgCell = _cellGen.CalOrgCell();
            int w, h;
            w = _upperEdgeCount * orgCell.B.X;

            if (_upperEdgeCount <= _lowerEdgeCount)
            {
                h = orgCell.D.Y * (Math.Abs(_upperEdgeCount - _lowerEdgeCount - 1)) + orgCell.D.Y / 3;
            }
            else
            {
                h = orgCell.D.Y * (Math.Abs(_upperEdgeCount - _lowerEdgeCount + 1)) + 2 + orgCell.D.Y / 3;
            }

            _orgPoint = new Point(Width / 2 - w, (Height - h) / 2);

            _cellGen._orgPoint = _orgPoint;

            _cellGen.GenerateCells(this._upperEdgeCount, this._lowerEdgeCount);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="opt"></param>
        /// <returns></returns>
        private Color Darker(Color color, float opt)
        {
            int r = (int)(color.R * opt);
            int g = (int)(color.G * opt);
            int b = (int)(color.B * opt);

            return Color.FromArgb(255, r, g, b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="opt"></param>
        /// <returns></returns>
        private Color Lighter(Color color, float opt)
        {
            if (opt < 0)
            {
                throw new Exception("Invalid opt value");
            }
            if (opt == 0)
            {
                return color;
            }
            int red = color.R < 3 ? 3 : (int)Math.Min(255, color.R / opt);
            int green = color.G < 3 ? 3 : (int)Math.Min(255, color.G / opt);
            int blue = color.B < 3 ? 3 : (int)Math.Min(255, color.B / opt);
            return Color.FromArgb(255, red, green, blue);
        }
        private void GenerateGradientColorByCell()
        {
            int index, th;
            index = 0;
            if (this._upperEdgeCount <= _lowerEdgeCount)
            {
                th = _lowerEdgeCount - _upperEdgeCount + 1;
                for (int y = 0; y < th; y++)
                {
                    int maxX = _upperEdgeCount + y;
                    Color startColor = Darker(_lightColor, (1 - (float)y / th / 10));
                    Color endColor = Lighter(_darkColor, ((float)y / th) + 1);

                    float dtR = (float)((float)(endColor.R - startColor.R) / maxX);
                    float dtG = (float)((float)(endColor.G - startColor.G) / maxX);
                    float dtB = (float)((float)(endColor.B - startColor.B) / maxX);

                    for (int x = 0; x < maxX; x++)
                    {
                        _cellGen._cells[index]._color = Color.FromArgb((int)(startColor.R + dtR * x),
                            (int)(startColor.G + dtG * x), (int)(startColor.B + dtB * x));
                        index++;
                    }
                }
            }
            else
            {
                th = _upperEdgeCount - _lowerEdgeCount + 1;
                for (int y = 0; y < th; y++)
                {
                    int maxX = _upperEdgeCount - y;

                    Color startColor = Darker(_lightColor, (1 - (float)y / th / 10));
                    Color endColor = Lighter(_darkColor, ((float)y / th) + 1);

                    float dtR = (float)((float)(endColor.R - startColor.R) / maxX);
                    float dtG = (float)((float)(endColor.G - startColor.G) / maxX);
                    float dtB = (float)((float)(endColor.B - startColor.B) / maxX);

                    for (int x = 0; x < maxX; x++)
                    {
                        _cellGen._cells[index]._color = Color.FromArgb((int)(startColor.R + dtR * x),
                            (int)(startColor.G + dtG * x), (int)(startColor.B + dtB * x));
                        index++;
                    }
                }
            }
        }
        private void GenerateColorByCell()
        {
            this.GenerateGradientColorByCell();
        }
        #endregion
    }

    #endregion

    #region Helper
    /// <summary>
    /// Summary description for CellHelper.
    /// </summary>
    internal class CellHelper
    {
        public float _sizeper2 = 3;

        public Cell[] _cells;
        public int _margin = 0;

        public int _grab = 1;
        public int _lenght;
        public Point _orgPoint = new Point(0, 0);


        private int _xDistancePer2;
        private int _yDistancePer2;

        internal int CellWidth
        {
            get
            {
                return _xDistancePer2 * 2;
            }
        }
        internal int CellHeight
        {
            get
            {
                return _yDistancePer2 * 4;
            }
        }
        /// <summary>
        /// Initializes a new instance of the CellHelper class
        /// </summary>
        public CellHelper()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Cell CalOrgCell()
        {
            Cell orgCell = new Cell();
            double sqrt3 = Math.Sqrt(3);
            _xDistancePer2 = (int)(_sizeper2 * sqrt3 + 0.5f);
            _yDistancePer2 = (int)(_sizeper2 + 0.5f);

            orgCell.A = new Point(0, _yDistancePer2);
            orgCell.B = new Point(_xDistancePer2, 0);
            orgCell.C = new Point(2 * _xDistancePer2, _yDistancePer2);
            orgCell.D = new Point(2 * _xDistancePer2, 3 * _yDistancePer2);
            orgCell.E = new Point(_xDistancePer2, 4 * _yDistancePer2);
            orgCell.F = new Point(0, 3 * _yDistancePer2);

            _xDistancePer2 = orgCell.B.X;
            _yDistancePer2 = (int)(_sizeper2 + 0.5f);

            return orgCell;
        }
        /// <summary>
        /// 
        /// </summary>
        public void GenerateCells(int edge1, int edge2)
        {
            Cell orgCell = CalOrgCell();
            int small, n;
            if (edge1 > edge2)
            {
                small = edge2;
                n = edge1 - edge2 + 1;
            }
            else
            {
                small = edge1;
                n = edge2 - edge1 + 1;
            }
            _lenght = small * n + (int)(((n + 1) * n) / 2);
            _cells = new Cell[_lenght];
            if (edge1 > edge2)
            {
                int inx = 0;
                int disX = _orgPoint.X;
                int disY = _orgPoint.Y;
                for (int i = 0; i < n; i++)
                {
                    int edge = edge1 - i;
                    for (int j = 0; j < edge; j++)
                    {
                        _cells[inx] = orgCell;
                        _cells[inx].Transform(disX, disY);
                        disX += 2 * _xDistancePer2 + _grab;
                        inx++; ;
                    }
                    disY += 3 * _yDistancePer2 + _grab;
                    disX = _orgPoint.X + (i + 1) * _xDistancePer2;
                }
            }
            else
            {//Edge2>edge1
                int inx = 0;
                int disX = _orgPoint.X;
                int disY = _orgPoint.Y;
                for (int i = 0; i < n; i++)
                {
                    int edge = i + small;
                    for (int j = 0; j < edge; j++)
                    {
                        _cells[inx] = orgCell;
                        _cells[inx].Transform(disX, disY);
                        disX += 2 * _xDistancePer2 + _grab;
                        inx++;
                    }
                    disY += 3 * _yDistancePer2 + _grab;
                    disX = _orgPoint.X - (i + 1) * _xDistancePer2;
                }
            }
        }
    }
    /// <summary>
    /// Declare struct Cell
    /// </summary>
    internal struct Cell
    {
        public static Cell Empty = new Cell();
        public Point A, B, C, D, E, F;
        public Color _color;

        public bool EqualCells(Cell obj)
        {
            if (A.Equals(obj.A) && B.Equals(obj.B) && C.Equals(obj.C) &&
                D.Equals(obj.D) && E.Equals(obj.E) && F.Equals(obj.F))
            {
                return true;
            }
            return false;
        }

        public bool IntersectWith(Rectangle rect)
        {
            Rectangle bound = Rectangle.FromLTRB(A.X, B.Y, C.X, E.Y);
            return bound.IntersectsWith(rect);
        }

        public Point[] Points
        {
            get
            {
                return new Point[] { A, B, C, D, E, F };
            }
        }
        public bool Contains(Point pt)
        {
            if ((pt.X < A.X) || (pt.X > C.X))
            {
                return false;
            }
            if (A.X == B.X)
            {
                return false;
            }
            //pt.Y must under dAB
            int yAB = (A.Y - B.Y) * ((pt.X - B.X) / (A.X - B.X)) + B.Y;
            if (yAB > pt.Y)
            {
                return false;
            }
            //pt.Y must under dBC
            int yCB = (C.Y - B.Y) * ((pt.X - B.X) / (C.X - B.X)) + B.Y;
            if (yCB > pt.Y)
            {
                return false;
            }

            //pt.Y must abover dDE
            int yDE = (E.Y - D.Y) * ((pt.X - D.X) / (E.X - D.X)) + D.Y;
            if (yDE < pt.Y)
            {
                return false;
            }
            //pt.Y must abover dEF
            int yEF = (E.Y - F.Y) * ((pt.X - F.X) / (E.X - F.X)) + F.Y;
            if (yEF < pt.Y)
            {
                return false;
            }

            return true;
        }
        public void Transform(int disX, int disY)
        {
            A.X += disX;
            B.X += disX;
            C.X += disX;
            D.X += disX;
            E.X += disX;
            F.X += disX;

            A.Y += disY;
            B.Y += disY;
            C.Y += disY;
            D.Y += disY;
            E.Y += disY;
            F.Y += disY;
        }

    }
    #endregion


}
