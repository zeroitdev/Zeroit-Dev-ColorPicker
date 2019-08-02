// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-30-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-01-2019
// ***********************************************************************
// <copyright file="FollowTextForm.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ZeroitDevColorPicker
{
    partial class FollowTextForm
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
            this.FollowText = new ZeroitDevColorPicker.TransparentText();
            this.SuspendLayout();
            // 
            // FollowText
            // 
            this.FollowText.AllowTransparency = true;
            this.FollowText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FollowText.Font = new System.Drawing.Font("Consolas", 9F);
            this.FollowText.ForeColor = System.Drawing.Color.White;
            this.FollowText.Location = new System.Drawing.Point(0, 0);
            this.FollowText.Name = "FollowText";
            this.FollowText.Size = new System.Drawing.Size(49, 22);
            this.FollowText.TabIndex = 0;
            this.FollowText.Text = "RGB";
            // 
            // FollowTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(49, 22);
            this.Controls.Add(this.FollowText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FollowTextForm";
            this.Opacity = 0.4D;
            this.ShowInTaskbar = false;
            this.Text = "FollowTextForm";
            this.ResumeLayout(false);

        }

        #endregion

        public TransparentText FollowText;
    }
}