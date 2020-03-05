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
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\html\\batman.html";
            var browser = new ChromiumWebBrowser(path);
            panel1.Controls.Add(browser);
        }
    }
}
