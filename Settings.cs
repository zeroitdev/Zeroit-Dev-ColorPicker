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
