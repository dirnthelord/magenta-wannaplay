using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class WannaPlayMainViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IKernel Kernel { get; private set; }

        [Browsable(false)]
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        [Browsable(false)]
        public ICommonUIService CommonUIService { get; private set; }


        public DutyGuard CurrentDutyGuard
        {
            get { return WannaPlayContextService.CurrentGuard; }
            set { WannaPlayContextService.CurrentGuard = value; }
        }

        public DateTime SelectedDay
        {
            get { return WannaPlayContextService.SelectedDay; }
            set { WannaPlayContextService.SelectedDay = value; }
        }


        public WannaPlayMainViewModel(IKernel kernel, IWannaPlayContextService wannaPlayContextService, ICommonUIService commonUIService)
        {
            Kernel = RequireArg.NotNull(kernel);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);
            CommonUIService = RequireArg.NotNull(commonUIService);

            WannaPlayContextService.CurrentGuardChanged += () => OnPropertyChanged("CurrentDutyGuard");
            WannaPlayContextService.SelectedDayChanged += () => OnPropertyChanged("SelectedDay");
        }

        public BookingScheduleViewModel CreateScheduleViewModel(FacilityType facilityType)
        {
            var scheduleViewModel = Kernel.Get<BookingScheduleViewModel>();

            scheduleViewModel.FacilityFilter = f => f.FacilityType == facilityType;

            return scheduleViewModel;
        }

        public void ChangeDutyGuard()
        {
            CommonUIService.ChangeDutyGuard();
        }
    }
}
