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


            //Create a new instance in code or add via the designer
            //Set the ChromiumWebBrowser.Address property to your Url if you use the designer.
            
            var geh = Path.GetFullPath(Application.ExecutablePath);
            geh = geh.Replace(Path.GetFileName(Application.ExecutablePath), "");

            var browser = new ChromiumWebBrowser(geh + "\\html\\drwho.html");
            panel1.Controls.Add(browser);
        }

        private void drwho_Load(object sender, EventArgs e)
        {

        }
    }
}
