using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ZeroitDevColorPicker.Helpers.Colors.WikiColors;


namespace ZeroitDevColorPicker
{
    public partial class Main : Form
    {

        #region Private Fields

        private ColorConverters.HSL m_hsl = new ColorConverters.HSL();

        private ColorConverters.CMYK m_cmyk = new ColorConverters.CMYK();

        private Color m_rgb;

        string m_H = String.Empty;

        string m_S = String.Empty;

        string m_V = String.Empty;

        string m_L = String.Empty;

        string m_a = String.Empty;

        string m_b = String.Empty;

        string m_X = String.Empty;

        string m_Y = String.Empty;

        string m_Z = String.Empty;

        private bool hoveringState = false;

        private Settings settingsForm = new Settings();

        private SelectorForm selectorForm = new SelectorForm();

        private FollowTextForm followTextForm = new FollowTextForm();

        private SelectorFormSecond selectorFormSecond = new SelectorFormSecond();

        Point mouseLocation;

        private bool down = false;

        private List<Color> lastColor = new List<Color>();

        private bool searchVisible = false;
        
        #endregion
        
        #region Constructor

        public Main()
        {
            InitializeComponent();

            error.Icon = Properties.Resources.error1;

            Size = new Size(798, 246);

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), Screen.PrimaryScreen.WorkingArea.Y + (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));

            //	Initialize Colors            
            m_hsl.H = 1.0;
            m_hsl.S = 1.0;
            m_hsl.L = 1.0;
            m_rgb = ColorConverters.HSL_to_RGB(m_hsl);
            m_cmyk = ColorConverters.RGB_to_CMYK(m_rgb);

