using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using System.ComponentModel;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingSearchViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IBookingService BookingService { get; private set; }

        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }


        public BookingSearchRequest BookingSearchRequest { get; private set; }
        public BindingList<BookingEntry> SearchResults { get; private set; }


        IEnumerable<BookingEntry> _selectedBookings = Enumerable.Empty<BookingEntry>();
        public IEnumerable<BookingEntry> SelectedBookings
        {
            get { return _selectedBookings; }
            set
            {
                _selectedBookings = value ?? Enumerable.Empty<BookingEntry>();
                OnSelectedBookingsChanged();
            }
        }

        bool _allowMultipleSelection;
        public bool AllowMultipleSelection
        {
            get { return _allowMultipleSelection; }
            set { _allowMultipleSelection = value; OnPropertyChanged("AllowMultipleSelection"); }
        }

        public event EventHandler SelectedBookingsChanged;

        private void OnSelectedBookingsChanged()
        {
            OnPropertyChanged("SelectedBookings");

            var handler = SelectedBookingsChanged;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }


        public BookingSearchViewModel(IBookingService bookingService, IResidenceManager residenceManager)
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            SearchResults = new BindingList<BookingEntry>();
            BookingSearchRequest = new BookingSearchRequest();
        }

        public void FindBookings()
        {
            // TODO: Remove hardcoded number of days
            var period = DateTimePeriod.FromDays(DateTime.Now, 1);
            var facilities = ResidenceManager.GetFacilities();

            // TODO: Change BookingService interface IQueryable
            var bookings = BookingService.GetBookingEntries(period, facilities);

            if (BookingSearchRequest.Resident.IsSpecified)
                bookings = bookings.Where(b => b.Resident.PassCardNumber == BookingSearchRequest.Resident.FacilityCardNumber);

            if (BookingSearchRequest.Unit.IsSpecified)
                bookings = bookings.Where(b =>
                    b.Resident.Unit.Block == BookingSearchRequest.Unit.BlockNumber && 
                    b.Resident.Unit.Number == BookingSearchRequest.Unit.UnitNumber);

            SearchResults.ReplaceWith(bookings);
        }
    }
}
