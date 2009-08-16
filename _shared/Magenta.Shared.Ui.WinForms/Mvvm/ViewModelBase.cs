using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Magenta.Shared.UI.WinForms.Mvvm
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            var handler = PropertyChanged;

            if (handler != null)
               propertyNames.ForEach(propertyName =>  handler(this, new PropertyChangedEventArgs(propertyName)));
        }
    }
}
