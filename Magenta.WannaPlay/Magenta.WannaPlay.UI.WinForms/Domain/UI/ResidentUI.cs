using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class ResidentUI : ViewModelBase
    {
        [Browsable(false)]
        public Resident Resident { get; private set; }

        public ResidentUI(Resident resident)
        {
            Resident = RequireArg.NotNull(resident);
        }

        public string FactilityCardNumber
        {
            get { return Resident.PassCardNumber; }
            set { Resident.PassCardNumber = value; OnPropertyChanged("FactilityCardNumber"); }
        }

        public string Name
        {
            get { return Resident.Name; }
            set { Resident.Name = value; OnPropertyChanged("Name"); }
        }

        public string AddressBlockNumber
        {
            get { return Resident.Unit.Block; }
            set { Resident.Unit.Block = value; OnPropertyChanged("AddressBlockNumber"); }
        }

        public string AddressUnitNumber
        {
            get { return Resident.Unit.Number; }
            set { Resident.Unit.Number = value; OnPropertyChanged("AddressUnitNumber"); }
        }

        bool _isReadOnly;

        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; OnPropertyChanged("IsReadOnly"); }
        }

        public bool IsWritable
        {
            get { return !IsReadOnly; }
            set { IsReadOnly = !value; OnPropertyChanged("IsWritable"); }
        }
    }
}
