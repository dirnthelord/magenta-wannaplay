using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            UpdateFacilityList();
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
            get
            {
                if (SelectedBookingSlots == null || SelectedBookingSlots.Count() != 1)
                    return false;

                return SelectedBookingEntries.Any();
            }
        }

        #region Booking slotPeriod

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

        private void UpdateFacilityList()
        {
            Facilities.ReplaceWith(ResidenceManager.GetFacilities().Where(FacilityFilter));
        }

        public IEnumerable<BookingEntry> GetBookingEntries(IEnumerable<BookingSlot> slots)
        {
            return slots
                .Where(s => s.Booking != null)
                .Select(s => s.Booking).Distinct();
        }

        public void FindBookings()
        {
            CommonUIService.FindBooking();
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

            CommonUIService.AddBooking(firstSlot.Facility, period);
            UpdateBookingData();
        }

        public void CancelSelectedBooking()
        {
            Debug.Assert(CanCancelBooking);

            CommonUIService.ConfirmCancelBooking(SelectedBookingEntries.First());

            UpdateBookingData();
        }

        public void AddOrCancelSelectedBooking()
        {
            if(CanAddBooking)
                AddBookingToSelected();
            else
            if(CanCancelBooking)
                CancelSelectedBooking();
        }

        //public bool IsSlotBooked(BookingSlot slot)
        //{
        //    return GetBookingEntries(slot.ToEnumerable()).Any();
        //}

        public BookingSlot GetBookingSlot(DateTimePeriod slotPeriod, Facility facility)
        {
            RequireArg.NotNull(slotPeriod);
            RequireArg.NotNull(facility);
            
            var entry = BookingEntries
                .Where(e =>
                    facility == e.Facility &&
                    !slotPeriod.Intersect(e.Period).IsEmpty())
                .SingleOrDefault();

            return new BookingSlot
            {
                Period = slotPeriod,
                Facility = facility,
                Booking = entry
            };
        }

        public string GetSlotToolTip(BookingSlot slot)
        {
            RequireArg.NotNull(slot);

            if (!slot.IsBooked)
                return "";

            return slot.Booking.Remarks;// string.Format("{0} (card {1})", entry.ResidentController.Name, entry.ResidentController.PassCardNumber);
        }
    }
}
