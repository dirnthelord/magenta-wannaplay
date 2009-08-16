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
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    [DefaultBindingProperty("Value")]
    public partial class BookingEntryView : ViewBase
    {
        public BookingEntryView()
        {
            InitializeComponent();

            ViewModel = new BookingEntryViewModel();
        }


        protected override IEnumerable<Control> ChildrenRequiringInjection
        {
            get { yield return residentView; }
        }


        #region DataContext
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(true)]
        public BookingEntry Value
        {
            get { return ViewModel.Booking; }
            set { ViewModel.Booking = value; }
        }


        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookingEntryViewModel ViewModel
        {
            get { return (BookingEntryViewModel)dataContext.DataSource; }
            private set { dataContext.DataSource = value; }
        }
        #endregion
    }
}
