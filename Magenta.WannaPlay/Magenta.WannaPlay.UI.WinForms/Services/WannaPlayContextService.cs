using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public class WannaPlayContextService : IWannaPlayContextService
    {
        public DutyGuard CurrentGuard
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime SelectedBookingDay
        {
            get { return DateTime.Today; }
        }
    }
}
