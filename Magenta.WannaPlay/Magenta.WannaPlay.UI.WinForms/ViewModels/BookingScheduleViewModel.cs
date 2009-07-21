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

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingScheduleViewModel : INotifyPropertyChanged
    {
        public IBookingService BookingService { get; private set; }
        public IResidenceManager ResidenceManager { get; private set; }

        public BindingList<BookingEntry> BookingEntries { get; private set; }
        public BindingList<Facility> Facilities { get; private set; }

        public DateTimePeriod Period { get; set; }
        public FacilityType FacilityType { get; set; }


        public BookingScheduleViewModel(IBookingService bookingService, IResidenceManager residenceManager)
        {
            BookingService = RequireArg.NotNull(bookingService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            // TODO: Parametrize
            FacilityType = FacilityType.TennisCourt;
            Period = DateTimePeriod.FromDays(DateTime.UtcNow.AddDays(-1), 1);

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            //TODO: Load list of bookings
            Facilities = ResidenceManager.GetFacilities(FacilityType.TennisCourt).ToBindingList();
            BookingEntries = BookingService.GetBookingEntries(Period, FacilityType).ToBindingList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public BookingSlot GetFacilityBookingSlot(Facility facility, DateTimePeriod period)
        {
            if (period.From.Hour % 5 == facility.Id)
                return new BookingSlot(BookingEntries.First());
            else
                return new EmptyBookingSlot(period);
        }
    }
}
