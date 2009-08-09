using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Residence;
using System.ComponentModel;
using Magenta.Shared.DesignByContract;
using Magenta.Shared.UI.WinForms.Mvvm;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class ResidentEditorViewModel : ViewModelBase
    {
        [Browsable(false)]
        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Browsable(false)]
        [Inject]
        public IKernel Kernel { get; set; }

        Resident _underlying;
        public Resident Underlying
        {
            get { return _underlying; }
            set { _underlying = value; OnUnderlyingChanged(); }
        }

        private void OnUnderlyingChanged()
        {
            var unitViewModel = Kernel.Get<ResidenceUnitViewModel>();
            unitViewModel.Underlying = Underlying.Unit;

            Unit = unitViewModel;
        }

        public string Name
        {
            get { return Underlying.Name; }
            private set { Underlying.Name = value; OnPropertyChanged("Name"); }
        }

        public string PassCardNumber
        {
            get { return Underlying.PassCardNumber; }
            set { Underlying.PassCardNumber = value; OnPropertyChanged("PassCardNumber"); }
        }

        ResidenceUnitViewModel _unit;
        public ResidenceUnitViewModel Unit
        {
            get { return _unit; }
            private set { _unit = value; OnPropertyChanged("Unit"); }
        }

        public void AutoFill()
        {
            var existing = ResidenceManager.GetResident(PassCardNumber);

            if (existing == null)
                return;

            Name = existing.Name;
            PassCardNumber = existing.PassCardNumber;
            Unit.Block = existing.Unit.Block;
            Unit.Number = existing.Unit.Number;
        }
    }
}
