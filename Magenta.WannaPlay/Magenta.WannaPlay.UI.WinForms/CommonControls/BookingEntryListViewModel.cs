using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public abstract class BookingEntryListViewModel : INotifyPropertyChanged
    {
        public abstract BindingList<BookingEntry> Bookings { get; protected set; }
        public abstract BookingEntry SelectedBooking { get; set; }

        public BookingEntryListViewModel()
        {
            Bookings = new BindingList<BookingEntry>();
        }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
