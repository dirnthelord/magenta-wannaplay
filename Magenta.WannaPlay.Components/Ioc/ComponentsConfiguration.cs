using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.Infrastructure.NHibernate;
using Magenta.WannaPlay.Infrastructure.Persistence;
using Magenta.WannaPlay.Services.Booking;
using Magenta.WannaPlay.Services.Booking.CastleGreen;
using Magenta.WannaPlay.Services.Residence;
using NHibernate;
using Ninject.Core;
using Ninject.Core.Behavior;

namespace Magenta.WannaPlay.Ioc
{
    public class ComponentsConfiguration : StandardModule
    {
        public override void Load()
        {
            // Infrustructure services
            Bind<ISession>().ToProvider<SessionProvider>();
            Bind<IPersistenceRepository>().To<PersistenceRepository>().Using<SingletonBehavior>();

            // Business services
            Bind<IResidenceManager>().To<ResidenceManager>().Using<SingletonBehavior>();
            Bind<IBookingValidator>().To<CastleGreenBookingValidator>().Using<SingletonBehavior>();
            Bind<IBookingService>().To<BookingService>().Using<SingletonBehavior>();
        }
    }
}
