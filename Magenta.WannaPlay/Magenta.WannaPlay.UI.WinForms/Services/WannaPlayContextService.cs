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

        #region SelectedDay
        DateTime _selectedDay;
        public DateTime SelectedDay
        {
            get { return _selectedDay; }
            set { _selectedDay = value; OnSelectedDayChanged(); }
        }

        public event Action SelectedDayChanged;

        void OnSelectedDayChanged()
        {
            var handler = SelectedDayChanged;

            if (handler != null)
                handler();
        }
        #endregion

        public WannaPlayContextService()
        {
            SelectedDay = DateTime.Today;
        }
    }
}
