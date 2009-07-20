using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingValidator
    {
        void Validate(BookingEntry bookingEntry);
    }
}