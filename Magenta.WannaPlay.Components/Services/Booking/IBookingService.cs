using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingService
    {
        BookingSlot GetBookingDay(DateTime date);

        void SaveBookingDay(BookingSlot bookingSlot);
    }
}
