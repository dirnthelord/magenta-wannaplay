using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.UI.WinForms.Services;
using Ninject.Core;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.Services.Booking;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.AddBooking
{
    [TestFixture]
    public class AddBookingControllerTests
    {
        [Test]
        public void CancelAdd_finishes_dialog_test()
        {
            var isDialogFinished = false;
            var controller = new AddBookingController();
            controller.DialogFinished += delegate { isDialogFinished = true; };

            controller.CancelAdd();
            isDialogFinished.AssertIsTrue();
        }

        [Test]
        public void AddBooking_finishes_dialog_test()
        {
            var isDialogFinished = false;
            var controller = new AddBookingController();
            controller.DialogFinished += delegate { isDialogFinished = true; };

            controller.AddBooking(null);
            isDialogFinished.AssertIsTrue();
        }
    }
}
