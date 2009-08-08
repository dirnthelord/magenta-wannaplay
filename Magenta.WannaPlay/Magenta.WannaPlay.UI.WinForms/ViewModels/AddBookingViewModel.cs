using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Residence;
using Magenta.Shared.DesignByContract;
using System.ComponentModel;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class AddBookingViewModel
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        [Browsable(false)]
        public IBookingService BookingService { get { return Kernel.Get<IBookingService>(); } }

        [Browsable(false)]
        public IResidenceManager ResidenceManager { get { return Kernel.Get<IResidenceManager>(); } }

        [Browsable(false)]
        public IWannaPlayContextService WannaPlayContextService { get { return Kernel.Get<IWannaPlayContextService>(); } }


        public BookingEntry Booking { get; set; }


        public string BookingTitle
        {
            get { return string.Format("Book {0}", Booking.Facility.Name); }
        }


        public AddBookingViewModel(IKernel kernel)
        {
            Kernel = RequireArg.NotNull(kernel);
        }

        public void SaveBooking()
        {
            var bookingEntry = new BookingEntry
            {
                BookedAtDateTime = DateTime.UtcNow,
                BookedByGuard = WannaPlayContextService.CurrentGuard,
                Facility = Booking.Facility,
                Resident = GetSelectedResident(),
                Period = Booking.Period,
            };

            BookingService.SaveBookingEntry(bookingEntry);
        }

        Resident GetSelectedResident()
        {
            var existingResident = ResidenceManager.GetResident(Booking.Resident.PassCardNumber);

            var resident = existingResident ?? new Resident();

            resident.Name = Booking.Resident.Name;
            resident.Unit = GetSelectedUnit();

            return resident;
        }

        ResidenceUnit GetSelectedUnit()
        {
            var existingUnit = ResidenceManager.GetResidenceUnit(Booking.Resident.Unit.Block, Booking.Resident.Unit.Number);

            var unit = existingUnit ?? new ResidenceUnit();

            unit.Block = Booking.Resident.Unit.Block;
            unit.Number = Booking.Resident.Unit.Number;

            return unit;
        }
    }
}
