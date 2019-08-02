using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
