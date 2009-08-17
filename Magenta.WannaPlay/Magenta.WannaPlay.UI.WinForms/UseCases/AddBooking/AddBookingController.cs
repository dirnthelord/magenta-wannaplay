using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public class AddBookingController
    {
        [Inject]
        public IKernel Kernel { get; set; }

        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Inject]
        public IWannaPlayContextService WannaPlayContextService { get; set; }

        [Inject]
        public IBookingService BookingService { get; set; }


        public void AddBooking(BookingEntry booking)
        {
            // TODO: Use external service to get time
            booking.BookedAtDateTime = DateTime.Now;
            booking.BookedByGuard = WannaPlayContextService.CurrentGuard;

            booking.Resident = RectifyResident(booking.Resident);

            BookingService.AddBooking(booking);
        }

        Resident RectifyResident(Resident newResident)
        {
            var resident = ResidenceManager.GetResident(newResident.PassCardNumber);

            if (resident == null)
                resident = newResident;
            else
                resident.CopyFrom(newResident);

            resident.Unit = RectifyUnit(newResident.Unit);

            return resident;
        }

        ResidenceUnit RectifyUnit(ResidenceUnit newUnit)
        {
            var unit = ResidenceManager.GetResidenceUnit(newUnit.Block, newUnit.Number);

            if (unit == null)
                unit = newUnit;
            else
                unit.CopyFrom(newUnit);

            return unit;
        }

        public void CancelAdd()
        {
            FinishDialog();
        }

        private void FinishDialog()
        {
            DialogFinished.Raise(this, EventArgs.Empty);
        }

        public event EventHandler DialogFinished;
    }
}
