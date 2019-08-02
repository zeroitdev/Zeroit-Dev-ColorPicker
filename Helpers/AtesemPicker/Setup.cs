using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ZeroitDevColorPicker
{
    [RunInstaller(true),
    ComVisible(false)]
    public partial class Setup : Installer
    {
        public Setup()
        {
            InitializeComponent();
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "explorer";
                p.StartInfo.Arguments = "\"" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Programs), "ColorPicker Gadget") + "\"";
                p.Start();
            }
            catch
            {
            }
        }
    }
}
