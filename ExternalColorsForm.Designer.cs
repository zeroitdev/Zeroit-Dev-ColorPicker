// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-30-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-01-2019
// ***********************************************************************
// <copyright file="ExternalColorsForm.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace ZeroitDevColorPicker
{
    partial class ExternalColorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ZeroitDevColorPicker.ColorConverters.HSL hsl1 = new ZeroitDevColorPicker.ColorConverters.HSL();
            ZeroitDevColorPicker.ColorConverters.HSL hsl2 = new ZeroitDevColorPicker.ColorConverters.HSL();
            this.baseTheme1 = new ZeroitDevColorPicker.BaseTheme();
            this.cancelBtn = new ZeroitDevColorPicker.Helpers.Button.ZeroitLollipopClickButton();
            this.okBtn = new ZeroitDevColorPicker.Helpers.Button.ZeroitLollipopClickButton();
            this.closeBtn = new System.Windows.Forms.Button();
            this.transparentPanel3 = new ZeroitDevColorPicker.TransparentPanel();
            this.currentColor = new ZeroitDevColorPicker.TransparentPanel();
            this.previousColor = new ZeroitDevColorPicker.TransparentPanel();
            this.colorFader = new ZeroitDevColorPicker.Helpers.Fader.ColorFader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blueSlider = new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider();
            this.greenSlider = new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider();
            this.redSlider = new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider();
            this.adobeColorBox = new ZeroitDevColorPicker.Helpers.Adobe.ZeroitAdobeColorBox();
            this.adobeColorSlider = new ZeroitDevColorPicker.Helpers.Adobe.ZeroitAdobeVerticalColorSlider();
            this.circleWheel = new ZeroitDevColorPicker.Helpers.ColorWheel.ZeroitColorWheel();
            this.colorPalette = new ZeroitDevColorPicker.Helpers.ColorPaleteControl();
            this.alphaSlider = new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider();
            this.baseTheme1.SuspendLayout();
            this.transparentPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme1
            // 
            this.baseTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme1.Colors = new ZeroitDevColorPicker.Bloom[0];
            this.baseTheme1.Controls.Add(this.cancelBtn);
            this.baseTheme1.Controls.Add(this.okBtn);
            this.baseTheme1.Controls.Add(this.closeBtn);
            this.baseTheme1.Controls.Add(this.transparentPanel3);
            this.baseTheme1.Controls.Add(this.colorFader);
            this.baseTheme1.Controls.Add(this.panel1);
            this.baseTheme1.Customization = "";
            this.baseTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.baseTheme1.Image = null;
            this.baseTheme1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baseTheme1.ImageSize = new System.Drawing.Size(0, 0);
            this.baseTheme1.Location = new System.Drawing.Point(0, 0);
            this.baseTheme1.Movable = true;
            this.baseTheme1.Name = "baseTheme1";
            this.baseTheme1.NoRounding = false;
            this.baseTheme1.ShowIcon = false;
            this.baseTheme1.ShowText = false;
            this.baseTheme1.Sizable = true;
            this.baseTheme1.Size = new System.Drawing.Size(835, 527);
            this.baseTheme1.SmartBounds = true;
            this.baseTheme1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.baseTheme1.TabIndex = 0;
            this.baseTheme1.Text = "Color";
            this.baseTheme1.TextAlign = System.Drawing.StringAlignment.Center;
            this.baseTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme1.Transparent = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.AllowTransparency = true;
            this.cancelBtn.AnimationInterval = 1;
            this.cancelBtn.BorderColor = System.Drawing.Color.Lime;
            this.cancelBtn.BorderWidth = 1F;
            this.cancelBtn.ClickLimit = 10;
            this.cancelBtn.ClickSpeed = 1;
            this.cancelBtn.Corners = 1F;
            this.cancelBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.cancelBtn.DoubleRipple = true;
            this.cancelBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.cancelBtn.Length = 100;
            this.cancelBtn.Location = new System.Drawing.Point(736, 485);
            this.cancelBtn.Mirror = false;
            this.cancelBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cancelBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.cancelBtn.RippleOpacity = 25;
            this.cancelBtn.ShowText = true;
            this.cancelBtn.Size = new System.Drawing.Size(84, 30);
            this.cancelBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.cancelBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.AllowTransparency = true;
            this.okBtn.AnimationInterval = 1;
            this.okBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.okBtn.BorderWidth = 1F;
            this.okBtn.ClickLimit = 10;
            this.okBtn.ClickSpeed = 1;
            this.okBtn.Corners = 1F;
            this.okBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.okBtn.DoubleRipple = true;
            this.okBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Image = null;
            this.okBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.okBtn.Length = 100;
            this.okBtn.Location = new System.Drawing.Point(646, 486);
            this.okBtn.Mirror = false;
            this.okBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.okBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.okBtn.Name = "okBtn";
            this.okBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.okBtn.RippleOpacity = 25;
            this.okBtn.ShowText = true;
            this.okBtn.Size = new System.Drawing.Size(84, 30);
            this.okBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.okBtn.TabIndex = 31;
            this.okBtn.Text = "OK";
            this.okBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.okBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(814, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 19);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // transparentPanel3
            // 
            this.transparentPanel3.AllowTransparency = true;
            this.transparentPanel3.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel3.Border = 1;
            this.transparentPanel3.BorderColor = System.Drawing.Color.Black;
            this.transparentPanel3.Circle = false;
            this.transparentPanel3.Controls.Add(this.currentColor);
            this.transparentPanel3.Controls.Add(this.previousColor);
            this.transparentPanel3.Location = new System.Drawing.Point(648, 40);
            this.transparentPanel3.MiddleColor = System.Drawing.Color.Red;
            this.transparentPanel3.MiddleDivisor = 10;
            this.transparentPanel3.Name = "transparentPanel3";
            this.transparentPanel3.ShowInner = false;
            this.transparentPanel3.Size = new System.Drawing.Size(169, 153);
            this.transparentPanel3.TabIndex = 7;
            // 
            // currentColor
            // 
            this.currentColor.AllowTransparency = true;
            this.currentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.currentColor.Border = 1;
            this.currentColor.BorderColor = System.Drawing.Color.Black;
            this.currentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColor.Circle = false;
            this.currentColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentColor.Location = new System.Drawing.Point(0, 0);
            this.currentColor.MiddleColor = System.Drawing.Color.Red;
            this.currentColor.MiddleDivisor = 10;
            this.currentColor.Name = "currentColor";
            this.currentColor.ShowInner = false;
            this.currentColor.Size = new System.Drawing.Size(169, 75);
            this.currentColor.TabIndex = 7;
            // 
            // previousColor
            // 
            this.previousColor.AllowTransparency = true;
            this.previousColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previousColor.Border = 1;
            this.previousColor.BorderColor = System.Drawing.Color.Black;
            this.previousColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previousColor.Circle = false;
            this.previousColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousColor.Location = new System.Drawing.Point(0, 78);
            this.previousColor.MiddleColor = System.Drawing.Color.Red;
            this.previousColor.MiddleDivisor = 10;
            this.previousColor.Name = "previousColor";
            this.previousColor.ShowInner = false;
            this.previousColor.Size = new System.Drawing.Size(169, 75);
            this.previousColor.TabIndex = 6;
            // 
            // colorFader
            // 
            this.colorFader.BorderColor = System.Drawing.Color.Gray;
            this.colorFader.BorderWidth = 1;
            this.colorFader.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorFader.GridColor = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Transparent};
            this.colorFader.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeCheckerBoard;
            this.colorFader.Location = new System.Drawing.Point(648, 209);
            this.colorFader.Maximum = 255F;
            this.colorFader.Minimum = 0F;
            this.colorFader.Name = "colorFader";
            this.colorFader.Position = 20F;
            this.colorFader.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorFader.Size = new System.Drawing.Size(169, 21);
            this.colorFader.TabIndex = 5;
            this.colorFader.Text = "colorFader1";
            this.colorFader.Scroll += new System.EventHandler(this.colorFader_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.alphaSlider);
            this.panel1.Controls.Add(this.blueSlider);
            this.panel1.Controls.Add(this.greenSlider);
            this.panel1.Controls.Add(this.redSlider);
            this.panel1.Controls.Add(this.adobeColorBox);
            this.panel1.Controls.Add(this.adobeColorSlider);
            this.panel1.Controls.Add(this.circleWheel);
            this.panel1.Controls.Add(this.colorPalette);
            this.panel1.Location = new System.Drawing.Point(15, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 476);
            this.panel1.TabIndex = 4;
            // 
            // blueSlider
            // 
            this.blueSlider.AllowTransparency = true;
            this.blueSlider.CircleColor = System.Drawing.Color.DodgerBlue;
            this.blueSlider.CircleReduction = 3;
            this.blueSlider.Depth = 0;
            this.blueSlider.FillColor = System.Drawing.Color.DodgerBlue;
            this.blueSlider.ForeColor = System.Drawing.Color.White;
            this.blueSlider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blueSlider.LineSize = 1F;
            this.blueSlider.Location = new System.Drawing.Point(392, 385);
            this.blueSlider.MaxValue = 255F;
            this.blueSlider.MinValColor = System.Drawing.Color.Gray;
            this.blueSlider.MinValue = 0F;
            this.blueSlider.MouseState = ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.State.HOVER;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.blueSlider.OuterCircleAlpha = 100;
            this.blueSlider.PostFix = "";
            this.blueSlider.ShowMaxMin = true;
            this.blueSlider.ShowPercentage = true;
            this.blueSlider.Size = new System.Drawing.Size(229, 40);
            this.blueSlider.Spacing = 1;
            this.blueSlider.TabIndex = 7;
            this.blueSlider.Text = "zeroitLollipopSlider3";
            this.blueSlider.Value = 50F;
            this.blueSlider.ValueChanged += new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.OnValueChanged(this.blueSlider_ValueChanged);
            // 
            // greenSlider
            // 
            this.greenSlider.AllowTransparency = true;
            this.greenSlider.CircleColor = System.Drawing.Color.LawnGreen;
            this.greenSlider.CircleReduction = 3;
            this.greenSlider.Depth = 0;
            this.greenSlider.FillColor = System.Drawing.Color.LawnGreen;
            this.greenSlider.ForeColor = System.Drawing.Color.White;
            this.greenSlider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.greenSlider.LineSize = 1F;
            this.greenSlider.Location = new System.Drawing.Point(392, 343);
            this.greenSlider.MaxValue = 255F;
            this.greenSlider.MinValColor = System.Drawing.Color.Gray;
            this.greenSlider.MinValue = 0F;
            this.greenSlider.MouseState = ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.State.HOVER;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.greenSlider.OuterCircleAlpha = 100;
            this.greenSlider.PostFix = "";
            this.greenSlider.ShowMaxMin = true;
            this.greenSlider.ShowPercentage = true;
            this.greenSlider.Size = new System.Drawing.Size(229, 40);
            this.greenSlider.Spacing = 1;
            this.greenSlider.TabIndex = 6;
            this.greenSlider.Text = "zeroitLollipopSlider2";
            this.greenSlider.Value = 50F;
            this.greenSlider.ValueChanged += new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.OnValueChanged(this.greenSlider_ValueChanged);
            // 
            // redSlider
            // 
            this.redSlider.AllowTransparency = true;
            this.redSlider.CircleColor = System.Drawing.Color.Red;
            this.redSlider.CircleReduction = 3;
            this.redSlider.Depth = 0;
            this.redSlider.FillColor = System.Drawing.Color.Red;
            this.redSlider.ForeColor = System.Drawing.Color.White;
            this.redSlider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.redSlider.LineSize = 1F;
            this.redSlider.Location = new System.Drawing.Point(391, 301);
            this.redSlider.MaxValue = 255F;
            this.redSlider.MinValColor = System.Drawing.Color.Gray;
            this.redSlider.MinValue = 0F;
            this.redSlider.MouseState = ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.State.HOVER;
            this.redSlider.Name = "redSlider";
            this.redSlider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.redSlider.OuterCircleAlpha = 100;
            this.redSlider.PostFix = "";
            this.redSlider.ShowMaxMin = true;
            this.redSlider.ShowPercentage = true;
            this.redSlider.Size = new System.Drawing.Size(229, 40);
            this.redSlider.Spacing = 1;
            this.redSlider.TabIndex = 5;
            this.redSlider.Text = "zeroitLollipopSlider1";
            this.redSlider.Value = 50F;
            this.redSlider.ValueChanged += new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.OnValueChanged(this.redSlider_ValueChanged);
            // 
            // adobeColorBox
            // 
            this.adobeColorBox.AllowTransparency = true;
            this.adobeColorBox.BorderColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Black};
            this.adobeColorBox.DrawStyle = ZeroitDevColorPicker.Helpers.Adobe.ZeroitAdobeColorBox.eDrawStyle.Hue;
            hsl1.H = 0D;
            hsl1.L = 0D;
            hsl1.S = 1D;
            this.adobeColorBox.HSL = hsl1;
            this.adobeColorBox.Location = new System.Drawing.Point(309, 5);
            this.adobeColorBox.MarkerColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black};
            this.adobeColorBox.Name = "adobeColorBox";
            this.adobeColorBox.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adobeColorBox.Size = new System.Drawing.Size(267, 250);
            this.adobeColorBox.TabIndex = 1;
            this.adobeColorBox.Text = "zeroitAdobeColorBox1";
            this.adobeColorBox.Scroll += new ZeroitDevColorPicker.Helpers.Adobe.EventHandler(this.zeroitAdobeColorBox1_Scroll);
            // 
            // adobeColorSlider
            // 
            this.adobeColorSlider.AllowTransparency = true;
            this.adobeColorSlider.BorderColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.adobeColorSlider.DrawStyle = ZeroitDevColorPicker.Helpers.Adobe.ZeroitAdobeVerticalColorSlider.eDrawStyle.Hue;
            hsl2.H = 0D;
            hsl2.L = 1D;
            hsl2.S = 1D;
            this.adobeColorSlider.HSL = hsl2;
            this.adobeColorSlider.Location = new System.Drawing.Point(584, 5);
            this.adobeColorSlider.Name = "adobeColorSlider";
            this.adobeColorSlider.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adobeColorSlider.Size = new System.Drawing.Size(37, 250);
            this.adobeColorSlider.SliderColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))))};
            this.adobeColorSlider.TabIndex = 0;
            this.adobeColorSlider.Text = "zeroitAdobeVerticalColorSlider1";
            this.adobeColorSlider.Scroll += new ZeroitDevColorPicker.Helpers.Adobe.EventHandler(this.zeroitAdobeVerticalColorSlider1_Scroll);
            // 
            // circleWheel
            // 
            this.circleWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.circleWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circleWheel.ColorStep = 1;
            this.circleWheel.Location = new System.Drawing.Point(3, 3);
            this.circleWheel.Name = "circleWheel";
            this.circleWheel.Size = new System.Drawing.Size(283, 258);
            this.circleWheel.TabIndex = 3;
            this.circleWheel.WheelBorder = 3;
            this.circleWheel.WheelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.circleWheel.ColorChanged += new System.EventHandler(this.circleWheel_ColorChanged);
            // 
            // colorPalette
            // 
            this.colorPalette.DarkColor = System.Drawing.Color.Maroon;
            this.colorPalette.EdgeSize = 6;
            this.colorPalette.Location = new System.Drawing.Point(3, 267);
            this.colorPalette.LowerEdgeCount = 40;
            this.colorPalette.Name = "colorPalette";
            this.colorPalette.Size = new System.Drawing.Size(410, 211);
            this.colorPalette.TabIndex = 2;
            this.colorPalette.Text = "colorPaleteControl1";
            this.colorPalette.UpperEdgeCount = 20;
            this.colorPalette.ColorCellSelected += new ZeroitDevColorPicker.Helpers.ColorSelectedHandler(this.colorPalette_ColorCellSelected);
            // 
            // alphaSlider
            // 
            this.alphaSlider.AllowTransparency = true;
            this.alphaSlider.CircleColor = System.Drawing.Color.White;
            this.alphaSlider.CircleReduction = 3;
            this.alphaSlider.Depth = 0;
            this.alphaSlider.FillColor = System.Drawing.Color.White;
            this.alphaSlider.ForeColor = System.Drawing.Color.White;
            this.alphaSlider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.alphaSlider.LineSize = 1F;
            this.alphaSlider.Location = new System.Drawing.Point(391, 263);
            this.alphaSlider.MaxValue = 255F;
            this.alphaSlider.MinValColor = System.Drawing.Color.Gray;
            this.alphaSlider.MinValue = 0F;
            this.alphaSlider.MouseState = ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.State.HOVER;
            this.alphaSlider.Name = "alphaSlider";
            this.alphaSlider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.alphaSlider.OuterCircleAlpha = 100;
            this.alphaSlider.PostFix = "";
            this.alphaSlider.ShowMaxMin = true;
            this.alphaSlider.ShowPercentage = true;
            this.alphaSlider.Size = new System.Drawing.Size(229, 40);
            this.alphaSlider.Spacing = 1;
            this.alphaSlider.TabIndex = 33;
            this.alphaSlider.Text = "zeroitLollipopSlider1";
            this.alphaSlider.Value = 50F;
            this.alphaSlider.ValueChanged += new ZeroitDevColorPicker.Helpers.Sliders.ZeroitLollipopSlider.OnValueChanged(this.alphaSlider_ValueChanged);
            // 
            // ExternalColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 527);
            this.Controls.Add(this.baseTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExternalColorsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExternalColorsForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.ExternalColorsForm_Load);
            this.baseTheme1.ResumeLayout(false);
            this.transparentPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme1;
        private Helpers.Adobe.ZeroitAdobeColorBox adobeColorBox;
        private Helpers.Adobe.ZeroitAdobeVerticalColorSlider adobeColorSlider;
        private Helpers.ColorPaleteControl colorPalette;
        private Helpers.ColorWheel.ZeroitColorWheel circleWheel;
        private TransparentPanel transparentPanel3;
        private TransparentPanel currentColor;
        private TransparentPanel previousColor;
        private Helpers.Fader.ColorFader colorFader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private Helpers.Button.ZeroitLollipopClickButton cancelBtn;
        private Helpers.Button.ZeroitLollipopClickButton okBtn;
        public Helpers.Sliders.ZeroitLollipopSlider blueSlider;
        public Helpers.Sliders.ZeroitLollipopSlider greenSlider;
        public Helpers.Sliders.ZeroitLollipopSlider redSlider;
        public Helpers.Sliders.ZeroitLollipopSlider alphaSlider;
    }
}