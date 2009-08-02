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
    public class BookingEntryViewModel
    {
        [Browsable(false)]
        public IBookingService BookingService { get; private set; }

        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }

        [Browsable(false)]
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        public string BookingDetails
        {
            get
            {
                return string.Format(@"{0} on {1:dd MMMM} at {2:$h $tt} for {3:$h $hour(s)}", Facility.Name, BookingPeriod.PeriodDay, BookingPeriod.PeriodFrom, BookingPeriod.PeriodFor);
            }
        }

        public Facility Facility { get; set; }
        public DateTimePeriodUI BookingPeriod { get; set; }
        public ResidentUI Resident { get; set; }
        public string Comment { get; set; }

        public BookingEntryViewModel
            (
                IBookingService bookingService,
                IResidenceManager residenceManager,
                IWannaPlayContextService wannaPlayContextService
            )
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);

            BookingPeriod = new DateTimePeriodUI();
            Resident = new ResidentUI();
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
