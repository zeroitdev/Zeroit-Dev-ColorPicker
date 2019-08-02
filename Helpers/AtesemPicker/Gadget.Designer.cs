namespace ZeroitDevColorPicker
{
    partial class Gadget
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AColor = new System.Windows.Forms.Panel();
            this.SColor = new System.Windows.Forms.Panel();
            this.lR = new System.Windows.Forms.Label();
            this.lG = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.lH = new System.Windows.Forms.Label();
            this.bSelect = new System.Windows.Forms.Button();
            this.MGlass = new ZeroitDevColorPicker.MagnifyingGlass();
            this.SuspendLayout();
            // 
            // AColor
            // 
            this.AColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AColor.Location = new System.Drawing.Point(76, 7);
            this.AColor.Name = "AColor";
            this.AColor.Size = new System.Drawing.Size(33, 63);
            this.AColor.TabIndex = 1;
            // 
            // SColor
            // 
            this.SColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SColor.Location = new System.Drawing.Point(76, 7);
            this.SColor.Name = "SColor";
            this.SColor.Size = new System.Drawing.Size(33, 37);
            this.SColor.TabIndex = 2;
            this.SColor.Click += new System.EventHandler(this.SColor_Click);
            this.SColor.MouseEnter += new System.EventHandler(this.SColor_MouseEnter);
            this.SColor.MouseLeave += new System.EventHandler(this.SColor_MouseLeave);
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.lR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lR.Location = new System.Drawing.Point(4, 7);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(15, 13);
            this.lR.TabIndex = 3;
            this.lR.Text = "R";
            this.lR.Click += new System.EventHandler(this.lR_Click);
            this.lR.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lR.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // lG
            // 
            this.lG.AutoSize = true;
            this.lG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.lG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lG.Location = new System.Drawing.Point(4, 20);
            this.lG.Name = "lG";
            this.lG.Size = new System.Drawing.Size(15, 13);
            this.lG.TabIndex = 4;
            this.lG.Text = "G";
            this.lG.Click += new System.EventHandler(this.lG_Click);
            this.lG.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lG.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lB.Location = new System.Drawing.Point(4, 33);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(14, 13);
            this.lB.TabIndex = 5;
            this.lB.Text = "B";
            this.lB.Click += new System.EventHandler(this.lB_Click);
            this.lB.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lB.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // lH
            // 
            this.lH.AutoSize = true;
            this.lH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.lH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lH.Location = new System.Drawing.Point(4, 55);
            this.lH.Name = "lH";
            this.lH.Size = new System.Drawing.Size(15, 13);
            this.lH.TabIndex = 6;
            this.lH.Text = "H";
            this.lH.Click += new System.EventHandler(this.lH_Click);
            this.lH.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lH.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // bSelect
            // 
            this.bSelect.Image = global::ZeroitDevColorPicker.Properties.Resources.Pipette;
            this.bSelect.Location = new System.Drawing.Point(76, 50);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(33, 23);
            this.bSelect.TabIndex = 7;
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // MGlass
            // 
            this.MGlass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MGlass.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.MGlass.Location = new System.Drawing.Point(7, 7);
            this.MGlass.Name = "MGlass";
            this.MGlass.PixelRange = 10;
            this.MGlass.PixelSize = 3;
            this.MGlass.PosAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MGlass.PosFormat = "#x ; #y";
            this.MGlass.ShowPixel = true;
            this.MGlass.ShowPosition = true;
            this.MGlass.Size = new System.Drawing.Size(63, 63);
            this.MGlass.TabIndex = 0;
            this.MGlass.UseMovingGlass = true;
            this.MGlass.DisplayUpdated += new ZeroitDevColorPicker.MagnifyingGlass.DisplayUpdatedDelegate(this.MGlass_DisplayUpdated);
            // 
            // Gadget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.lH);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.lG);
            this.Controls.Add(this.lR);
            this.Controls.Add(this.SColor);
            this.Controls.Add(this.AColor);
            this.Controls.Add(this.MGlass);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Gadget";
            this.Size = new System.Drawing.Size(120, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagnifyingGlass MGlass;
        private System.Windows.Forms.Panel AColor;
        private System.Windows.Forms.Panel SColor;
        private System.Windows.Forms.Label lR;
        private System.Windows.Forms.Label lG;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Label lH;
        private System.Windows.Forms.Button bSelect;
    }
}
