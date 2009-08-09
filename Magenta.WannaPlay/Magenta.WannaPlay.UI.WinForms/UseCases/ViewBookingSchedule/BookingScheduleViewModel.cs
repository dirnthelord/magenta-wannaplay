using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
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
using Magenta.WannaPlay.UI.WinForms.Controls.Editors;

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


        public BindingList<DateTimePeriod> BookingPeriods { get; private set; }
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
            OnPropertyChanged("SelectedBookings");
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
            BookingPeriods = new BindingList<DateTimePeriod>();
        }

        void OnSelectedDayChanged()
        {
            UpdateBookingData();
        }

        private void UpdateBookingData()
        {
            BookingEntries.ReplaceWith(BookingService.GetBookingEntries(Period, Facilities));
            BookingPeriods.ReplaceWith(BookingScheduleService.GetSchedule(Period));
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

        public void CancelBookings()
        {
            // TODO: Remove UI depencency
            var bookingSearchView = Kernel.Get<CancelBookingsControl>();
            bookingSearchView.ViewModel = Kernel.Get<CancelBookingViewModel>();

            var form = ControlHoster.CreateForm(null, "Find booking", bookingSearchView);

            form.ShowDialog();

            UpdateBookingData();
        }

        public void AddBookingToSelected()
        {
            if (!CanAddBooking)
                return;

            var firstSlot = SelectedBookingSlots.OrderBy(s => s.Period.From).First();
            var slots = SelectedBookingSlots.Where(s => s.Facility == firstSlot.Facility);

            var length = slots.Count();
            var period = DateTimePeriod.FromHours(firstSlot.Period.From, length);


            // TODO: Remove UI dependency from this ViewModel
            var addBookingViewModel = Kernel.Get<AddBookingViewModel>();
            addBookingViewModel.Booking = new BookingEntry
            {
                Period = period,
                Facility = firstSlot.Facility,
                Resident = new Resident
                {
                    Unit = new ResidenceUnit { }
                }
            };

            var bookingEditor = Kernel.Get<BookingEntryEditor>();
            var bookingEditorViewModel = Kernel.Get<BookingEntryEditorViewModel>();
            bookingEditorViewModel.Underlying = addBookingViewModel.Booking;

            bookingEditor.ViewModel = bookingEditorViewModel;


            var form = ControlHoster.CreateDialog(new DialogDescription
            {
                Parent = CommonUIService.MainForm,
                Title = "Add booking",
                Content = bookingEditor,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "Add", OnClick = () => addBookingViewModel.SaveBooking() },
                    new DialogButtonDescription { Text = "Cancel", IsCancelButton = true }     
                },
                Icon = Resources.AddBooking.ToBitmap()
            });

            form.AddBinding(addBookingViewModel, f => f.Text, vm => vm.BookingTitle);

            form.ShowDialog();

            UpdateBookingData();
        }

        public bool IsSlotBooked(BookingSlot slot)
        {
            return GetBookingEntries(slot.ToEnumerable()).Any();
        }

        public BookingEntry GetBookingEntry(BookingSlot slot)
        {
            return GetBookingEntries(slot.ToEnumerable()).SingleOrDefault();
        }

        public string GetSlotToolTip(BookingSlot slot)
        {
            RequireArg.NotNull(slot);

            var entry = GetBookingEntry(slot);

            if (entry == null)
                return null;

            return string.Format("{0} (card {1})", entry.Resident.Name, entry.Resident.PassCardNumber);
        }
    }
}
