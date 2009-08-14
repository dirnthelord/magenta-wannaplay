using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Controls;
using System.Windows.Forms;
using Magenta.WannaPlay.Domain;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface ICommonUIService
    {
        Form MainForm { get; set; }

        void ChangeDutyGuard();
        void FindBooking();
        void ConfirmCancelBooking(BookingEntry booking);
        void AddBooking(Facility facility, DateTimePeriod period);
    }
}
