using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

//using Zeroit.Framework.ColorPicker.Adobe.Simple.ColorManagement.ColorModels;
namespace ZeroitDevColorPicker.Helpers.Fader
{
	[DefaultEvent("PositionChanged")]
	public class ColorFader:Control
	{
        #region variables

        HatchStyle hatchStyle = HatchStyle.LargeCheckerBoard;

        Color[] checkerColor = { Color.Silver, Color.White };
        Color[] gridColor = { Color.Black, Color.Transparent };

        LinearGradientBrush _grd;

        Color borderColor = Color.Gray;
        int borderWidth = 1;

        float maximum = 100;
        float minimum = 0;
        
        //painting

        //control
        private Orientation _orientation=Orientation.Horizontal;
		private float _position=50;
		private bool _highlighted=false;
		private FadeType _fadetype=FadeType.Internal;
		#endregion
		/// <summary>
		/// ctor
		/// </summary>
		public ColorFader()
		{
			this.SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.DoubleBuffer |
				ControlStyles.ResizeRedraw |
				ControlStyles.UserPaint, true);

            _grd= new LinearGradientBrush(new Point(0, 0), new Point(1, 0), gridColor[0], gridColor[1]);
        }

		#region controller
		//paint slider
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

            //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            
            HatchBrush _checker = new HatchBrush(hatchStyle, checkerColor[0], checkerColor[1]);
            _grd = new LinearGradientBrush(new Point(0, 0), new Point(1, 0), gridColor[0], gridColor[1]);

            Rectangle bandrct=this.GetBandRectangle();
			if(bandrct.Width<1|| bandrct.Height<1) return;
			//forecolor adjust
			Color forecolor=
				this._fadetype==FadeType.Internal?
				ColorUtility.AoverB(this.GetSelectedColor(),Color.Silver)://blended with checker
				base.BackColor;
			if(_highlighted)
				forecolor=ColorUtility.MaxContrastRBTo(forecolor);//color
			else
				forecolor=ColorUtility.MaxContrastTo(forecolor);//blackwhite
			float position;
			//start painting
			switch(_orientation)
			{
				case Orientation.Horizontal:
					#region horizontal
					//horizontal stretching
					_grd.Transform=new Matrix(
						(float)bandrct.Width+2f,0f,0f,1f,(float)bandrct.X-1f,0f);
					//fill band
					e.Graphics.FillRectangle(_checker,bandrct);
					e.Graphics.FillRectangle(_grd,bandrct);
					//draw position
					e.Graphics.SmoothingMode=SmoothingMode.AntiAlias;
					position= (float)(bandrct.X+(bandrct.Width*_position)/Maximum);
					if(_fadetype==FadeType.External)//triangle select
					{
						using (SolidBrush sld=new SolidBrush(forecolor))
						{
							e.Graphics.FillPolygon(sld,new Point[]{//upper triangle
																	  new Point(Convert.ToInt32(position) + 3 ,0),
																	  new Point(Convert.ToInt32(position),5),
																	  new Point(Convert.ToInt32(position)-3,0)
																  });
							e.Graphics.FillPolygon(sld,new Point[]{//lower triangle
																	  new Point(Convert.ToInt32(position)+3,this.Height-1),
																	  new Point(Convert.ToInt32(position),this.Height-6),
																	  new Point(Convert.ToInt32(position)-3,this.Height-1)
																  });
						}
					}
					else//bracket select
					{
						using (Pen pn=new Pen(forecolor))
						{
							e.Graphics.DrawLines(pn,new Point[]{//left bracket
																   new Point(Convert.ToInt32(position)-1,0),
																   new Point(Convert.ToInt32(position)-3,0),
																   new Point(Convert.ToInt32(position)-3,this.Height-1),
																   new Point(Convert.ToInt32(position)-1,this.Height-1)
															   });
							e.Graphics.DrawLines(pn,new Point[]{//right bracket
																   new Point(Convert.ToInt32(position)+1,0),
																   new Point(Convert.ToInt32(position)+3,0),
																   new Point(Convert.ToInt32(position)+3,this.Height-1),
																   new Point(Convert.ToInt32(position)+1,this.Height-1)
															   });

						}
					}

					#endregion
					break;
				case Orientation.Vertical:
					#region vertical
					//horizontal stretching
					//vertical stretching and rotating
					_grd.Transform=new Matrix(
						0f,(float)bandrct.Width+2f,1f,0f,0f,(float)bandrct.Y+1f);
					//fill band
					e.Graphics.FillRectangle(_checker,bandrct);
					e.Graphics.FillRectangle(_grd,bandrct);
					//draw position
					e.Graphics.SmoothingMode=SmoothingMode.AntiAlias;
					position= ((float)bandrct.Y)+((float)bandrct.Height *(float)_position)/ (float)Maximum;
					if(_fadetype==FadeType.External)//triangle select
					{
						using (SolidBrush sld=new SolidBrush(forecolor))
						{
							e.Graphics.FillPolygon(sld,new Point[]{//left triangle
																	  new Point(0,Convert.ToInt32(position)+3),
																	  new Point(5,Convert.ToInt32(position)),
																	  new Point(0,Convert.ToInt32(position)-3)
																  });
							e.Graphics.FillPolygon(sld,new Point[]{//lower triangle
																	  new Point(this.Width-1,Convert.ToInt32(position)+3),
																	  new Point(this.Width-6,Convert.ToInt32(position)),
																	  new Point(this.Width-1,Convert.ToInt32(position)-3)
																  });
						}
					}
					else//bracket select
					{
						using (Pen pn=new Pen(forecolor))
						{
							e.Graphics.DrawLines(pn,new Point[]{//left bracket
																   new Point(0,Convert.ToInt32(position)-1),
																   new Point(0,Convert.ToInt32(position)-3),
																   new Point(this.Width-1,Convert.ToInt32(position)-3),
																   new Point(this.Width-1,Convert.ToInt32(position)-1)
															   });
							e.Graphics.DrawLines(pn,new Point[]{//right bracket
																   new Point(0,Convert.ToInt32(position)+1),
																   new Point(0,Convert.ToInt32(position)+3),
																   new Point(this.Width-1,Convert.ToInt32(position)+3),
																   new Point(this.Width-1,Convert.ToInt32(position)+1)
															   });

						}
					}
					#endregion
					break;
			}

