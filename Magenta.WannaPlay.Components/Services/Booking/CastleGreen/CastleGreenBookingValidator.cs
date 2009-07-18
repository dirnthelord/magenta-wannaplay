using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.Services.Booking.CastleGreen
{
    /// <summary>
    /// Adds Castle Green validation rules:
    /// - 1 hour per day per unit
    /// - more?
    /// </summary>
    public class CastleGreenBookingValidator : GenericBookingValidator
    {
        public override void Validate(BookingSlot bookingSlot)
        {
        }
    }
}