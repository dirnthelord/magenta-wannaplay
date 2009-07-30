using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class WannaPlayMainViewModel : ViewModelBase
    {
        public DateTime SelectedDay { get; set; }

        public IKernel Kernel { get; private set; }
        public IWannaPlayContextService WannaPlayContextService { get; private set; }
        public ICommonUIService CommonUIService { get; private set; }

        public BookingScheduleViewModel TennisSchedule { get; private set; }
        public BookingScheduleViewModel SquashSchedule { get; private set; }

        public DutyGuard CurrentDutyGuard
        {
            get { return WannaPlayContextService.CurrentGuard; }
        }

        public WannaPlayMainViewModel(IKernel kernel, IWannaPlayContextService wannaPlayContextService, ICommonUIService commonUIService)
        {
            Kernel = RequireArg.NotNull(kernel);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);
            CommonUIService = RequireArg.NotNull(commonUIService);

            WannaPlayContextService.CurrentGuardChanged += () => OnPropertyChanged("CurrentDutyGuard");

            SelectedDay = DateTime.Today;

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

        public void MainFormLoaded()
        {
            CommonUIService.AskToSelectCurrentDutyGuard();
        }

        public void AskToSelectCurrentDutyGuard()
        {
            CommonUIService.AskToSelectCurrentDutyGuard();
        }
    }
}