            Color color = SColor.BackColor;
            try
            {
                m_H = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).H).ToString();
                m_S = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).S).ToString();
                m_V = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).V).ToString();

                m_L = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.R, color.B, (float)scaleValue.Value).L).ToString();
                m_a = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.G, color.B, (float)scaleValue.Value).A).ToString();
                m_b = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.G, color.B, (float)scaleValue.Value).B).ToString();

                m_X = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).X).ToString();
                m_Y = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).Y).ToString();
                m_Z = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).Z).ToString();

            }
            catch (Exception)
            {


            }


            m_txt_H.Text = m_H;
            m_txt_S.Text = m_S;
            m_txt_V.Text = m_V;
            m_txt_L.Text = m_L;
            m_txt_a.Text = m_a;
            m_txt_b.Text = m_b;
            m_txt_X.Text = m_X;
            m_txt_Y.Text = m_Y;
            m_txt_Z.Text = m_Z;

            MagnifyingGlass.UseWin32Api = true;
            
            this.Zoom = 8;
            this.Color = Color.Empty;
            this.ShowTextWithSnapshot = false;
            this.ShowGrid = true;
            this.GridColor = SystemColors.ControlDark;
                        
            savedColors.Columns.Add("Name");
            savedColors.Columns.Add("RGB");
            savedColors.Columns.Add("HTML");
            savedColors.Columns.Add("HSL");
            savedColors.Columns.Add("HSV");
            savedColors.Columns.Add("CMYK");
            savedColors.Columns.Add("XYZ");
            savedColors.Columns.Add("Lab");


            Graphics g = CreateGraphics();
            List<float> lengths = new List<float>();

            SizeF fs;
            foreach (ColumnHeader clmnHeader in savedColors.Columns)
            {
                fs = g.MeasureString(clmnHeader.Text, savedColors.HeaderFont);
                lengths.Add(fs.Width);
            }

            int max = (int)lengths.Max();

            savedColors.FullRowSelect = true;

            const int padding = 50;

            foreach (ColumnHeader clmnHeader in savedColors.Columns)
            {
                //clmnHeader.Width = (this.Width - padding) / savedColors.Columns.Count;

                clmnHeader.Width = max + padding;
            }

            #region Settings Form

            settingsForm.MGlass_Zoom_Num.Value = Zoom;
            settingsForm.MGlass_GridColor.BackColor = GridColor;
            settingsForm.MGlass_ShowGrid_Yes.Checked = ShowGrid;
            settingsForm.MGlass_ShowTxtWithSnapshot_Yes.Checked = ShowTextWithSnapshot;

            settingsForm.Follow_Divisor_Num.Value = selectorFormSecond.selectorPanel.MiddleDivisor;
            settingsForm.Follow_Middle_Color_Btn.BackColor = selectorFormSecond.selectorPanel.MiddleColor;
            settingsForm.Follow_Border_Color_Btn.BackColor = selectorFormSecond.selectorPanel.BorderColor;
            settingsForm.Follow_Code_Color_Btn.BackColor = followTextForm.FollowText.ForeColor;
            settingsForm.Follow_Circle_Yes.Checked = selectorFormSecond.selectorPanel.Circle;
            settingsForm.Follow_Inner_Yes.Checked = selectorFormSecond.selectorPanel.ShowInner;
            
            #endregion

            selectorForm.MouseClick += SelectorForm_Click;
            selectorForm.selectorPanel.MouseClick += SelectorPanel_Click;

            selectorForm.Load += SelectorForm_Load;
            selectorForm.MouseDown += SelectorForm_MouseDown;

            selectorFormSecond.selectorPanel.MouseClick += SelectorFormSecond_MouseClick;

            lastColor.Add(SColor.BackColor);

            foreach (KeyValuePair<string, Color> kvp in WebColor.AllColors)
            {
                colorListBox.Items.Add(kvp.Key);
            }

            if (showColors.Checked)
            {
                savedColors.DrawMode = Helpers.SimpleListView.drawMode.Default;
                savedColors.Invalidate();
            }
            else
            {
                savedColors.DrawMode = Helpers.SimpleListView.drawMode.Stylish;
                savedColors.Invalidate();
            }

        }
                
        #endregion

        #region Events

        private void upDownBtn_MouseEnter(object sender, EventArgs e)
        {
            upDownBtn.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void upDownBtn_MouseLeave(object sender, EventArgs e)
        {
            upDownBtn.FlatAppearance.BorderColor = Color.FromArgb(20,20,20);
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }


        private void externalLinkBtn_MouseEnter(object sender, EventArgs e)
        {
            externalLinkBtn.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void externalLinkBtn_MouseLeave(object sender, EventArgs e)
        {
            externalLinkBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scaleValue_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_L = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(SColor.BackColor.R, SColor.BackColor.G, SColor.BackColor.B, (float)scaleValue.Value).L).ToString();
                m_a = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(SColor.BackColor.R, SColor.BackColor.G, SColor.BackColor.B, (float)scaleValue.Value).A).ToString();
                m_b = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(SColor.BackColor.R, SColor.BackColor.G, SColor.BackColor.B, (float)scaleValue.Value).B).ToString();

            }
            catch (Exception)
            {


            }

            m_txt_L.Text = m_L;
            m_txt_a.Text = m_a;
            m_txt_b.Text = m_b;
        }

        private void baseTheme1_Click(object sender, EventArgs e)
        {

        }

        private void baseTheme1_MouseMove(object sender, MouseEventArgs e)
        {


            OnMouseDown_PanelGrid(e);
            OnMouseMove_PanelGrid(e);
        }

        private void baseTheme1_MouseLeave(object sender, EventArgs e)
        {
            MouseEventArgs mouse = new MouseEventArgs(MouseButtons.None,1, mouseLocation.X, mouseLocation.Y, 0);
                        
            if (mouse.Button == MouseButtons.Left)
            {
                RestoreForm();
                Cursor.Tag = "clicked";
                MessageBox.Show(Cursor.Tag.ToString());
            }
            
        }

        private void baseTheme1_MouseEnter(object sender, EventArgs e)
        {
            selectorForm.Clicked = false;
        }

        private void externalLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExternalColorsForm externalColorsForm = new ExternalColorsForm(SColor.BackColor, lastColor.Last());

                CenterScreen(externalColorsForm);

                if (externalColorsForm.ShowDialog() == DialogResult.OK)
                {
                    SelectColor(externalColorsForm.Color);
                    lastColor.Add(externalColorsForm.Color);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void upDownBtn_Click(object sender, EventArgs e)
        {
            UpdAndDownUpdate();

            //expandFormAnimator.Activate();
        }

        private void UpdAndDownUpdate()
        {
            down = !down;

            if (down)
            {

                updateBtn.Image = Properties.Resources.down_16px;
                updateBtn.Invalidate();
                //ShowSavedColors();

                #region Show Saved Colors

                //Size = new Size(798, 488);
                magnifyViewer.Visible = true;
                AColor.Visible = true;
                //MGlass.Visible = true;

                savedColors.Visible = true;
                savedDisplayedColors.Visible = true;

                #endregion

                ExpandFormVertically();

                expanded = true;

            }
            else
            {

                updateBtn.Image = Properties.Resources.up_16px;
                updateBtn.Invalidate();

                //RestoreForm();

                #region RestoreForm

                magnifyViewer.Location = new Point(594, 27);
                detailPanel.Visible = true;
                closeBtn.Visible = true;

                #endregion

                ContractFormVertically();

                expanded = false;
            }
        }

        private void ContractFormVertically()
        {
            shrinkUp.Animation = Helpers.Animations.FormAnimator.FormAnimationTypes.ShrinkVertical;
            shrinkUp.Positions.Start = 488;
            shrinkUp.Positions.End = 246;
            shrinkUp.Time.Time = 3;
            shrinkUp.Start(this);
        }

        private void ExpandFormVertically()
        {
            shrinkUp.Animation = Helpers.Animations.FormAnimator.FormAnimationTypes.GrowVertical;
            shrinkUp.Grow.Start = 246;
            shrinkUp.Grow.End = 488;
            shrinkUp.Time.Time = 5;
            shrinkUp.Start(this);
        }

        private void scaleValue_Move(object sender, EventArgs e)
        {
            if (!this.IsCapturing)
            {
                this.IsCapturing = true;
                this.gridPanel.Invalidate();
            }

            if (this.IsCapturing)
            {
                this.UpdateSnapshot();
            }
        }

        private void gridPanel_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown_PanelGrid(e);
        }

        private void gridPanel_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp_PanelGrid(e);
        }

        private void MagnifyingGlass_Move(object sender, EventArgs e)
        {

        }


        #endregion

        #region External Form Events

        private void SelectorForm_Click(object sender, MouseEventArgs e)
        {
            AColor.BackColor = PixelColor;
            SelectColor(PixelColor);
            SColor.Invalidate();
            selectorForm.Hide();
            followTextForm.Hide();
            RestoreForm();
            hoveringState = false;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + (Screen.PrimaryScreen.WorkingArea.Width/2) - (this.Width/2), Screen.PrimaryScreen.WorkingArea.Y + (Screen.PrimaryScreen.WorkingArea.Height/2) - (this.Height/2));

            
            selectorFormSecond.Hide();

            t.Enabled = false;
            t.Stop();
        }

        private void SelectorPanel_Click(object sender, MouseEventArgs e)
        {
            AColor.BackColor = PixelColor;
            SelectColor(PixelColor);
            SColor.Invalidate();
            selectorForm.Hide();
            followTextForm.Hide();
            RestoreForm();
            hoveringState = false;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), Screen.PrimaryScreen.WorkingArea.Y + (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));
                        
            selectorFormSecond.Hide();

            t.Enabled = false;
            t.Stop();
            
        }

        private void SelectorFormSecond_MouseClick(object sender, MouseEventArgs e)
        {
            AColor.BackColor = PixelColor;
            SelectColor(PixelColor);
            SColor.Invalidate();
            selectorForm.Hide();
            followTextForm.Hide();
            RestoreForm();
            hoveringState = false;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.X + (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), Screen.PrimaryScreen.WorkingArea.Y + (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));

            selectorFormSecond.Hide();

            t.Enabled = false;
            t.Stop();
        }
        
        private void SelectorForm_MouseDown(object sender, MouseEventArgs e)
        {
            selectorForm.Location = new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1);

            selectorFormSecond.Location = selectorForm.Location;


        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            #region Settings Form

            settingsForm.MGlass_Zoom_Num.Value = Zoom;
            settingsForm.MGlass_GridColor.BackColor = GridColor;
            settingsForm.MGlass_ShowGrid_Yes.Checked = ShowGrid;
            settingsForm.MGlass_ShowTxtWithSnapshot_Yes.Checked = ShowTextWithSnapshot;

            settingsForm.Follow_Divisor_Num.Value = selectorFormSecond.selectorPanel.MiddleDivisor;
            settingsForm.Follow_Middle_Color_Btn.BackColor = selectorFormSecond.selectorPanel.MiddleColor;
            settingsForm.Follow_Border_Color_Btn.BackColor = selectorFormSecond.selectorPanel.BorderColor;
            settingsForm.Follow_Code_Color_Btn.BackColor = followTextForm.FollowText.ForeColor;
            settingsForm.Follow_Circle_Yes.Checked = selectorFormSecond.selectorPanel.Circle;
            settingsForm.Follow_Inner_Yes.Checked = selectorFormSecond.selectorPanel.ShowInner;

            #endregion
        }

        #endregion

        #region Moving Animation

        System.Windows.Forms.Timer t;

        private void MovingAnimation()
        {
            t = new System.Windows.Forms.Timer();
            t.Enabled = true;
            t.Interval = 1;
            t.Tick += T_Tick;
            t.Start();
        }


        private void T_Tick(object sender, EventArgs e)
        {
            UpdateAndMovingAnimations();
            
        }
        
        private void UpdateAndMovingAnimations()
        {

            #region Form Location Movements

            int CursorLocationPointX = Cursor.Position.X - (this.Width / 2);
            int CursorLocationPointY = Cursor.Position.Y + 10 + (selectorForm.Height / 2);

            Rectangle wa;
            Control c = this;
            wa = Screen.FromControl(c).WorkingArea;
            int heightLimit = (int)(0.73f * wa.Height);
            int widthLowerLimit = (int)(0.08f * wa.Width);
            int widthHigherLimit = (int)(0.91f * wa.Width);
                        
            if (hoveringState)
            {
                if (Cursor.Position.Y > heightLimit)
                {

                    CursorLocationPointY = Cursor.Position.Y - 10 - (this.Height);
                }

                if(Cursor.Position.X > widthHigherLimit)
                {
                    CursorLocationPointX = Cursor.Position.X - (this.Width);
                }
                else if(Cursor.Position.X < widthLowerLimit)
                {
                    CursorLocationPointX = Cursor.Position.X + (this.Width/10);
                }

                mouseLocation = new Point(CursorLocationPointX, CursorLocationPointY);

                this.Location = mouseLocation;

            }

            #endregion

            UpdateSnapshot();
            gridPanel.Invalidate();

            //SelectColor(PixelColor);
            AColor.BackColor = PixelColor;

            int fw,fh;
            using (Graphics g = CreateGraphics())
            {
                SizeF fs = g.MeasureString(followTextForm.FollowText.Text, followTextForm.FollowText.Font);
                fw = (int)fs.Width;
                fh = (int)fs.Height;
            }

            followTextForm.FollowText.Text = string.Format("{0} {1} {2}", PixelColor.R, PixelColor.G, PixelColor.B);
               
            selectorForm.Location = new Point(Cursor.Position.X - (selectorForm.Width / 2), Cursor.Position.Y - (selectorForm.Height / 2));

            selectorFormSecond.Location = selectorForm.Location;

            followTextForm.Location = new Point(selectorForm.Location.X + (selectorForm.Width/5) - (followTextForm.Width/5)  + fw/2, selectorForm.Location.Y - (followTextForm.Height / (2 *5)));

            #region Old Working Code
            //if (hoveringState)
            //{
            //    mouseLocation = new Point(Cursor.Position.X - (MGlass.MovingGlass.Width) + (MGlass.MovingGlass.Width / 10), Cursor.Position.Y + (MGlass.MovingGlass.Height / 2) + 10);

            //    this.Location = mouseLocation;
            //}
            //else
            //{

            //} 
            #endregion

            
        }

        #endregion

        #region Thread

        /// <summary>
        /// The thread
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Starts this instance.
        /// </summary>
        private void Start()
        {
            //main working thread
            thread = new Thread(Work);
            thread.IsBackground = true;
            thread.Name = "Animator thread";
            thread.Start();
        }

        private void IncludeInConstructor()
        {
            Disposed += new EventHandler(Animator_Disposed);
        }

        /// <summary>
        /// Interval between frames (ms)
        /// </summary>
        /// <value>The interval.</value>
        [DefaultValue(10)]
        public int Interval
        {
            get;
            set;
        }

        /// <summary>
        /// Works this instance.
        /// </summary>
        void Work()
        {
            while (true)
            {
                Thread.Sleep(Interval);

                try
                {
                    // Redraw and continue the timer if we're visible, enabled and not in DesignMode
                    // The timer is also disabled here because the Timer component seems to have an error (it will crashafter a while!?). Restarting the timer is a workaround.
                    //UpdateTimer.Stop();
                    //UpdateAndMovingAnimations();
                }
                finally
                {
                    // Restart the timer
                    //UpdateTimer.Start();
                }

            }
        }

        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Animator_Disposed(object sender, EventArgs e)
        {

            if (thread != null)
                thread.Abort();
        }

        void StopThread()
        {

            if (thread != null && t != null)
            {
                thread.Abort();
                t.Enabled = false;
            }

            Invalidate();

        }


        #endregion
        
        #region Effects
        private void SColor_MouseEnter(object sender, EventArgs e)
        {
            SColor.BorderStyle = BorderStyle.None;
                        
        }

        private void SColor_MouseLeave(object sender, EventArgs e)
        {
            SColor.BorderStyle = BorderStyle.FixedSingle;

            
        }

        private void lR_MouseEnter(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Bold);
        }

        private void lR_MouseLeave(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Regular);
        }
        #endregion

        #region Tools
        public string Int2Hex(int intVal, int len)
        {
            string hexVal = intVal.ToString("X");
            if (hexVal.Length < len)
            {
                hexVal = hexVal.PadLeft(len, '0');
            }
            return hexVal;
        }
        #endregion

        #region Copy a color value
        private void lR_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.R.ToString());
        }

        private void lG_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.G.ToString());
        }

        private void lB_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.B.ToString());
        }

        private void lH_Click(object sender, EventArgs e)
        {
            CopyTextData(lH.Text.Substring(1));
        }

        private void rgb_Click(object sender, EventArgs e)
        {
            CopyTextData(rgb.Text);
        }

        private void m_txt_Hue_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Hue.Text);
        }

        private void m_txt_Sat_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Sat.Text);
        }

        private void m_txt_Black_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Black.Text);
        }

        private void m_txt_Cyan_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Cyan.Text);
        }

        private void m_txt_Magenta_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Magenta.Text);
        }

        private void m_txt_Yellow_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Yellow.Text);
        }

        private void m_txt_K_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_K.Text);
        }

        private void CopyTextData(string text)
        {
            Clipboard.SetText(text);
        }

        private void m_txt_H_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_H.Text);
        }

        private void m_txt_S_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_S.Text);
        }

        private void m_txt_V_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_V.Text);
        }

        private void m_txt_X_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_X.Text);
        }

        private void m_txt_Y_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Y.Text);
        }

        private void m_txt_Z_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_Z.Text);
        }

        private void m_txt_L_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_L.Text);
        }

        private void m_txt_a_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_a.Text);
        }

        private void m_txt_b_Click(object sender, EventArgs e)
        {
            CopyTextData(m_txt_b.Text);
        }
        #endregion
        
        #region Update the color preview
        private void MGlass_DisplayUpdated(MagnifyingGlass sender)
        {
            //AColor.BackColor = MGlass.PixelColor;
        }

        #endregion

        #region Select a color
        private void MagnifyingGlass_Click(object sender, EventArgs e)
        {
            
            hoveringState = false;
            
            RestoreForm();
            
            //SelectColor(MGlass.PixelColor);
            //MGlass.Hide();
            //MGlass.UpdateTimer.Stop();
            //MGlass.UpdateTimer.Dispose();            
            AColor.Hide();
            
            SColor.BorderStyle = BorderStyle.FixedSingle;

            
        }
               

        private void SColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = SColor.BackColor;
            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            cd.FullOpen = true;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            SelectColor(cd.Color);
        }

        private void SelectColor(Color color)
        {
            
            SColor.BackColor = color;
            m_rgb = color;
            m_cmyk = ColorConverters.RGB_to_CMYK(m_rgb);
            m_hsl = ColorConverters.RGB_to_HSL(m_rgb);

            try
            {
                m_H = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).H).ToString();
                m_S = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).S).ToString();
                m_V = Round(Helpers.Colors.ColorConverter.RGBtoHSV(color).V).ToString();

                m_L = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.R, color.B, (float)scaleValue.Value).L).ToString();
                m_a = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.G, color.B, (float)scaleValue.Value).A).ToString();
                m_b = Round(Helpers.Colors.ColorConverter.CIELabFromRGB(color.R, color.G, color.B, (float)scaleValue.Value).B).ToString();

                m_X = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).X).ToString();
                m_Y = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).Y).ToString();
                m_Z = Round(Helpers.Colors.ColorConverter.RGBToXYZ(color).Z).ToString();
            }
            catch (Exception)
            {
                                
            }

            

            lR.Text = color.R.ToString();
            lG.Text = color.G.ToString();
            lB.Text = color.B.ToString();
            rgb.Text = string.Format("{0},{1},{2}", color.R.ToString(), color.G.ToString(), color.B.ToString());
            lH.Text = "#" + Int2Hex(color.R, 2) + Int2Hex(color.G, 2) + Int2Hex(color.B, 2);

            m_txt_Hue.Text = Round(m_hsl.H * 360).ToString();
            m_txt_Sat.Text = Round(m_hsl.S * 100).ToString();
            m_txt_Black.Text = Round(m_hsl.L * 100).ToString();
            m_txt_Cyan.Text = Round(m_cmyk.C * 100).ToString();
            m_txt_Magenta.Text = Round(m_cmyk.M * 100).ToString();
            m_txt_Yellow.Text = Round(m_cmyk.Y * 100).ToString();
            m_txt_K.Text = Round(m_cmyk.K * 100).ToString();

            m_txt_H.Text = m_H;
            m_txt_S.Text = m_S;
            m_txt_V.Text = m_V;
            m_txt_L.Text = m_L;
            m_txt_a.Text = m_a;
            m_txt_b.Text = m_b;
            m_txt_X.Text = m_X;
            m_txt_Y.Text = m_Y;
            m_txt_Z.Text = m_Z;


        }

        #endregion

        #region Form Changes

        private void ChangeForm()
        {
            
            AColor.BorderStyle = BorderStyle.None;
            AColor.Show();
            hoveringState = true;
            selectorForm.selectorPanel.ShowInner = false;
            //selectorForm.Show();
            //selectorFormSecond.Show();

            if (precisionCheck.Checked)
            {
                selectorFormSecond.TransparencyKey = Color.Empty;
                selectorFormSecond.Show();
                selectorFormSecond.Opacity = 0.01;
            }
            else
            {
                selectorFormSecond.TransparencyKey = Color.FromArgb(20,20,20);
                selectorFormSecond.Opacity = 1;
                selectorForm.Show();
                selectorFormSecond.Show();
                
            }


            followTextForm.Show(); 

            //MGlass.BorderStyle = BorderStyle.None;
            
            gridPanel.BorderStyle = BorderStyle.None;

            magnifyViewer.Location = new Point(17, 27);
            Size = new Size(220, 240);
            savedColors.Visible = false;
            detailPanel.Visible = false;
            magnifyViewer.Visible = true;
            closeBtn.Visible = false;
            minimize.Visible = false;
        }

        private void RestoreForm()
        {
            magnifyViewer.Location = new Point(594, 27);            
            Size = new Size(798, 246);            
            detailPanel.Visible = true;
            closeBtn.Visible = true;
            minimize.Visible = true;
            //savedColors.Visible = false;
            //savedDisplayedColors.Visible = false;

        }

        #endregion
        
        #region Eyedropper Select 

        private void bSelect_Click(object sender, EventArgs e)
        {
            
            ChangeForm();

            MovingAnimation();

            animator.Activate();

        }

        private void bSelect_MouseEnter(object sender, EventArgs e)
        {
            bSelect.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void bSelect_MouseLeave(object sender, EventArgs e)
        {
            bSelect.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }

        #endregion

        #region Color Converters
        private int Round(double val)
        {
            int ret_val = (int)val;

            int temp = (int)(val * 100);

            if ((temp % 100) >= 50)
                ret_val += 1;

            return ret_val;
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

            }
        }

        /// <summary>
		/// The HSL color of the control, changing the HSL will automatically change the RGB color for the control.
		/// </summary>
		public ColorConverters.CMYK CMYK
        {
            get
            {
                return m_cmyk;
            }
            set
            {
                m_cmyk = value;
                m_rgb = ColorConverters.CMYK_to_RGB(m_cmyk);

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
                m_cmyk = ColorConverters.RGB_to_CMYK(m_rgb);


            }
        }
        #endregion

        #region Grid

        #region Constants

        private static readonly object _eventColorChanged = new object();

        private static readonly object _eventGridColorChanged = new object();

        private static readonly object _eventImageChanged = new object();

        private static readonly object _eventShowGridChanged = new object();

        private static readonly object _eventShowTextWithSnapshotChanged = new object();

        private static readonly object _eventZoomChanged = new object();

        #endregion

        #region Fields

        private Color _color;

        private Cursor _eyedropperCursor;

        private Color _gridColor;

        private Image _image;

        private bool _showGrid;

        private bool _showTextWithSnapshot;

        private int _zoom;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the grid.
        /// </summary>
        /// <value>The color of the grid.</value>
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "ControlDark")]
        public virtual Color GridColor
        {
            get { return _gridColor; }
            set
            {
                if (this.GridColor != value)
                {
                    _gridColor = value;

                    this.OnGridColorChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Returns if a snapshot image is available
        /// </summary>
        /// <value><c>true</c> if a snapshot image is available; otherwise, <c>false</c>.</value>
        [Browsable(false)]
        public bool HasSnapshot { get; protected set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        [Category("Appearance")]
        [DefaultValue(typeof(Image), null)]
        public Image GridPanelImage
        {
            get { return gridPanel.BackgroundImage; }
            set
            {
                if (this.GridPanelImage != value)
                {
                    _image = value;

                    this.OnImageChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a pixel grid is displayed.
        /// </summary>
        /// <value><c>true</c> if a pixel grid is displayed; otherwise, <c>false</c>.</value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool ShowGrid
        {
            get { return _showGrid; }
            set
            {
                if (this.ShowGrid != value)
                {
                    _showGrid = value;

                    this.OnShowGridChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether text should be shown when a snapshot is present.
        /// </summary>
        /// <value><c>true</c> if text is to be shown when a snapshot is present; otherwise, <c>false</c> to only show text when no snapshot is available.</value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ShowTextWithSnapshot
        {
            get { return _showTextWithSnapshot; }
            set
            {
                if (this.ShowTextWithSnapshot != value)
                {
                    _showTextWithSnapshot = value;

                    this.OnShowTextWithSnapshotChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets or sets the zoom level of the snapshot image.
        /// </summary>
        /// <value>The zoom level.</value>
        [Category("Appearance")]
        [DefaultValue(8)]
        public int Zoom
        {
            get { return _zoom; }
            set
            {
                if (this.Zoom != value)
                {
                    _zoom = value;

                    this.OnZoomChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating snapshot capture is in progress.
        /// </summary>
        /// <value><c>true</c> if snapshot capture is in progress; otherwise, <c>false</c>.</value>
        public bool IsCapturing { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether redraw operations should occur.
        /// </summary>
        /// <value><c>true</c> if redraw operations should occur; otherwise, <c>false</c>.</value>
        public bool LockUpdates { get; set; }

        /// <summary>
        /// Gets or sets the snapshot image.
        /// </summary>
        /// <value>The snapshot image.</value>
        public Bitmap SnapshotImage { get; set; }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates the snapshot image.
        /// </summary>
        private void CreateSnapshotImage()
        {
            Size size;

            if (this.SnapshotImage != null)
            {
                this.SnapshotImage.Dispose();
                this.SnapshotImage = null;
            }

            size = this.GetSnapshotSize();
            if (!size.IsEmpty)
            {
                this.SnapshotImage = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
                this.gridPanel.Invalidate();
            }
        }


        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        private void DisposeSnapEye(bool disposing)
        {
            if (disposing)
            {
                if (_eyedropperCursor != null)
                {
                    _eyedropperCursor.Dispose();
                }

                if (this.SnapshotImage != null)
                {
                    this.SnapshotImage.Dispose();
                }
            }
                        
        }

        /// <summary>
        /// Gets the center point based on the current zoom level.
        /// </summary>
        private Point GetCenterPoint()
        {
            int x;
            int y;

            x = this.gridPanel.ClientSize.Width / this.Zoom / 2;
            y = this.gridPanel.Height / this.Zoom / 2;

            return new Point(x, y);
        }

        /// <summary>
        /// Gets the size of the snapshot.
        /// </summary>
        private Size GetSnapshotSize()
        {
            int snapshotWidth;
            int snapshotHeight;

            snapshotWidth = (int)Math.Ceiling(this.gridPanel.ClientSize.Width / (double)this.Zoom);
            snapshotHeight = (int)Math.Ceiling(this.gridPanel.ClientSize.Height / (double)this.Zoom);

            return snapshotHeight != 0 && snapshotWidth != 0 ? new Size(snapshotWidth, snapshotHeight) : Size.Empty;
        }

        /// <summary>
        /// Updates the snapshot.
        /// </summary>
        private void UpdateSnapshot()
        {
            Point cursor;

            cursor = MousePosition /*MousePosition*/;
            cursor.X -= this.SnapshotImage.Width / 2;
            cursor.Y -= this.SnapshotImage.Height / 2;

            using (Graphics graphics = Graphics.FromImage(this.SnapshotImage))
            {
                Point center;

                // clear the image first, in case the mouse is near the borders of the screen so there isn't enough copy content to fill the area
                graphics.Clear(Color.Empty);


                // copy the image from the screen
                graphics.CopyFromScreen(cursor, Point.Empty, this.SnapshotImage.Size);

                // update the active color
                center = this.GetCenterPoint();
                this.Color = this.SnapshotImage.GetPixel(center.X, center.Y);

                // force a redraw
                this.HasSnapshot = true;
                this.gridPanel.Refresh(); // just calling gridPanel.Invalidate isn't enough as the display will lag
            }
        }
        
        #endregion

        #region Events

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void OnPaint_PanelGrid(PaintEventArgs e)
        {
            
            //this.gridPanel.OnPaintBackground(e); // HACK: Easiest way of supporting things like BackgroundImage, BackgroundImageLayout etc

            // draw the current snapshot, if present
            if (this.SnapshotImage != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                e.Graphics.DrawImage(this.SnapshotImage, new Rectangle(0, 0, this.SnapshotImage.Width * this.Zoom, this.SnapshotImage.Height * this.Zoom), new Rectangle(Point.Empty, this.SnapshotImage.Size), GraphicsUnit.Pixel);
            }

            this.PaintAdornments(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void OnResize_PanelGrid(EventArgs e)
        {
            ////base.OnResize(e);

            this.CreateSnapshotImage();
        }

        /// <summary>
        /// Raises the <see cref="ShowGridChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnShowGridChanged(EventArgs e)
        {
            EventHandler handler;

            this.gridPanel.Invalidate();

            handler = (EventHandler)this.Events[_eventShowGridChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="ShowTextWithSnapshotChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnShowTextWithSnapshotChanged(EventArgs e)
        {
            EventHandler handler;

            this.gridPanel.Invalidate();

            handler = (EventHandler)this.Events[_eventShowTextWithSnapshotChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected virtual void OnTextChanged_PanelGrid(EventArgs e)
        {
            //base.OnTextChanged(e);

            this.gridPanel.Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="ColorChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnColorChanged(EventArgs e)
        {
            EventHandler handler;

            handler = (EventHandler)this.Events[_eventColorChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void OnFontChanged_PanelGrid(EventArgs e)
        {
            //base.OnFontChanged(e);

            this.gridPanel.Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ForeColorChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void OnForeColorChanged_PanelGrid(EventArgs e)
        {
            //base.OnForeColorChanged(e);

            this.gridPanel.Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="GridColorChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnGridColorChanged(EventArgs e)
        {
            EventHandler handler;

            this.gridPanel.Invalidate();

            handler = (EventHandler)this.Events[_eventGridColorChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="ImageChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnImageChanged(EventArgs e)
        {
            EventHandler handler;

            this.gridPanel.Invalidate();

            handler = (EventHandler)this.Events[_eventImageChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void OnMouseDown_PanelGrid(MouseEventArgs e)
        {
            //base.OnMouseDown(e);

            if (!this.IsCapturing)
            {
                this.IsCapturing = true;
                this.gridPanel.Invalidate();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void OnMouseMove_PanelGrid(MouseEventArgs e)
        {
            //base.OnMouseMove(e);

            if (this.IsCapturing)
            {
                this.UpdateSnapshot();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void OnMouseUp_PanelGrid(MouseEventArgs e)
        {
            //base.OnMouseUp(e);

            if (this.IsCapturing)
            {
                this.Cursor = Cursors.Default;
                this.IsCapturing = false;
                this.gridPanel.Invalidate();
            }
        }

        /// <summary>
        /// Raises the <see cref="ZoomChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnZoomChanged(EventArgs e)
        {
            EventHandler handler;

            this.CreateSnapshotImage();

            handler = (EventHandler)this.Events[_eventZoomChanged];

            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Paints adornments onto the control.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PaintAdornments(PaintEventArgs e)
        {
            // grid
            if (this.ShowGrid)
            {
                this.PaintGrid(e);
            }

            // center marker
            if (this.HasSnapshot)
            {
                this.PaintCenterMarker(e);
            }

            // image
            if (this.GridPanelImage != null && (!this.HasSnapshot || this.ShowTextWithSnapshot))
            {
                e.Graphics.DrawImage(this.GridPanelImage, (this.gridPanel.ClientSize.Width - this.GridPanelImage.Size.Width) / 2, (this.gridPanel.ClientSize.Height - this.GridPanelImage.Size.Height) / 2);
            }

            // draw text
            if (!string.IsNullOrEmpty(this.gridPanel.Text) && (!this.HasSnapshot || this.ShowTextWithSnapshot))
            {
                TextRenderer.DrawText(e.Graphics, this.gridPanel.Text, this.gridPanel.Font, this.gridPanel.ClientRectangle, this.gridPanel.ForeColor, this.gridPanel.BackColor, TextFormatFlags.ExpandTabs | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.WordBreak | TextFormatFlags.WordEllipsis);
            }
        }

        /// <summary>
        /// Paints the center marker.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PaintCenterMarker(PaintEventArgs e)
        {
            Point center;

            center = this.GetCenterPoint();

            using (Pen pen = new Pen(this.gridPanel.ForeColor))
            {
                e.Graphics.DrawRectangle(pen, center.X * this.Zoom, center.Y * this.Zoom, this.Zoom + 2, this.Zoom + 2);
            }
        }

        /// <summary>
        /// Paints the pixel grid.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PaintGrid(PaintEventArgs e)
        {
            Rectangle viewport;
            int pixelSize;

            pixelSize = this.Zoom;
            viewport = this.gridPanel.ClientRectangle;

            using (Pen pen = new Pen(this.GridColor)
            {
                DashStyle = DashStyle.Dot
            })
            {
                for (int x = viewport.Left + 1; x < viewport.Right; x += pixelSize)
                {
                    e.Graphics.DrawLine(pen, x, viewport.Top, x, viewport.Bottom);
                }

                for (int y = viewport.Top + 1; y < viewport.Bottom; y += pixelSize)
                {
                    e.Graphics.DrawLine(pen, viewport.Left, y, viewport.Right, y);
                }

                e.Graphics.DrawRectangle(pen, viewport);
            }
        } 

        #endregion
        
        #region IColorEditor Interface

        [Category("Property Changed")]
        public event EventHandler ColorChanged
        {
            add { this.Events.AddHandler(_eventColorChanged, value); }
            remove { this.Events.RemoveHandler(_eventColorChanged, value); }
        }

        /// <summary>
        /// Gets or sets the component color.
        /// </summary>
        /// <value>The component color.</value>
        [Category("Behavior")]
        [DefaultValue(typeof(Color), "Empty")]
        public virtual Color Color
        {
            get { return _color; }
            set
            {
                if (this.Color != value)
                {
                    _color = value;

                    this.OnColorChanged(EventArgs.Empty);
                }
            }
        }


        #endregion

        #endregion

        #region Grid Panel

        private void gridPanel_Paint(object sender, PaintEventArgs e)
        {
            OnPaint_PanelGrid(e);
        }

        private void gridPanel_Resize(object sender, EventArgs e)
        {
            OnResize_PanelGrid(e);
        }



        #endregion

        #region Settings Form

        private void settings_Click(object sender, EventArgs e)
        {
            settingsForm.Location = new Point(this.Location.X + (settingsForm.Width / 2), this.Location.Y + (settingsForm.Height / 5));

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                settingsForm.Location = new Point(this.Location.X + (settingsForm.Width / 2), this.Location.Y + (settingsForm.Height / 5));

                #region Settings Form

                Zoom = (int)settingsForm.MGlass_Zoom_Num.Value;
                GridColor = settingsForm.MGlass_GridColor.BackColor;
                ShowGrid = settingsForm.MGlass_ShowGrid_Yes.Checked;
                ShowTextWithSnapshot = settingsForm.MGlass_ShowTxtWithSnapshot_Yes.Checked;
                selectorFormSecond.selectorPanel.MiddleDivisor = (int)settingsForm.Follow_Divisor_Num.Value;
                selectorFormSecond.selectorPanel.MiddleColor = settingsForm.Follow_Middle_Color_Btn.BackColor;
                selectorFormSecond.selectorPanel.BorderColor = settingsForm.Follow_Border_Color_Btn.BackColor;
                followTextForm.FollowText.ForeColor = settingsForm.Follow_Code_Color_Btn.BackColor;
                selectorFormSecond.selectorPanel.Circle = settingsForm.Follow_Circle_Yes.Checked;
                selectorFormSecond.selectorPanel.ShowInner = settingsForm.Follow_Inner_Yes.Checked;

                selectorFormSecond.MiddleDivisor = (int)settingsForm.Follow_Divisor_Num.Value;
                selectorFormSecond.MiddleColor = settingsForm.Follow_Middle_Color_Btn.BackColor;
                selectorFormSecond.BorderColor = settingsForm.Follow_Border_Color_Btn.BackColor;
                selectorFormSecond.Circle = settingsForm.Follow_Circle_Yes.Checked;
                //selectorFormSecond.ShowInner = settingsForm.Follow_Inner_Yes.Checked;

                #endregion

            }
        }

        #endregion

        #region Saved Colors

        private void Add()
        {
            string name = nameTxtBox.Text;
            string rgbColor = rgb.Text;
            string htmlColor = lH.Text;
            string hsbColor = string.Format(@"{0}°, {1}%, {2}%", m_txt_Hue.Text, m_txt_Sat.Text, m_txt_Black.Text);
            string hsvColor = string.Format(@"{0}°, {1}%, {2}%", m_txt_H.Text, m_txt_S.Text, m_txt_V.Text);
            string cmykColor = string.Format(@"{0}°, {1}%, {2}%, {3}%", m_txt_Cyan.Text, m_txt_Magenta.Text, m_txt_Yellow.Text, m_txt_K.Text);
            string xyzColor = string.Format(@"{0}, {1}, {2}", m_txt_X.Text, m_txt_Y.Text, m_txt_Z.Text);
            string labColor = string.Format(@"{0}, {1}, {2}, {3}", m_txt_L.Text, m_txt_a.Text, m_txt_b.Text, scaleValue.Value.ToString());

            string[] row = new string[]
            {
                name,
                rgbColor,
                htmlColor,
                hsbColor,
                hsvColor,
                cmykColor,
                xyzColor,
                labColor
            };

            ListViewItem lvi = new ListViewItem(row);
            lvi.BackColor = m_rgb;
            savedColors.Invalidate();
            savedColors.Items.Add(lvi);

            if (File.Exists(openFileDialog.FileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(openFileDialog.FileName);

                XmlNode colorNode = doc.CreateElement("Color");

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.InnerText = name;
                colorNode.AppendChild(nameNode);

                XmlNode rgbNode = doc.CreateElement("RGB");
                rgbNode.InnerText = rgbColor;
                colorNode.AppendChild(rgbNode);

                XmlNode htmlNode = doc.CreateElement("HTML");
                htmlNode.InnerText = htmlColor;
                colorNode.AppendChild(htmlNode);

                XmlNode hsbNode = doc.CreateElement("HSL");
                hsbNode.InnerText = hsbColor;
                colorNode.AppendChild(hsbNode);

                XmlNode hsvNode = doc.CreateElement("HSV");
                hsvNode.InnerText = hsvColor;
                colorNode.AppendChild(hsvNode);

                XmlNode cmykNode = doc.CreateElement("CMYK");
                cmykNode.InnerText = cmykColor;
                colorNode.AppendChild(cmykNode);

                XmlNode xyzNode = doc.CreateElement("XYZ");
                xyzNode.InnerText = xyzColor;
                colorNode.AppendChild(xyzNode);

                XmlNode labNode = doc.CreateElement("Lab");
                labNode.InnerText = labColor;
                colorNode.AppendChild(labNode);

                doc.DocumentElement.AppendChild(colorNode);
                doc.Save(openFileDialog.FileName);
            }
        }

        private void Updates()
        {

            savedColors.SelectedItems[0].SubItems[0].Text = nameTxtBox.Text;
            savedColors.SelectedItems[0].SubItems[1].Text = previewRGB.Text;
            savedColors.SelectedItems[0].SubItems[2].Text = previewHTML.Text;
            savedColors.SelectedItems[0].SubItems[3].Text = previewHSB.Text;
            savedColors.SelectedItems[0].SubItems[4].Text = previewHSV.Text;
            savedColors.SelectedItems[0].SubItems[5].Text = previewCMYK.Text;
            savedColors.SelectedItems[0].SubItems[6].Text = previewXYZ.Text;
            savedColors.SelectedItems[0].SubItems[7].Text = previewLab.Text;

            ClearFields();
        }

        private void Delete()
        {

            try
            {
                
                if (File.Exists(openFileDialog.FileName))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(openFileDialog.FileName);

                    foreach (XmlNode node in doc.SelectNodes("Colors/Color"))
                    {

                        if (node.SelectSingleNode("Name").InnerText == savedColors.Items[savedColors.SelectedIndices[0]].SubItems[0].Text)
                        {
                            node.ParentNode.RemoveChild(node);
                        }
                        
                    }

                    doc.Save(openFileDialog.FileName);
                }

                savedColors.Items.RemoveAt(savedColors.SelectedIndices[0]);

                ClearFields();
            }

            catch (ArgumentOutOfRangeException e)
            {

                Messages messages = new Messages();
                                
                messages.Message = @"Cannot Delete Empty Item. Add Colors";

                CenterForm(messages);

                if (messages.ShowDialog() == DialogResult.OK)
                {
                    //Do nothing
                }
            }
        }

        private void ClearAll()
        {

            try
            {
                savedColors.Items.Clear();

                ClearFields();
            }
            catch (ArgumentOutOfRangeException e)
            {

                Messages messages = new Messages();
                                
                messages.Message = @"Cannot Clear Empty Colors";

                CenterForm(messages);

                if (messages.ShowDialog() == DialogResult.OK)
                {
                    //Do nothing
                }
            }
        }

        private void ClearFields()
        {
            //Restore After Adding
            nameTxtBox.Text = String.Empty;
            previewRGB.Text = "RGB";
            previewHTML.Text = "HTML";
            previewHSB.Text = "HSB";
            previewHSV.Text = "HSV";
            previewLab.Text = "Lab";
            previewCMYK.Text = "CMYK";
            previewXYZ.Text = "XYZ";

        }

        private void ShowSavedColors()
        {

            
            Size = new Size(798, 488);            
            magnifyViewer.Visible = true;
            AColor.Visible = true;
            //MGlass.Visible = true;

            savedColors.Visible = true;
            savedDisplayedColors.Visible = true;
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            saveBtn.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }

        bool expanded = false;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            Save();
                        
        }

        private void Save()
        {
            if (nameTxtBox.Text != String.Empty)
            {
                error.Clear();
                Add();
                ClearFields();
                               

            }
            else
            {
                SetErrorNotification();
            }

            if(expanded == false)
            {
                ExpandFormVertically();
                expanded = true;
                down = true;
            }
            

            //UpdAndDownUpdate();

            //ShowSavedColors();

            #region Show Saved Colors
                        
            magnifyViewer.Visible = true;
            AColor.Visible = true;
            //MGlass.Visible = true;

            savedColors.Visible = true;
            savedDisplayedColors.Visible = true;

            #endregion

            foreach (ListViewItem lvw in savedColors.Items)
            {
                //lvw.UseItemStyleForSubItems = false;

                try
                {
                    lvw.BackColor = Color.FromArgb(
                                int.Parse(lvw.SubItems[1].Text.Substring(0, lvw.SubItems[1].Text.IndexOf(','))),
                                int.Parse(lvw.SubItems[1].Text.Substring(lvw.SubItems[1].Text.IndexOf(',') + 1, lvw.SubItems[1].Text.LastIndexOf(',') - lvw.SubItems[1].Text.IndexOf(',') - 1)),
                                int.Parse(lvw.SubItems[1].Text.Substring(lvw.SubItems[1].Text.LastIndexOf(',') + 1)));
                }
                catch (Exception)
                {

                    
                }
            }

            
        }

        private void SetErrorNotification()
        {
            error.SetError(nameTxtBox, "Please provide a name");
        }

        private void baseTheme1_Click_1(object sender, EventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Messages messages = new Messages();
            messages.Message = @"Do You Want To Delete Entire Row ?";
            messages.MessageTitle = "Delete Rows";

            CenterForm(messages);

            if (messages.ShowDialog() == DialogResult.OK)
            {
                Delete();

            }

            if (savedColors.Items.Count > 0)
            {
                previewRGB.Visible = true;
                previewHTML.Visible = true;
                previewHSB.Visible = true;
                previewHSV.Visible = true;
                previewCMYK.Visible = true;
                previewXYZ.Visible = true;
                previewLab.Visible = true;
            }
            else if (savedColors.Items.Count == 0)
            {
                previewRGB.Visible = false;
                previewHTML.Visible = false;
                previewHSB.Visible = false;
                previewHSV.Visible = false;
                previewCMYK.Visible = false;
                previewXYZ.Visible = false;
                previewLab.Visible = false;
            }

        }

        private void clearColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();

            CenterForm(messages);

            if (messages.ShowDialog() == DialogResult.OK)
            {
                ClearAll();
            }

            if (savedColors.Items.Count > 0)
            {
                previewRGB.Visible = true;
                previewHTML.Visible = true;
                previewHSB.Visible = true;
                previewHSV.Visible = true;
                previewCMYK.Visible = true;
                previewXYZ.Visible = true;
                previewLab.Visible = true;
            }
            else if (savedColors.Items.Count == 0)
            {
                previewRGB.Visible = false;
                previewHTML.Visible = false;
                previewHSB.Visible = false;
                previewHSV.Visible = false;
                previewCMYK.Visible = false;
                previewXYZ.Visible = false;
                previewLab.Visible = false;
            }
        }

        private void savedColors_MouseClick(object sender, MouseEventArgs e)
        {
            if (savedColors.Items.Count > 0)
            {
                previewRGB.Visible = true;
                previewHTML.Visible = true;
                previewHSB.Visible = true;
                previewHSV.Visible = true;
                previewCMYK.Visible = true;
                previewXYZ.Visible = true;
                previewLab.Visible = true;
            }
            else if (savedColors.Items.Count == 0)
            {
                previewRGB.Visible = false;
                previewHTML.Visible = false;
                previewHSB.Visible = false;
                previewHSV.Visible = false;
                previewCMYK.Visible = false;
                previewXYZ.Visible = false;
                previewLab.Visible = false;
            }

            nameTxtBox.Text = savedColors.SelectedItems[0].SubItems[0].Text;
            previewRGB.Text = savedColors.SelectedItems[0].SubItems[1].Text;
            previewHTML.Text = savedColors.SelectedItems[0].SubItems[2].Text;
            previewHSB.Text = savedColors.SelectedItems[0].SubItems[3].Text;
            previewHSV.Text = savedColors.SelectedItems[0].SubItems[4].Text;
            previewCMYK.Text = savedColors.SelectedItems[0].SubItems[5].Text;
            previewXYZ.Text = savedColors.SelectedItems[0].SubItems[6].Text;
            previewLab.Text = savedColors.SelectedItems[0].SubItems[7].Text;

            //rgb.Text = string.Format("{0},{1},{2}", color.R.ToString(), color.G.ToString(), color.B.ToString());
            try
            {
                SelectColor(Color.FromArgb(
                    int.Parse(previewRGB.Text.Substring(0, previewRGB.Text.IndexOf(','))),
                    int.Parse(previewRGB.Text.Substring(previewRGB.Text.IndexOf(',') + 1, previewRGB.Text.LastIndexOf(',') - previewRGB.Text.IndexOf(',') - 1)),
                    int.Parse(previewRGB.Text.Substring(previewRGB.Text.LastIndexOf(',') + 1))));

            }


            catch (Exception ex)
            {

                //MessageBox.Show("1 : " + previewRGB.Text.Substring(0, previewRGB.Text.IndexOf(',')).ToString() + "\n" + 
                //    "2 : " + previewRGB.Text.Substring(previewRGB.Text.IndexOf(',') + 1, previewRGB.Text.LastIndexOf(',') - previewRGB.Text.IndexOf(',') - 1).ToString() + "\n" + 
                //    "3 : " + previewRGB.Text.Substring(previewRGB.Text.LastIndexOf(',') + 1).ToString());


            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Updates();
        }
        #endregion

        #region Pixel Color

        [Description("Get the color of the current pixel")]
        public Color PixelColor
        {
            get
            {
                Bitmap bmp = null;
                try
                {
                    // Make a screenshot of the pixel from the current cursor position
                    bmp = new Bitmap(1, 1);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        bool makeScreenshot = !FollowCursor;// Make a real screenshot?
                        if (makeScreenshot)
                        {
                            if (gridPanel != null)
                            {
                                //Only make a real screenshot if the moving glass is inactive
                                makeScreenshot &= !gridPanel.Visible;
                            }
                        }
                        if (!FollowCursor)
                        {
                            // Make a real screenshot
                            g.DrawImage(MakeScreenshot(new Rectangle(Cursor.Position, bmp.Size)), new Point(0, 0));
                        }
                        else
                        {
                            // Use the screen image for the screenshot
                            bool createScreenshot = false;// Did we create a screenshot for this?
                            if (FollowCursor)
                            {
                                // Create the screenshot only if it wasn't done yet
                                createScreenshot = _ScreenShot == null;
                            }
                            else
                            {
                                // Create the screenshot only of the moving glass has not done it yet
                                createScreenshot = this._ScreenShot == null;
                            }
                            if (createScreenshot)
                            {
                                // Create a new screen image
                                MakeScreenshot();
                            }
                            if (FollowCursor)
                            {
                                // We're the moving glass
                                g.DrawImage(_ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
                            }
                            else
                            {
                                // Use the moving glasses screenshot
                                g.DrawImage(_ScreenShot, new Rectangle(new Point(0, 0), new Size(1, 1)), new Rectangle(Cursor.Position, new Size(1, 1)), GraphicsUnit.Pixel);
                            }
                            if (createScreenshot)
                            {
                                // Destroy the screenshot if we only needed to create one for this
                                _ScreenShot.Dispose();
                            }
                        }
                    }
                    // Return the pixel color
                    return bmp.GetPixel(0, 0);
                }
                finally
                {
                    bmp.Dispose();
                }
            }
        }

        #endregion
                
        #region Screen Shot

        internal Bitmap _ScreenShot = null;
        private Point _LastPosition = Point.Empty;
        private static bool _UseWin32Api = false;
        private bool _FollowCursor = false;
        

        /// <summary>
        /// You may use the Win32 API to get screenshots with alpha / layered windows
        /// </summary>
        [Browsable(false)]
        public static bool UseWin32Api
        {
            get
            {
                return _UseWin32Api;
            }
            set
            {
                _UseWin32Api = value;
            }
        }

        [Browsable(false)]
        internal bool FollowCursor
        {
            get
            {
                return _FollowCursor;
            }
            set
            {
                if (!(_FollowCursor = value))
                {
                    // Exit the following mode
                    if (_ScreenShot != null)
                    {
                        _ScreenShot.Dispose();
                        _ScreenShot = null;
                    }
                }
            }
        }

        private Bitmap MakeScreenshot(Rectangle rect)
        {
            // Capture an rectangle area from the screen
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);

            #region Old Code
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (UseWin32Api)
                {
                    // We're using BitBlt from the GDI API to copy alpha / layered screen regions also
                    IntPtr gHdc = g.GetHdc();
                    IntPtr dHdc = W32.GetDesktopWindow();
                    IntPtr wHdc = W32.GetWindowDC(dHdc);
                    W32.BitBlt(gHdc, 0, 0, bmp.Width, bmp.Height, wHdc, rect.X, rect.Y, W32.SRCCOPY | W32.CAPTUREBLT);
                    W32.ReleaseDC(dHdc, wHdc);
                    g.ReleaseHdc(gHdc);
                    gHdc = IntPtr.Zero;
                    dHdc = IntPtr.Zero;
                    wHdc = IntPtr.Zero;
                }
                else
                {
                    // The standard C# screen capturing
                    g.CopyFromScreen(rect.Location, new Point(0, 0), bmp.Size);
                    //this.Refresh();
                }


            }
            #endregion

            #region CPU Boils up

            //Graphics g = Graphics.FromImage(bmp);

            //if (UseWin32Api)
            //{
            //    // We're using BitBlt from the GDI API to copy alpha / layered screen regions also
            //    IntPtr gHdc = g.GetHdc();
            //    IntPtr dHdc = W32.GetDesktopWindow();
            //    IntPtr wHdc = W32.GetWindowDC(dHdc);
            //    W32.BitBlt(gHdc, 0, 0, bmp.Width, bmp.Height, wHdc, rect.X, rect.Y, W32.SRCCOPY | W32.CAPTUREBLT);
            //    W32.ReleaseDC(dHdc, wHdc);
            //    g.ReleaseHdc(gHdc);
            //    gHdc = IntPtr.Zero;
            //    dHdc = IntPtr.Zero;
            //    wHdc = IntPtr.Zero;
            //}
            //else
            //{
            //    // The standard C# screen capturing
            //    g.CopyFromScreen(rect.Location, new Point(0, 0), bmp.Size);

            //}
            //g.Dispose();
            //GC.Collect(); 
            #endregion

            //this.Refresh();
            return bmp;
        }

        internal void MakeScreenshot()
        {
            // Copy the current screen without this control for the following glass
            OnBeforeMakingScreenshot();
            
            _ScreenShot = MakeScreenshot(new Rectangle(new Point(0, 0), Screen.PrimaryScreen.Bounds.Size));
            
            OnAfterMakingScreenshot();
        }

        #endregion

        #region Windows API
        /// <summary>
        /// This private class is holding all used Win32 API calls and constants
        /// </summary>
        private static class W32
        {
            /// <summary>
            /// Copy the source with BitBlt
            /// </summary>
            public const int SRCCOPY = 0x00CC0020;
            /// <summary>
            /// Copy alpha / layered with BitBlt
            /// </summary>
            public const int CAPTUREBLT = 0x40000000;

            /// <summary>
            /// BitBlt method from the GDI API
            /// </summary>
            /// <param name="hDestDC">Destination DC handle</param>
            /// <param name="x">Destination x</param>
            /// <param name="y">Destination y</param>
            /// <param name="nWidth">Destination width</param>
            /// <param name="nHeight">Destination height</param>
            /// <param name="hSrcDC">Source DC handle</param>
            /// <param name="xSrc">Source x</param>
            /// <param name="ySrc">Source y</param>
            /// <param name="dwRop">Options</param>
            /// <returns>Result</returns>
            [DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
            public static extern UInt64 BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, System.Int32 dwRop);

            /// <summary>
            /// Get the desktop window handle
            /// </summary>
            /// <returns>Desktop window handle</returns>
            [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
            public static extern IntPtr GetDesktopWindow();

            /// <summary>
            /// Get a window DC
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            /// <returns>Window DC</returns>
            [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
            public static extern IntPtr GetWindowDC(IntPtr hwnd);

            /// <summary>
            /// Release a DC
            /// </summary>
            /// <param name="hwnd">Window handle</param>
            /// <param name="dc">Window DC</param>
            /// <returns>Result</returns>
            [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = false)]
            public static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);
        }
        #endregion

        #region Delegates

        /// <summary>
        /// Delegate for the BeforeMakingScreenshot and the AfterMakingScreenshot events
        /// </summary>
        /// <param name="sender">The sending MagnifyingGlass object</param>
        public delegate void MakingScreenshotDelegate(object sender);
        /// <summary>
        /// Fired before making a screenshot
        /// </summary>
        public event MakingScreenshotDelegate BeforeMakingScreenshot;
        /// <summary>
        /// Fired after making a screenshot
        /// </summary>
        public event MakingScreenshotDelegate AfterMakingScreenshot;
        private void OnBeforeMakingScreenshot()
        {
            if (BeforeMakingScreenshot != null)
            {
                BeforeMakingScreenshot(this);
            }
        }
        private void OnAfterMakingScreenshot()
        {
            if (AfterMakingScreenshot != null)
            {
                AfterMakingScreenshot(this);
            }
        }


        #endregion

        #region Windows Messages

        ///// <summary>
        ///// The wm lmbuttondown
        ///// </summary>
        //private bool WM_LMBUTTONDOWN;
        ///// <summary>
        ///// Processes Windows messages.
        ///// </summary>
        ///// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);

        //    string messages;
        //    if (WM_LMBUTTONDOWN && m.Msg == 513)
        //    {
        //        followTextForm.FollowText.Text = "Clicked";
        //        messages = followTextForm.FollowText.Text.ToString();
        //        MessageBox.Show(messages);
        //    }

        //}

        #endregion

        #region Search
        private void allWebColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor(allWebColors.SelectedColor);
        }

        
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            colorListBox.Items.Clear();


            foreach (KeyValuePair<string, Color> kvp in WebColor.AllColors)
            {
                if (kvp.Key.Contains(searchTextBox.Text.ToUpper())
                    | kvp.Key.Contains(searchTextBox.Text.ToLower())
                    | kvp.Key.Contains(searchTextBox.Text.Capitalize())
                    | kvp.Key.Contains(searchTextBox.Text.SwapCases())
                    | kvp.Key.Contains(searchTextBox.Text.AlternateCases()))
                {
                    colorListBox.Items.Add(kvp.Key);

                }
            }

            itemsFound.Visible = true;
            itemsFoundSecond.Visible = true;

            if (colorListBox.Items.Count > 1)
            {
                itemsFound.Text = colorListBox.Items.Count.ToString();
                itemsFoundSecond.Text = "items found";

            }
            else
            {
                itemsFound.Text = colorListBox.Items.Count.ToString();
                itemsFoundSecond.Text = "item found";

            }

            if (searchTextBox.Text == String.Empty)
            {
                colorListBox.Visible = false;
            }
            else
            {
                colorListBox.Visible = true;
            }


        }

        private void colorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorListBox.SelectedItem != null && colorListBox.SelectedItem.Equals(colorListBox.SelectedItem.ToString()))
            {
                for (int i = 0; i < allWebColors.Items.Count; i++)
                {

                    if (colorListBox.SelectedItem.ToString() == allWebColors.ColorName[i])
                    {
                        allWebColors.SelectedIndex = i;
                        SelectColor(allWebColors.SelectedColor);
                        allWebColors.Invalidate();
                    }
                }

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchVisible = !searchVisible;

            if (searchVisible)
            {
                searchPanel.Visible = true;
            }
            else
            {
                searchPanel.Visible = false;
            }
        }

        private void searchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);
        }

        #endregion
        
        #region Private Methods

        private void CenterForm(Form form)
        {
            form.Location = new Point(this.Location.X + (form.Width / 2), this.Location.Y + (form.Height / 5));

        }

        private void CenterScreen(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2) - (form.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (form.Height / 2));

        }


        #endregion

        private void nameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Save();
            }
                        
        }

        private void nameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Save();
            }
            if (e.KeyChar == 13)
            {
                Save();
            }
        }

        private void showColors_CheckedChanged(object sender, EventArgs e)
        {
            if(showColors.Checked)
            {
                savedColors.DrawMode = Helpers.SimpleListView.drawMode.Default;
                savedColors.Invalidate();
            }
            else
            {
                savedColors.DrawMode = Helpers.SimpleListView.drawMode.Stylish;
                savedColors.Invalidate();
            }
        }

        private void previewRGB_Click(object sender, EventArgs e)
        {
            CopyTextData(previewRGB.Text);
        }

        private void previewHTML_Click(object sender, EventArgs e)
        {
            CopyTextData(previewHTML.Text);
        }

        private void previewHSB_Click(object sender, EventArgs e)
        {
            CopyTextData(previewHSB.Text);
        }

        private void previewHSV_Click(object sender, EventArgs e)
        {
            CopyTextData(previewHSV.Text);
        }

        private void previewLab_Click(object sender, EventArgs e)
        {
            CopyTextData(previewLab.Text);
        }

        private void previewCMYK_Click(object sender, EventArgs e)
        {
            CopyTextData(previewCMYK.Text);
        }

        private void previewXYZ_Click(object sender, EventArgs e)
        {
            CopyTextData(previewXYZ.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            CenterForm(about);

            if(about.ShowDialog() == DialogResult.OK)
            {
                //Do nothing
            }
        }

        private void saveAsProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter xmlwriter = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8);
                xmlwriter.Formatting = Formatting.Indented;
                xmlwriter.WriteStartElement("Colors");

                foreach (ListViewItem item in savedColors.Items)
                {
                    xmlwriter.WriteStartElement("Color");

                    xmlwriter.WriteStartElement("Name");
                    xmlwriter.WriteString(item.SubItems[0].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("RGB");
                    xmlwriter.WriteString(item.SubItems[1].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("HTML");
                    xmlwriter.WriteString(item.SubItems[2].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("HSL");
                    xmlwriter.WriteString(item.SubItems[3].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("HSV");
                    xmlwriter.WriteString(item.SubItems[4].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("CMYK");
                    xmlwriter.WriteString(item.SubItems[5].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("XYZ");
                    xmlwriter.WriteString(item.SubItems[6].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteStartElement("Lab");
                    xmlwriter.WriteString(item.SubItems[7].Text);
                    xmlwriter.WriteEndElement();

                    xmlwriter.WriteEndElement();

                }

                xmlwriter.WriteEndElement();
                xmlwriter.Close();
            }

        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                savedColors.Items.Clear();
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(openFileDialog.FileName);

                foreach (XmlNode node in xdoc.SelectNodes("Colors/Color"))
                {
                    
                    string[] row = new string[]
                    {
                        node.SelectSingleNode("Name").InnerText,
                        node.SelectSingleNode("RGB").InnerText,
                        node.SelectSingleNode("HTML").InnerText,
                        node.SelectSingleNode("HSL").InnerText,
                        node.SelectSingleNode("HSV").InnerText,
                        node.SelectSingleNode("CMYK").InnerText,
                        node.SelectSingleNode("XYZ").InnerText,
                        node.SelectSingleNode("Lab").InnerText
                    };

                    string previewRGB = node.SelectSingleNode("RGB").InnerText;

                    Color m_rgb = Color.FromArgb(
                        int.Parse(previewRGB.Substring(0, previewRGB.IndexOf(','))),
                        int.Parse(previewRGB.Substring(previewRGB.IndexOf(',') + 1,
                            previewRGB.LastIndexOf(',') - previewRGB.IndexOf(',') - 1)),
                        int.Parse(previewRGB.Substring(previewRGB.LastIndexOf(',') + 1)));
                    
                    ListViewItem lvi = new ListViewItem(row);
                    lvi.BackColor = m_rgb;
                    savedColors.Invalidate();
                    savedColors.Items.Add(lvi);
                    
                }
                
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.Hide();

            notifyIcon1.ShowBalloonTip(2000, "Color Picker Running",
                "The Color Picker is still running in the background", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                this.Show();

                ChangeForm();

                MovingAnimation();

                animator.Activate();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RestoreForm();
            this.Show();
        }
    }
}
