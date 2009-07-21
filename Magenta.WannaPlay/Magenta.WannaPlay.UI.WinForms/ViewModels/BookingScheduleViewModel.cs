using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingScheduleViewModel : INotifyPropertyChanged
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IBookingService BookingService { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IBookingScheduleService BookingScheduleService { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IResidenceManager ResidenceManager { get; private set; }

        public IEnumerable<BookingEntry> BookingEntries { get; private set; }
        public BindingList<BookingPeriodUI> BookingSlots { get; private set; }

        public BindingList<Facility> Facilities { get; private set; }

        public DateTimePeriod Period { get; set; }


        public BookingScheduleViewModel(IBookingService bookingService,
            IBookingScheduleService bookingScheduleService,
            IResidenceManager residenceManager)
        {
            BookingService = RequireArg.NotNull(bookingService);
            BookingScheduleService = RequireArg.NotNull(bookingScheduleService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            // TODO: Parametrize
            Facilities = ResidenceManager.GetFacilities().ToBindingList();

            Period = DateTimePeriod.FromDays(DateTime.UtcNow.AddDays(-1), 1);

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            //TODO: Load list of bookings
            BookingEntries = BookingService.GetBookingEntries(Period, Facilities).ToBindingList();
            BookingSlots = BookingScheduleService.GetSchedule(Period).Select(p => new BookingPeriodUI(p)).ToBindingList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable<BookingEntry> GetBookingEntries(IEnumerable<BookingSlot> slots)
        {
            return BookingEntries.Where(entry => slots.Any(slot =>
                slot.Facility == entry.Facility &&
                slot.Period.Intersect(entry.Period).GetTimeSpan().Ticks > 0));
        }

    }
}
