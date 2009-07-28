using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Residence;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class AddBookingViewModel
    {
        [Inject]
        public IBookingService BookingService { get; set; }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Inject]
        public BookingEntryEditorViewModel BookingEntry { get; set; }


        public void AddBooking()
        {
            var bookingEntry = new BookingEntry
            {
                BookedAtDateTime = DateTime.UtcNow,
                BookedByGuard = BookingEntry.SelectedDutyGuard,
                Facility = BookingEntry.SelectedFacility,
                Resident = GetSelectedResident(),
                Period = BookingEntry.BookingPeriod.Model,
            };

            BookingService.SaveBookingEntry(bookingEntry);
        }

        private Resident GetSelectedResident()
        {
            var existingResident = ResidenceManager.GetResident(BookingEntry.Resident.FactilityCardNumber);

            var resident = existingResident ?? new Resident();

            resident.Name = BookingEntry.Resident.Name;
            resident.PassCardNumber = BookingEntry.Resident.FactilityCardNumber;
            resident.Unit = GetSelectedUnit();

            return resident;
        }

        private ResidenceUnit GetSelectedUnit()
        {
            var existingUnit = ResidenceManager.GetResidenceUnit(BookingEntry.Resident.AddressBlockNumber, BookingEntry.Resident.AddressUnitNumber);

            var unit = existingUnit ?? new ResidenceUnit();

            unit.Block = BookingEntry.Resident.AddressBlockNumber;
            unit.Number = BookingEntry.Resident.AddressUnitNumber;

            return unit;
        }
    }
}
