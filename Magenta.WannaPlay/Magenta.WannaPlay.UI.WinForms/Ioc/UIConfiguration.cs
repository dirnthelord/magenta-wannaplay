using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.WannaPlay.UI.WinForms.Diagnostics;
using Ninject.Core;
using Ninject.Core.Behavior;
using Magenta.WannaPlay.UI.WinForms.Services;

namespace Magenta.WannaPlay.UI.WinForms.Ioc
{
    public class UIConfiguration : StandardModule
    {
        public override void Load()
        {
            Bind<ApplicationInfo>().ToConstant(new ApplicationInfo
                                                        {
                                                            Name = "Wanna Play",
                                                            SupportEMailAddress = "support@magenta.com"
                                                        });

            Bind<IExceptionNotifier>().To<EmailExceptionNotifier>().Using<SingletonBehavior>();
            Bind<ExceptionMessageBox>().ToSelf().Using<SingletonBehavior>();
            Bind<ExceptionManager>().ToSelf().Using<SingletonBehavior>();

            Bind<ICommonUIService>().To<CommonUIService>().Using<SingletonBehavior>();
            Bind<IBookingScheduleService>().To<BookingScheduleService>().Using<SingletonBehavior>();
            Bind<IWannaPlayContextService>().To<WannaPlayContextService>().Using<SingletonBehavior>();
            Bind<IWorkflowManager>().To<WorkflowManager>().Using<SingletonBehavior>();
        }
    }
}