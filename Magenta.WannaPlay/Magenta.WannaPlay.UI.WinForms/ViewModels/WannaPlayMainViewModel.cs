using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class WannaPlayMainViewModel
    {
        public DateTime SelectedDay { get; set; }

        public IKernel Kernel { get; private set; }

        public BookingScheduleViewModel TennisSchedule { get; private set; }
        public BookingScheduleViewModel SquashSchedule { get; private set; }

        public WannaPlayMainViewModel(IKernel kernel)
        {
            SelectedDay = DateTime.Today;

            Kernel = kernel;

            TennisSchedule = CreateScheduleViewModel(FacilityType.TennisCourt);
            SquashSchedule = CreateScheduleViewModel(FacilityType.SquashCourt);
        }

        BookingScheduleViewModel CreateScheduleViewModel(FacilityType facilityType)
        {
            var scheduleViewModel = Kernel.Get<BookingScheduleViewModel>();

            scheduleViewModel.FacilityFilter = f => f.FacilityType == facilityType;
            scheduleViewModel.Day = SelectedDay;

            return scheduleViewModel;
        }
    }
}
