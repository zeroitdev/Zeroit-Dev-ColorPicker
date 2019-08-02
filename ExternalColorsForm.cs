// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-30-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="ExternalColorsForm.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public partial class ExternalColorsForm : Form
    {

        private Color color;

        private Color lastColor;

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                Invalidate();
            }
        }

        public Color LastColor
        {
            get { return lastColor; }
            set
            {
                lastColor = value;
                Invalidate();
            }
        }

        public ExternalColorsForm(Color color, Color lastColor)
        {
            this.color = color;

            this.lastColor = lastColor;                      

            InitializeComponent();
                        
        }
            
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void circleWheel_ColorChanged(object sender, EventArgs e)
        {
            this.Color = circleWheel.Color;
            adobeColorBox.RGB = circleWheel.Color;
            colorPalette.DarkColor = circleWheel.Color;
            currentColor.BackColor = circleWheel.Color;
            colorFader.FirstColor = circleWheel.Color;
            colorFader.Position = (float)circleWheel.Color.A;

            alphaSlider.Value = circleWheel.Color.A;
            redSlider.Value = circleWheel.Color.R;
            greenSlider.Value = circleWheel.Color.G;
            blueSlider.Value = circleWheel.Color.B;
        }

        private void zeroitAdobeColorBox1_Scroll(object sender, EventArgs e)
        {
            this.Color = adobeColorBox.RGB;
            circleWheel.Color = adobeColorBox.RGB;
            colorPalette.DarkColor = adobeColorBox.RGB;
            currentColor.BackColor = adobeColorBox.RGB;
            colorFader.FirstColor = adobeColorBox.RGB;

            colorFader.Position = (float)adobeColorBox.RGB.A;

            alphaSlider.Value = adobeColorBox.RGB.A;
            redSlider.Value = adobeColorBox.RGB.R;
            greenSlider.Value = adobeColorBox.RGB.G;
            blueSlider.Value = adobeColorBox.RGB.B;
        }

        private void zeroitAdobeVerticalColorSlider1_Scroll(object sender, EventArgs e)
        {
            
            this.Color = adobeColorBox.RGB;
            adobeColorBox.RGB = adobeColorSlider.RGB;
            circleWheel.Color = adobeColorBox.RGB;
            colorPalette.DarkColor = adobeColorBox.RGB;
            currentColor.BackColor = adobeColorBox.RGB;
            colorFader.FirstColor = adobeColorBox.RGB;

            colorFader.Position = (float)adobeColorBox.RGB.A;

            alphaSlider.Value = adobeColorSlider.RGB.A;
            redSlider.Value = adobeColorSlider.RGB.R;
            greenSlider.Value = adobeColorSlider.RGB.G;
            blueSlider.Value = adobeColorSlider.RGB.B;
        }

        private void colorPalette_ColorCellSelected(object sender, Helpers.ColorSelectedEventArgs e)
        {
            this.Color = e.Color;
            currentColor.BackColor = e.Color;

            colorFader.Position = (float)e.Color.A;

            alphaSlider.Value = e.Color.A;
            redSlider.Value = e.Color.R;
            greenSlider.Value = e.Color.G;
            blueSlider.Value = e.Color.B;
        }

        private void colorFader_Scroll(object sender, EventArgs e)
        {
            Color changedColor = this.Color;
                             
            Color currentlyChanged = Color.FromArgb((int)colorFader.Position, changedColor.R, changedColor.G, changedColor.B);

            currentColor.BackColor = currentlyChanged;

            this.Color = currentlyChanged;
            adobeColorBox.RGB = currentlyChanged;
            circleWheel.Color = currentlyChanged;
            colorPalette.DarkColor = currentlyChanged;

            alphaSlider.Value = colorFader.Position;
        }

        private void ExternalColorsForm_Load(object sender, EventArgs e)
        {
            adobeColorBox.RGB = Color;
            circleWheel.Color = Color;
            colorPalette.DarkColor = Color;
            currentColor.BackColor = Color;
            colorFader.FirstColor = Color;
            colorFader.Position = (float)Color.A;

            redSlider.Value = Color.R;
            greenSlider.Value = Color.G;
            blueSlider.Value = Color.B;

            previousColor.BackColor = LastColor;

        }

        private void redSlider_ValueChanged(int newValue)
        {
            Color colorchanged = Color.FromArgb((int)redSlider.Value, Color.G, Color.B);
            adobeColorBox.RGB = colorchanged;
            colorPalette.DarkColor = colorchanged;
            currentColor.BackColor = colorchanged;
            colorFader.FirstColor = colorchanged;
            colorFader.Position = (float)colorchanged.A;

            alphaSlider.Value = colorchanged.A;
        }

        private void greenSlider_ValueChanged(int newValue)
        {
            Color colorchanged = Color.FromArgb(Color.R, (int)greenSlider.Value, Color.B);
            adobeColorBox.RGB = colorchanged;
            colorPalette.DarkColor = colorchanged;
            currentColor.BackColor = colorchanged;
            colorFader.FirstColor = colorchanged;
            colorFader.Position = (float)colorchanged.A;

            alphaSlider.Value = colorchanged.A;
        }

        private void blueSlider_ValueChanged(int newValue)
        {
            Color colorchanged = Color.FromArgb(Color.R, Color.G, (int)blueSlider.Value);
            adobeColorBox.RGB = colorchanged;
            colorPalette.DarkColor = colorchanged;
            currentColor.BackColor = colorchanged;
            colorFader.FirstColor = colorchanged;
            colorFader.Position = (float)colorchanged.A;

            alphaSlider.Value = colorchanged.A;
        }

        private void alphaSlider_ValueChanged(int newValue)
        {
            Color colorchanged = Color.FromArgb((int)alphaSlider.Value,Color.R, Color.G, Color.B);
            adobeColorBox.RGB = colorchanged;
            colorPalette.DarkColor = colorchanged;
            currentColor.BackColor = colorchanged;
            colorFader.FirstColor = colorchanged;
            colorFader.Position = alphaSlider.Value;
        }
    }
}
