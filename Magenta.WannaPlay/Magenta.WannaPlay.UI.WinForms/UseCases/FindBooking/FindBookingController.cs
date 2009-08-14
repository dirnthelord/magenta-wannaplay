using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.Aop;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public class FindBookingController
    {
        [Inject]
        public IBookingService BookingService { get; set; }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }


        public FindBookingViewModel ViewModel { get; private set; }


        public FindBookingController()
        {
            ViewModel = ObjectFactory.Create<FindBookingViewModel>();
        }


        public void FindBooking()
        {
            // TODO: Remove hardcoded number of days
            var period = DateTimePeriod.FromDays(DateTime.Now, 1);
            var facilities = ResidenceManager.GetFacilities();

            // TODO: Change BookingService interface to IQueryable
            var bookings = BookingService.GetBookingEntries(period, facilities);

            
            var facilityCard = ViewModel.BookingSearchRequest.ResidentFacilityCardNumber;

            if (!facilityCard.IsNullOrEmpty())
                bookings = bookings.Where(b => b.Resident.PassCardNumber == facilityCard);

            
            var unitNumber = ViewModel.BookingSearchRequest.AddressUnitNumber;

            if (!unitNumber.IsNullOrEmpty())
                bookings = bookings.Where(b => b.Resident.Unit.Number == unitNumber);

            
            var blockNumber = ViewModel.BookingSearchRequest.AddressBlockNumber;

            if (!blockNumber.IsNullOrEmpty() )
                bookings = bookings.Where(b =>b.Resident.Unit.Block == blockNumber);


            ViewModel.SearchResults.Bookings.ReplaceWith(bookings);
        }

    }
}
