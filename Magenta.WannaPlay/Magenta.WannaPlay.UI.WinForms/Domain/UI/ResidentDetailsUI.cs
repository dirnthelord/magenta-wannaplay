using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.Domain.UI
{
    public class ResidentDetailsUI : INotifyPropertyChanged
    {
        string _factilityCardNumber;
        string _name;
        string _addressBlockNumber;
        string _addressUnitNumber;

        public string FactilityCardNumber
        {
            get { return _factilityCardNumber; }
            set { _factilityCardNumber = value; OnPropertyChanged("FactilityCardNumber"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        public string AddressBlockNumber
        {
            get { return _addressBlockNumber; }
            set { _addressBlockNumber = value; OnPropertyChanged("AddressBlockNumber"); }
        }

        public string AddressUnitNumber
        {
            get { return _addressUnitNumber; }
            set { _addressUnitNumber = value; OnPropertyChanged("AddressUnitNumber"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
