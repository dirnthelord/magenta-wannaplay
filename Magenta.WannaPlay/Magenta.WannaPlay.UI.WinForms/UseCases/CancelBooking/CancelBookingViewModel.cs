using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.Shared.UI.WinForms;
using Magenta.WannaPlay.UI.WinForms.Properties;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.UI.WinForms.Controls.Editors;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CancelBookingViewModel : ViewModelBase
    {
        private readonly IWorkflowManager _workflowManager;

        public IKernel Kernel { get; private set; }

        public BookingSearchViewModel BookingSearch { get; private set; }


        public CancelBookingViewModel(IKernel kernel,
            IWorkflowManager workflowManager)
        {
            _workflowManager = workflowManager;
            Kernel = RequireArg.NotNull(kernel);

            BookingSearch = Kernel.Get<BookingSearchViewModel>();
        }

        public void CancelSelectedBookings()
        {
            var bookingsToCancel = BookingSearch.SearchResults.SelectedBookings.ToList();

            if (bookingsToCancel.Count == 0)
                return;

            _workflowManager.ProcessCancelBooking(bookingsToCancel.First());
            BookingSearch.DoSearch();
        }

    }
}
