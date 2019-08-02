﻿// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-30-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="Messages.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string Message
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                Invalidate();
            }
        }

        public string MessageTitle
        {
            get { return this.Text; }
            set
            {
                Text = value;
                Invalidate();
            }
        }
    }
}
