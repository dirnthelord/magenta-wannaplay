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

namespace Magenta.WannaPlay.UI.WinForms.Controls.Editors
{
    public partial class BookingEntryEditor : UserControl
    {
        public BookingEntryEditor()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Bindable(true)]
        public BookingEntryViewModel ViewModel
        {
            get { return (BookingEntryViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        bool _isReadOnly;
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value;
            throw new NotImplementedException();
            //resident.IsReadOnly = true;
            }
        }
    }
}
