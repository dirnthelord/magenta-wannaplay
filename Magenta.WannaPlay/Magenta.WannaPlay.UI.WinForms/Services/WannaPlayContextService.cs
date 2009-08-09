using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Residence;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class WannaPlayContextService : IWannaPlayContextService
    {
        private readonly IResidenceManager _residenceManager;

        #region CurrentGuard
        DutyGuard _currentGuard;

        public DutyGuard CurrentGuard
        {
            get { return _currentGuard; }
            set
            {
                _currentGuard = value;
                _currentGuard.LoggedLastTime = DateTime.UtcNow;
                _residenceManager.SaveDutyGuard(_currentGuard);

                OnCurrentGuardChanged();
            }
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

        public WannaPlayContextService(IResidenceManager residenceManager)
        {
            _residenceManager = residenceManager;

            SelectedDay = DateTime.Today;

            var guards = residenceManager.GetDutyGuards();
            if (guards.Count() > 0)
                CurrentGuard = guards.OrderByDescending(x => x.LoggedLastTime).First();
        }
    }
}
