using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Value")]
    [DefaultBindingProperty("Value")]
    public partial class UnitNumberEditor : UserControl
    {
        public UnitNumberEditor()
        {
            InitializeComponent();
        }

        public string Value
        {
            get { return unitNumber.Text; }
            set { unitNumber.Text = value; }
        }

        public bool ReadOnly
        {
            get { return unitNumber.ReadOnly; }
            set { unitNumber.ReadOnly = value; }
        }

        public event EventHandler ValueChanged
        {
            add { unitNumber.TextChanged += value; }
            remove { unitNumber.TextChanged -= value; }
        }
    }
}
