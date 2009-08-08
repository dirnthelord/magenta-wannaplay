using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryListViewModel
    {
        public BindingList<BookingEntry> Bookings { get; private set; }
        public bool AllowMultipleSelection { get; set; }
        public IEnumerable<BookingEntry> SelectedBookings { get; set; }

        public BookingEntryListViewModel(BindingList<BookingEntry> bookings)
        {
            Bookings = RequireArg.NotNull(bookings);
        }
    }
}
