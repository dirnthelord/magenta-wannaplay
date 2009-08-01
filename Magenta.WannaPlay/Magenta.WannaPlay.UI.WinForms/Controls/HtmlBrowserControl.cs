using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    [DefaultBindingProperty("Html")]
    public partial class HtmlBrowserControl : UserControl
    {
        public HtmlBrowserControl()
        {
            InitializeComponent();
        }

        public string Html
        {
            get { return webBrowser.DocumentText; }
            set { webBrowser.DocumentText = value; }
        }
    }
}
