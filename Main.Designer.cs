// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-28-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-01-2019
// ***********************************************************************
// <copyright file="Main.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace ZeroitDevColorPicker
{
    partial class Main
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

            DisposeSnapEye(disposing);

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ZeroitDevColorPicker.Helpers.Animations.ZeroitAnimate_Animation zeroitAnimate_Animation2 = new ZeroitDevColorPicker.Helpers.Animations.ZeroitAnimate_Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            ZeroitDevColorPicker.Helpers.Animations.FoldSizes foldSizes2 = new ZeroitDevColorPicker.Helpers.Animations.FoldSizes();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Grow grow2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Grow();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Locations locations2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Locations();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Move move2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Move();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Opacity opacity2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Opacity();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Positions positions2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Positions();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Shake shake2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Shake();
            ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Timer timer2 = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.Timer();
            this.baseTheme1 = new ZeroitDevColorPicker.BaseTheme();
            this.mainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimize = new System.Windows.Forms.Button();
            this.savedColors = new ZeroitDevColorPicker.Helpers.SimpleListView();
            this.savedColorsContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedDisplayedColors = new ZeroitDevColorPicker.NoFlickerPanel();
            this.updateBtn = new ZeroitDevColorPicker.Helpers.Button.ZeroitLollipopClickButton();
            this.updatePanel = new ZeroitDevColorPicker.NoFlickerPanel();
            this.previewCMYK = new System.Windows.Forms.Label();
            this.previewXYZ = new System.Windows.Forms.Label();
            this.previewLab = new System.Windows.Forms.Label();
            this.previewHSV = new System.Windows.Forms.Label();
            this.previewHSB = new System.Windows.Forms.Label();
            this.previewRGB = new System.Windows.Forms.Label();
            this.previewHTML = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.magnifyViewer = new ZeroitDevColorPicker.NoFlickerPanel();
            this.panel1 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.AColor = new ZeroitDevColorPicker.NoFlickerPanel();
            this.gridPanel = new ZeroitDevColorPicker.NoFlickerPanel();
            this.detailPanel = new ZeroitDevColorPicker.NoFlickerPanel();
            this.showColors = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.searchPanel = new ZeroitDevColorPicker.NoFlickerPanel();
            this.itemsFoundSecond = new System.Windows.Forms.Label();
            this.itemsFound = new System.Windows.Forms.Label();
            this.colorListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new ZeroitDevColorPicker.Helpers.ZeroitUltraTextBox();
            this.saveColorNamePanel = new ZeroitDevColorPicker.NoFlickerPanel();
            this.nameTxtBox = new ZeroitDevColorPicker.Helpers.ZeroitUltraTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.allWebColors = new ZeroitDevColorPicker.Helpers.Colors.WikiColors.AllWebColorsComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.precisionCheck = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.upDownBtn = new System.Windows.Forms.Button();
            this.externalLinkBtn = new System.Windows.Forms.Button();
            this.noFlickerPanel6 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.m_txt_H = new System.Windows.Forms.Label();
            this.m_txt_V = new System.Windows.Forms.Label();
            this.m_txt_S = new System.Windows.Forms.Label();
            this.noFlickerPanel5 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.m_txt_X = new System.Windows.Forms.Label();
            this.m_txt_Z = new System.Windows.Forms.Label();
            this.m_txt_Y = new System.Windows.Forms.Label();
            this.noFlickerPanel4 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleValue = new System.Windows.Forms.NumericUpDown();
            this.m_txt_L = new System.Windows.Forms.Label();
            this.m_txt_b = new System.Windows.Forms.Label();
            this.m_txt_a = new System.Windows.Forms.Label();
            this.noFlickerPanel3 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.m_txt_Cyan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_txt_K = new System.Windows.Forms.Label();
            this.m_txt_Yellow = new System.Windows.Forms.Label();
            this.m_txt_Magenta = new System.Windows.Forms.Label();
            this.noFlickerPanel2 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.m_txt_Hue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_Black = new System.Windows.Forms.Label();
            this.m_txt_Sat = new System.Windows.Forms.Label();
            this.noFlickerPanel1 = new ZeroitDevColorPicker.NoFlickerPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lR = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.lH = new System.Windows.Forms.Label();
            this.lG = new System.Windows.Forms.Label();
            this.rgb = new System.Windows.Forms.Label();
            this.bSelect = new System.Windows.Forms.Button();
            this.SColor = new ZeroitDevColorPicker.NoFlickerPanel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.animator = new ZeroitDevColorPicker.Helpers.Animations.ZeroitAnimator(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandFormAnimator = new ZeroitDevColorPicker.Helpers.Animations.ZeroitVisAnim();
            this.shrinkUp = new ZeroitDevColorPicker.Helpers.Animations.FormAnimator.ZeroitFormAnimator(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTheme1.SuspendLayout();
            this.mainForm.SuspendLayout();
            this.savedColorsContextMenuStrip1.SuspendLayout();
            this.savedDisplayedColors.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.magnifyViewer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.saveColorNamePanel.SuspendLayout();
            this.noFlickerPanel6.SuspendLayout();
            this.noFlickerPanel5.SuspendLayout();
            this.noFlickerPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).BeginInit();
            this.noFlickerPanel3.SuspendLayout();
            this.noFlickerPanel2.SuspendLayout();
            this.noFlickerPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.notifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme1
            // 
            this.baseTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme1.Colors = new ZeroitDevColorPicker.Bloom[0];
            this.baseTheme1.ContextMenuStrip = this.mainForm;
            this.baseTheme1.Controls.Add(this.minimize);
            this.baseTheme1.Controls.Add(this.savedColors);
            this.baseTheme1.Controls.Add(this.savedDisplayedColors);
            this.baseTheme1.Controls.Add(this.closeBtn);
            this.baseTheme1.Controls.Add(this.magnifyViewer);
            this.baseTheme1.Controls.Add(this.detailPanel);
            this.baseTheme1.Customization = "";
            this.animator.SetDecoration(this.baseTheme1, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
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
            this.baseTheme1.Sizable = false;
            this.baseTheme1.Size = new System.Drawing.Size(798, 488);
            this.baseTheme1.SmartBounds = true;
            this.baseTheme1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.baseTheme1.TabIndex = 0;
            this.baseTheme1.Text = "Zeroit Dev Color Picker";
            this.baseTheme1.TextAlign = System.Drawing.StringAlignment.Center;
            this.baseTheme1.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.baseTheme1.Transparent = false;
            this.baseTheme1.Click += new System.EventHandler(this.baseTheme1_Click_1);
            this.baseTheme1.MouseEnter += new System.EventHandler(this.baseTheme1_MouseEnter);
            this.baseTheme1.MouseLeave += new System.EventHandler(this.baseTheme1_MouseLeave);
            this.baseTheme1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // mainForm
            // 
            this.mainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.animator.SetDecoration(this.mainForm, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.mainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mainForm.Name = "savedColorsContextMenuStrip1";
            this.mainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainForm.ShowImageMargin = false;
            this.mainForm.Size = new System.Drawing.Size(83, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.minimize, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Verdana", 8F);
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(753, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 19);
            this.minimize.TabIndex = 35;
            this.minimize.Text = "_";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimize.UseCompatibleTextRendering = true;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // savedColors
            // 
            this.savedColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.savedColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedColors.CellBorderFocused = System.Drawing.Color.White;
            this.savedColors.CellBorderUnFocused = System.Drawing.Color.White;
            this.savedColors.ColumnHeader = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.savedColors.ContextMenuStrip = this.savedColorsContextMenuStrip1;
            this.animator.SetDecoration(this.savedColors, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.savedColors.DrawMode = ZeroitDevColorPicker.Helpers.SimpleListView.drawMode.Default;
            this.savedColors.FillFocused = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Gray};
            this.savedColors.FillUnfocused = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))))};
            this.savedColors.ForeColor = System.Drawing.Color.White;
            this.savedColors.FullRowSelect = true;
            this.savedColors.HeaderAlignment = ZeroitDevColorPicker.Helpers.SimpleListView.headerAlignment.Center;
            this.savedColors.HeaderBorder = System.Drawing.Color.White;
            this.savedColors.HeaderColor = System.Drawing.Color.White;
            this.savedColors.HeaderFont = new System.Drawing.Font("Consolas", 10F);
            this.savedColors.HideHeader = false;
            this.savedColors.LineColor = System.Drawing.Color.Yellow;
            this.savedColors.LineHeight = 1;
            this.savedColors.Location = new System.Drawing.Point(17, 246);
            this.savedColors.Name = "savedColors";
            this.savedColors.NumberStyles = ((System.Globalization.NumberStyles)((((((((System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite) 
            | System.Globalization.NumberStyles.AllowLeadingSign) 
            | System.Globalization.NumberStyles.AllowTrailingSign) 
            | System.Globalization.NumberStyles.AllowParentheses) 
            | System.Globalization.NumberStyles.AllowDecimalPoint) 
            | System.Globalization.NumberStyles.AllowThousands) 
            | System.Globalization.NumberStyles.AllowCurrencySymbol)));
            this.savedColors.Radius = 1F;
            this.savedColors.Rounding = false;
            this.savedColors.ShowBorder = false;
            this.savedColors.ShowCellBorder = false;
            this.savedColors.ShowHeaderLine = true;
            this.savedColors.Size = new System.Drawing.Size(566, 228);
            this.savedColors.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.savedColors.SubTextColor = System.Drawing.Color.Red;
            this.savedColors.SurrondBorder = false;
            this.savedColors.TabIndex = 34;
            this.savedColors.TextRendering = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.savedColors.UseCompatibleStateImageBehavior = false;
            this.savedColors.View = System.Windows.Forms.View.Details;
            this.savedColors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savedColors_MouseClick);
            this.savedColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // savedColorsContextMenuStrip1
            // 
            this.savedColorsContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.animator.SetDecoration(this.savedColorsContextMenuStrip1, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.savedColorsContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.clearColorsToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.saveAsProjectToolStripMenuItem});
            this.savedColorsContextMenuStrip1.Name = "savedColorsContextMenuStrip1";
            this.savedColorsContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.savedColorsContextMenuStrip1.ShowImageMargin = false;
            this.savedColorsContextMenuStrip1.Size = new System.Drawing.Size(128, 92);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // clearColorsToolStripMenuItem
            // 
            this.clearColorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clearColorsToolStripMenuItem.Name = "clearColorsToolStripMenuItem";
            this.clearColorsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearColorsToolStripMenuItem.Text = "Clear Colors";
            this.clearColorsToolStripMenuItem.Click += new System.EventHandler(this.clearColorsToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // saveAsProjectToolStripMenuItem
            // 
            this.saveAsProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsProjectToolStripMenuItem.Name = "saveAsProjectToolStripMenuItem";
            this.saveAsProjectToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveAsProjectToolStripMenuItem.Text = "Save as Project";
            this.saveAsProjectToolStripMenuItem.Click += new System.EventHandler(this.saveAsProjectToolStripMenuItem_Click);
            // 
            // savedDisplayedColors
            // 
            this.savedDisplayedColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.savedDisplayedColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedDisplayedColors.ContextMenuStrip = this.mainForm;
            this.savedDisplayedColors.Controls.Add(this.updateBtn);
            this.savedDisplayedColors.Controls.Add(this.updatePanel);
            this.animator.SetDecoration(this.savedDisplayedColors, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.savedDisplayedColors.Location = new System.Drawing.Point(594, 246);
            this.savedDisplayedColors.Name = "savedDisplayedColors";
            this.savedDisplayedColors.Size = new System.Drawing.Size(187, 228);
            this.savedDisplayedColors.TabIndex = 33;
            this.savedDisplayedColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // updateBtn
            // 
            this.updateBtn.AllowTransparency = true;
            this.updateBtn.AnimationInterval = 1;
            this.updateBtn.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.updateBtn.BorderWidth = 1F;
            this.updateBtn.ClickLimit = 10;
            this.updateBtn.ClickSpeed = 1;
            this.updateBtn.Corners = 5F;
            this.animator.SetDecoration(this.updateBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.updateBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.updateBtn.DoubleRipple = true;
            this.updateBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Image = null;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.updateBtn.Length = 100;
            this.updateBtn.Location = new System.Drawing.Point(34, 189);
            this.updateBtn.Mirror = false;
            this.updateBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.updateBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.updateBtn.RippleOpacity = 25;
            this.updateBtn.ShowText = true;
            this.updateBtn.Size = new System.Drawing.Size(116, 34);
            this.updateBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.updateBtn.TabIndex = 36;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.updateBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            this.updateBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // updatePanel
            // 
            this.updatePanel.ContextMenuStrip = this.mainForm;
            this.updatePanel.Controls.Add(this.previewCMYK);
            this.updatePanel.Controls.Add(this.previewXYZ);
            this.updatePanel.Controls.Add(this.previewLab);
            this.updatePanel.Controls.Add(this.previewHSV);
            this.updatePanel.Controls.Add(this.previewHSB);
            this.updatePanel.Controls.Add(this.previewRGB);
            this.updatePanel.Controls.Add(this.previewHTML);
            this.updatePanel.Controls.Add(this.label31);
            this.updatePanel.Controls.Add(this.label32);
            this.updatePanel.Controls.Add(this.label33);
            this.updatePanel.Controls.Add(this.label34);
            this.updatePanel.Controls.Add(this.label35);
            this.updatePanel.Controls.Add(this.label37);
            this.updatePanel.Controls.Add(this.label38);
            this.animator.SetDecoration(this.updatePanel, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.updatePanel.Location = new System.Drawing.Point(3, 3);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(179, 180);
            this.updatePanel.TabIndex = 33;
            this.updatePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // previewCMYK
            // 
            this.previewCMYK.AutoSize = true;
            this.previewCMYK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewCMYK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewCMYK, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewCMYK.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewCMYK.ForeColor = System.Drawing.Color.GreenYellow;
            this.previewCMYK.Location = new System.Drawing.Point(35, 131);
            this.previewCMYK.Name = "previewCMYK";
            this.previewCMYK.Size = new System.Drawing.Size(36, 12);
            this.previewCMYK.TabIndex = 34;
            this.previewCMYK.Text = "CMYK";
            this.previewCMYK.Visible = false;
            this.previewCMYK.Click += new System.EventHandler(this.previewCMYK_Click);
            this.previewCMYK.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewCMYK.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewXYZ
            // 
            this.previewXYZ.AutoSize = true;
            this.previewXYZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewXYZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewXYZ, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewXYZ.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewXYZ.ForeColor = System.Drawing.Color.Lime;
            this.previewXYZ.Location = new System.Drawing.Point(35, 157);
            this.previewXYZ.Name = "previewXYZ";
            this.previewXYZ.Size = new System.Drawing.Size(26, 12);
            this.previewXYZ.TabIndex = 17;
            this.previewXYZ.Text = "XYZ";
            this.previewXYZ.Visible = false;
            this.previewXYZ.Click += new System.EventHandler(this.previewXYZ_Click);
            this.previewXYZ.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewXYZ.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewLab
            // 
            this.previewLab.AutoSize = true;
            this.previewLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewLab, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewLab.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewLab.ForeColor = System.Drawing.Color.Violet;
            this.previewLab.Location = new System.Drawing.Point(35, 105);
            this.previewLab.Name = "previewLab";
            this.previewLab.Size = new System.Drawing.Size(25, 12);
            this.previewLab.TabIndex = 19;
            this.previewLab.Text = "Lab";
            this.previewLab.Visible = false;
            this.previewLab.Click += new System.EventHandler(this.previewLab_Click);
            this.previewLab.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewLab.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewHSV
            // 
            this.previewHSV.AutoSize = true;
            this.previewHSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewHSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewHSV, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewHSV.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewHSV.ForeColor = System.Drawing.Color.Yellow;
            this.previewHSV.Location = new System.Drawing.Point(35, 79);
            this.previewHSV.Name = "previewHSV";
            this.previewHSV.Size = new System.Drawing.Size(27, 12);
            this.previewHSV.TabIndex = 17;
            this.previewHSV.Text = "HSV";
            this.previewHSV.Visible = false;
            this.previewHSV.Click += new System.EventHandler(this.previewHSV_Click);
            this.previewHSV.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewHSV.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewHSB
            // 
            this.previewHSB.AutoSize = true;
            this.previewHSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewHSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewHSB, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewHSB.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewHSB.ForeColor = System.Drawing.Color.Cyan;
            this.previewHSB.Location = new System.Drawing.Point(34, 53);
            this.previewHSB.Name = "previewHSB";
            this.previewHSB.Size = new System.Drawing.Size(26, 12);
            this.previewHSB.TabIndex = 20;
            this.previewHSB.Text = "HSL";
            this.previewHSB.Visible = false;
            this.previewHSB.Click += new System.EventHandler(this.previewHSB_Click);
            this.previewHSB.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewHSB.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewRGB
            // 
            this.previewRGB.AutoSize = true;
            this.previewRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewRGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewRGB, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewRGB.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewRGB.ForeColor = System.Drawing.Color.Orange;
            this.previewRGB.Location = new System.Drawing.Point(34, 1);
            this.previewRGB.Name = "previewRGB";
            this.previewRGB.Size = new System.Drawing.Size(28, 12);
            this.previewRGB.TabIndex = 33;
            this.previewRGB.Text = "RGB";
            this.previewRGB.Visible = false;
            this.previewRGB.Click += new System.EventHandler(this.previewRGB_Click);
            this.previewRGB.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewRGB.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // previewHTML
            // 
            this.previewHTML.AutoSize = true;
            this.previewHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.previewHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.previewHTML, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.previewHTML.Font = new System.Drawing.Font("Verdana", 7F);
            this.previewHTML.ForeColor = System.Drawing.Color.Orange;
            this.previewHTML.Location = new System.Drawing.Point(33, 27);
            this.previewHTML.Name = "previewHTML";
            this.previewHTML.Size = new System.Drawing.Size(35, 12);
            this.previewHTML.TabIndex = 32;
            this.previewHTML.Text = "HTML";
            this.previewHTML.Visible = false;
            this.previewHTML.Click += new System.EventHandler(this.previewHTML_Click);
            this.previewHTML.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.previewHTML.MouseHover += new System.EventHandler(this.lR_MouseEnter);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label31, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label31.Font = new System.Drawing.Font("Verdana", 7F);
            this.label31.ForeColor = System.Drawing.Color.Lime;
            this.label31.Location = new System.Drawing.Point(2, 157);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 12);
            this.label31.TabIndex = 35;
            this.label31.Text = "XYZ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label32, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label32.Font = new System.Drawing.Font("Verdana", 7F);
            this.label32.ForeColor = System.Drawing.Color.GreenYellow;
            this.label32.Location = new System.Drawing.Point(2, 131);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(36, 12);
            this.label32.TabIndex = 41;
            this.label32.Text = "CMYK";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label33, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label33.Font = new System.Drawing.Font("Verdana", 7F);
            this.label33.ForeColor = System.Drawing.Color.Violet;
            this.label33.Location = new System.Drawing.Point(2, 105);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 12);
            this.label33.TabIndex = 37;
            this.label33.Text = "Lab";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label34, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label34.Font = new System.Drawing.Font("Verdana", 7F);
            this.label34.ForeColor = System.Drawing.Color.Yellow;
            this.label34.Location = new System.Drawing.Point(2, 79);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 12);
            this.label34.TabIndex = 36;
            this.label34.Text = "HSV";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label35, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label35.Font = new System.Drawing.Font("Verdana", 7F);
            this.label35.ForeColor = System.Drawing.Color.Cyan;
            this.label35.Location = new System.Drawing.Point(1, 53);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(26, 12);
            this.label35.TabIndex = 38;
            this.label35.Text = "HSL";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label37, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label37.Font = new System.Drawing.Font("Verdana", 7F);
            this.label37.ForeColor = System.Drawing.Color.Orange;
            this.label37.Location = new System.Drawing.Point(1, 1);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 12);
            this.label37.TabIndex = 40;
            this.label37.Text = "RGB";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label38, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label38.Font = new System.Drawing.Font("Verdana", 7F);
            this.label38.ForeColor = System.Drawing.Color.Orange;
            this.label38.Location = new System.Drawing.Point(1, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 39;
            this.label38.Text = "HTML";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.animator.SetDecoration(this.closeBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(777, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 19);
            this.closeBtn.TabIndex = 29;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // magnifyViewer
            // 
            this.magnifyViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magnifyViewer.Controls.Add(this.panel1);
            this.magnifyViewer.Controls.Add(this.gridPanel);
            this.animator.SetDecoration(this.magnifyViewer, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.magnifyViewer.Location = new System.Drawing.Point(594, 27);
            this.magnifyViewer.Name = "magnifyViewer";
            this.magnifyViewer.Size = new System.Drawing.Size(187, 204);
            this.magnifyViewer.TabIndex = 17;
            this.magnifyViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AColor);
            this.animator.SetDecoration(this.panel1, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 13);
            this.panel1.TabIndex = 16;
            // 
            // AColor
            // 
            this.AColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AColor.ContextMenuStrip = this.mainForm;
            this.animator.SetDecoration(this.AColor, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.AColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AColor.Location = new System.Drawing.Point(0, 0);
            this.AColor.Name = "AColor";
            this.AColor.Size = new System.Drawing.Size(185, 13);
            this.AColor.TabIndex = 15;
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gridPanel.ContextMenuStrip = this.mainForm;
            this.animator.SetDecoration(this.gridPanel, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(185, 189);
            this.gridPanel.TabIndex = 32;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPanel_Paint);
            this.gridPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseDown);
            this.gridPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            this.gridPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridPanel_MouseUp);
            this.gridPanel.Resize += new System.EventHandler(this.gridPanel_Resize);
            // 
            // detailPanel
            // 
            this.detailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.detailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPanel.ContextMenuStrip = this.mainForm;
            this.detailPanel.Controls.Add(this.showColors);
            this.detailPanel.Controls.Add(this.label30);
            this.detailPanel.Controls.Add(this.searchPanel);
            this.detailPanel.Controls.Add(this.saveColorNamePanel);
            this.detailPanel.Controls.Add(this.allWebColors);
            this.detailPanel.Controls.Add(this.searchBtn);
            this.detailPanel.Controls.Add(this.precisionCheck);
            this.detailPanel.Controls.Add(this.label29);
            this.detailPanel.Controls.Add(this.settings);
            this.detailPanel.Controls.Add(this.upDownBtn);
            this.detailPanel.Controls.Add(this.externalLinkBtn);
            this.detailPanel.Controls.Add(this.noFlickerPanel6);
            this.detailPanel.Controls.Add(this.noFlickerPanel5);
            this.detailPanel.Controls.Add(this.noFlickerPanel4);
            this.detailPanel.Controls.Add(this.noFlickerPanel3);
            this.detailPanel.Controls.Add(this.noFlickerPanel2);
            this.detailPanel.Controls.Add(this.noFlickerPanel1);
            this.detailPanel.Controls.Add(this.bSelect);
            this.detailPanel.Controls.Add(this.SColor);
            this.animator.SetDecoration(this.detailPanel, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.detailPanel.Location = new System.Drawing.Point(17, 27);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(566, 204);
            this.detailPanel.TabIndex = 16;
            this.detailPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // showColors
            // 
            this.showColors.AutoSize = true;
            this.showColors.Checked = true;
            this.showColors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animator.SetDecoration(this.showColors, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.showColors.Location = new System.Drawing.Point(458, 151);
            this.showColors.Name = "showColors";
            this.showColors.Size = new System.Drawing.Size(15, 14);
            this.showColors.TabIndex = 43;
            this.showColors.UseVisualStyleBackColor = true;
            this.showColors.CheckedChanged += new System.EventHandler(this.showColors_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label30, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(371, 150);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 42;
            this.label30.Text = "Show Colors";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.itemsFoundSecond);
            this.searchPanel.Controls.Add(this.itemsFound);
            this.searchPanel.Controls.Add(this.colorListBox);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.animator.SetDecoration(this.searchPanel, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.searchPanel.Location = new System.Drawing.Point(6, 133);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(267, 66);
            this.searchPanel.TabIndex = 39;
            this.searchPanel.Visible = false;
            // 
            // itemsFoundSecond
            // 
            this.itemsFoundSecond.AutoSize = true;
            this.itemsFoundSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.itemsFoundSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.itemsFoundSecond, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.itemsFoundSecond.Font = new System.Drawing.Font("Consolas", 8F);
            this.itemsFoundSecond.ForeColor = System.Drawing.Color.White;
            this.itemsFoundSecond.Location = new System.Drawing.Point(66, 48);
            this.itemsFoundSecond.Name = "itemsFoundSecond";
            this.itemsFoundSecond.Size = new System.Drawing.Size(37, 13);
            this.itemsFoundSecond.TabIndex = 44;
            this.itemsFoundSecond.Text = "Items";
            this.itemsFoundSecond.Visible = false;
            this.itemsFoundSecond.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // itemsFound
            // 
            this.itemsFound.AutoSize = true;
            this.itemsFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.itemsFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.itemsFound, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.itemsFound.Font = new System.Drawing.Font("Consolas", 8F);
            this.itemsFound.ForeColor = System.Drawing.Color.Cyan;
            this.itemsFound.Location = new System.Drawing.Point(35, 48);
            this.itemsFound.Name = "itemsFound";
            this.itemsFound.Size = new System.Drawing.Size(13, 13);
            this.itemsFound.TabIndex = 35;
            this.itemsFound.Text = "0";
            this.itemsFound.Visible = false;
            this.itemsFound.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // colorListBox
            // 
            this.colorListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.colorListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator.SetDecoration(this.colorListBox, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.colorListBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.colorListBox.ForeColor = System.Drawing.Color.White;
            this.colorListBox.FormattingEnabled = true;
            this.colorListBox.Location = new System.Drawing.Point(152, 6);
            this.colorListBox.Name = "colorListBox";
            this.colorListBox.Size = new System.Drawing.Size(112, 54);
            this.colorListBox.TabIndex = 42;
            this.colorListBox.Visible = false;
            this.colorListBox.SelectedIndexChanged += new System.EventHandler(this.colorListBox_SelectedIndexChanged);
            this.colorListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // searchTextBox
            // 
            this.animator.SetDecoration(this.searchTextBox, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.searchTextBox.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.searchTextBox.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.searchTextBox.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.searchTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.searchTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.IsEnabled = true;
            this.searchTextBox.Location = new System.Drawing.Point(3, 20);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.Placeholder = true;
            this.searchTextBox.PlaceHolderText = "Search Color";
            this.searchTextBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.searchTextBox.ReadOnly = false;
            this.searchTextBox.Size = new System.Drawing.Size(143, 24);
            this.searchTextBox.TabIndex = 43;
            this.searchTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.searchTextBox.UseSystemPasswordChar = false;
            this.searchTextBox.WordWrap = true;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // saveColorNamePanel
            // 
            this.saveColorNamePanel.Controls.Add(this.nameTxtBox);
            this.saveColorNamePanel.Controls.Add(this.saveBtn);
            this.saveColorNamePanel.Controls.Add(this.label36);
            this.animator.SetDecoration(this.saveColorNamePanel, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.saveColorNamePanel.Location = new System.Drawing.Point(369, 108);
            this.saveColorNamePanel.Name = "saveColorNamePanel";
            this.saveColorNamePanel.Size = new System.Drawing.Size(188, 30);
            this.saveColorNamePanel.TabIndex = 33;
            // 
            // nameTxtBox
            // 
            this.animator.SetDecoration(this.nameTxtBox, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.nameTxtBox.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.nameTxtBox.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.nameTxtBox.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.nameTxtBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.nameTxtBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.nameTxtBox.ForeColor = System.Drawing.Color.White;
            this.nameTxtBox.IsEnabled = true;
            this.nameTxtBox.Location = new System.Drawing.Point(41, 4);
            this.nameTxtBox.MaxLength = 32767;
            this.nameTxtBox.Multiline = false;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.PasswordChar = '\0';
            this.nameTxtBox.Placeholder = true;
            this.nameTxtBox.PlaceHolderText = "eg. Save Color";
            this.nameTxtBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.nameTxtBox.ReadOnly = false;
            this.nameTxtBox.Size = new System.Drawing.Size(111, 24);
            this.nameTxtBox.TabIndex = 34;
            this.nameTxtBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTxtBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nameTxtBox.UseSystemPasswordChar = false;
            this.nameTxtBox.WordWrap = true;
            this.nameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxtBox_KeyDown);
            this.nameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxtBox_KeyPress);
            // 
            // saveBtn
            // 
            this.animator.SetDecoration(this.saveBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::ZeroitDevColorPicker.Properties.Resources.save_20px_1;
            this.saveBtn.Location = new System.Drawing.Point(158, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(26, 24);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label36, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label36.Font = new System.Drawing.Font("Verdana", 7F);
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(3, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 12);
            this.label36.TabIndex = 35;
            this.label36.Text = "NAME";
            // 
            // allWebColors
            // 
            this.allWebColors.AccentColor = System.Drawing.Color.Green;
            this.allWebColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.allWebColors.BoxStyle = ZeroitDevColorPicker.Helpers.Colors.WikiColors.AllWebColorsComboBox.DropBoxStyle.DropDownList;
            this.animator.SetDecoration(this.allWebColors, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.allWebColors.DividerColor = System.Drawing.Color.Cyan;
            this.allWebColors.DrawingMode = ZeroitDevColorPicker.Helpers.Colors.WikiColors.AllWebColorsComboBox.DrawingModes.Variable;
            this.allWebColors.DrawOuterBorder = true;
            this.allWebColors.DropdownBorder = System.Drawing.Color.Cyan;
            this.allWebColors.DropDownBorderStlye = ZeroitDevColorPicker.Helpers.Colors.WikiColors.AllWebColorsComboBox.PenStyles.PS_SOLID;
            this.allWebColors.FocusedColor = System.Drawing.Color.Cyan;
            this.allWebColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.allWebColors.ForeColor = System.Drawing.Color.White;
            this.allWebColors.FormattingEnabled = true;
            this.allWebColors.Location = new System.Drawing.Point(4, 108);
            this.allWebColors.Name = "allWebColors";
            this.allWebColors.OuterBorderColor = System.Drawing.Color.DimGray;
            this.allWebColors.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(186)))));
            this.allWebColors.Size = new System.Drawing.Size(269, 21);
            this.allWebColors.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.allWebColors.TabIndex = 35;
            this.allWebColors.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.allWebColors.UnFocusedColor = System.Drawing.Color.Yellow;
            this.allWebColors.SelectedIndexChanged += new System.EventHandler(this.allWebColors_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.animator.SetDecoration(this.searchBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Image = global::ZeroitDevColorPicker.Properties.Resources.search_20px;
            this.searchBtn.Location = new System.Drawing.Point(414, 171);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(26, 24);
            this.searchBtn.TabIndex = 41;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_MouseEnter);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            this.searchBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // precisionCheck
            // 
            this.precisionCheck.AutoSize = true;
            this.precisionCheck.Checked = true;
            this.precisionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animator.SetDecoration(this.precisionCheck, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.precisionCheck.Location = new System.Drawing.Point(544, 150);
            this.precisionCheck.Name = "precisionCheck";
            this.precisionCheck.Size = new System.Drawing.Size(15, 14);
            this.precisionCheck.TabIndex = 40;
            this.precisionCheck.UseVisualStyleBackColor = true;
            this.precisionCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label29, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(482, 149);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 21;
            this.label29.Text = "Precision";
            this.label29.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // settings
            // 
            this.animator.SetDecoration(this.settings, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = global::ZeroitDevColorPicker.Properties.Resources.settings_20px;
            this.settings.Location = new System.Drawing.Point(492, 170);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(26, 24);
            this.settings.TabIndex = 39;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            this.settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // upDownBtn
            // 
            this.upDownBtn.AutoSize = true;
            this.animator.SetDecoration(this.upDownBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.upDownBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.upDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDownBtn.Image = global::ZeroitDevColorPicker.Properties.Resources.down_16px;
            this.upDownBtn.Location = new System.Drawing.Point(531, 170);
            this.upDownBtn.Name = "upDownBtn";
            this.upDownBtn.Size = new System.Drawing.Size(24, 24);
            this.upDownBtn.TabIndex = 37;
            this.upDownBtn.UseVisualStyleBackColor = true;
            this.upDownBtn.Click += new System.EventHandler(this.upDownBtn_Click);
            this.upDownBtn.MouseEnter += new System.EventHandler(this.upDownBtn_MouseEnter);
            this.upDownBtn.MouseLeave += new System.EventHandler(this.upDownBtn_MouseLeave);
            this.upDownBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // externalLinkBtn
            // 
            this.animator.SetDecoration(this.externalLinkBtn, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.externalLinkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.externalLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.externalLinkBtn.Image = global::ZeroitDevColorPicker.Properties.Resources.external_link_20px;
            this.externalLinkBtn.Location = new System.Drawing.Point(453, 169);
            this.externalLinkBtn.Name = "externalLinkBtn";
            this.externalLinkBtn.Size = new System.Drawing.Size(26, 24);
            this.externalLinkBtn.TabIndex = 36;
            this.externalLinkBtn.UseVisualStyleBackColor = true;
            this.externalLinkBtn.Click += new System.EventHandler(this.externalLinkBtn_Click);
            this.externalLinkBtn.MouseEnter += new System.EventHandler(this.externalLinkBtn_MouseEnter);
            this.externalLinkBtn.MouseLeave += new System.EventHandler(this.externalLinkBtn_MouseLeave);
            this.externalLinkBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // noFlickerPanel6
            // 
            this.noFlickerPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel6.Controls.Add(this.label40);
            this.noFlickerPanel6.Controls.Add(this.label11);
            this.noFlickerPanel6.Controls.Add(this.label41);
            this.noFlickerPanel6.Controls.Add(this.label12);
            this.noFlickerPanel6.Controls.Add(this.label42);
            this.noFlickerPanel6.Controls.Add(this.label13);
            this.noFlickerPanel6.Controls.Add(this.m_txt_H);
            this.noFlickerPanel6.Controls.Add(this.m_txt_V);
            this.noFlickerPanel6.Controls.Add(this.m_txt_S);
            this.noFlickerPanel6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.noFlickerPanel6, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel6.Location = new System.Drawing.Point(276, 10);
            this.noFlickerPanel6.Name = "noFlickerPanel6";
            this.noFlickerPanel6.Size = new System.Drawing.Size(90, 97);
            this.noFlickerPanel6.TabIndex = 19;
            this.noFlickerPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label40, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(65, 80);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(19, 13);
            this.label40.TabIndex = 22;
            this.label40.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label11, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(2, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "H";
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label41, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(66, 42);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(19, 13);
            this.label41.TabIndex = 21;
            this.label41.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label12, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(2, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "V";
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label42, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(68, 4);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 13);
            this.label42.TabIndex = 20;
            this.label42.Text = "°";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label13, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(2, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "S";
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_H
            // 
            this.m_txt_H.AutoSize = true;
            this.m_txt_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_H, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_H.ForeColor = System.Drawing.Color.White;
            this.m_txt_H.Location = new System.Drawing.Point(21, 3);
            this.m_txt_H.Name = "m_txt_H";
            this.m_txt_H.Size = new System.Drawing.Size(15, 13);
            this.m_txt_H.TabIndex = 11;
            this.m_txt_H.Text = "H";
            this.m_txt_H.Click += new System.EventHandler(this.m_txt_H_Click);
            this.m_txt_H.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_H.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_H.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_V
            // 
            this.m_txt_V.AutoSize = true;
            this.m_txt_V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_V, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_V.ForeColor = System.Drawing.Color.White;
            this.m_txt_V.Location = new System.Drawing.Point(21, 77);
            this.m_txt_V.Name = "m_txt_V";
            this.m_txt_V.Size = new System.Drawing.Size(15, 13);
            this.m_txt_V.TabIndex = 13;
            this.m_txt_V.Text = "V";
            this.m_txt_V.Click += new System.EventHandler(this.m_txt_V_Click);
            this.m_txt_V.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_V.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_V.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_S
            // 
            this.m_txt_S.AutoSize = true;
            this.m_txt_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_S.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_S, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_S.ForeColor = System.Drawing.Color.White;
            this.m_txt_S.Location = new System.Drawing.Point(21, 40);
            this.m_txt_S.Name = "m_txt_S";
            this.m_txt_S.Size = new System.Drawing.Size(15, 13);
            this.m_txt_S.TabIndex = 12;
            this.m_txt_S.Text = "S";
            this.m_txt_S.Click += new System.EventHandler(this.m_txt_S_Click);
            this.m_txt_S.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_S.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_S.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // noFlickerPanel5
            // 
            this.noFlickerPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel5.Controls.Add(this.label22);
            this.noFlickerPanel5.Controls.Add(this.label23);
            this.noFlickerPanel5.Controls.Add(this.label24);
            this.noFlickerPanel5.Controls.Add(this.m_txt_X);
            this.noFlickerPanel5.Controls.Add(this.m_txt_Z);
            this.noFlickerPanel5.Controls.Add(this.m_txt_Y);
            this.noFlickerPanel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.noFlickerPanel5, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel5.Location = new System.Drawing.Point(276, 109);
            this.noFlickerPanel5.Name = "noFlickerPanel5";
            this.noFlickerPanel5.Size = new System.Drawing.Size(90, 90);
            this.noFlickerPanel5.TabIndex = 18;
            this.noFlickerPanel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label22, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label22.ForeColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "X";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label23, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(3, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Z";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label24, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label24.ForeColor = System.Drawing.Color.Lime;
            this.label24.Location = new System.Drawing.Point(3, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Y";
            // 
            // m_txt_X
            // 
            this.m_txt_X.AutoSize = true;
            this.m_txt_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_X, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_X.ForeColor = System.Drawing.Color.White;
            this.m_txt_X.Location = new System.Drawing.Point(20, 3);
            this.m_txt_X.Name = "m_txt_X";
            this.m_txt_X.Size = new System.Drawing.Size(15, 13);
            this.m_txt_X.TabIndex = 11;
            this.m_txt_X.Text = "X";
            this.m_txt_X.Click += new System.EventHandler(this.m_txt_X_Click);
            this.m_txt_X.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_X.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // m_txt_Z
            // 
            this.m_txt_Z.AutoSize = true;
            this.m_txt_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Z.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Z, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Z.ForeColor = System.Drawing.Color.White;
            this.m_txt_Z.Location = new System.Drawing.Point(20, 69);
            this.m_txt_Z.Name = "m_txt_Z";
            this.m_txt_Z.Size = new System.Drawing.Size(15, 13);
            this.m_txt_Z.TabIndex = 13;
            this.m_txt_Z.Text = "Z";
            this.m_txt_Z.Click += new System.EventHandler(this.m_txt_Z_Click);
            this.m_txt_Z.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Z.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // m_txt_Y
            // 
            this.m_txt_Y.AutoSize = true;
            this.m_txt_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Y, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Y.ForeColor = System.Drawing.Color.White;
            this.m_txt_Y.Location = new System.Drawing.Point(20, 36);
            this.m_txt_Y.Name = "m_txt_Y";
            this.m_txt_Y.Size = new System.Drawing.Size(14, 13);
            this.m_txt_Y.TabIndex = 12;
            this.m_txt_Y.Text = "Y";
            this.m_txt_Y.Click += new System.EventHandler(this.m_txt_Y_Click);
            this.m_txt_Y.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Y.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // noFlickerPanel4
            // 
            this.noFlickerPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel4.Controls.Add(this.label2);
            this.noFlickerPanel4.Controls.Add(this.label3);
            this.noFlickerPanel4.Controls.Add(this.label6);
            this.noFlickerPanel4.Controls.Add(this.label1);
            this.noFlickerPanel4.Controls.Add(this.scaleValue);
            this.noFlickerPanel4.Controls.Add(this.m_txt_L);
            this.noFlickerPanel4.Controls.Add(this.m_txt_b);
            this.noFlickerPanel4.Controls.Add(this.m_txt_a);
            this.noFlickerPanel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.noFlickerPanel4, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel4.Location = new System.Drawing.Point(369, 10);
            this.noFlickerPanel4.Name = "noFlickerPanel4";
            this.noFlickerPanel4.Size = new System.Drawing.Size(93, 97);
            this.noFlickerPanel4.TabIndex = 17;
            this.noFlickerPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label2, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "L";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label3, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "b";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label6, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Violet;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "a";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label1, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Scale";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // scaleValue
            // 
            this.scaleValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scaleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scaleValue.DecimalPlaces = 2;
            this.animator.SetDecoration(this.scaleValue, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.scaleValue.Font = new System.Drawing.Font("Verdana", 7F);
            this.scaleValue.ForeColor = System.Drawing.Color.White;
            this.scaleValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleValue.Location = new System.Drawing.Point(44, 74);
            this.scaleValue.Name = "scaleValue";
            this.scaleValue.Size = new System.Drawing.Size(44, 19);
            this.scaleValue.TabIndex = 14;
            this.scaleValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.scaleValue.ValueChanged += new System.EventHandler(this.scaleValue_ValueChanged);
            this.scaleValue.Move += new System.EventHandler(this.scaleValue_Move);
            // 
            // m_txt_L
            // 
            this.m_txt_L.AutoSize = true;
            this.m_txt_L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_L, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_L.ForeColor = System.Drawing.Color.White;
            this.m_txt_L.Location = new System.Drawing.Point(23, 3);
            this.m_txt_L.Name = "m_txt_L";
            this.m_txt_L.Size = new System.Drawing.Size(13, 13);
            this.m_txt_L.TabIndex = 11;
            this.m_txt_L.Text = "L";
            this.m_txt_L.Click += new System.EventHandler(this.m_txt_L_Click);
            this.m_txt_L.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_L.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_L.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_b
            // 
            this.m_txt_b.AutoSize = true;
            this.m_txt_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_b, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_b.ForeColor = System.Drawing.Color.White;
            this.m_txt_b.Location = new System.Drawing.Point(23, 51);
            this.m_txt_b.Name = "m_txt_b";
            this.m_txt_b.Size = new System.Drawing.Size(14, 13);
            this.m_txt_b.TabIndex = 13;
            this.m_txt_b.Text = "b";
            this.m_txt_b.Click += new System.EventHandler(this.m_txt_b_Click);
            this.m_txt_b.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_b.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_b.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_a
            // 
            this.m_txt_a.AutoSize = true;
            this.m_txt_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_a, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_a.ForeColor = System.Drawing.Color.White;
            this.m_txt_a.Location = new System.Drawing.Point(23, 29);
            this.m_txt_a.Name = "m_txt_a";
            this.m_txt_a.Size = new System.Drawing.Size(14, 13);
            this.m_txt_a.TabIndex = 12;
            this.m_txt_a.Text = "a";
            this.m_txt_a.Click += new System.EventHandler(this.m_txt_a_Click);
            this.m_txt_a.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_a.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_a.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // noFlickerPanel3
            // 
            this.noFlickerPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel3.Controls.Add(this.label39);
            this.noFlickerPanel3.Controls.Add(this.label25);
            this.noFlickerPanel3.Controls.Add(this.label26);
            this.noFlickerPanel3.Controls.Add(this.label27);
            this.noFlickerPanel3.Controls.Add(this.label28);
            this.noFlickerPanel3.Controls.Add(this.m_txt_Cyan);
            this.noFlickerPanel3.Controls.Add(this.label10);
            this.noFlickerPanel3.Controls.Add(this.label8);
            this.noFlickerPanel3.Controls.Add(this.label9);
            this.noFlickerPanel3.Controls.Add(this.m_txt_K);
            this.noFlickerPanel3.Controls.Add(this.m_txt_Yellow);
            this.noFlickerPanel3.Controls.Add(this.m_txt_Magenta);
            this.noFlickerPanel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.noFlickerPanel3, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel3.Location = new System.Drawing.Point(465, 10);
            this.noFlickerPanel3.Name = "noFlickerPanel3";
            this.noFlickerPanel3.Size = new System.Drawing.Size(92, 97);
            this.noFlickerPanel3.TabIndex = 17;
            this.noFlickerPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label39, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(69, 78);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(19, 13);
            this.label39.TabIndex = 24;
            this.label39.Text = "%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label25, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label25.ForeColor = System.Drawing.Color.GreenYellow;
            this.label25.Location = new System.Drawing.Point(3, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "C";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label26, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label26.ForeColor = System.Drawing.Color.GreenYellow;
            this.label26.Location = new System.Drawing.Point(3, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 13);
            this.label26.TabIndex = 23;
            this.label26.Text = "K";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label27, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label27.ForeColor = System.Drawing.Color.GreenYellow;
            this.label27.Location = new System.Drawing.Point(3, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Y";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label28, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label28.ForeColor = System.Drawing.Color.GreenYellow;
            this.label28.Location = new System.Drawing.Point(3, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 13);
            this.label28.TabIndex = 21;
            this.label28.Text = "M";
            // 
            // m_txt_Cyan
            // 
            this.m_txt_Cyan.AutoSize = true;
            this.m_txt_Cyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Cyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Cyan, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Cyan.ForeColor = System.Drawing.Color.White;
            this.m_txt_Cyan.Location = new System.Drawing.Point(22, 3);
            this.m_txt_Cyan.Name = "m_txt_Cyan";
            this.m_txt_Cyan.Size = new System.Drawing.Size(16, 13);
            this.m_txt_Cyan.TabIndex = 11;
            this.m_txt_Cyan.Text = "C";
            this.m_txt_Cyan.Click += new System.EventHandler(this.m_txt_Cyan_Click);
            this.m_txt_Cyan.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Cyan.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label10, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(70, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label8, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(70, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label9, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // m_txt_K
            // 
            this.m_txt_K.AutoSize = true;
            this.m_txt_K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_K.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_K, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_K.ForeColor = System.Drawing.Color.White;
            this.m_txt_K.Location = new System.Drawing.Point(22, 77);
            this.m_txt_K.Name = "m_txt_K";
            this.m_txt_K.Size = new System.Drawing.Size(15, 13);
            this.m_txt_K.TabIndex = 14;
            this.m_txt_K.Text = "K";
            this.m_txt_K.Click += new System.EventHandler(this.m_txt_K_Click);
            this.m_txt_K.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_K.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // m_txt_Yellow
            // 
            this.m_txt_Yellow.AutoSize = true;
            this.m_txt_Yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Yellow, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Yellow.ForeColor = System.Drawing.Color.White;
            this.m_txt_Yellow.Location = new System.Drawing.Point(22, 55);
            this.m_txt_Yellow.Name = "m_txt_Yellow";
            this.m_txt_Yellow.Size = new System.Drawing.Size(14, 13);
            this.m_txt_Yellow.TabIndex = 13;
            this.m_txt_Yellow.Text = "Y";
            this.m_txt_Yellow.Click += new System.EventHandler(this.m_txt_Yellow_Click);
            this.m_txt_Yellow.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Yellow.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // m_txt_Magenta
            // 
            this.m_txt_Magenta.AutoSize = true;
            this.m_txt_Magenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Magenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Magenta, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Magenta.ForeColor = System.Drawing.Color.White;
            this.m_txt_Magenta.Location = new System.Drawing.Point(22, 29);
            this.m_txt_Magenta.Name = "m_txt_Magenta";
            this.m_txt_Magenta.Size = new System.Drawing.Size(16, 13);
            this.m_txt_Magenta.TabIndex = 12;
            this.m_txt_Magenta.Text = "M";
            this.m_txt_Magenta.Click += new System.EventHandler(this.m_txt_Magenta_Click);
            this.m_txt_Magenta.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Magenta.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            // 
            // noFlickerPanel2
            // 
            this.noFlickerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel2.Controls.Add(this.label14);
            this.noFlickerPanel2.Controls.Add(this.label15);
            this.noFlickerPanel2.Controls.Add(this.label16);
            this.noFlickerPanel2.Controls.Add(this.m_txt_Hue);
            this.noFlickerPanel2.Controls.Add(this.label7);
            this.noFlickerPanel2.Controls.Add(this.label5);
            this.noFlickerPanel2.Controls.Add(this.label4);
            this.noFlickerPanel2.Controls.Add(this.m_txt_Black);
            this.noFlickerPanel2.Controls.Add(this.m_txt_Sat);
            this.noFlickerPanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator.SetDecoration(this.noFlickerPanel2, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel2.Location = new System.Drawing.Point(181, 10);
            this.noFlickerPanel2.Name = "noFlickerPanel2";
            this.noFlickerPanel2.Size = new System.Drawing.Size(92, 97);
            this.noFlickerPanel2.TabIndex = 16;
            this.noFlickerPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label14, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(4, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "H";
            this.label14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label15, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label15.ForeColor = System.Drawing.Color.Cyan;
            this.label15.Location = new System.Drawing.Point(3, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "L";
            this.label15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label16, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label16.ForeColor = System.Drawing.Color.Cyan;
            this.label16.Location = new System.Drawing.Point(4, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "S";
            this.label16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_Hue
            // 
            this.m_txt_Hue.AutoSize = true;
            this.m_txt_Hue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Hue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Hue, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Hue.ForeColor = System.Drawing.Color.White;
            this.m_txt_Hue.Location = new System.Drawing.Point(24, 3);
            this.m_txt_Hue.Name = "m_txt_Hue";
            this.m_txt_Hue.Size = new System.Drawing.Size(15, 13);
            this.m_txt_Hue.TabIndex = 11;
            this.m_txt_Hue.Text = "H";
            this.m_txt_Hue.Click += new System.EventHandler(this.m_txt_Hue_Click);
            this.m_txt_Hue.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Hue.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_Hue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label7, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(67, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "%";
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label5, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "%";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label4, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "°";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_Black
            // 
            this.m_txt_Black.AutoSize = true;
            this.m_txt_Black.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Black, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Black.ForeColor = System.Drawing.Color.White;
            this.m_txt_Black.Location = new System.Drawing.Point(23, 79);
            this.m_txt_Black.Name = "m_txt_Black";
            this.m_txt_Black.Size = new System.Drawing.Size(13, 13);
            this.m_txt_Black.TabIndex = 13;
            this.m_txt_Black.Text = "L";
            this.m_txt_Black.Click += new System.EventHandler(this.m_txt_Black_Click);
            this.m_txt_Black.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Black.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_Black.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // m_txt_Sat
            // 
            this.m_txt_Sat.AutoSize = true;
            this.m_txt_Sat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.m_txt_Sat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.m_txt_Sat, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.m_txt_Sat.ForeColor = System.Drawing.Color.White;
            this.m_txt_Sat.Location = new System.Drawing.Point(24, 41);
            this.m_txt_Sat.Name = "m_txt_Sat";
            this.m_txt_Sat.Size = new System.Drawing.Size(15, 13);
            this.m_txt_Sat.TabIndex = 12;
            this.m_txt_Sat.Text = "S";
            this.m_txt_Sat.Click += new System.EventHandler(this.m_txt_Sat_Click);
            this.m_txt_Sat.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.m_txt_Sat.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.m_txt_Sat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // noFlickerPanel1
            // 
            this.noFlickerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noFlickerPanel1.Controls.Add(this.label17);
            this.noFlickerPanel1.Controls.Add(this.label18);
            this.noFlickerPanel1.Controls.Add(this.label19);
            this.noFlickerPanel1.Controls.Add(this.label20);
            this.noFlickerPanel1.Controls.Add(this.label21);
            this.noFlickerPanel1.Controls.Add(this.lR);
            this.noFlickerPanel1.Controls.Add(this.lB);
            this.noFlickerPanel1.Controls.Add(this.lH);
            this.noFlickerPanel1.Controls.Add(this.lG);
            this.noFlickerPanel1.Controls.Add(this.rgb);
            this.noFlickerPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.noFlickerPanel1, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.noFlickerPanel1.Location = new System.Drawing.Point(60, 10);
            this.noFlickerPanel1.Name = "noFlickerPanel1";
            this.noFlickerPanel1.Size = new System.Drawing.Size(118, 97);
            this.noFlickerPanel1.TabIndex = 4;
            this.noFlickerPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label17, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label17.ForeColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "R";
            this.label17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label18, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label18.ForeColor = System.Drawing.Color.Orange;
            this.label18.Location = new System.Drawing.Point(4, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "B";
            this.label18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label19, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label19.ForeColor = System.Drawing.Color.Orange;
            this.label19.Location = new System.Drawing.Point(4, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "HTML";
            this.label19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label20, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label20.ForeColor = System.Drawing.Color.Orange;
            this.label20.Location = new System.Drawing.Point(3, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "G";
            this.label20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label21, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.label21.ForeColor = System.Drawing.Color.Orange;
            this.label21.Location = new System.Drawing.Point(4, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "RGB";
            this.label21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.lR, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.lR.ForeColor = System.Drawing.Color.White;
            this.lR.Location = new System.Drawing.Point(39, 3);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(15, 13);
            this.lR.TabIndex = 11;
            this.lR.Text = "R";
            this.lR.Click += new System.EventHandler(this.lR_Click);
            this.lR.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lR.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.lR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.lB, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.lB.ForeColor = System.Drawing.Color.White;
            this.lB.Location = new System.Drawing.Point(40, 41);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(15, 13);
            this.lB.TabIndex = 13;
            this.lB.Text = "B";
            this.lB.Click += new System.EventHandler(this.lB_Click);
            this.lB.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lB.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.lB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // lH
            // 
            this.lH.AutoSize = true;
            this.lH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.lH, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.lH.ForeColor = System.Drawing.Color.White;
            this.lH.Location = new System.Drawing.Point(40, 60);
            this.lH.Name = "lH";
            this.lH.Size = new System.Drawing.Size(37, 13);
            this.lH.TabIndex = 14;
            this.lH.Text = "HTML";
            this.lH.Click += new System.EventHandler(this.lH_Click);
            this.lH.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lH.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.lH.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // lG
            // 
            this.lG.AutoSize = true;
            this.lG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.lG, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.lG.ForeColor = System.Drawing.Color.White;
            this.lG.Location = new System.Drawing.Point(39, 22);
            this.lG.Name = "lG";
            this.lG.Size = new System.Drawing.Size(16, 13);
            this.lG.TabIndex = 12;
            this.lG.Text = "G";
            this.lG.Click += new System.EventHandler(this.lG_Click);
            this.lG.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.lG.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.lG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // rgb
            // 
            this.rgb.AutoSize = true;
            this.rgb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rgb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.rgb, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.rgb.ForeColor = System.Drawing.Color.White;
            this.rgb.Location = new System.Drawing.Point(40, 79);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(32, 13);
            this.rgb.TabIndex = 15;
            this.rgb.Text = "RGB";
            this.rgb.Click += new System.EventHandler(this.rgb_Click);
            this.rgb.MouseEnter += new System.EventHandler(this.lR_MouseEnter);
            this.rgb.MouseLeave += new System.EventHandler(this.lR_MouseLeave);
            this.rgb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // bSelect
            // 
            this.animator.SetDecoration(this.bSelect, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.bSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelect.Image = global::ZeroitDevColorPicker.Properties.Resources.color_dropper_20px;
            this.bSelect.Location = new System.Drawing.Point(375, 170);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(26, 24);
            this.bSelect.TabIndex = 8;
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            this.bSelect.MouseEnter += new System.EventHandler(this.bSelect_MouseEnter);
            this.bSelect.MouseLeave += new System.EventHandler(this.bSelect_MouseLeave);
            this.bSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // SColor
            // 
            this.SColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.SColor, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.SColor.Location = new System.Drawing.Point(3, 10);
            this.SColor.Name = "SColor";
            this.SColor.Size = new System.Drawing.Size(54, 97);
            this.SColor.TabIndex = 3;
            this.SColor.Click += new System.EventHandler(this.SColor_Click);
            this.SColor.MouseEnter += new System.EventHandler(this.SColor_MouseEnter);
            this.SColor.MouseLeave += new System.EventHandler(this.SColor_MouseLeave);
            this.SColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            // 
            // error
            // 
            this.error.BlinkRate = 500;
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // animator
            // 
            this.animator.AnimationType = ZeroitDevColorPicker.Helpers.Animations.AnimationType.Mosaic;
            this.animator.Cursor = null;
            zeroitAnimate_Animation2.AnimateOnlyDifferences = true;
            zeroitAnimate_Animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.BlindCoeff")));
            zeroitAnimate_Animation2.LeafCoeff = 0F;
            zeroitAnimate_Animation2.MaxTime = 1F;
            zeroitAnimate_Animation2.MinTime = 0F;
            zeroitAnimate_Animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.MosaicCoeff")));
            zeroitAnimate_Animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.MosaicShift")));
            zeroitAnimate_Animation2.MosaicSize = 20;
            zeroitAnimate_Animation2.Padding = new System.Windows.Forms.Padding(30);
            zeroitAnimate_Animation2.RotateCoeff = 0F;
            zeroitAnimate_Animation2.RotateLimit = 0F;
            zeroitAnimate_Animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.ScaleCoeff")));
            zeroitAnimate_Animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation2.SlideCoeff")));
            zeroitAnimate_Animation2.TimeCoeff = 0F;
            zeroitAnimate_Animation2.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = zeroitAnimate_Animation2;
            this.animator.Interval = 2;
            this.animator.MaxAnimationTime = 300;
            this.animator.Target = this.baseTheme1;
            this.animator.TargetHeight = 240;
            this.animator.TargetWidth = 220;
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.animator.SetDecoration(this.notifyMenuStrip, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripMenuItem2});
            this.notifyMenuStrip.Name = "savedColorsContextMenuStrip1";
            this.notifyMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.notifyMenuStrip.ShowImageMargin = false;
            this.notifyMenuStrip.Size = new System.Drawing.Size(128, 70);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem2.Text = "Quit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // expandFormAnimator
            // 
            this.expandFormAnimator.AnimationType = ZeroitDevColorPicker.Helpers.Animations.ZeroitVisAnim.GetAnimationType.TopAnchoredHeightEffect;
            this.expandFormAnimator.Delay = 0;
            this.expandFormAnimator.Duration = 200;
            this.expandFormAnimator.EasingType = ZeroitDevColorPicker.Helpers.Animations.ZeroitVisAnim.EasingFunctionTypes.BounceEaseIn;
            foldSizes2.MaximumSize = new System.Drawing.Size(0, 0);
            foldSizes2.MinimumSize = new System.Drawing.Size(0, 0);
            this.expandFormAnimator.FoldSizes = foldSizes2;
            this.expandFormAnimator.FoldStyle = ZeroitDevColorPicker.Helpers.Animations.ZeroitVisAnim.FoldMethod.Show;
            this.expandFormAnimator.Loops = 1;
            this.expandFormAnimator.Reverse = true;
            this.expandFormAnimator.Target = this;
            this.expandFormAnimator.ValueToReach = 400;
            // 
            // shrinkUp
            // 
            this.shrinkUp.Animation = ZeroitDevColorPicker.Helpers.Animations.FormAnimator.FormAnimationTypes.ShrinkVertical;
            grow2.End = 100;
            grow2.EndPoint = new System.Drawing.Point(100, 100);
            grow2.FixWindowWhenGrown = false;
            grow2.Recalculate = false;
            grow2.Size = new System.Drawing.Size(100, 0);
            grow2.Start = 0;
            grow2.StartPoint = new System.Drawing.Point(0, 0);
            this.shrinkUp.Grow = grow2;
            locations2.FormLocations = ZeroitDevColorPicker.Helpers.Animations.FormAnimator.FormLocations.TopLeft;
            this.shrinkUp.Locations = locations2;
            move2.DirectTrajectory = true;
            move2.EndPoint = new System.Drawing.Point(100, 100);
            move2.RandomLocations = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("move2.RandomLocations")));
            move2.StartPoint = new System.Drawing.Point(0, 0);
            this.shrinkUp.Move = move2;
            this.shrinkUp.MoveToPoint = false;
            opacity2.Start = 0.5D;
            opacity2.Step = 1D;
            this.shrinkUp.Opacity = opacity2;
            positions2.End = 246;
            positions2.EndPoint = new System.Drawing.Point(100, 100);
            positions2.ShrinkToCenter = true;
            positions2.Size = new System.Drawing.Size(200, 200);
            positions2.Start = 488;
            positions2.StartPoint = new System.Drawing.Point(0, 0);
            this.shrinkUp.Positions = positions2;
            shake2.ShakeDistance = 30;
            shake2.ShakeSpeed = 20;
            shake2.ShakeType = ZeroitDevColorPicker.Helpers.Animations.FormAnimator.ShakeType.Horizontal;
            this.shrinkUp.Shake = shake2;
            timer2.StepX = 5;
            timer2.StepY = 5;
            timer2.Time = 10;
            this.shrinkUp.Time = timer2;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "Xml Files|*.xml";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Xml Files|*.xml";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.notifyMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Color Picker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(798, 488);
            this.Controls.Add(this.baseTheme1);
            this.animator.SetDecoration(this, ZeroitDevColorPicker.Helpers.Animations.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MouseLeave += new System.EventHandler(this.baseTheme1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseTheme1_MouseMove);
            this.baseTheme1.ResumeLayout(false);
            this.mainForm.ResumeLayout(false);
            this.savedColorsContextMenuStrip1.ResumeLayout(false);
            this.savedDisplayedColors.ResumeLayout(false);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.magnifyViewer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.saveColorNamePanel.ResumeLayout(false);
            this.saveColorNamePanel.PerformLayout();
            this.noFlickerPanel6.ResumeLayout(false);
            this.noFlickerPanel6.PerformLayout();
            this.noFlickerPanel5.ResumeLayout(false);
            this.noFlickerPanel5.PerformLayout();
            this.noFlickerPanel4.ResumeLayout(false);
            this.noFlickerPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleValue)).EndInit();
            this.noFlickerPanel3.ResumeLayout(false);
            this.noFlickerPanel3.PerformLayout();
            this.noFlickerPanel2.ResumeLayout(false);
            this.noFlickerPanel2.PerformLayout();
            this.noFlickerPanel1.ResumeLayout(false);
            this.noFlickerPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.notifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme1;
        private NoFlickerPanel SColor;
        private System.Windows.Forms.Label lH;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Label lG;
        private System.Windows.Forms.Label lR;
        private NoFlickerPanel AColor;
        private NoFlickerPanel detailPanel;
        private NoFlickerPanel magnifyViewer;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label rgb;
        private NoFlickerPanel noFlickerPanel2;
        private System.Windows.Forms.Label m_txt_Hue;
        private System.Windows.Forms.Label m_txt_Black;
        private System.Windows.Forms.Label m_txt_Sat;
        private NoFlickerPanel noFlickerPanel1;
        private NoFlickerPanel noFlickerPanel3;
        private System.Windows.Forms.Label m_txt_Cyan;
        private System.Windows.Forms.Label m_txt_Yellow;
        private System.Windows.Forms.Label m_txt_Magenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_txt_K;
        private NoFlickerPanel noFlickerPanel4;
        private System.Windows.Forms.Label m_txt_L;
        private System.Windows.Forms.Label m_txt_b;
        private System.Windows.Forms.Label m_txt_a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private NoFlickerPanel noFlickerPanel6;
        private System.Windows.Forms.Label m_txt_H;
        private System.Windows.Forms.Label m_txt_V;
        private System.Windows.Forms.Label m_txt_S;
        private NoFlickerPanel noFlickerPanel5;
        private System.Windows.Forms.Label m_txt_X;
        private System.Windows.Forms.Label m_txt_Z;
        private System.Windows.Forms.Label m_txt_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown scaleValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private NoFlickerPanel gridPanel;
        private NoFlickerPanel updatePanel;
        private System.Windows.Forms.Label previewXYZ;
        private System.Windows.Forms.Label previewCMYK;
        private System.Windows.Forms.Label previewLab;
        private System.Windows.Forms.Label previewHSV;
        private System.Windows.Forms.Label previewHSB;
        private System.Windows.Forms.Label previewRGB;
        private System.Windows.Forms.Label previewHTML;
        private System.Windows.Forms.Label label36;
        private Helpers.ZeroitUltraTextBox nameTxtBox;
        private System.Windows.Forms.ContextMenuStrip savedColorsContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private NoFlickerPanel savedDisplayedColors;
        private Helpers.Button.ZeroitLollipopClickButton updateBtn;
        private NoFlickerPanel panel1;
        private System.Windows.Forms.Button externalLinkBtn;
        private System.Windows.Forms.Button upDownBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.CheckBox precisionCheck;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ErrorProvider error;
        private Helpers.SimpleListView savedColors;
        private System.Windows.Forms.ToolStripMenuItem clearColorsToolStripMenuItem;
        private Helpers.Colors.WikiColors.AllWebColorsComboBox allWebColors;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.ListBox colorListBox;
        private NoFlickerPanel searchPanel;
        private Helpers.ZeroitUltraTextBox searchTextBox;
        private NoFlickerPanel saveColorNamePanel;
        private System.Windows.Forms.Label itemsFound;
        private System.Windows.Forms.Label itemsFoundSecond;
        private System.Windows.Forms.CheckBox showColors;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label39;
        private Helpers.Animations.ZeroitAnimator animator;
        private Helpers.Animations.ZeroitVisAnim expandFormAnimator;
        private System.Windows.Forms.ContextMenuStrip mainForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Helpers.Animations.FormAnimator.ZeroitFormAnimator shrinkUp;
        private System.Windows.Forms.ToolStripMenuItem saveAsProjectToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}

