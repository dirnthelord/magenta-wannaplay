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

        [Browsable(false)]
        public IKernel Kernel { get; set; }


        public BookingSearchRequest BookingSearchRequest { get; private set; }
        public BookingEntryListViewModel SearchResults { get; private set; }


        public BookingSearchViewModel(IBookingService bookingService, IResidenceManager residenceManager, IKernel kernel)
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);
            Kernel = RequireArg.NotNull(kernel);

            BookingSearchRequest = Kernel.Get<BookingSearchRequest>();
            SearchResults = Kernel.Get<BookingEntryListViewModel>();
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

            SearchResults.Bookings.ReplaceWith(bookings);
        }
    }
}
