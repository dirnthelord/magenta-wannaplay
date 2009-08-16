using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryListViewModel : ViewModelBase
    {
        public BindingList<BookingEntry> Bookings { get; protected set; }
        
        BookingEntry _selectedBooking;
        public BookingEntry SelectedBooking
        {
            get { return _selectedBooking; }
            set { _selectedBooking = value; OnPropertyChanged("SelectedBooking"); }
        }


        public BookingEntryListViewModel()
        {
            Bookings = new BindingList<BookingEntry>();
        }
    }
}
