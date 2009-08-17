using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.UI.WinForms;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.CommonControls;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public partial class AddBookingView : ViewBase
    {
        public AddBookingView()
        {
            InitializeComponent();

            ViewModel = new AddBookingViewModel();
        }

        protected override IEnumerable<Control> ChildrenRequiringInjection
        {
            get { yield return bookingEntryView; }
        }


        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Inject]
        public AddBookingController Controller { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AddBookingViewModel ViewModel
        {
            get { return (AddBookingViewModel)dataContext.DataSource; }
            private set { dataContext.DataSource = value; }
        }

        private void addBooking_Click(object sender, EventArgs e)
        {
            Controller.AddBooking(ViewModel.Booking);
        }

        private void cancelAdd_Click(object sender, EventArgs e)
        {
            Controller.CancelAdd();
        }
    }
}
