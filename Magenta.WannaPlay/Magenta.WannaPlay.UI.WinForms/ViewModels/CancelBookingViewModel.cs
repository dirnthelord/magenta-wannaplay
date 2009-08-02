using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingViewModel
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        public BookingSearchViewModel BookingSearch { get; private set; }


        public CancelBookingViewModel()
        {
            BookingSearch = Kernel.Get<BookingSearchViewModel>();
        }
    }
}
