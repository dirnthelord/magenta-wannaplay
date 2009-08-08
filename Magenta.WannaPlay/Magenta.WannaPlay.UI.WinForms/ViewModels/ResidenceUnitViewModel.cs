using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.Shared.UI.WinForms.Mvvm;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class ResidenceUnitViewModel : ViewModelBase
    {
        ResidenceUnit _underlying;
        public ResidenceUnit Underlying
        {
            get { return _underlying; }
            set { _underlying = value; OnUnderlyingChanged(); }
        }

        public string Block
        {
            get { return Underlying.Block; }
            set { Underlying.Block = value; OnPropertyChanged("Block"); }
        }

        public string Number
        {
            get { return Underlying.Number; }
            set { Underlying.Number = value; OnPropertyChanged("Number"); }
        }

        private void OnUnderlyingChanged()
        {
            // Raise OnPropertyChanged
            Block = Block;
            Number = Number;
        }
    }
}
