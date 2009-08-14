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

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    public abstract class ResidentViewModel : INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;

        public abstract string Name { get; set; }
        public abstract string PassCardNumber { get; set; }
        public abstract string AddressBlockNumber { get; set; }
        public abstract string AddressUnitNumber { get; set; }
    }
}
