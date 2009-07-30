using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Ninject.Core;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Services;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class CurrentDutyGuardViewModel
    {
        public IResidenceManager ResidenceManager { get; private set; }
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        public DutyGuard SelectedDutyGuard { get; set; }
        public BindingList<DutyGuard> AllGuards { get; private set; }

        public CurrentDutyGuardViewModel(IResidenceManager residenceManager, IWannaPlayContextService wannaPlayContextService)
        {
            ResidenceManager = RequireArg.NotNull(residenceManager);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);

            AllGuards = new BindingList<DutyGuard>();

            AllGuards.ReplaceWith(ResidenceManager.GetDutyGuards());
            SelectedDutyGuard = WannaPlayContextService.CurrentGuard;
        }

        public void AcceptSelectedDutyGuard()
        {
            WannaPlayContextService.CurrentGuard = SelectedDutyGuard;
        }
    }
}
