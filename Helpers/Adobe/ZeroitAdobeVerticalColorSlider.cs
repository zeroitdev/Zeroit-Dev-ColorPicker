/******************************************************************/
/*****                                                        *****/
/*****     Project:           Adobe Color Picker Clone 1      *****/
/*****     Filename:          ctrlVerticalColorSlider.cs      *****/
/*****     Original Author:   Danny Blanchard                 *****/
/*****                        - scrabcakes@gmail.com          *****/
/*****     Updates:	                                          *****/
/*****      3/28/2005 - Initial Version : Danny Blanchard     *****/
/*****                                                        *****/
/******************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroitDevColorPicker.Helpers.Adobe
{
    public delegate void EventHandler(object sender, EventArgs e);

	/// <summary>
	/// A vertical slider control that shows a range for a color property (a.k.a. Hue, Saturation, Brightness,
	/// Red, Green, Blue) and sends an event when the slider is changed.
	/// </summary>
	public class ZeroitAdobeVerticalColorSlider : Control
	{

		#region Class Variables

		public enum eDrawStyle
		{
			Hue,
			Saturation,
			Brightness,
			Red,
			Green,
			Blue
		}


		//	Slider properties
		private int			m_iMarker_Start_Y = 0;
		private bool		m_bDragging = false;

		//	These variables keep track of how to fill in the content inside the box;
		private eDrawStyle		m_eDrawStyle = eDrawStyle.Hue;
		private ColorConverters.HSL	m_hsl;
		private Color			m_rgb;

		private System.ComponentModel.Container components = null;

        Point mouseLocation;

        Color[] borderColor = new Color[] { Color.FromArgb(172, 168, 153), Color.White, Color.Black, SystemColors.Control };

        Color[] sliderColor = new Color[] { Color.FromArgb(116, 114, 106), Color.White };


        #endregion

        #region Public Properties

        public Color[] SliderColor
        {
            get { return sliderColor; }
            set
            {
                sliderColor = value;
                Invalidate();
            }
        }

        public Color[] BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructors / Destructors

        public ZeroitAdobeVerticalColorSlider()
		{


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            
            //	Initialize Colors
            m_hsl = new ColorConverters.HSL();
			m_hsl.H = 1.0;
			m_hsl.S = 1.0;
			m_hsl.L = 1.0;
			m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
			m_eDrawStyle = eDrawStyle.Hue;

            Invalidate();

            mouseLocation = new Point(MousePosition.X, MousePosition.Y);

        }


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#endregion

		
		#region Control Events
    
        private void CapsuleMover(Graphics g, Point mouse)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            int y;
            y = mouse.Y;
            y -= 4;                                         //	Calculate slider position
            if (y < 0) y = 0;
            if (y > this.Height - 9) y = this.Height - 9;

            if (y == m_iMarker_Start_Y)                 //	If the slider hasn't moved, no need to redraw it.
                return;                                     //	or send a scroll notification

            DrawSlider(y, false, g);   //	Redraw the slider
            ResetHSLRGB();			//	Reset the color
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseLocation = e.Location;

            if (e.Button != MouseButtons.Left)  //	Only respond to left mouse button events
                return;

            m_bDragging = true;     //	Begin dragging which notifies MouseMove function that it needs to update the marker

            Invalidate();

            if (Scroll != null) //	Notify anyone who cares that the controls slider(color) has changed
                Scroll(this, e);

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            mouseLocation = e.Location;

            if (!m_bDragging)       //	Only respond when the mouse is dragging the marker.
                return;

            Invalidate();

            if (Scroll != null) //	Notify anyone who cares that the controls slider(color) has changed
                Scroll(this, e);

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseLocation = e.Location;

            if (e.Button != MouseButtons.Left)  //	Only respond to left mouse button events
                return;

            m_bDragging = false;

            Invalidate();

            if (Scroll != null) //	Notify anyone who cares that the controls slider(color) has changed
                Scroll(this, e);

        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }
            
            DrawContent(g);
            Reset_Slider(true, g);
            CapsuleMover(g, mouseLocation);
            Redraw_Control(g);

            
            
            
        }

        #endregion

        #region Events

        public event EventHandler Scroll;

		#endregion

		#region Public Methods

		/// <summary>
		/// The drawstyle of the contol (Hue, Saturation, Brightness, Red, Green or Blue)
		/// </summary>
		public eDrawStyle DrawStyle
		{
			get
			{
				return m_eDrawStyle;
			}
			set
			{
				m_eDrawStyle = value;

                //	Redraw the control based on the new eDrawStyle
                //Reset_Slider(true);
                //Redraw_Control();
                Invalidate();
			}
		}


		/// <summary>
		/// The HSL color of the control, changing the HSL will automatically change the RGB color for the control.
		/// </summary>
		public ColorConverters.HSL HSL
		{
			get
			{
				return m_hsl;
			}
			set
			{
				m_hsl = value;
				m_rgb = ColorConverters.HSL_to_RGB(m_hsl);

                //	Redraw the control based on the new color.
                //Reset_Slider(true);
                //DrawContent();
                Invalidate();
			}
		}


		/// <summary>
		/// The RGB color of the control, changing the RGB will automatically change the HSL color for the control.
		/// </summary>
		public Color RGB
		{
			get
			{
				return m_rgb;
			}
			set
			{
				m_rgb = value;
				m_hsl = ColorConverters.RGB_to_HSL(m_rgb);

                //	Redraw the control based on the new color.
                //Reset_Slider(true);
                //DrawContent();
                Invalidate();
			}
		}


		#endregion

		#region Private Methods

		/// <summary>
		/// Redraws the background over the slider area on both sides of the control
		/// </summary>
		private void ClearSlider(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            SolidBrush brush = new SolidBrush(borderColor[3]);
			g.FillRectangle(brush, 0, 0, 8, this.Height);				//	clear left hand slider
			g.FillRectangle(brush, this.Width - 8, 0, 8, this.Height);	//	clear right hand slider
		}


		/// <summary>
		/// Draws the slider arrows on both sides of the control.
		/// </summary>
		/// <param name="position">position value of the slider, lowest being at the bottom.  The range
		/// is between 0 and the controls height-9.  The values will be adjusted if too large/small</param>
		/// <param name="Unconditional">If Unconditional is true, the slider is drawn, otherwise some logic 
		/// is performed to determine is drawing is really neccessary.</param>
		private void DrawSlider(int position, bool Unconditional, Graphics g)
		{
            if ( position < 0 ) position = 0;
			if ( position > this.Height - 9 ) position = this.Height - 9;

			if ( m_iMarker_Start_Y == position && !Unconditional )	//	If the marker position hasn't changed
				return;												//	since the last time it was drawn and we don't HAVE to redraw
			//	then exit procedure

			m_iMarker_Start_Y = position;	//	Update the controls marker position

			this.ClearSlider(g);     //	Remove old slider

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Pen pencil = new Pen(sliderColor[0]);	//	Same gray color Photoshop uses
			SolidBrush brush = new SolidBrush(sliderColor[1]);
			
			Point[] arrow = new Point[7];				//	 GGG
			arrow[0] = new Point(1,position);			//	G   G
			arrow[1] = new Point(3,position);			//	G    G
			arrow[2] = new Point(7,position + 4);		//	G     G
			arrow[3] = new Point(3,position + 8);		//	G      G
			arrow[4] = new Point(1,position + 8);		//	G     G
			arrow[5] = new Point(0,position + 7);		//	G    G
			arrow[6] = new Point(0,position + 1);		//	G   G
			//	 GGG

			g.FillPolygon(brush, arrow);	//	Fill left arrow with white
			g.DrawPolygon(pencil, arrow);	//	Draw left arrow border with gray

			//	    GGG
			arrow[0] = new Point(this.Width - 2,position);		//	   G   G
			arrow[1] = new Point(this.Width - 4,position);		//	  G    G
			arrow[2] = new Point(this.Width - 8,position + 4);	//	 G     G
			arrow[3] = new Point(this.Width - 4,position + 8);	//	G      G
			arrow[4] = new Point(this.Width - 2,position + 8);	//	 G     G
			arrow[5] = new Point(this.Width - 1,position + 7);	//	  G    G
			arrow[6] = new Point(this.Width - 1,position + 1);	//	   G   G
			//	    GGG

			g.FillPolygon(brush, arrow);	//	Fill right arrow with white
			g.DrawPolygon(pencil, arrow);	//	Draw right arrow border with gray

		}


		/// <summary>
		/// Draws the border around the control, in this case the border around the content area between
		/// the slider arrows.
		/// </summary>
		private void DrawBorder(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Pen pencil;
			
			//	To make the control look like Adobe Photoshop's the border around the control will be a gray line
			//	on the top and left side, a white line on the bottom and right side, and a black rectangle (line) 
			//	inside the gray/white rectangle

			pencil = new Pen(borderColor[0]);	//	The same gray color used by Photoshop
			g.DrawLine(pencil, this.Width - 10, 2, 9, 2);	//	Draw top line
			g.DrawLine(pencil, 9, 2, 9, this.Height - 4);	//	Draw left hand line

			pencil = new Pen(borderColor[1]);
			g.DrawLine(pencil, this.Width - 9, 2, this.Width - 9,this.Height - 3);	//	Draw right hand line
			g.DrawLine(pencil, this.Width - 9,this.Height - 3, 9,this.Height - 3);	//	Draw bottome line

			pencil = new Pen(borderColor[2]);
			g.DrawRectangle(pencil, 10, 3, this.Width - 20, this.Height - 7);	//	Draw inner black rectangle
		}


		/// <summary>
		/// Evaluates the DrawStyle of the control and calls the appropriate
		/// drawing function for content
		/// </summary>
		private void DrawContent(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					Draw_Style_Hue(g);
					break;
				case eDrawStyle.Saturation :
					Draw_Style_Saturation(g);
					break;
				case eDrawStyle.Brightness :
					Draw_Style_Luminance(g);
					break;
				case eDrawStyle.Red :
					Draw_Style_Red(g);
					break;
				case eDrawStyle.Green :
					Draw_Style_Green(g);
					break;
				case eDrawStyle.Blue :
					Draw_Style_Blue(g);
					break;
			}
		}


		#region Draw_Style_X - Content drawing functions

		//	The following functions do the real work of the control, drawing the primary content (the area between the slider)
		//	

		/// <summary>
		/// Fills in the content of the control showing all values of Hue (from 0 to 360)
		/// </summary>
		private void Draw_Style_Hue(Graphics g)
		{
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			ColorConverters.HSL _hsl = new ColorConverters.HSL();
			_hsl.S = 1.0;	//	S and L will both be at 100% for this DrawStyle
			_hsl.L = 1.0;

			for ( int i = 0; i < this.Height - 8; i++ )	//	i represents the current line of pixels we want to draw horizontally
			{
				_hsl.H = 1.0 - (double)i/(this.Height - 8);			//	H (hue) is based on the current vertical position
				Pen pen = new Pen(ColorConverters.HSL_to_RGB(_hsl));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);	//	Draw the line and loop back for next line
			}
		}


		/// <summary>
		/// Fills in the content of the control showing all values of Saturation (0 to 100%) for the given
		/// Hue and Luminance.
		/// </summary>
		private void Draw_Style_Saturation(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            
            ColorConverters.HSL _hsl = new ColorConverters.HSL();
			_hsl.H = m_hsl.H;	//	Use the H and L values of the current color (m_hsl)
			_hsl.L = m_hsl.L;

			for ( int i = 0; i < this.Height - 8; i++ ) //	i represents the current line of pixels we want to draw horizontally
			{
				_hsl.S = 1.0 - (double)i/(this.Height - 8);			//	S (Saturation) is based on the current vertical position
				Pen pen = new Pen(ColorConverters.HSL_to_RGB(_hsl));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);	//	Draw the line and loop back for next line
			}
		}


		/// <summary>
		/// Fills in the content of the control showing all values of Luminance (0 to 100%) for the given
		/// Hue and Saturation.
		/// </summary>
		private void Draw_Style_Luminance(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            ColorConverters.HSL _hsl = new ColorConverters.HSL();
			_hsl.H = m_hsl.H;	//	Use the H and S values of the current color (m_hsl)
			_hsl.S = m_hsl.S;

			for ( int i = 0; i < this.Height - 8; i++ ) //	i represents the current line of pixels we want to draw horizontally
			{
				_hsl.L = 1.0 - (double)i/(this.Height - 8);			//	L (Luminance) is based on the current vertical position
				Pen pen = new Pen(ColorConverters.HSL_to_RGB(_hsl));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);	//	Draw the line and loop back for next line
			}
		}


		/// <summary>
		/// Fills in the content of the control showing all values of Red (0 to 255) for the given
		/// Green and Blue.
		/// </summary>
		private void Draw_Style_Red(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            for ( int i = 0; i < this.Height - 8; i++ ) //	i represents the current line of pixels we want to draw horizontally
			{
				int red = 255 - Round(255 * (double)i/(this.Height - 8));	//	red is based on the current vertical position
				Pen pen = new Pen(Color.FromArgb(red, m_rgb.G, m_rgb.B));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);			//	Draw the line and loop back for next line
			}
		}


		/// <summary>
		/// Fills in the content of the control showing all values of Green (0 to 255) for the given
		/// Red and Blue.
		/// </summary>
		private void Draw_Style_Green(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            for ( int i = 0; i < this.Height - 8; i++ ) //	i represents the current line of pixels we want to draw horizontally
			{
				int green = 255 - Round(255 * (double)i/(this.Height - 8));	//	green is based on the current vertical position
				Pen pen = new Pen(Color.FromArgb(m_rgb.R, green, m_rgb.B));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);			//	Draw the line and loop back for next line
			}
		}


		/// <summary>
		/// Fills in the content of the control showing all values of Blue (0 to 255) for the given
		/// Red and Green.
		/// </summary>
		private void Draw_Style_Blue(Graphics g)
		{
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            for ( int i = 0; i < this.Height - 8; i++ ) //	i represents the current line of pixels we want to draw horizontally
			{
				int blue = 255 - Round(255 * (double)i/(this.Height - 8));	//	green is based on the current vertical position
				Pen pen = new Pen(Color.FromArgb(m_rgb.R, m_rgb.G, blue));	//	Get the Color for this line

				g.DrawLine(pen, 11, i + 4, this.Width - 11, i + 4);			//	Draw the line and loop back for next line
			}
		}


		#endregion

		/// <summary>
		/// Calls all the functions neccessary to redraw the entire control.
		/// </summary>
		private void Redraw_Control(Graphics g)
		{
			DrawSlider(m_iMarker_Start_Y, true,g);
			DrawBorder(g);

            switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					Draw_Style_Hue(g);
					break;
				case eDrawStyle.Saturation :
					Draw_Style_Saturation(g);
					break;
				case eDrawStyle.Brightness :
					Draw_Style_Luminance(g);
					break;
				case eDrawStyle.Red :
					Draw_Style_Red(g);
					break;
				case eDrawStyle.Green :
					Draw_Style_Green(g);
					break;
				case eDrawStyle.Blue :
					Draw_Style_Blue(g);
					break;
			}
		}


		/// <summary>
		/// Resets the vertical position of the slider to match the controls color.  Gives the option of redrawing the slider.
		/// </summary>
		/// <param name="Redraw">Set to true if you want the function to redraw the slider after determining the best position</param>
		private void Reset_Slider(bool Redraw, Graphics g)
		{
			//	The position of the marker (slider) changes based on the current drawstyle:
			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * m_hsl.H );
					break;
				case eDrawStyle.Saturation :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * m_hsl.S );
					break;
				case eDrawStyle.Brightness :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * m_hsl.L );
					break;
				case eDrawStyle.Red :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * (double)m_rgb.R/255 );
					break;
				case eDrawStyle.Green :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * (double)m_rgb.G/255 );
					break;
				case eDrawStyle.Blue :
					m_iMarker_Start_Y = (this.Height - 8) - Round( (this.Height - 8) * (double)m_rgb.B/255 );
					break;
			}

            //if (Redraw)
            //    DrawSlider(m_iMarker_Start_Y, true, g);
        }


		/// <summary>
		/// Resets the controls color (both HSL and RGB variables) based on the current slider position
		/// </summary>
		private void ResetHSLRGB()
		{
			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					m_hsl.H = 1.0 - (double)m_iMarker_Start_Y/(this.Height - 9);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Saturation :
					m_hsl.S = 1.0 - (double)m_iMarker_Start_Y/(this.Height - 9);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Brightness :
					m_hsl.L = 1.0 - (double)m_iMarker_Start_Y/(this.Height - 9);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Red :
					m_rgb = Color.FromArgb(255 - Round( 255 * (double)m_iMarker_Start_Y/(this.Height - 9) ), m_rgb.G, m_rgb.B);
					m_hsl = ColorConverters.RGB_to_HSL(m_rgb);
					break;
				case eDrawStyle.Green :
					m_rgb = Color.FromArgb(m_rgb.R, 255 - Round( 255 * (double)m_iMarker_Start_Y/(this.Height - 9) ), m_rgb.B);
					m_hsl = ColorConverters.RGB_to_HSL(m_rgb);
					break;
				case eDrawStyle.Blue :
					m_rgb = Color.FromArgb(m_rgb.R, m_rgb.G, 255 - Round( 255 * (double)m_iMarker_Start_Y/(this.Height - 9) ));
					m_hsl = ColorConverters.RGB_to_HSL(m_rgb);
					break;
			}
		}


		/// <summary>
		/// Kindof self explanitory, I really need to look up the .NET function that does this.
		/// </summary>
		/// <param name="val">double value to be rounded to an integer</param>
		/// <returns></returns>
		private int Round(double val)
		{
			int ret_val = (int)val;
			
			int temp = (int)(val * 100);

			if ( (temp % 100) >= 50 )
				ret_val += 1;

			return ret_val;
			
		}


        #endregion
        
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
