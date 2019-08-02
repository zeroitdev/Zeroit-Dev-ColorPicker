// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Spicylips Theme.cs" company="Zeroit Dev Technologies">
//    This program is for creating a program for viewing code.
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace ZeroitDevColorPicker
{

    /// <summary>
    /// Class SpicyLips.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ProgressThematic.ThemeManagers.ThemeContainer" />
    [ToolboxItem(true)]
    public class BaseTheme : ThemeContainer
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SpicyLips"/> class.
        /// </summary>
        public BaseTheme()
        {
            TransparencyKey = Color.Fuchsia;
            Height = 30;
            BackColor = Color.FromArgb(20, 20, 20);
        }


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(20, 20, 20));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(9, 9, 9), Color.FromArgb(15, 15, 15));
            G.FillRectangle(T, ClientRectangle);
            G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), ClientRectangle);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 0, 0, Width, Height);

            G.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), 12, 22, Width - 24, Height - 27);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 12, 22, Width - 24, Height - 27);

            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 2);
            DrawCorners(TransparencyKey);

            if(ShowIcon)
                DrawImage(G, new Rectangle(30, 0, ImageSize.Width, ImageSize.Height));
            

        }




        #region Image Designer

        #region Include in paint method

        ///////////////////////////////////////////////////////////////////////////////////////////////// 
        //                                                                                             //                                                                     
        //         ------------------------Add this to the Paint Method ------------------------       //
        //                                                                                             //
        // Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          //
        //                                                                                             //
        // PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);                   //
        //                                                                                             //
        // if ((Image == null))                                                                        //
        //     {                                                                                       //
        //         G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat           //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        // else                                                                                        //
        //      {                                                                                      //
        //         G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);              //
        //          G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat          //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        //                                                                                             //
        /////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Include in Private Fields
        private Image _Image;
        private Size _ImageSize;
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleCenter;
        private StringAlignment _TextAlignment = StringAlignment.Center;
        private bool showText = false;
        private bool showIcon = false;
        #endregion

        #region Include in Public Properties

        public bool ShowIcon
        {
            get { return showIcon; }
            set
            {
                showIcon = value;
                Invalidate();
            }
        }
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }


        public new Size ImageSize
        {
            get { return _ImageSize; }
            set
            {
                _ImageSize = value;
                Invalidate();
            }
        }

        public ContentAlignment ImageAlign
        {
            get { return _ImageAlign; }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                Invalidate();
            }
        }

        public StringAlignment TextAlign
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }



        #endregion

        #region Include in Private Methods
        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint = default(PointF);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    MyPoint.X = Convert.ToSingle((Area.Width - ImageArea.Width) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.X = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.X = Area.Width - ImageArea.Width - 2;
                    break;
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    MyPoint.Y = Convert.ToSingle((Area.Height - ImageArea.Height) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.Y = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.Y = Area.Height - ImageArea.Height - 2;
                    break;
            }
            return MyPoint;
        }

        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            StringFormat SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.TopCenter:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopLeft:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomRight:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Far;
                    break;
            }
            return SF;
        }

        private void DrawImage(Graphics G, Rectangle R1)
        {
            //Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          
            G.SmoothingMode = SmoothingMode.HighQuality;

            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

            if ((Image == null))
            {
                if (ShowText)
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                    {
                        Alignment = _TextAlignment,
                        LineAlignment = StringAlignment.Center

                    });
            }
            else
            {
                G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);

                if (ShowText)
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                    {
                        Alignment = _TextAlignment,
                        LineAlignment = StringAlignment.Center
                    });
            }

        }


        #endregion
        
        #endregion




    }
    

}