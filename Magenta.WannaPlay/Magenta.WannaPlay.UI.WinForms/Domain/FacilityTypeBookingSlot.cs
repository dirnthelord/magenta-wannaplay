using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Domain
{
    public class FacilityTypeBookingSlot : CustomTypeDescriptor
    {
        [Browsable(false)]
        public virtual DateTimePeriod Period { get { return Booking.Period; } }

        public virtual bool IsEmpty { get { return false; } }

        [Browsable(false)]
        public BookingEntry Booking { get; private set; }

        public FacilityTypeBookingSlot(BookingEntry booking)
        {
            Booking = RequireArg.NotNull(booking);
        }

        protected FacilityTypeBookingSlot()
        {
        }

        public override PropertyDescriptorCollection GetProperties()
        {
            return new PropertyDescriptorCollection(Properties.ToArray());
        }

        PropertyDescriptorCollection BaseProperties()
        {
            return base.GetProperties();
        }

        IEnumerable<PropertyDescriptor> Properties
        {
            get
            {
                foreach (var property in BaseProperties().Cast<PropertyDescriptor>())
                    yield return property;

                yield return new GenericPropertyDescriptor<FacilityBookingSlot>("Tennis Court 1", null);
            }
        }

        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return base.GetProperties(attributes);
        }
    }
}
