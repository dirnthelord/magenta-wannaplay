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
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Value")]
    [DefaultBindingProperty("Value")]
    public partial class UnitNumberEditorControl : UserControl
    {
        public UnitNumberEditorControl()
        {
            InitializeComponent();
        }

        public string Value
        {
            get { return unitNumber.Text; }
            set { unitNumber.Text = value; }
        }

        public event EventHandler ValueChanged
        {
            add { unitNumber.TextChanged += value; }
            remove { unitNumber.TextChanged -= value; }
        }
    }
}
