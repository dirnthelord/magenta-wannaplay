using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    [DefaultBindingProperty("ViewModel")]
    public partial class BookingEntryEditor : UserControl
    {
        public BookingEntryEditor()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public BookingEntry ViewModel
        {
            get { return dataContext.DataSource as BookingEntry; }
            set { dataContext.DataSource = value; }
        }
    }
}
