using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using System.ComponentModel;
using Magenta.Shared;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;
using System.Windows.Forms;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class ResidentController
    {
        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        public ResidentViewModel ViewModel { get; set; }


        public void AutoSuggestResident()
        {
            var resident = ResidenceManager.GetResident(ViewModel.Resident.PassCardNumber);

            ViewModel.AutoSuggestResult = resident != null ? "" : "first timer";

            if (resident == null)
                return;

            ViewModel.Resident.CopyFrom(resident);
        }
    }
}
