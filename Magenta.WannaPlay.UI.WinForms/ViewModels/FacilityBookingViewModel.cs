using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class FacilityBookingViewModel : INotifyPropertyChanged
    {
        public BindingList<FixedTimeBooking> Slots { get; private set; }
        public IBookingService BookingService { get; private set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public FacilityType FacilityType { get; set; }


        public FacilityBookingViewModel(IBookingService bookingService)
        {
            BookingService = RequireArg.NotNull(bookingService);

            // TODO: Parametrize
            FacilityType = FacilityType.TennisCourt;

            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            Slots = GetFixedTimeBookings(BookingService.GetBookingSlots(From, To, FacilityType));
        }

        private BindingList<FixedTimeBooking> GetFixedTimeBookings(IEnumerable<BookingSlot> iEnumerable)
        {
            return new[] 
            {
                new FixedTimeBooking { Period = "10am", Address = "143 #12-08", BookedBy = "Tom", FacilityCard = "1234", ResidentName = "Konstantin Spirin" },
                new FixedTimeBooking { Period = "11am", Address = "143 #15-03", BookedBy = "Jerry", FacilityCard = "54", ResidentName = "Nick Ward" },
                new FixedTimeBooking { Period = "12pm", Address = "145 #6-08", BookedBy = "Tom", FacilityCard = "127", ResidentName = "Niau Chin Chuan" },
            }.ToBindingList();
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
