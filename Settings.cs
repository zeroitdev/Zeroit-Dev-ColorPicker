// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-29-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="Settings.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void MGlass_GridColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                MGlass_GridColor.BackColor = colorDialog.Color;
                MGlass_GridColor.Invalidate();
            }
        }

        private void Follow_Middle_Color_Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Follow_Middle_Color_Btn.BackColor = colorDialog.Color;
                Follow_Middle_Color_Btn.Invalidate();
            }
        }

        private void Follow_Border_Color_Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Follow_Border_Color_Btn.BackColor = colorDialog.Color;
                Follow_Border_Color_Btn.Invalidate();
            }
        }

        private void Follow_Code_Color_Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Follow_Code_Color_Btn.BackColor = colorDialog.Color;
                Follow_Code_Color_Btn.Invalidate();
            }
        }
    }
}
