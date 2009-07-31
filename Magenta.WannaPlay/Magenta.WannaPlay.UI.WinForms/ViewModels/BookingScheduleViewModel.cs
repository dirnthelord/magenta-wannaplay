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
using Magenta.Shared.UI.WinForms;

namespace Magenta.WannaPlay.UI.WinForms.ViewModels
{
    public class BookingScheduleViewModel : ViewModelBase
    {
        [Inject]
        public IKernel Kernel { get; set; }

        public IWannaPlayContextService WannaPlayContextService { get; private set; }
        public IBookingService BookingService { get; private set; }
        public IBookingScheduleService BookingScheduleService { get; private set; }
        public IResidenceManager ResidenceManager { get; private set; }
        public ICommonUIService CommonUIService { get; private set; }

        public BindingList<BookingPeriodUI> BookingPeriods { get; private set; }
        public BindingList<BookingEntry> BookingEntries { get; private set; }
        public BindingList<Facility> Facilities { get; private set; }


        Func<Facility, bool> _facilityFilter;
        public Func<Facility, bool> FacilityFilter
        {
            get { return _facilityFilter; }
            set { _facilityFilter = value; OnFacilityFilterChanged(); }
        }

        void OnFacilityFilterChanged()
        {
            UpdateFaciltyList();
            UpdateBookingData();
        }

        
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

        IEnumerable<BookingEntry> SelectedBookingEntries
        {
            get { return GetBookingEntries(SelectedBookingSlots); }
        }

        public bool CanAddBooking
        {
            get
            {
                if (SelectedBookingSlots == null || !SelectedBookingSlots.Any())
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


        #region Booking period
        TimeSpan StartHour { get { return TimeSpan.FromHours(7); } }
        TimeSpan FinishHour { get { return TimeSpan.FromHours(22); } }

        DateTime BookingDay
        {
            get { return WannaPlayContextService.SelectedDay; }
        }

        DateTimePeriod Period
        {
            get { return new DateTimePeriod(BookingDay.Add(StartHour), BookingDay.Add(FinishHour)); }
        }
        #endregion


        public BookingScheduleViewModel
            (
                IBookingService bookingService,
                IBookingScheduleService bookingScheduleService,
                IResidenceManager residenceManager,
                IWannaPlayContextService wannaPlayContextService,
                ICommonUIService commonUIService
            )
        {
            BookingService = RequireArg.NotNull(bookingService);
            BookingScheduleService = RequireArg.NotNull(bookingScheduleService);
            ResidenceManager = RequireArg.NotNull(residenceManager);
            WannaPlayContextService = RequireArg.NotNull(wannaPlayContextService);
            CommonUIService = RequireArg.NotNull(commonUIService);

            // TODO: Should be weak event subscription
            WannaPlayContextService.SelectedDayChanged += OnSelectedDayChanged;

            Facilities = new BindingList<Facility>();
            BookingEntries = new BindingList<BookingEntry>();
            BookingPeriods = new BindingList<BookingPeriodUI>();
        }

        void OnSelectedDayChanged()
        {
            UpdateBookingData();
        }

        private void UpdateBookingData()
        {
            BookingEntries.ReplaceWith(BookingService.GetBookingEntries(Period, Facilities));
            BookingPeriods.ReplaceWith(BookingScheduleService.GetSchedule(Period).Select(p => new BookingPeriodUI(p)));
        }

        private void UpdateFaciltyList()
        {
            Facilities.ReplaceWith(ResidenceManager.GetFacilities().Where(FacilityFilter));
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

            // TODO: Remove hardcoded max number of hours to book
            var length = Math.Min(2, SelectedBookingSlots.Count());

            // TODO: Remove UI dependency from this ViewModel
            var addBookingViewModel = Kernel.Get<AddBookingViewModel>();
            var bookingEntryView = Kernel.Get<BookingEntryEditorControl>();

            bookingEntryView.ViewModel = addBookingViewModel.BookingEntryViewModel;

            bookingEntryView.ViewModel.BookingPeriod = new DateTimePeriodUI
            {
                Model = DateTimePeriod.FromHours(firstSlot.Period.From, length),
            };

            var form = ControlHoster.HostInDialog(CommonUIService.MainForm, "Add booking", bookingEntryView,
                new DialogButtonDescription { Text = "Add", OnClick = () => addBookingViewModel.AddBooking() },
                new DialogButtonDescription { Text = "Cancel", IsCancelButton = true }
                );

            form.ShowDialog();
        }
    }
}
