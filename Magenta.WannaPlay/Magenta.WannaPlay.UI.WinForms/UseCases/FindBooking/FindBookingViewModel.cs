using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.UI.WinForms.Mvvm;
using System.ComponentModel;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.UI.WinForms.ViewModels;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public abstract class FindBookingViewModel : ViewModelBase
    {
        public BookingSearchRequestViewModel BookingSearchRequest { get; private set; }
        public BookingEntryListViewModel SearchResults { get; private set; }


        public FindBookingViewModel()
        {
            BookingSearchRequest = new BookingSearchRequestViewModel();
            SearchResults = new BookingEntryListViewModel();
        }
    }
}
