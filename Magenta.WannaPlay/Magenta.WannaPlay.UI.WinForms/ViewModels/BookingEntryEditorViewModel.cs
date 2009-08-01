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
using Magenta.WannaPlay.UI.WinForms.Services;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryEditorViewModel
    {
        public IBookingService BookingService { get; private set; }
        public IResidenceManager ResidenceManager { get; private set; }
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        public BindingList<Facility> Facilities { get; private set; }
        public BindingList<DutyGuard> DutyGuards { get; private set; }

        public DutyGuard SelectedDutyGuard { get; set; }
        public Facility SelectedFacility { get; set; }

        public DateTimePeriodUI BookingPeriod { get; set; }
        public ResidentDetailsUI Resident { get; set; }
        public string Comment { get; set; }

        public BookingEntryEditorViewModel
            (
                IBookingService bookingService,
                IResidenceManager residenceManager,
                IWannaPlayContextService wannaPlayContextService
            )
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);

            Facilities = ResidenceManager.GetFacilities().ToBindingList();
            DutyGuards = ResidenceManager.GetDutyGuards().ToBindingList();

            BookingPeriod = new DateTimePeriodUI();
            SelectedDutyGuard = WannaPlayContextService.CurrentGuard;

            // TODO: Replace with Resident from Model (?)
            Resident = new ResidentDetailsUI();
        }

        public void ResidentAutoFillRequired()
        {
            var resident = ResidenceManager.GetResident(Resident.FactilityCardNumber);

            if (resident == null)
                return;

            var unit = resident.Unit;

            if (unit != null)
            {
                Resident.AddressBlockNumber = unit.Block;
                Resident.AddressUnitNumber = unit.Number;
            }

            Resident.Name = resident.Name;
        }
    }
}
