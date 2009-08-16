using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class BookingEntryViewModel : ViewModelBase
    {
        BookingEntry _booking;
        public virtual BookingEntry Booking
        {
            get { return _booking; }
            set { _booking = value; OnPropertyChanged("Booking"); }
        }
    }
}
