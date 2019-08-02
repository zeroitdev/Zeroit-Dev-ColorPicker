#region Using...
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace ZeroitDevColorPicker
{
    //[Guid("fc720f6d-e15d-4b4d-82af-4dff1fb3db4d"),
    //ComVisible(true)]


    public partial class Gadget : UserControl
    {
        #region Constructor
        public Gadget()
        {
            MagnifyingGlass.UseWin32Api = true;
            InitializeComponent();
            Font = new Font("Microsoft Sans Serif", (float)8.25);
            MGlass.Hide();
            AColor.Hide();
            MGlass.MovingGlass.MagnifyingGlass.Click += new EventHandler(MagnifyingGlass_Click);
            SelectColor(MGlass.PixelColor);
        }
        #endregion

        #region Update the color preview
        private void MGlass_DisplayUpdated(MagnifyingGlass sender)
        {
            AColor.BackColor = MGlass.PixelColor;
        }
        
        #endregion

        #region Select a color
        private void MagnifyingGlass_Click(object sender, EventArgs e)
        {
            SelectColor(MGlass.PixelColor);
            MGlass.Hide();
            MGlass.UpdateTimer.Stop();
            AColor.Hide();
            SColor.Show();
            lR.Show();
            lG.Show();
            lB.Show();
            lH.Show();
            bSelect.Show();
        }

        private void SColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = SColor.BackColor;
            cd.AllowFullOpen = true;
            cd.AnyColor = true;
            cd.FullOpen = true;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            SelectColor(cd.Color);
        }

        private void SelectColor(Color color)
        {
            SColor.BackColor = color;
            lR.Text = "R: " + color.R.ToString();
            lG.Text = "G: " + color.G.ToString();
            lB.Text = "B: " + color.B.ToString();
            lH.Text = "#" + Int2Hex(color.R, 2) + Int2Hex(color.G, 2) + Int2Hex(color.B, 2);
        }
        #endregion

        #region Copy a color value
        private void lR_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.R.ToString());
        }

        private void lH_Click(object sender, EventArgs e)
        {
            CopyTextData(lH.Text.Substring(1));
        }

        private void lG_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.G.ToString());
        }

        private void lB_Click(object sender, EventArgs e)
        {
            CopyTextData(SColor.BackColor.B.ToString());
        }

        private void CopyTextData(string text)
        {
            Clipboard.SetText(text);
        }
        #endregion

        #region Enter the select mode
        private void bSelect_Click(object sender, EventArgs e)
        {
            lR.Hide();
            lG.Hide();
            lB.Hide();
            lH.Hide();
            SColor.Hide();
            bSelect.Hide();
            MGlass.Show();
            AColor.Show();
            MGlass.UpdateTimer.Start();
            MGlass.MovingGlass.Show();
        }
        #endregion

        #region Effects
        private void SColor_MouseEnter(object sender, EventArgs e)
        {
            SColor.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SColor_MouseLeave(object sender, EventArgs e)
        {
            SColor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lR_MouseEnter(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Bold);
        }

        private void lR_MouseLeave(object sender, EventArgs e)
        {
            Label obj = (Label)sender;
            obj.Font = new Font(obj.Font, FontStyle.Regular);
        }
        #endregion

        #region Tools
		public string Int2Hex(int intVal,int len)
		{
            string hexVal = intVal.ToString("X");
            if(hexVal.Length < len)
			{
                hexVal = hexVal.PadLeft(len, '0');
			}
            return hexVal;
		}
        #endregion
    }
}
