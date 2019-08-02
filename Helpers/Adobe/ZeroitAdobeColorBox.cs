/******************************************************************/
/*****                                                        *****/
/*****     Project:           Adobe Color Picker Clone 1      *****/
/*****     Filename:          ctrl2DColorBox.cs               *****/
/*****     Original Author:   Danny Blanchard                 *****/
/*****                        - scrabcakes@gmail.com          *****/
/*****     Updates:	                                          *****/
/*****      3/28/2005 - Initial Version : Danny Blanchard     *****/
/*****                                                        *****/
/******************************************************************/

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

namespace ZeroitDevColorPicker.Helpers.Adobe
{
	/// <summary>
	/// Summary description for ctrl2DColorBox.
	/// </summary>
	public class ZeroitAdobeColorBox : System.Windows.Forms.Control
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

		private int		m_iMarker_X = 0;
		private int		m_iMarker_Y = 0;
		private bool	m_bDragging = false;

		//	These variables keep track of how to fill in the content inside the box;
		private eDrawStyle		m_eDrawStyle = eDrawStyle.Hue;
		private ColorConverters.HSL	m_hsl;
		private Color			m_rgb;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        Point mouseLocation;

        private Color[] markerColor = { Color.White, Color.Black };

        private Color[] borderColor = { Color.FromArgb(172, 168, 153), Color.White, Color.Black};

        #endregion

        #region Constructors / Destructors

        public ZeroitAdobeColorBox()
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

        #region Public Properties

