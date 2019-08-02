// ***********************************************************************
// Assembly         : Zeroit Dev Color Picker
// Author           : ZEROIT
// Created          : 06-30-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="FollowTextForm.cs" company="Zeroit Dev Technologies">
//     Copyright ©  2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Windows.Forms;

namespace ZeroitDevColorPicker
{
    public partial class FollowTextForm : Form
    {
        public FollowTextForm()
        {
            InitializeComponent();
            TransparencyKey = BackColor;
        }
    }
}
