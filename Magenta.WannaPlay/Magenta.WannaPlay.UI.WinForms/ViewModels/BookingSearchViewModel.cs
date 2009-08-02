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

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingSearchViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IBookingService BookingService { get; private set; }

        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }


        public BookingSearchRequestUI BookingSearchRequest { get; set; }
        public BindingList<BookingEntryUI> SearchResults { get; set; }

        public BookingSearchViewModel
            (
                IBookingService bookingService, 
                IResidenceManager residenceManager
            )
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            SearchResults = new BindingList<BookingEntryUI>();
            BookingSearchRequest = new BookingSearchRequestUI();
        }

        public void FindBookings()
        {
            // TODO: Remove hardcoded number of days
            var period = DateTimePeriod.FromDays(DateTime.Now, 1);
            var facilities = ResidenceManager.GetFacilities();

            var bookings = BookingService.GetBookingEntries(period, facilities);

            if (BookingSearchRequest.Unit.IsSpecified)
            {
                var unit = ResidenceManager.GetResidenceUnit(BookingSearchRequest.Unit.BlockNumber, BookingSearchRequest.Unit.UnitNumber);
                bookings = bookings.Where(b => b.Resident.Unit == unit);
            };

            if (BookingSearchRequest.Resident.IsSpecified)
            {
                var resident = ResidenceManager.GetResident(BookingSearchRequest.Resident.FacilityCardNumber);
                bookings = bookings.Where(b => b.Resident == resident);
            };

            SearchResults.ReplaceWith(bookings.Select(b => new BookingEntryUI(b)));
        }
    }
}
