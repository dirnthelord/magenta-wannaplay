using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.WannaPlay.Domain;
using Ninject.Core;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.Shared;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class BookingScheduleControl : UserControl
    {
        public BookingScheduleControl()
        {
            InitializeComponent();

            dataContext.DataSourceChanged += delegate { OnViewModelChanged(); };
        }

        BookingIndicatorCell _indicatorCellTemplate = new BookingIndicatorCell();

        DataGridViewColumn CreateFacilityBookingColumn(Facility facility)
        {
            return new DataGridViewColumn
            {
                CellTemplate = _indicatorCellTemplate,
                HeaderText = facility.Name,
                Tag = facility,
            };
        }

        private void OnViewModelChanged()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.RowCount = (int)ViewModel.Period.GetTimeSpan().TotalHours;

            foreach (var facility in ViewModel.Facilities)
                dataGridView1.Columns.Add(CreateFacilityBookingColumn(facility));
            //dataGridView1.Columns.Add(new DataGridViewColumn { Name = "Court Two", CellTemplate = _indicatorCellTemplate });
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var column = dataGridView1.Columns[e.ColumnIndex];
            var facility = (Facility)column.Tag;

            if (facility != null)
            {
                var period = DateTimePeriod.FromHours(ViewModel.Period.From.AddHours(e.RowIndex), 1);

                e.Value = ViewModel.GetFacilityBookingSlot(facility, period);
            }
        }

        [Inject]
        public BookingViewModel ViewModel
        {
            get { return (BookingViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }
    }
}
