using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using System.IO;

namespace Pinball
{
    public partial class drwho : UserControl
    {
        public drwho()
        {
            InitializeComponent();
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\html\\drwho.html";
            var browser = new ChromiumWebBrowser(path);
            panel1.Controls.Add(browser);
        }

        private void drwho_Load(object sender, EventArgs e)
        {

        }
    }
}