        public Color[] MarkerColor
        {
            get { return markerColor; }
            set
            {
                markerColor = value;
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

        #region Control Events

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseLocation = e.Location;
            
            if (e.Button != MouseButtons.Left)  //	Only respond to left mouse button events
                return;

            m_bDragging = true;     //	Begin dragging which notifies MouseMove function that it needs to update the marker

            Invalidate();

            if (Scroll != null) //	Notify anyone who cares that the controls marker (selected color) has changed
                Scroll(this, e);
        }
                
        private void CapsuleMover(Graphics g, Point mouse)
        {
            int x = mouse.X - 2, y = mouse.Y - 2;
            if (x < 0) x = 0;
            if (x > this.Width - 4) x = this.Width - 4; //	Calculate marker position
            if (y < 0) y = 0;
            if (y > this.Height - 4) y = this.Height - 4;

            if (x == m_iMarker_X && y == m_iMarker_Y)       //	If the marker hasn't moved, no need to redraw it.
                return;                                     //	or send a scroll notification

            DrawMarker(x, y, true, g);  //	Redraw the marker
            ResetHSLRGB();          //	Reset the color
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            base.OnMouseMove(e);

            mouseLocation = e.Location;

            if (!m_bDragging)       //	Only respond when the mouse is dragging the marker.
                return;

            Invalidate();
            
            if (Scroll != null) //	Notify anyone who cares that the controls marker (selected color) has changed
                Scroll(this, e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseLocation = e.Location;

            if (e.Button != MouseButtons.Left)  //	Only respond to left mouse button events
                return;

            if (!m_bDragging)
                return;

            m_bDragging = false;

            Invalidate();

            if (Scroll != null) //	Notify anyone who cares that the controls marker (selected color) has changed
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
            g.SmoothingMode = SmoothingMode.HighQuality;

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            //	Redraw the control based on the new color.
            Reset_Marker(true,g);
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
                //Reset_Marker(true);
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
				//Reset_Marker(true);
				//Redraw_Control();

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
                //Reset_Marker(true);
                //Redraw_Control();
                Invalidate();
			}
		}


		#endregion

		#region Private Methods

		/// <summary>
		/// Redraws only the content over the marker
		/// </summary>
		private void ClearMarker(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            //	Determine the area that needs to be redrawn
            int start_x, start_y, end_x, end_y;
			int red = 0; int green = 0; int blue = 0;
			ColorConverters.HSL hsl_start = new ColorConverters.HSL();
			ColorConverters.HSL hsl_end = new ColorConverters.HSL();

			//	Find the markers corners
			start_x = m_iMarker_X - 5;
			start_y = m_iMarker_Y - 5;
			end_x = m_iMarker_X + 5;
			end_y = m_iMarker_Y + 5;
			//	Adjust the area if part of it hangs outside the content area
			if ( start_x < 0 ) start_x = 0;
			if ( start_y < 0 ) start_y = 0;
			if ( end_x > this.Width - 4 ) end_x = this.Width - 4;
			if ( end_y > this.Height - 4 ) end_y = this.Height - 4;

			//	Redraw the content based on the current draw style:
			//	The code get's a little messy from here
			switch (m_eDrawStyle)
			{
					//		  S=0,S=1,S=2,S=3.....S=100
					//	L=100
					//	L=99
					//	L=98		Drawstyle
					//	L=97		   Hue
					//	...
					//	L=0
				case eDrawStyle.Hue :	

					hsl_start.H = m_hsl.H;	hsl_end.H = m_hsl.H;	//	Hue is constant
					hsl_start.S = (double)start_x/(this.Width - 4);	//	Because we're drawing horizontal lines, s will not change
					hsl_end.S = (double)end_x/(this.Width - 4);		//	from line to line

					for ( int i = start_y; i <= end_y; i++ )		//	For each horizontal line:
					{
						hsl_start.L = 1.0 - (double)i/(this.Height - 4);	//	Brightness (L) WILL change for each horizontal
						hsl_end.L = hsl_start.L;							//	line drawn
				
						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(start_x + 1,i + 2, end_x - start_x + 1, 1), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 0, false); 
						g.FillRectangle(br,new Rectangle(start_x + 2,i + 2, end_x - start_x + 1 , 1)); 
					}
					
					break;
					//		  H=0,H=1,H=2,H=3.....H=360
					//	L=100
					//	L=99
					//	L=98		Drawstyle
					//	L=97		Saturation
					//	...
					//	L=0
				case eDrawStyle.Saturation :

					hsl_start.S = m_hsl.S;	hsl_end.S = m_hsl.S;			//	Saturation is constant
					hsl_start.L = 1.0 - (double)start_y/(this.Height - 4);	//	Because we're drawing vertical lines, L will 
					hsl_end.L = 1.0 - (double)end_y/(this.Height - 4);		//	not change from line to line

					for ( int i = start_x; i <= end_x; i++ )				//	For each vertical line:
					{
						hsl_start.H = (double)i/(this.Width - 4);			//	Hue (H) WILL change for each vertical
						hsl_end.H = hsl_start.H;							//	line drawn
				
						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(i + 2,start_y + 1, 1, end_y - start_y + 2), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 90, false); 
						g.FillRectangle(br,new Rectangle(i + 2, start_y + 2, 1, end_y - start_y + 1)); 
					}
					break;
					//		  H=0,H=1,H=2,H=3.....H=360
					//	S=100
					//	S=99
					//	S=98		Drawstyle
					//	S=97		Brightness
					//	...
					//	S=0
				case eDrawStyle.Brightness :
					
					hsl_start.L = m_hsl.L;	hsl_end.L = m_hsl.L;			//	Luminance is constant
					hsl_start.S = 1.0 - (double)start_y/(this.Height - 4);	//	Because we're drawing vertical lines, S will 
					hsl_end.S = 1.0 - (double)end_y/(this.Height - 4);		//	not change from line to line

					for ( int i = start_x; i <= end_x; i++ )				//	For each vertical line:
					{
						hsl_start.H = (double)i/(this.Width - 4);			//	Hue (H) WILL change for each vertical
						hsl_end.H = hsl_start.H;							//	line drawn
				
						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(i + 2,start_y + 1, 1, end_y - start_y + 2), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 90, false); 
						g.FillRectangle(br,new Rectangle(i + 2, start_y + 2, 1, end_y - start_y + 1)); 
					}

					break;
					//		  B=0,B=1,B=2,B=3.....B=100
					//	G=100
					//	G=99
					//	G=98		Drawstyle
					//	G=97		   Red
					//	...
					//	G=0
				case eDrawStyle.Red :
					
