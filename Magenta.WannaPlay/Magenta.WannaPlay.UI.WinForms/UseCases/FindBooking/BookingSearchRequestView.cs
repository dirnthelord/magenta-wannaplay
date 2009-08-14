using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Domain.UI;
using Magenta.WannaPlay.UI.WinForms.Domain;
using Magenta.Shared.DesignByContract;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.FindBooking
{
    public partial class BookingSearchRequestView : UserControl
    {
        public BookingSearchRequestView()
        {
            InitializeComponent();
        }

        public void SetContext(BookingSearchRequestViewModel viewModel)
        {
            dataContext.DataSource = RequireArg.NotNull(viewModel);
        }
    }
}
