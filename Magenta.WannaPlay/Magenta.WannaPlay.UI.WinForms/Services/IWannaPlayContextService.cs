using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface IWannaPlayContextService
    {
        DutyGuard CurrentGuard { get; set; }
        event Action CurrentGuardChanged;

        DateTime SelectedDay { get; set; }
        event Action SelectedDayChanged;
    }
}
