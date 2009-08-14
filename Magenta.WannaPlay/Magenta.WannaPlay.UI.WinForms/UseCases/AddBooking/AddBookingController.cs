using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.Aop;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Booking;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public class AddBookingController
    {
        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Inject]
        public IWannaPlayContextService WannaPlayContextService { get; set; }

        [Inject]
        public IBookingService BookingService { get; set; }


        public AddBookingViewModel ViewModel { get; private set; }


        public AddBookingController()
        {
            ViewModel = ObjectFactory.Create<AddBookingViewModel>();
        }

        public void AddBooking()
        {
            var bookingEntry = new BookingEntry
            {
                // TODO: Use external service to get time
                BookedAtDateTime = DateTime.Now,

                BookedByGuard = WannaPlayContextService.CurrentGuard,
                Facility = ViewModel.Facility,
                Resident = GetResident(),
                Period = ViewModel.Period,
                Remarks = ViewModel.Remarks
            };

            BookingService.SaveBookingEntry(bookingEntry);
        }

        Resident GetResident()
        {
            var passCardNumber = ViewModel.ResidentController.ViewModel.PassCardNumber;
            var resident = ResidenceManager.GetResident(passCardNumber);

            if (resident == null)
                resident = new Resident
                {
                    PassCardNumber = passCardNumber
                };

            resident.Name = ViewModel.ResidentController.ViewModel.Name;
            resident.Unit = GetUnit();

            return resident;
        }

        ResidenceUnit GetUnit()
        {
            var block = ViewModel.ResidentController.ViewModel.AddressBlockNumber;
            var unit = ViewModel.ResidentController.ViewModel.AddressUnitNumber;

            var address = ResidenceManager.GetResidenceUnit(block, unit);

            if (address == null)
                address = new ResidenceUnit
                {
                    Block = block,
                    Number = unit,
                };

            return address;
        }

    }
}
