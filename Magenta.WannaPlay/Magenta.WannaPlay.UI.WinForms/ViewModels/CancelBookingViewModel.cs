using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingViewModel
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        public BookingSearchViewModel BookingSearch { get; private set; }

        public IEnumerable<BookingEntryUI> SelectedBookings { get; set; }


        public CancelBookingViewModel(IKernel kernel)
        {
            Kernel = RequireArg.NotNull(kernel);
            BookingSearch = Kernel.Get<BookingSearchViewModel>();
        }

        public void CancelSelectedBookings()
        {
            throw new NotImplementedException();
        }
    }
}