					red = m_rgb.R;													//	Red is constant
					int start_b = Round(255 * (double)start_x/(this.Width - 4));	//	Because we're drawing horizontal lines, B
					int end_b = Round(255 * (double)end_x/(this.Width - 4));		//	will not change from line to line

					for ( int i = start_y; i <= end_y; i++ )						//	For each horizontal line:
					{
						green = Round(255 - (255 * (double)i/(this.Height - 4)));	//	green WILL change for each horizontal line drawn

						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(start_x + 1,i + 2, end_x - start_x + 1, 1), Color.FromArgb(red, green, start_b), Color.FromArgb(red, green, end_b), 0, false); 
						g.FillRectangle(br,new Rectangle(start_x + 2,i + 2, end_x - start_x + 1 , 1));  
					}

					break;
					//		  B=0,B=1,B=2,B=3.....B=100
					//	R=100
					//	R=99
					//	R=98		Drawstyle
					//	R=97		  Green
					//	...
					//	R=0
				case eDrawStyle.Green :
					
					green = m_rgb.G;;												//	Green is constant
					int start_b2 = Round(255 * (double)start_x/(this.Width - 4));	//	Because we're drawing horizontal lines, B
					int end_b2 = Round(255 * (double)end_x/(this.Width - 4));		//	will not change from line to line

					for ( int i = start_y; i <= end_y; i++ )						//	For each horizontal line:
					{
						red = Round(255 - (255 * (double)i/(this.Height - 4)));		//	red WILL change for each horizontal line drawn

						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(start_x + 1,i + 2, end_x - start_x + 1, 1), Color.FromArgb(red, green, start_b2), Color.FromArgb(red, green, end_b2), 0, false); 
						g.FillRectangle(br,new Rectangle(start_x + 2,i + 2, end_x - start_x + 1 , 1)); 
					}

					break;
					//		  R=0,R=1,R=2,R=3.....R=100
					//	G=100
					//	G=99
					//	G=98		Drawstyle
					//	G=97		   Blue
					//	...
					//	G=0
				case eDrawStyle.Blue :
					
					blue = m_rgb.B;;												//	Blue is constant
					int start_r = Round(255 * (double)start_x/(this.Width - 4));	//	Because we're drawing horizontal lines, R
					int end_r = Round(255 * (double)end_x/(this.Width - 4));		//	will not change from line to line

					for ( int i = start_y; i <= end_y; i++ )						//	For each horizontal line:
					{
						green = Round(255 - (255 * (double)i/(this.Height - 4)));	//	green WILL change for each horizontal line drawn

						LinearGradientBrush br = new LinearGradientBrush(new Rectangle(start_x + 1,i + 2, end_x - start_x + 1, 1), Color.FromArgb(start_r, green, blue), Color.FromArgb(end_r, green, blue), 0, false); 
						g.FillRectangle(br,new Rectangle(start_x + 2,i + 2, end_x - start_x + 1 , 1)); 
					}

					break;
			}
		}


		/// <summary>
		/// Draws the marker (circle) inside the box
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="Unconditional"></param>
		private void DrawMarker(int x, int y, bool Unconditional, Graphics g)			//	   *****
		{
            g.SmoothingMode = SmoothingMode.HighQuality;
            //	  *  |  *
			if ( x < 0 ) x = 0;												//	 *   |   *
			if ( x > this.Width - 4 ) x = this.Width - 4;					//	*    |    *
			if ( y < 0 ) y = 0;												//	*    |    *
			if ( y > this.Height - 4 ) y = this.Height - 4;					//	*----X----*
			//	*    |    *
			if ( m_iMarker_Y == y && m_iMarker_X == x && !Unconditional )	//	*    |    *
				return;														//	 *   |   *
			//	  *  |  *
			ClearMarker(g);													//	   *****

			m_iMarker_X = x;
			m_iMarker_Y = y;

			//Graphics g = this.CreateGraphics();

			Pen pen;
			ColorConverters.HSL _hsl = GetColor(x,y);	//	The selected color determines the color of the marker drawn over
			//	it (black or white)
			if ( _hsl.L < (double)200/255 )
				pen = new Pen(markerColor[0]);									//	White marker if selected color is dark
			else if ( _hsl.H < (double)26/360 || _hsl.H > (double)200/360 )
				if ( _hsl.S > (double)70/255 )
					pen = new Pen(markerColor[0]);
				else
					pen = new Pen(markerColor[1]);								//	Else use a black marker for lighter colors
			else
				pen = new Pen(markerColor[1]);

			g.DrawEllipse(pen, x - 3, y - 3, 10, 10);						//	Draw the marker : 11 x 11 circle

			DrawBorder(g);		//	Force the border to be redrawn, just in case the marker has been drawn over it.
		}


		/// <summary>
		/// Draws the border around the control.
		/// </summary>
		private void DrawBorder(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            Pen pencil;
			
			//	To make the control look like Adobe Photoshop's the border around the control will be a gray line
			//	on the top and left side, a white line on the bottom and right side, and a black rectangle (line) 
			//	inside the gray/white rectangle

			pencil = new Pen(borderColor[0]);	//	The same gray color used by Photoshop
			g.DrawLine(pencil, this.Width - 2, 0, 0, 0);	//	Draw top line
			g.DrawLine(pencil, 0, 0, 0, this.Height - 2);	//	Draw left hand line

			pencil = new Pen(borderColor[1]);
			g.DrawLine(pencil, this.Width - 1, 0, this.Width - 1,this.Height - 1);	//	Draw right hand line
			g.DrawLine(pencil, this.Width - 1,this.Height - 1, 0,this.Height - 1);	//	Draw bottome line

			pencil = new Pen(borderColor[2]);
			g.DrawRectangle(pencil, 1, 1, this.Width - 3, this.Height - 3);	//	Draw inner black rectangle
		}


		/// <summary>
		/// Evaluates the DrawStyle of the control and calls the appropriate
		/// drawing function for content
		/// </summary>
		private void DrawContent(Graphics g)
		{
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
		/// Draws the content of the control filling in all color values with the provided Hue value.
		/// </summary>
		private void Draw_Style_Hue(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            ColorConverters.HSL hsl_start = new ColorConverters.HSL();
			ColorConverters.HSL hsl_end = new ColorConverters.HSL();
			hsl_start.H = m_hsl.H;
			hsl_end.H = m_hsl.H;
			hsl_start.S = 0.0;
			hsl_end.S = 1.0;

			for ( int i = 0; i < this.Height - 4; i++ )				//	For each horizontal line in the control:
			{
				hsl_start.L = 1.0 - (double)i/(this.Height - 4);	//	Calculate luminance at this line (Hue and Saturation are constant)
				hsl_end.L = hsl_start.L;
				
				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, this.Width - 4, 1), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 0, false); 
				g.FillRectangle(br,new Rectangle(2,i + 2, this.Width - 4, 1)); 
			}
		}


		/// <summary>
		/// Draws the content of the control filling in all color values with the provided Saturation value.
		/// </summary>
		private void Draw_Style_Saturation(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            ColorConverters.HSL hsl_start = new ColorConverters.HSL();
			ColorConverters.HSL hsl_end = new ColorConverters.HSL();
			hsl_start.S = m_hsl.S;
			hsl_end.S = m_hsl.S;
			hsl_start.L = 1.0;
			hsl_end.L = 0.0;

			for ( int i = 0; i < this.Width - 4; i++ )		//	For each vertical line in the control:
			{
				hsl_start.H = (double)i/(this.Width - 4);	//	Calculate Hue at this line (Saturation and Luminance are constant)
				hsl_end.H = hsl_start.H;
				
				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, 1, this.Height - 4), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 90, false); 
				g.FillRectangle(br,new Rectangle(i + 2, 2, 1, this.Height - 4)); 
			}
		}


		/// <summary>
		/// Draws the content of the control filling in all color values with the provided Luminance or Brightness value.
		/// </summary>
		private void Draw_Style_Luminance(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            ColorConverters.HSL hsl_start = new ColorConverters.HSL();
			ColorConverters.HSL hsl_end = new ColorConverters.HSL();
			hsl_start.L = m_hsl.L;
			hsl_end.L = m_hsl.L;
			hsl_start.S = 1.0;
			hsl_end.S = 0.0;

			for ( int i = 0; i < this.Width - 4; i++ )		//	For each vertical line in the control:
			{
				hsl_start.H = (double)i/(this.Width - 4);	//	Calculate Hue at this line (Saturation and Luminance are constant)
				hsl_end.H = hsl_start.H;
				
				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, 1, this.Height - 4), ColorConverters.HSL_to_RGB(hsl_start), ColorConverters.HSL_to_RGB(hsl_end), 90, false); 
				g.FillRectangle(br,new Rectangle(i + 2, 2, 1, this.Height - 4)); 
			}
		}


		/// <summary>
		/// Draws the content of the control filling in all color values with the provided Red value.
		/// </summary>
		private void Draw_Style_Red(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            int red = m_rgb.R;;

			for ( int i = 0; i < this.Height - 4; i++ )				//	For each horizontal line in the control:
			{
				//	Calculate Green at this line (Red and Blue are constant)
				int green = Round(255 - (255 * (double)i/(this.Height - 4)));

				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, this.Width - 4, 1), Color.FromArgb(red, green, 0), Color.FromArgb(red, green, 255), 0, false); 
				g.FillRectangle(br,new Rectangle(2,i + 2, this.Width - 4, 1)); 
			}
		}


		/// <summary>
		/// Draws the content of the control filling in all color values with the provided Green value.
		/// </summary>
		private void Draw_Style_Green(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            int green = m_rgb.G;;

			for ( int i = 0; i < this.Height - 4; i++ )	//	For each horizontal line in the control:
			{
				//	Calculate Red at this line (Green and Blue are constant)
				int red = Round(255 - (255 * (double)i/(this.Height - 4)));

				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, this.Width - 4, 1), Color.FromArgb(red, green, 0), Color.FromArgb(red, green, 255), 0, false); 
				g.FillRectangle(br,new Rectangle(2,i + 2, this.Width - 4, 1)); 
			}
		}


		/// <summary>
		/// Draws the content of the control filling in all color values with the provided Blue value.
		/// </summary>
		private void Draw_Style_Blue(Graphics g)
		{
			//Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

			int blue = m_rgb.B;;

			for ( int i = 0; i < this.Height - 4; i++ )	//	For each horizontal line in the control:
			{
				//	Calculate Green at this line (Red and Blue are constant)
				int green = Round(255 - (255 * (double)i/(this.Height - 4)));

				LinearGradientBrush br = new LinearGradientBrush(new Rectangle(2,2, this.Width - 4, 1), Color.FromArgb(0, green, blue), Color.FromArgb(255, green, blue), 0, false); 
				g.FillRectangle(br,new Rectangle(2,i + 2, this.Width - 4, 1)); 
			}
		}


		/// <summary>
		/// Calls all the functions neccessary to redraw the entire control.
		/// </summary>
		private void Redraw_Control(Graphics g)
		{
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

			DrawMarker(m_iMarker_X, m_iMarker_Y, true,g);
		}


		/// <summary>
		/// Resets the marker position of the slider to match the controls color.  Gives the option of redrawing the slider.
		/// </summary>
		/// <param name="Redraw">Set to true if you want the function to redraw the slider after determining the best position</param>
		private void Reset_Marker(bool Redraw, Graphics g)
		{
			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					m_iMarker_X = Round((this.Width - 4) * m_hsl.S);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - m_hsl.L));
					break;
				case eDrawStyle.Saturation :
					m_iMarker_X = Round((this.Width - 4) * m_hsl.H);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - m_hsl.L));
					break;
				case eDrawStyle.Brightness :
					m_iMarker_X = Round((this.Width - 4) * m_hsl.H);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - m_hsl.S));
					break;
				case eDrawStyle.Red :
					m_iMarker_X = Round((this.Width - 4) * (double)m_rgb.B/255);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - (double)m_rgb.G/255));
					break;
				case eDrawStyle.Green :
					m_iMarker_X = Round((this.Width - 4) * (double)m_rgb.B/255);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - (double)m_rgb.R/255));
					break;
				case eDrawStyle.Blue :
					m_iMarker_X = Round((this.Width - 4) * (double)m_rgb.R/255);
					m_iMarker_Y = Round((this.Height - 4) * (1.0 - (double)m_rgb.G/255));
					break;
			}

			if ( Redraw )
				DrawMarker(m_iMarker_X, m_iMarker_Y, true,g);
		}


		/// <summary>
		/// Resets the controls color (both HSL and RGB variables) based on the current marker position
		/// </summary>
		private void ResetHSLRGB()
		{
			int red, green, blue;

			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					m_hsl.S = (double)m_iMarker_X/(this.Width - 4);
					m_hsl.L = 1.0 - (double)m_iMarker_Y/(this.Height - 4);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Saturation :
					m_hsl.H = (double)m_iMarker_X/(this.Width - 4);
					m_hsl.L = 1.0 - (double)m_iMarker_Y/(this.Height - 4);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Brightness :
					m_hsl.H = (double)m_iMarker_X/(this.Width - 4);
					m_hsl.S = 1.0 - (double)m_iMarker_Y/(this.Height - 4);
					m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
					break;
				case eDrawStyle.Red :
					blue = Round(255 * (double)m_iMarker_X/(this.Width - 4));
					green = Round(255 * (1.0 - (double)m_iMarker_Y/(this.Height - 4)));
					m_rgb = Color.FromArgb(m_rgb.R, green, blue);
					m_hsl = ColorConverters.RGB_to_HSL(m_rgb);
					break;
				case eDrawStyle.Green :
					blue = Round(255 * (double)m_iMarker_X/(this.Width - 4));
					red = Round(255 * (1.0 - (double)m_iMarker_Y/(this.Height - 4)));
					m_rgb = Color.FromArgb(red, m_rgb.G, blue);
					m_hsl = ColorConverters.RGB_to_HSL(m_rgb);
					break;
				case eDrawStyle.Blue :
					red = Round(255 * (double)m_iMarker_X/(this.Width - 4));
					green = Round(255 * (1.0 - (double)m_iMarker_Y/(this.Height - 4)));
					m_rgb = Color.FromArgb(red, green, m_rgb.B);
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


		/// <summary>
		/// Returns the graphed color at the x,y position on the control
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		private ColorConverters.HSL GetColor(int x, int y)
		{

			ColorConverters.HSL _hsl = new ColorConverters.HSL();

			switch (m_eDrawStyle)
			{
				case eDrawStyle.Hue :
					_hsl.H = m_hsl.H;
					_hsl.S = (double)x/(this.Width - 4);
					_hsl.L = 1.0 - (double)y/(this.Height - 4);
					break;
				case eDrawStyle.Saturation :
					_hsl.S = m_hsl.S;
					_hsl.H = (double)x/(this.Width - 4);
					_hsl.L = 1.0 - (double)y/(this.Height - 4);
					break;
				case eDrawStyle.Brightness :
					_hsl.L = m_hsl.L;
					_hsl.H = (double)x/(this.Width - 4);
					_hsl.S = 1.0 - (double)y/(this.Height - 4);
					break;
				case eDrawStyle.Red :
					_hsl = ColorConverters.RGB_to_HSL(Color.FromArgb(m_rgb.R, Round(255 * (1.0 - (double)y/(this.Height - 4))), Round(255 * (double)x/(this.Width - 4))));
					break;
				case eDrawStyle.Green :
					_hsl = ColorConverters.RGB_to_HSL(Color.FromArgb(Round(255 * (1.0 - (double)y/(this.Height - 4))), m_rgb.G, Round(255 * (double)x/(this.Width - 4))));
					break;
				case eDrawStyle.Blue :
					_hsl = ColorConverters.RGB_to_HSL(Color.FromArgb(Round(255 * (double)x/(this.Width - 4)), Round(255 * (1.0 - (double)y/(this.Height - 4))), m_rgb.B));
					break;
			}

			return _hsl;
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