            //e.Graphics.DrawRectangle(new Pen(BorderColor, BorderWidth),
            //    new Rectangle(this.ClientRectangle.X + BorderWidth, this.ClientRectangle.Y + BorderWidth,
            //    this.ClientRectangle.Width - (2 * BorderWidth), this.ClientRectangle.Height - (2 * BorderWidth)));

        }
        //stick to mouse
        protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown (e);
			SetPositionToPoint(new Point(e.X,e.Y));
		}
		//move slider
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove (e);
			if(e.Button!=MouseButtons.None)
			{
				if(SetPositionToPoint(new Point(e.X,e.Y)))
					RaiseScroll();
			}
		}
		//raise positionchanged
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp (e);
			if(SetPositionToPoint(new Point(e.X,e.Y)))
				RaisePositionChanged();
		}
		//set higlight
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter (e);
			this._highlighted=true;
			this.Refresh();
		}
		//reset higlight
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave (e);
			this._highlighted=false;
			this.Refresh();
		}
		#endregion
		
        #region members
		/// <summary>
		/// gets the rectangle of the slider
		/// </summary>
		public Rectangle GetBandRectangle()
		{
			Rectangle ret=this.ClientRectangle;
			if(_fadetype==FadeType.External)
			{
				if(_orientation==Orientation.Horizontal)
					ret.Inflate(-4,-5);
				else
					ret.Inflate(-5,-4);
			}
			return ret;
		}
		/// <summary>
		/// sets the slider position to the specified point and returns TRUE if successful
		/// </summary>
		public bool SetPositionToPoint(Point clientpos)
		{
			Rectangle bandrct=GetBandRectangle();
			float pos;
			if(_orientation==Orientation.Horizontal)
			{
				if(bandrct.Width<2) return false;

				pos=Math.Max(Minimum,Math.Min(Maximum,
					((clientpos.X-bandrct.X)*Maximum)/bandrct.Width));
			}
			else
			{
				if(bandrct.Height<2) return false;

				pos=Math.Max(Minimum,Math.Min(Maximum,
					((clientpos.Y-bandrct.Y)*Maximum)/bandrct.Height));
			}
			if(pos!=_position)
			{
				_position=pos;
				this.Refresh();
				return true;
			}
			return false;
		}
		/// <summary>
		/// gets the color the slider is at
		/// </summary>
		public Color GetSelectedColor()
		{
			return ColorUtility.BlendOver(
				this.FirstColor,
				this.SecondColor,
				(float)_position/100f);
		}
        #endregion

        #region properties

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        public HatchStyle HatchStyle
        {
            get { return hatchStyle; }
            set
            {
                hatchStyle = value;
                Invalidate();
            }
        }

        public new Color[] BackColor
        {
            get { return checkerColor; }
            set
            {
                checkerColor = value;
                Invalidate();
            }
        }

        public Color[] GridColor
        {
            get { return gridColor; }
            set
            {
                gridColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// gets or sets the orientation of the fader
        /// </summary>
        [Category("ColorFader properties"),
		Description("gets or sets the orientation of the fader"),
		DefaultValue(typeof(Orientation),"Horizontal")]
		public Orientation Orientation
		{
			get{return _orientation;}
			set
			{
				if(_orientation==value) return;
				_orientation=value;
				this.Refresh();
			}
		}
		/// <summary>
		/// gets or sets the fader type
		/// </summary>
		[Category("ColorFader properties"),
		Description("gets or sets the fader type"),
		DefaultValue(typeof(FadeType),"Internal")]
		public FadeType FadeType
		{
			get{return _fadetype;}
			set
			{
				if(_fadetype==value) return;
				_fadetype=value;
				this.Refresh();
			}
		}

        public float Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                Invalidate();
            }
        }

        public float Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                Invalidate();
            }
        }

		/// <summary>
		/// gets or sets the position of the fader (0-100)
		/// </summary>
		[Category("ColorFader properties"),
		Description("gets or sets the position of the fader (0-100)"),
		DefaultValue(50)]
		public float Position
		{
			get{return _position;}
			set
			{
				value=Math.Max(Minimum,Math.Min(Maximum,value));
				if(_position==value) return;
				_position=value;
				this.Refresh();
			}
		}
		/// <summary>
		/// gets or sets the color that is displayed at top or respectively at left end
		/// </summary>
		[Category("ColorFader properties"),
		Description("gets or sets the color that is displayed at top or respectively at left end"),
		DefaultValue(typeof(Color),"0,0,0")]

		public Color FirstColor
		{
			get{return _grd.LinearColors[0];}
			set
			{
				if(_grd.LinearColors[0]==value) return;
				_grd.LinearColors=new Color[]{
													  value,
													  _grd.LinearColors[1]
												  };
				this.Refresh();
			}
		}
		/// <summary>
		/// gets or sets the color that is displayed at bottom or respectively at right end
		/// </summary>
		[Category("ColorFader properties"),
		Description("gets or sets the color that is displayed at bottom or respectively at right end"),
		DefaultValue(typeof(Color),"0,255,255,255")]
		public Color SecondColor
		{
			get{return _grd.LinearColors[1];}
			set
			{
				if(_grd.LinearColors[1]==value) return;
				_grd.LinearColors=new Color[]{
													  _grd.LinearColors[0],
													  value
												  };
				this.Refresh();
			}
		}
		#endregion
		
        #region events
		//scrolling is while the mouse is moving
		private void RaiseScroll()
		{
			if(this.Scroll!=null)
				this.Scroll(this,EventArgs.Empty);
		}
		public event EventHandler Scroll;
		//positionchanged is when the position is dropped
		private void RaisePositionChanged()
		{
			if(this.PositionChanged!=null)
				this.PositionChanged(this,EventArgs.Empty);
		}
		public event EventHandler PositionChanged;
		#endregion
	}
	
    /// <summary>
	/// the display type of colorfader control
	/// </summary>
	public enum FadeType
	{
		/// <summary>
		/// fade position is displayed through two brackets
		/// </summary>
		Internal=0,
		/// <summary>
		/// fade band is smaller and fade position is displayed
		/// trough two triangles
		/// </summary>
		External=1
	}
}
