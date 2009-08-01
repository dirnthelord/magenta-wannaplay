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
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingScheduleDetailsViewModel// : INotifyPropertyChanged
    {
        public BindingList<BookingEntryUI> BookingSlots { get; private set; }
        public IEnumerable<BookingEntry> BookingEntries { get; private set; }

        public IBookingService BookingService { get; private set; }
        public IBookingScheduleService BookingScheduleService { get; private set; }

        public DateTimePeriod Period { get; set; }
        public Facility Facility { get; set; }


        public BookingScheduleDetailsViewModel(IBookingService bookingService, IBookingScheduleService bookingScheduleService)
        {
            BookingService = RequireArg.NotNull(bookingService);
            BookingScheduleService = RequireArg.NotNull(bookingScheduleService);

            // TODO: Parametrize
            Facility = new Facility { FacilityType = FacilityType.TennisCourt, Name = "Court One", Id = 1 };
            Period = DateTimePeriod.FromDays(DateTime.UtcNow.AddDays(-1), 1);

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            BookingEntries = BookingService.GetBookingEntries(Period, Facility.ToEnumerable());
            BookingSlots = BookingScheduleService.GetBookingDetails(Period, Facility).ToBindingList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
