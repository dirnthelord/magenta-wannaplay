﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.ViewModels;
using Magenta.Shared.DesignByContract;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public partial class FacilityBookingControl : UserControl
    {
        public FacilityBookingControl()
        {
            InitializeComponent();

            dataContext.ListChanged += delegate { FormatRows(); };
        }

        private void FormatRows()
        {
            foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                row.Height = (int)((FacilityBookingSlot)row.DataBoundItem).Period.GetTimeSpan().TotalHours * 22;
                row.DefaultCellStyle.BackColor = Color.Green;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FacilityBookingViewModel ViewModel
        {
            get { return (FacilityBookingViewModel)dataContext.DataSource; }
            set { dataContext.DataSource = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormatRows();
        }
    }
}
