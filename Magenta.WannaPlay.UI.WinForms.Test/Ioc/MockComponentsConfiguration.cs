using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Core;
using Magenta.WannaPlay.Ioc;
using Magenta.WannaPlay.Services.Booking;
using Ninject.Core.Behavior;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Services;

namespace Magenta.WannaPlay.UI.WinForms.Ioc
{
    public class MockComponentsConfiguration : StandardModule
    {
        public override void Load()
        {
            Bind<IBookingService>().To<MockBookingService>().Using<SingletonBehavior>();
            Bind<IResidenceManager>().To<MockResidenceManager>().Using<SingletonBehavior>();
        }
    }
}
