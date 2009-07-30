using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class WannaPlayContextService : IWannaPlayContextService
    {
        #region CurrentGuard
        DutyGuard _currentGuard;

        public DutyGuard CurrentGuard
        {
            get { return _currentGuard; }
            set { _currentGuard = value; OnCurrentGuardChanged(); }
        }

        public event Action CurrentGuardChanged;

        void OnCurrentGuardChanged()
        {
            var handler = CurrentGuardChanged;

            if (handler != null)
                handler();
        }
        #endregion

        public DateTime SelectedBookingDay
        {
            get { return DateTime.Today; }
            set { throw new NotImplementedException(); }
        }
    }
}
