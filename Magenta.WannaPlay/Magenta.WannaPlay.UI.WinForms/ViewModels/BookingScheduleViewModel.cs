using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Magenta.WannaPlay.Domain;
using Magenta.WannaPlay.Services.Booking;
using Magenta.Shared.DesignByContract;
using Magenta.Shared;
using Magenta.WannaPlay.UI.WinForms.Properties;
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
        [Browsable(false)]
        [Inject]
        public IKernel Kernel { get; set; }

        [Browsable(false)]
        public IWannaPlayContextService WannaPlayContextService { get; private set; }

        [Browsable(false)]
        public IBookingService BookingService { get; private set; }
        
        [Browsable(false)]
        public IBookingScheduleService BookingScheduleService { get; private set; }
        
        [Browsable(false)]
        public IResidenceManager ResidenceManager { get; private set; }
        
        [Browsable(false)]
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
            // TODO: Remove UI depencency
            var bookingSearchView = Kernel.Get<BookingSearchControl>();
            bookingSearchView.ViewModel = Kernel.Get<BookingSearchViewModel>();

            var form = ControlHoster.HostInForm(null, "Find booking", bookingSearchView);

            form.ShowDialog();

            UpdateBookingData();
        }

        public void AddSelectedBooking()
        {
            var firstSlot = SelectedBookingSlots.OrderBy(s => s.Period.From).First();
            var slots = SelectedBookingSlots.Where(s => s.Facility == firstSlot.Facility);

            var length = slots.Count();
            var period = DateTimePeriod.FromHours(firstSlot.Period.From, length);

            
            // TODO: Remove UI dependency from this ViewModel
            var addBookingViewModel = Kernel.Get<AddBookingViewModel>();

            addBookingViewModel.BookingEntryViewModel.BookingPeriod.Model = period;
            addBookingViewModel.BookingEntryViewModel.Facility = firstSlot.Facility;


            var bookingEntryView = Kernel.Get<BookingEntryEditorControl>();

            bookingEntryView.ViewModel = addBookingViewModel.BookingEntryViewModel;


            var form = ControlHoster.HostInDialog(new DialogDescription
            {
                Parent = CommonUIService.MainForm,
                Title = "Add booking",
                Content = bookingEntryView,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Add", OnClick = () => addBookingViewModel.SaveBooking() },
                    new DialogButtonDescription { Text = "Cancel", IsCancelButton = true }     
                },
                Icon = Resources.AddBookingEntry
            });

            form.DataBindings.Add("Text", addBookingViewModel, "BookingTitle");

            form.ShowDialog();

            UpdateBookingData();
        }
    }
}
