using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CefSharp.WinForms;

namespace Pinball
{
    public partial class batman66 : UserControl
    {
        public batman66()
        {
            InitializeComponent();
            var geh = Path.GetFullPath(Application.ExecutablePath);
            geh = geh.Replace(Path.GetFileName(Application.ExecutablePath), "");

            var browser = new ChromiumWebBrowser(geh + "\\html\\batman.html");
            panel1.Controls.Add(browser);
        }
    }
}
