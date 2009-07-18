using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking
{
    /// <summary>
    /// Generic validation rules
    /// - slot is filled correctly
    /// - check for time collisions
    /// </summary>
    public class GenericBookingValidator : IBookingValidator
    {
        #region IBookingValidator Members

        public virtual void Validate(BookingSlot bookingSlot)
        {

        }

        #endregion
    }
}