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

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class FacilityBookingViewModel : INotifyPropertyChanged
    {
        public BindingList<FixedTimeBooking> Slots { get; private set; }
        public IFixedTimeBookingService BookingService { get; private set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public FacilityType FacilityType { get; set; }


        public FacilityBookingViewModel(IFixedTimeBookingService bookingService)
        {
            BookingService = RequireArg.NotNull(bookingService);

            // TODO: Parametrize
            FacilityType = FacilityType.TennisCourt;
            From = DateTime.UtcNow;
            To = From.AddDays(1);

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            Slots = BookingService.GetBookings(new DateTimePeriod(From, To), FacilityType).ToBindingList();
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
