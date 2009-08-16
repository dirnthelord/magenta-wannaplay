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

namespace Magenta.WannaPlay.UI.WinForms.CommonControls
{
    public class ResidentViewModel : ViewModelBase
    {
        Resident _resident;
        [ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Resident Resident
        {
            get { return _resident; }
            set { _resident = value; OnPropertyChanged("Resident"); }
        }

        string _autoSuggestResult;
        [ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AutoSuggestResult
        {
            get { return _autoSuggestResult; }
            set { _autoSuggestResult = value; OnPropertyChanged("AutoSuggestResult"); }
        }

        bool _isReadOnly;
        [DefaultValue(false)]
        public virtual bool IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; OnPropertyChanged("IsReadOnly"); }
        }
    }
}
