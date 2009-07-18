using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingService
    {
        BookingDay GetBookingDay(DateTime date);

        void SaveBookingDay(BookingDay bookingDay);
    }
}
