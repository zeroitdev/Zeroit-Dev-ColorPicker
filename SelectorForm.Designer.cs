namespace ZeroitDevColorPicker
{
    partial class SelectorForm
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
            this.selectorPanel = new ZeroitDevColorPicker.TransparentPanel();
            this.SuspendLayout();
            // 
            // selectorPanel
            // 
            this.selectorPanel.AllowTransparency = true;
            this.selectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.selectorPanel.Border = 1;
            this.selectorPanel.BorderColor = System.Drawing.Color.Cyan;
            this.selectorPanel.Circle = false;
            this.selectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectorPanel.Location = new System.Drawing.Point(0, 0);
            this.selectorPanel.MiddleColor = System.Drawing.Color.Red;
            this.selectorPanel.MiddleDivisor = 10;
            this.selectorPanel.Name = "selectorPanel";
            this.selectorPanel.ShowInner = true;
            this.selectorPanel.Size = new System.Drawing.Size(30, 30);
            this.selectorPanel.TabIndex = 0;
            this.selectorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.selectorPanel_MouseDown);
            this.selectorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectorPanel_MouseUp);
            // 
            // SelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Border = 2;
            this.BorderColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(30, 30);
            this.Controls.Add(this.selectorPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(30, 30);
            this.MiddleColor = System.Drawing.SystemColors.Control;
            this.MiddleDivisor = 3;
            this.MinimumSize = new System.Drawing.Size(30, 30);
            this.Name = "SelectorForm";
            this.Opacity = 0.015D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectorForm";
            this.LocationChanged += new System.EventHandler(this.SelectorForm_LocationChanged);
            this.Click += new System.EventHandler(this.SelectorForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        public TransparentPanel selectorPanel;
    }
}