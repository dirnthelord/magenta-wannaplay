using System;
using System.Collections.Generic;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.Shared;
using System.Linq;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingService : IBookingService
    {
        [Inject]
        public IBookingValidationService BookingValidationService { get; set; }

        [Inject]
        public IPersistenceRepository PersistenceRepository { get; set; }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }


        #region IBookingService Members

        public IEnumerable<BookingEntry> GetBookingEntries(DateTimePeriod period, IEnumerable<Facility> facilities)
        {
            return PersistenceRepository.Search<BookingEntry>(e => e.Period.From >= period.From.RoundDateDown()
                    && e.Period.To <= period.To.RoundDateUp()
                   && facilities.Contains(e.Facility));
        }

        public void AddBooking(BookingEntry bookingEntry)
        {
            BookingValidationService.ValidateBookingToAdd(bookingEntry).ThrowIfFailed();

            // Ensure such no resident duplication
            bookingEntry.Resident = ResidenceManager.RectifyResident(bookingEntry.Resident);

            PersistenceRepository.Save(bookingEntry);
        }

        public void CancelBooking(BookingEntry bookingEntry)
        {
            PersistenceRepository.Delete(bookingEntry);
        }

        #endregion
    }
}