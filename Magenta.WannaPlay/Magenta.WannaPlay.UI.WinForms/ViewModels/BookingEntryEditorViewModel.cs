using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Ninject.Core;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;
using Magenta.Shared.UI.WinForms.Mvvm;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingEntryEditorViewModel : ViewModelBase
    {
        public IKernel Kernel { get; private set; }

        public BookingEntryEditorViewModel(IKernel kernel)
        {
            Kernel = RequireArg.NotNull(kernel);
        }

        BookingEntry _underlying;
        public BookingEntry Underlying
        {
            get { return _underlying; }
            set { _underlying = value; OnUnderlyingChanged(); }
        }

        ResidentEditorViewModel _resident;
        public ResidentEditorViewModel Resident
        {
            get { return _resident; }
            private set { _resident = value; OnPropertyChanged("Resident"); }
        }

        public Facility Facility
        {
            get { return Underlying.Facility; }
        }

        public DateTimePeriod Period
        {
            get { return Underlying.Period; }
        }

        public string Remarks
        {
            get { return Underlying.Remarks; }
        }

        private void OnUnderlyingChanged()
        {
            OnResidentChanged();
        }

        private void OnResidentChanged()
        {
            var residentViewModel = Kernel.Get<ResidentEditorViewModel>();
            residentViewModel.Underlying = Underlying.Resident;

            Resident = residentViewModel;
        }
    }
}
