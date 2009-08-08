using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Domain;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Services.Residence;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class ResidentUI : ViewModelBase
    {
        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }

        [Browsable(false)]
        public Resident Underlying { get; set; }

        public ResidentUI(IResidenceManager residenceManager)
        {
            ResidenceManager = RequireArg.NotNull(residenceManager);
        }

        public string FactilityCardNumber
        {
            get { return Underlying.PassCardNumber; }
            set { Underlying.PassCardNumber = value; OnPropertyChanged("FactilityCardNumber"); }
        }

        public string Name
        {
            get { return Underlying.Name; }
            set { Underlying.Name = value; OnPropertyChanged("Name"); }
        }

        public string AddressBlockNumber
        {
            get { return Underlying.Unit.Block; }
            set { Underlying.Unit.Block = value; OnPropertyChanged("AddressBlockNumber"); }
        }

        public string AddressUnitNumber
        {
            get { return Underlying.Unit.Number; }
            set { Underlying.Unit.Number = value; OnPropertyChanged("AddressUnitNumber"); }
        }

        public void AutoFill()
        {
            var resident = ResidenceManager.GetResident(FactilityCardNumber);

            if (resident == null)
                return;

            var unit = resident.Unit;

            if (unit != null)
            {
                AddressBlockNumber = unit.Block;
                AddressUnitNumber = unit.Number;
            }

            Underlying.Name = resident.Name;
        }

        #region Read only
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
        #endregion
    }
}
