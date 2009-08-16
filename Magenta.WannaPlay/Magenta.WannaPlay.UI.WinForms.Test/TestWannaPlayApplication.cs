using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Ioc;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Ninject.Core;

namespace Magenta.WannaPlay.UI.WinForms
{
    /// <summary>
    /// TODO: Remove this type
    /// </summary>
    class TestWannaPlayApplication : WannaPlayApplication
    {
        public TestWannaPlayApplication(StandardKernel kernel)
            : base(kernel)
        {
        }

        protected override Control GetMainControl()
        {
            return base.GetMainControl();
            //return Kernel.Get<BookingScheduleDetailsControl>();
            //var main = Kernel.Get<BookingScheduleControl>();
            //return Kernel.Get<BookingPeriodControl>();
            //return Kernel.Get<ResidentDetailsControl>();

            //var main = Kernel.Get<DateTimePeriodControl>();
            //var from = DateTime.Now.Date.AddHours(9);

            //main.ViewModel = new DateTimePeriodUI 
            //{ 
            //    Underlying = new DateTimePeriod(from, from.AddHours(2))
            //};


            //var main = Kernel.Get<AddBookingControl>();

            //var from = DateTime.Now.Date.AddHours(9).AddDays(-4);

            //main.ViewModel.BookingPeriod = new DateTimePeriodUI
            //{
            //    Underlying = new DateTimePeriod(from, from.AddHours(2))
            //};

            //var main = Kernel.Get<BookingEntryListControl>();
            //var from = DateTime.Now.Date.AddHours(9).AddDays(-4);

            //main.ItemsSource = new[]
            //{
            //    new BookingEntry 
            //    { 
            //        Period = DateTimePeriod.FromHours(from, 2),
            //        BookedAtDateTime = DateTime.Now,
            //        Resident = new Resident
            //        {
            //            Name = "Nickolas",
            //            PassCardNumber = "9994",
            //            Unit = new ResidenceUnit { Block = "123", Number = "58-05" }
            //        },
            //        BookedByGuard = new DutyGuard { Name = "Benny" },
            //        Facility = new Facility { Name = "Squash Court Two" }
            //    },
            //    new BookingEntry 
            //    { 
            //        Period = DateTimePeriod.FromHours(from.AddHours(7), 1),
            //        BookedAtDateTime = DateTime.Now.AddHours(-45),
            //        Resident = new Resident
            //        {
            //            Name = "Postulkanis Vigulinfikus",
            //            PassCardNumber = "765",
            //            Unit = new ResidenceUnit { Block = "1287C", Number = "15-07" }
            //        },
            //        BookedByGuard = new DutyGuard { Name = "Thomas" },
            //        Facility = new Facility { Name = "Tennis Court Two" }
            //    },
            //    new BookingEntry 
            //    { 
            //        Period = DateTimePeriod.FromHours(from.AddHours(3), 2),
            //        BookedAtDateTime = DateTime.Now.AddMinutes(-23),
            //        Resident = new Resident
            //        {
            //            Name = "Miguel Sranchos",
            //            PassCardNumber = "2",
            //            Unit = new ResidenceUnit { Block = "65B", Number = "9-165" }
            //        },
            //        BookedByGuard = new DutyGuard { Name = "Thomas" },
            //        Facility = new Facility { Name = "Squash Court One" }
            //    },
            //}
            //.Select(e => new BookingEntryUI(e))
            //.ToBindingList();


            //return main;
        }
    }
}
