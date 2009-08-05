using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.Domain;
using System.ComponentModel;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }

        bool _isReadOnly;
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                Resident.IsReadOnly = value;

                _isReadOnly = value;
                OnPropertyChanged("IsReadOnly");
            }
        }

        public Facility Facility { get; set; }
        public DateTimePeriodUI BookingPeriod { get; set; }
        public ResidentUI Resident { get; set; }
        public string Comment { get; set; }

        public BookingEntryViewModel(IResidenceManager residenceManager)
        {
            ResidenceManager = RequireArg.NotNull(residenceManager);

            BookingPeriod = new DateTimePeriodUI();
            Resident = new ResidentUI(new Resident());
        }

        public void ResidentAutoFillRequired()
        {
            var resident = ResidenceManager.GetResident(Resident.FactilityCardNumber);

            if (resident == null)
                return;

            var unit = resident.Unit;

            if (unit != null)
            {
                Resident.AddressBlockNumber = unit.Block;
                Resident.AddressUnitNumber = unit.Number;
            }

            Resident.Name = resident.Name;
        }
    }
}
