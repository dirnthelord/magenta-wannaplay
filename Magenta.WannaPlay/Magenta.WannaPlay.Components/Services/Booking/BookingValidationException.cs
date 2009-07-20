using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Exceptions;

namespace Magenta.WannaPlay.Services.Booking
{
    public class BookingValidationException : UserFriendlyException
    {
        public BookingValidationException(string message)
            : base(message)
        {
        }
    }
}
