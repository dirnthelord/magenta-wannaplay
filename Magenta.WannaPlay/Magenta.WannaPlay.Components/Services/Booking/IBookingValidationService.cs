using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    public interface IBookingValidationService
    {
        ValidationResults ValidateBookingToAdd(BookingEntry booking);
    }
}
