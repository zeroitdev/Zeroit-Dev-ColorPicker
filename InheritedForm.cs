// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-29-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="InheritedForm.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public class InheritedForm : Form
    {
        private int border = 1;
        private Color borderColor = Color.Black;
        private Color middleColor = Color.Red;
        private int middleDivisor = 10;
        private bool circle = false;

        public InheritedForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        public bool Circle
        {
            get { return circle; }
            set
            {
                circle = value;
                Invalidate();
            }
        }

        public Color MiddleColor
        {
            get { return middleColor; }
            set
            {
                middleColor = value;
                Invalidate();
            }
        }

        public int MiddleDivisor
        {
            get { return middleDivisor; }
            set
            {
                middleDivisor = value;
                Invalidate();
            }
        }

        public int Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }


        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(BackColor);
            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            int smallerRectWidth = Width / MiddleDivisor;
            int smallerRectHeight = Width / MiddleDivisor;

            if(!Circle)
            {
                //Smaller Rectangle
                g.DrawRectangle(new Pen(MiddleColor), new Rectangle(ClientRectangle.X + (Width / 2) - (smallerRectWidth / 2), ClientRectangle.Y + (Height / 2) - (smallerRectHeight / 2), smallerRectWidth, smallerRectHeight));

                //Border
                g.DrawRectangle(new Pen(BorderColor), new Rectangle(ClientRectangle.X, ClientRectangle.Y, Width - 1, Height - 1));

            }
            else
            {
                //Smaller Rectangle
                //g.DrawEllipse(new Pen(MiddleColor), new Rectangle(ClientRectangle.X + (Width / 2) - (smallerRectWidth / 2), ClientRectangle.Y + (Height / 2) - (smallerRectHeight / 2), smallerRectWidth, smallerRectHeight));

                //Border
                g.DrawEllipse(new Pen(BorderColor), new Rectangle(ClientRectangle.X, ClientRectangle.Y, Width - 1, Height - 1));

            }

        }




        #region Transparency


        #region Include in Paint

        private void TransInPaint(Graphics g)
        {
            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }
        }

        #endregion

        #region Include in Private Field

        private bool allowTransparency = true;

        #endregion

        #region Include in Public Properties

        public bool AllowTransparency
        {
            get { return allowTransparency; }
            set
            {
                allowTransparency = value;

                Invalidate();
            }
        }

        #endregion

        #region Method

        //-----------------------------Include in Paint--------------------------//
        //
        // if(AllowTransparency)
        //  {
        //    MakeTransparent(this,g);
        //  }
        //
        //-----------------------------Include in Paint--------------------------//

        private static void MakeTransparent(Control control, Graphics g)
        {
            var parent = control.Parent;
            if (parent == null) return;
            var bounds = control.Bounds;
            var siblings = parent.Controls;
            int index = siblings.IndexOf(control);
            Bitmap behind = null;
            for (int i = siblings.Count - 1; i > index; i--)
            {
                var c = siblings[i];
                if (!c.Bounds.IntersectsWith(bounds)) continue;
                if (behind == null)
                    behind = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                c.DrawToBitmap(behind, c.Bounds);
            }
            if (behind == null) return;
            g.DrawImage(behind, control.ClientRectangle, bounds, GraphicsUnit.Pixel);
            behind.Dispose();
        }

        #endregion


        #endregion



    }
}
