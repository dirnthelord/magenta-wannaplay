using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.Aop;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using System.ComponentModel;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public class ResidentController
    {
        [Inject]
        public IResidenceManager ResidenceManager { get; set; }


        public ResidentViewModel ViewModel { get; private set; }


        public ResidentController()
        {
            ViewModel = ObjectFactory.Create<ResidentViewModel>();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == ExpressionHelper.GetPropertyName(ViewModel, vm => vm.PassCardNumber))
                AutoSuggestResident();
        }


        public void AutoSuggestResident()
        {
            var resident = ResidenceManager.GetResident(ViewModel.PassCardNumber);

            if (resident == null)
                return;

            ViewModel.AddressBlockNumber = resident.Unit.ValueOrDefault(u => u.Block);
            ViewModel.AddressUnitNumber = resident.Unit.ValueOrDefault(u => u.Number);
            ViewModel.Name = resident.Name;
        }
    }
}
