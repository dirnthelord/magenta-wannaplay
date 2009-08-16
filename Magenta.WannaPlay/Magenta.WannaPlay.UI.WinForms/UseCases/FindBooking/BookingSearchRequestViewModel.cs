using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public class BookingSearchRequestViewModel : ViewModelBase
    {
        string _addressBlockNumber;
        public string AddressBlockNumber
        {
            get { return _addressBlockNumber; }
            set { _addressBlockNumber = value; OnPropertyChanged("AddressBlockNumber"); }
        }

        string _addressUnitNumber;
        public string AddressUnitNumber
        {
            get { return _addressUnitNumber; }
            set { _addressUnitNumber = value; OnPropertyChanged("AddressUnitNumber"); }
        }

        string _residentFacilityCardNumber;
        public string ResidentFacilityCardNumber
        {
            get { return _residentFacilityCardNumber; }
            set { _residentFacilityCardNumber = value; OnPropertyChanged("ResidentFacilityCardNumber"); }
        }
    }
}
