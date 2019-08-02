// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-29-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-01-2019
// ***********************************************************************
// <copyright file="Settings.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ZeroitDevColorPicker
{
    partial class Settings
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
            this.baseTheme1 = new ZeroitDevColorPicker.BaseTheme();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Follow_Border_Color_Btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Follow_Middle_Color_Btn = new System.Windows.Forms.Button();
            this.Follow_Divisor_Num = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Follow_Inner_No = new System.Windows.Forms.RadioButton();
            this.Follow_Inner_Yes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Follow_Circle_No = new System.Windows.Forms.RadioButton();
            this.Follow_Circle_Yes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MGlass_GridColor = new System.Windows.Forms.Button();
            this.MGlass_Zoom_Num = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MGlass_ShowTxtWithSnapshot_No = new System.Windows.Forms.RadioButton();
            this.MGlass_ShowTxtWithSnapshot_Yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MGlass_ShowGrid_No = new System.Windows.Forms.RadioButton();
            this.MGlass_ShowGrid_Yes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Follow_Code_Color_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.baseTheme1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Follow_Divisor_Num)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGlass_Zoom_Num)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme1
            // 
            this.baseTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme1.Colors = new ZeroitDevColorPicker.Bloom[0];
            this.baseTheme1.Controls.Add(this.groupBox2);
            this.baseTheme1.Controls.Add(this.closeBtn);
            this.baseTheme1.Controls.Add(this.groupBox1);
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
            this.baseTheme1.Size = new System.Drawing.Size(346, 265);
            this.baseTheme1.SmartBounds = true;
            this.baseTheme1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.baseTheme1.TabIndex = 0;
            this.baseTheme1.Text = "Settings";
            this.baseTheme1.TextAlign = System.Drawing.StringAlignment.Center;
            this.baseTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.baseTheme1.Transparent = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Follow_Code_Color_Btn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Follow_Border_Color_Btn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Follow_Middle_Color_Btn);
            this.groupBox2.Controls.Add(this.Follow_Divisor_Num);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 113);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Follow Control";
            // 
            // Follow_Border_Color_Btn
            // 
            this.Follow_Border_Color_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Follow_Border_Color_Btn.BackColor = System.Drawing.Color.White;
            this.Follow_Border_Color_Btn.FlatAppearance.BorderSize = 0;
            this.Follow_Border_Color_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Follow_Border_Color_Btn.Font = new System.Drawing.Font("Verdana", 8F);
            this.Follow_Border_Color_Btn.ForeColor = System.Drawing.Color.Black;
            this.Follow_Border_Color_Btn.Location = new System.Drawing.Point(91, 68);
            this.Follow_Border_Color_Btn.Name = "Follow_Border_Color_Btn";
            this.Follow_Border_Color_Btn.Size = new System.Drawing.Size(44, 18);
            this.Follow_Border_Color_Btn.TabIndex = 33;
            this.Follow_Border_Color_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Follow_Border_Color_Btn.UseCompatibleTextRendering = true;
            this.Follow_Border_Color_Btn.UseVisualStyleBackColor = false;
            this.Follow_Border_Color_Btn.Click += new System.EventHandler(this.Follow_Border_Color_Btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Border Color";
            // 
            // Follow_Middle_Color_Btn
            // 
            this.Follow_Middle_Color_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Follow_Middle_Color_Btn.BackColor = System.Drawing.Color.White;
            this.Follow_Middle_Color_Btn.FlatAppearance.BorderSize = 0;
            this.Follow_Middle_Color_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Follow_Middle_Color_Btn.Font = new System.Drawing.Font("Verdana", 8F);
            this.Follow_Middle_Color_Btn.ForeColor = System.Drawing.Color.Black;
            this.Follow_Middle_Color_Btn.Location = new System.Drawing.Point(91, 47);
            this.Follow_Middle_Color_Btn.Name = "Follow_Middle_Color_Btn";
            this.Follow_Middle_Color_Btn.Size = new System.Drawing.Size(44, 18);
            this.Follow_Middle_Color_Btn.TabIndex = 31;
            this.Follow_Middle_Color_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Follow_Middle_Color_Btn.UseCompatibleTextRendering = true;
            this.Follow_Middle_Color_Btn.UseVisualStyleBackColor = false;
            this.Follow_Middle_Color_Btn.Click += new System.EventHandler(this.Follow_Middle_Color_Btn_Click);
            // 
            // Follow_Divisor_Num
            // 
            this.Follow_Divisor_Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Follow_Divisor_Num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Follow_Divisor_Num.Font = new System.Drawing.Font("Verdana", 10F);
            this.Follow_Divisor_Num.ForeColor = System.Drawing.Color.White;
            this.Follow_Divisor_Num.Location = new System.Drawing.Point(91, 19);
            this.Follow_Divisor_Num.Name = "Follow_Divisor_Num";
            this.Follow_Divisor_Num.Size = new System.Drawing.Size(44, 24);
            this.Follow_Divisor_Num.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Follow_Inner_No);
            this.panel3.Controls.Add(this.Follow_Inner_Yes);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(161, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 46);
            this.panel3.TabIndex = 8;
            // 
            // Follow_Inner_No
            // 
            this.Follow_Inner_No.ForeColor = System.Drawing.Color.White;
            this.Follow_Inner_No.Location = new System.Drawing.Point(92, 26);
            this.Follow_Inner_No.Name = "Follow_Inner_No";
            this.Follow_Inner_No.Size = new System.Drawing.Size(46, 17);
            this.Follow_Inner_No.TabIndex = 7;
            this.Follow_Inner_No.Text = "No";
            this.Follow_Inner_No.UseVisualStyleBackColor = true;
            // 
            // Follow_Inner_Yes
            // 
            this.Follow_Inner_Yes.Checked = true;
            this.Follow_Inner_Yes.ForeColor = System.Drawing.Color.White;
            this.Follow_Inner_Yes.Location = new System.Drawing.Point(92, 3);
            this.Follow_Inner_Yes.Name = "Follow_Inner_Yes";
            this.Follow_Inner_Yes.Size = new System.Drawing.Size(46, 17);
            this.Follow_Inner_Yes.TabIndex = 6;
            this.Follow_Inner_Yes.TabStop = true;
            this.Follow_Inner_Yes.Text = "Yes";
            this.Follow_Inner_Yes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Show Inner\r\nControl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Divisor";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Follow_Circle_No);
            this.panel4.Controls.Add(this.Follow_Circle_Yes);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(161, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 46);
            this.panel4.TabIndex = 4;
            // 
            // Follow_Circle_No
            // 
            this.Follow_Circle_No.Checked = true;
            this.Follow_Circle_No.ForeColor = System.Drawing.Color.White;
            this.Follow_Circle_No.Location = new System.Drawing.Point(92, 26);
            this.Follow_Circle_No.Name = "Follow_Circle_No";
            this.Follow_Circle_No.Size = new System.Drawing.Size(46, 17);
            this.Follow_Circle_No.TabIndex = 7;
            this.Follow_Circle_No.TabStop = true;
            this.Follow_Circle_No.Text = "No";
            this.Follow_Circle_No.UseVisualStyleBackColor = true;
            // 
            // Follow_Circle_Yes
            // 
            this.Follow_Circle_Yes.ForeColor = System.Drawing.Color.White;
            this.Follow_Circle_Yes.Location = new System.Drawing.Point(92, 3);
            this.Follow_Circle_Yes.Name = "Follow_Circle_Yes";
            this.Follow_Circle_Yes.Size = new System.Drawing.Size(46, 17);
            this.Follow_Circle_Yes.TabIndex = 6;
            this.Follow_Circle_Yes.Text = "Yes";
            this.Follow_Circle_Yes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Circle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Middle Color";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(325, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 19);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MGlass_GridColor);
            this.groupBox1.Controls.Add(this.MGlass_Zoom_Num);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magnify Glass";
            // 
            // MGlass_GridColor
            // 
            this.MGlass_GridColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MGlass_GridColor.BackColor = System.Drawing.Color.White;
            this.MGlass_GridColor.FlatAppearance.BorderSize = 0;
            this.MGlass_GridColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MGlass_GridColor.Font = new System.Drawing.Font("Verdana", 8F);
            this.MGlass_GridColor.ForeColor = System.Drawing.Color.Black;
            this.MGlass_GridColor.Location = new System.Drawing.Point(91, 74);
            this.MGlass_GridColor.Name = "MGlass_GridColor";
            this.MGlass_GridColor.Size = new System.Drawing.Size(44, 26);
            this.MGlass_GridColor.TabIndex = 31;
            this.MGlass_GridColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MGlass_GridColor.UseCompatibleTextRendering = true;
            this.MGlass_GridColor.UseVisualStyleBackColor = false;
            this.MGlass_GridColor.Click += new System.EventHandler(this.MGlass_GridColor_Click);
            // 
            // MGlass_Zoom_Num
            // 
            this.MGlass_Zoom_Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MGlass_Zoom_Num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MGlass_Zoom_Num.Font = new System.Drawing.Font("Verdana", 10F);
            this.MGlass_Zoom_Num.ForeColor = System.Drawing.Color.White;
            this.MGlass_Zoom_Num.Location = new System.Drawing.Point(91, 22);
            this.MGlass_Zoom_Num.Name = "MGlass_Zoom_Num";
            this.MGlass_Zoom_Num.Size = new System.Drawing.Size(44, 24);
            this.MGlass_Zoom_Num.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MGlass_ShowTxtWithSnapshot_No);
            this.panel2.Controls.Add(this.MGlass_ShowTxtWithSnapshot_Yes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(161, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 46);
            this.panel2.TabIndex = 8;
            // 
            // MGlass_ShowTxtWithSnapshot_No
            // 
            this.MGlass_ShowTxtWithSnapshot_No.Checked = true;
            this.MGlass_ShowTxtWithSnapshot_No.ForeColor = System.Drawing.Color.White;
            this.MGlass_ShowTxtWithSnapshot_No.Location = new System.Drawing.Point(92, 26);
            this.MGlass_ShowTxtWithSnapshot_No.Name = "MGlass_ShowTxtWithSnapshot_No";
            this.MGlass_ShowTxtWithSnapshot_No.Size = new System.Drawing.Size(46, 17);
            this.MGlass_ShowTxtWithSnapshot_No.TabIndex = 7;
            this.MGlass_ShowTxtWithSnapshot_No.TabStop = true;
            this.MGlass_ShowTxtWithSnapshot_No.Text = "No";
            this.MGlass_ShowTxtWithSnapshot_No.UseVisualStyleBackColor = true;
            // 
            // MGlass_ShowTxtWithSnapshot_Yes
            // 
            this.MGlass_ShowTxtWithSnapshot_Yes.ForeColor = System.Drawing.Color.White;
            this.MGlass_ShowTxtWithSnapshot_Yes.Location = new System.Drawing.Point(92, 3);
            this.MGlass_ShowTxtWithSnapshot_Yes.Name = "MGlass_ShowTxtWithSnapshot_Yes";
            this.MGlass_ShowTxtWithSnapshot_Yes.Size = new System.Drawing.Size(46, 17);
            this.MGlass_ShowTxtWithSnapshot_Yes.TabIndex = 6;
            this.MGlass_ShowTxtWithSnapshot_Yes.Text = "Yes";
            this.MGlass_ShowTxtWithSnapshot_Yes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Show Text\r\nWith Snapshot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MGlass_ShowGrid_No);
            this.panel1.Controls.Add(this.MGlass_ShowGrid_Yes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(161, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 46);
            this.panel1.TabIndex = 4;
            // 
            // MGlass_ShowGrid_No
            // 
            this.MGlass_ShowGrid_No.ForeColor = System.Drawing.Color.White;
            this.MGlass_ShowGrid_No.Location = new System.Drawing.Point(92, 26);
            this.MGlass_ShowGrid_No.Name = "MGlass_ShowGrid_No";
            this.MGlass_ShowGrid_No.Size = new System.Drawing.Size(46, 17);
            this.MGlass_ShowGrid_No.TabIndex = 7;
            this.MGlass_ShowGrid_No.TabStop = true;
            this.MGlass_ShowGrid_No.Text = "No";
            this.MGlass_ShowGrid_No.UseVisualStyleBackColor = true;
            // 
            // MGlass_ShowGrid_Yes
            // 
            this.MGlass_ShowGrid_Yes.Checked = true;
            this.MGlass_ShowGrid_Yes.ForeColor = System.Drawing.Color.White;
            this.MGlass_ShowGrid_Yes.Location = new System.Drawing.Point(92, 3);
            this.MGlass_ShowGrid_Yes.Name = "MGlass_ShowGrid_Yes";
            this.MGlass_ShowGrid_Yes.Size = new System.Drawing.Size(46, 17);
            this.MGlass_ShowGrid_Yes.TabIndex = 6;
            this.MGlass_ShowGrid_Yes.TabStop = true;
            this.MGlass_ShowGrid_Yes.Text = "Yes";
            this.MGlass_ShowGrid_Yes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show \r\nGrid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grid Color";
            // 
            // Follow_Code_Color_Btn
            // 
            this.Follow_Code_Color_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Follow_Code_Color_Btn.BackColor = System.Drawing.Color.White;
            this.Follow_Code_Color_Btn.FlatAppearance.BorderSize = 0;
            this.Follow_Code_Color_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Follow_Code_Color_Btn.Font = new System.Drawing.Font("Verdana", 8F);
            this.Follow_Code_Color_Btn.ForeColor = System.Drawing.Color.Black;
            this.Follow_Code_Color_Btn.Location = new System.Drawing.Point(91, 89);
            this.Follow_Code_Color_Btn.Name = "Follow_Code_Color_Btn";
            this.Follow_Code_Color_Btn.Size = new System.Drawing.Size(44, 18);
            this.Follow_Code_Color_Btn.TabIndex = 35;
            this.Follow_Code_Color_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Follow_Code_Color_Btn.UseCompatibleTextRendering = true;
            this.Follow_Code_Color_Btn.UseVisualStyleBackColor = false;
            this.Follow_Code_Color_Btn.Click += new System.EventHandler(this.Follow_Code_Color_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Code Color";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 265);
            this.Controls.Add(this.baseTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.baseTheme1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Follow_Divisor_Num)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGlass_Zoom_Num)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.NumericUpDown MGlass_Zoom_Num;
        public System.Windows.Forms.RadioButton MGlass_ShowTxtWithSnapshot_No;
        public System.Windows.Forms.RadioButton MGlass_ShowTxtWithSnapshot_Yes;
        public System.Windows.Forms.RadioButton MGlass_ShowGrid_No;
        public System.Windows.Forms.RadioButton MGlass_ShowGrid_Yes;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.NumericUpDown Follow_Divisor_Num;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton Follow_Inner_No;
        public System.Windows.Forms.RadioButton Follow_Inner_Yes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.RadioButton Follow_Circle_No;
        public System.Windows.Forms.RadioButton Follow_Circle_Yes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button MGlass_GridColor;
        public System.Windows.Forms.Button Follow_Middle_Color_Btn;
        public System.Windows.Forms.Button Follow_Border_Color_Btn;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.Button Follow_Code_Color_Btn;
        private System.Windows.Forms.Label label10;
    }
}