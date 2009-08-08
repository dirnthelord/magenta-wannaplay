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
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryViewModel : ViewModelBase
    {
        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }

        [Browsable(false)]
        public IKernel Kernel { get; private set; }

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

        public BookingEntryViewModel(IResidenceManager residenceManager, IKernel kernel)
        {
            ResidenceManager = RequireArg.NotNull(residenceManager);
            Kernel = RequireArg.NotNull(kernel);

            Resident = Kernel.Get<ResidentUI>();
            Resident.Underlying = new Resident { Unit = new ResidenceUnit() };
            BookingPeriod = Kernel.Get<DateTimePeriodUI>();
        }
    }
}
