using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Services.Booking.CastleGreen;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Ninject.Core;
using Ninject.Core.Behavior;

namespace Magenta.WannaPlay.UI.WinForms.Ioc
{
    public class UIConfiguration : StandardModule
    {
        public override void Load()
        {
            Bind<WannaPlayMainControl>().ToSelf().Using<TransientBehavior>();
        }
    }
}