using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using Magenta.WannaPlay.UI.WinForms.Controls;

namespace Magenta.WannaPlay.UI.WinForms
{
    class TestWannaPlayApplication : WannaPlayApplication
    {
        public TestWannaPlayApplication()
            : base(new MockComponentsConfiguration())
        {
        }

        protected override Control GetMainControl()
        {
            //return base.GetMainControl();
            //return Kernel.Get<BookingScheduleDetailsControl>();
            //return Kernel.Get<BookingScheduleControl>();
            return Kernel.Get<AddBookingControl>();
            //return Kernel.Get<BookingPeriodControl>();
            //return Kernel.Get<ResidentDetailsControl>();
        }
    }
}
