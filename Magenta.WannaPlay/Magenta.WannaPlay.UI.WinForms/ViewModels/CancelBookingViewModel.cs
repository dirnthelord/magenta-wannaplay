using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.Services.Booking;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        [Browsable(false)]
        public ICommonUIService CommonUIService { get; private set; }

        [Browsable(false)]
        public IBookingService BookingService { get; private set; }

        public BookingSearchViewModel BookingSearch { get; private set; }

        IEnumerable<BookingEntryUI> _selectedBookings = Enumerable.Empty<BookingEntryUI>();
        public IEnumerable<BookingEntryUI> SelectedBookings
        {
            get { return _selectedBookings; }
            set
            {
                _selectedBookings = value ?? Enumerable.Empty<BookingEntryUI>();
                OnSelectedBookingsChanged();
            }
        }

        private void OnSelectedBookingsChanged()
        {
            OnPropertyChanged("SelectedBookings");
            OnPropertyChanged("CanCacelSelectedBookings");
        }

        public bool CanCacelSelectedBookings
        {
            get { return SelectedBookings.Count() > 0; }
        }


        public CancelBookingViewModel(IKernel kernel, ICommonUIService commonUIService, IBookingService bookingService)
        {
            Kernel = RequireArg.NotNull(kernel);
            CommonUIService = RequireArg.NotNull(commonUIService);
            BookingService = RequireArg.NotNull(bookingService);

            BookingSearch = Kernel.Get<BookingSearchViewModel>();
        }

        public void CancelSelectedBookings()
        {
            var bookingsToCancel = SelectedBookings.ToBindingList();

            var bookingListControl = new BookingEntryListControl();
            bookingListControl.ItemsSource = bookingsToCancel;

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = CommonUIService.MainForm,
                Title = "Cancel bookings?",
                Content = bookingListControl,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Yes", IsAcceptButton = true, OnClick = () => CancelBookings(bookingsToCancel) },
                    new DialogButtonDescription { Text = "No", IsCancelButton = true }     
                },
                Icon = Resources.CancelBooking
            });

            // TODO: Remove UI references
        }

        private void CancelBookings(IEnumerable<BookingEntryUI> bookings)
        {
            foreach (var booking in bookings)
                BookingService.CancelBookingEntry(booking.Booking);
        }
    }
}
