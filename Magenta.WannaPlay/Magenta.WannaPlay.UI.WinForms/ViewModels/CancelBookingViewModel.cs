﻿using System;
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
using Magenta.WannaPlay.UI.WinForms.Controls.Editors;

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

        #region SelectedBookings
        IEnumerable<BookingEntryUI> _selectedBookings;
        public IEnumerable<BookingEntryUI> SelectedBookings
        {
            get { return BookingSearch.SelectedBookings; }
        }

        private void OnSelectedBookingsChanged()
        {
            OnCanCacelSelectedBookingsChanged();
        }
        #endregion

        #region CanCacelSelectedBookings
        public bool CanCacelSelectedBookings
        {
            get { return SelectedBookings.Count() > 0; }
        }

        public event EventHandler CanCacelSelectedBookingsChanged;

        void OnCanCacelSelectedBookingsChanged()
        {
            var handler = CanCacelSelectedBookingsChanged;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion

        public CancelBookingViewModel(IKernel kernel, ICommonUIService commonUIService, IBookingService bookingService)
        {
            Kernel = RequireArg.NotNull(kernel);
            CommonUIService = RequireArg.NotNull(commonUIService);
            BookingService = RequireArg.NotNull(bookingService);

            BookingSearch = Kernel.Get<BookingSearchViewModel>();
            BookingSearch.SelectedBookingsChanged += delegate { OnSelectedBookingsChanged(); };
        }

        public void CancelSelectedBookings()
        {
            var bookingsToCancel = SelectedBookings.ToBindingList();

            if (bookingsToCancel.Count == 0)
                return;

            CancelSingleBooking(bookingsToCancel.First());
        }

        private void CancelSingleBooking(BookingEntryUI bookingToCancel)
        {
            var bookingControl = new CancelBookingConfirmationControl();

            var viewModel = Kernel.Get<CancelBookingConfirmationViewModel>();
            viewModel.BookingUI = bookingToCancel;

            bookingControl.ViewModel = viewModel;

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Parent = CommonUIService.MainForm,
                Title = "Cancel booking?",
                Content = bookingControl,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Cancel booking", IsAcceptButton = true, OnClick = () => CancelBooking(bookingToCancel) },
                    new DialogButtonDescription { Text = "Don't cancel", IsCancelButton = true }     
                },
                Icon = Resources.CancelBooking
            });
        }

        private void CancelBooking(BookingEntryUI booking)
        {
            BookingService.CancelBookingEntry(booking.Booking);
        }
    }
}
