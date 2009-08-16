using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public abstract class BookingEntryListItem : INotifyPropertyChanged
    {
        public abstract string FacilityName { get; set; }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
