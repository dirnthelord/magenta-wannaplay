using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Services;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.WannaPlay.Services.Residence;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.Shared.UI.WinForms.Mvvm;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Controls;
using Magenta.Shared.Ui.WinForms;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingScheduleViewModel : ViewModelBase
    {
        [Inject]
        public IKernel Kernel { get; set; }

        public IBookingService BookingService { get; private set; }
        public IBookingScheduleService BookingScheduleService { get; private set; }
        public IResidenceManager ResidenceManager { get; private set; }

        public BindingList<BookingPeriodUI> BookingPeriods { get; private set; }
        public BindingList<BookingEntry> BookingEntries { get; private set; }
        public BindingList<Facility> Facilities { get; private set; }

        IEnumerable<BookingSlot> _selectedBookingSlots;
        public IEnumerable<BookingSlot> SelectedBookingSlots
        {
            get { return _selectedBookingSlots; }
            set { _selectedBookingSlots = value; OnSelectedBookingSlotsChanged(); }
        }

        private void OnSelectedBookingSlotsChanged()
        {
            OnPropertyChanged("SelectedBookingSlots");
            OnPropertyChanged("SelectedBookingEntries");
            OnPropertyChanged("CanAddBooking");
            OnPropertyChanged("CanCancelBooking");
        }

        #region Booking period
        public DateTime _day;
        public DateTime Day
        {
            get { return _day.Date; }
            set { _day = value; OnDayChanged(); }
        }

        TimeSpan StartHour { get { return TimeSpan.FromHours(7); } }
        TimeSpan FinishHour { get { return TimeSpan.FromHours(22); } }

        private void OnDayChanged()
        {
            Period = new DateTimePeriod(Day.Add(StartHour), Day.Add(FinishHour));
        }

        public DateTimePeriod _period;
        public DateTimePeriod Period
        {
            get { return _period; }
            private set { _period = value; OnPeriodChanged(); }
        }

        void OnPeriodChanged()
        {
            InitializeDataContext();
            OnPropertyChanged("Period");
        }
        #endregion


        IEnumerable<BookingEntry> SelectedBookingEntries
        {
            get { return GetBookingEntries(SelectedBookingSlots); }
        }

        public bool CanAddBooking
        {
            get
            {
                if (SelectedBookingSlots == null)
                    return false;

                var firstSlot = SelectedBookingSlots.OrderBy(s => s.Period.From).First();

                var allForTheSameFacility = SelectedBookingSlots.All(s => s.Facility == firstSlot.Facility);
                var allEmpty = !SelectedBookingEntries.Any();

                return allEmpty && allForTheSameFacility;
            }
        }

        public bool CanCancelBooking
        {
            get { return SelectedBookingEntries.Any(); }
        }


        public BookingScheduleViewModel(IBookingService bookingService,
            IBookingScheduleService bookingScheduleService,
            IResidenceManager residenceManager)
        {
            BookingService = RequireArg.NotNull(bookingService);
            BookingScheduleService = RequireArg.NotNull(bookingScheduleService);
            ResidenceManager = RequireArg.NotNull(residenceManager);

            Facilities = new BindingList<Facility>();
            BookingEntries = new BindingList<BookingEntry>();
            BookingPeriods = new BindingList<BookingPeriodUI>();

            Day = DateTime.UtcNow.Date;
        }

        private void InitializeDataContext()
        {
            Facilities.ReplaceWith(ResidenceManager.GetFacilities());
            BookingEntries.ReplaceWith(BookingService.GetBookingEntries(Period, Facilities));
            BookingPeriods.ReplaceWith(BookingScheduleService.GetSchedule(Period).Select(p => new BookingPeriodUI(p)));
        }

        public IEnumerable<BookingEntry> GetBookingEntries(IEnumerable<BookingSlot> slots)
        {
            if (slots == null)
                return Enumerable.Empty<BookingEntry>();

            return BookingEntries.Where(entry => slots.Any(slot =>
                slot.Facility == entry.Facility &&
                slot.Period.Intersect(entry.Period).GetTimeSpan().Ticks > 0));
        }

        public void CancelSelectedBooking()
        {
            throw new NotImplementedException();
        }

        public void AddSelectedBooking()
        {
            var firstSlot = SelectedBookingSlots.OrderBy(s => s.Period.From).First();
            var length = Math.Min(2, SelectedBookingSlots.Count());

            //throw new NotImplementedException();
            var addBookingView = Kernel.Get<BookingEntryEditorControl>();
            addBookingView.ViewModel.BookingPeriod = new DateTimePeriodUI
            {
                Model = DateTimePeriod.FromHours(firstSlot.Period.From, length),
            };

            var form = ControlHoster.HostInForm(null, "Add booking", addBookingView);
            form.ShowDialog();
        }
    }
}
