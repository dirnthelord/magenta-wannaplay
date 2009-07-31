using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.Services.Residence;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.Ui.WinForms;
using Magenta.WannaPlay.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class WannaPlayMainControl : UserControl
    {
        [Inject]
        public IResidenceManager ResidenceManager { get; set; }

        [Inject]
        public IKernel Kernel { get; set; }


        public WannaPlayMainViewModel ViewModel
        {
            get { return (WannaPlayMainViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }


        public WannaPlayMainControl()
        {
            InitializeComponent();

            dataContext.DataSourceChanged += dataContext_DataSourceChanged;
        }

        void dataContext_DataSourceChanged(object sender, EventArgs e)
        {
            dayPicker.Value = ViewModel.SelectedDay;

            UpdateBookingSchedules();
        }

        private void UpdateBookingSchedules()
        {
            tennisBookingSchedule.ViewModel = ViewModel.CreateScheduleViewModel(FacilityType.TennisCourt);
            squashBookingSchedule.ViewModel = ViewModel.CreateScheduleViewModel(FacilityType.SquashCourt);
        }

        DateTime Today { get { return DateTime.Today; } }

        private void setDayToToday_Click(object sender, EventArgs e)
        {
            ViewModel.SetSelectedDayToToday();
        }

        private void dayPicker_ValueChanged(object sender, EventArgs e)
        {
            ViewModel.SelectedDay = dayPicker.Value;

            setDayToToday.Enabled = dayPicker.Value != Today;
        }

        private void changeCurrentDutyGuard_Click(object sender, EventArgs e)
        {
            ViewModel.AskToSelectCurrentDutyGuard();
        }
    }
}
