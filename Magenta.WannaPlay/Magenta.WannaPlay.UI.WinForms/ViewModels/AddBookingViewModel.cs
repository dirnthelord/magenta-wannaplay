using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class AddBookingViewModel
    {
        public IBookingService BookingService { get; private set; }
        public IResidenceManager ResidenceManager { get; private set; }

        public BindingList<Facility> Facilities { get; private set; }
        public BindingList<DutyGuard> DutyGuards { get; private set; }

        public DateTimePeriod BookingPeriod { get; set; }
        public ResidentDetailsUI Resident { get; set; }
        public string Comment { get; set; }

        public AddBookingViewModel(IBookingService bookingService, IResidenceManager residenceManager)
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            Facilities = ResidenceManager.GetFacilities().ToBindingList();
            DutyGuards = ResidenceManager.GetDutyGuards().ToBindingList();

            // TODO: Replace with Resident from Model (?)
            Resident = new ResidentDetailsUI();
        }

        public void ResidentAutoFillRequired()
        {
            var resident = ResidenceManager.GetResident(Resident.FactilityCardNumber);

            if (resident == null)
                return;

            Resident.AddressBlockNumber = resident.Unit.Block;
            Resident.AddressUnitNumber = resident.Unit.Number;
            Resident.Name = resident.Name;
        }
    }
}
