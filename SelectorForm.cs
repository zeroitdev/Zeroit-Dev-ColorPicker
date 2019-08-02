// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-29-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="SelectorForm.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public partial class SelectorForm : InheritedForm
    {

        private bool clicked = false;

        public bool Clicked
        {
            get { return clicked; }
            set
            {
                clicked = value;
                Invalidate();
            }
        }
        public SelectorForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable, true);
            
        }

        private void SelectorForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Clicked = true;

            this.Hide();
        }
                
        private void selectorPanel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;

            if (Clicked)
            {
                this.Hide();
            }
        }

        private void SelectorForm_LocationChanged(object sender, EventArgs e)
        {
            
            
        }

        
        public int Delta
        {
            get;
            set;
        }

        public int X
        {
            get;
            set;

        }

        public int Y
        {
            get;
            set;

        }

        public int Clicks
        {
            get;
            set;

        }

        public MouseButtons MouseButton
        {
            get;
            set;
        }

        private void selectorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Delta = e.Delta;
            X = e.X;
            Y = e.Y;
            Clicks = e.Clicks;
            MouseButton = e.Button;                    

            this.Size = new Size(10, 10);
            Clicked = true;            
                        
        }

        private void selectorPanel_MouseUp(object sender, MouseEventArgs e)
        {
             
            this.Size = new Size(30, 30);            
            this.Hide();
            
        }
    }
}
