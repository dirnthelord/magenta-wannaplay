using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.Validation;
using Magenta.WannaPlay.Services.Booking.Validation;
using Ninject.Core;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingValidationService : IBookingValidationService
    {
        readonly BookingValidationRules Rules;

        public BookingValidationService(IKernel kernel)
        {
            Rules = kernel.Get<BookingValidationRules>();
        }

        public ValidationResults ValidateBookingToAdd(BookingEntry booking)
        {
            return new ValidationResults(Rules.Validate(booking));
        }
    }
}
