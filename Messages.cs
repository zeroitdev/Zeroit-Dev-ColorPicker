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
