using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.WannaPlay.UI.WinForms.Controls.GridCells;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.ViewBookingSchedule
{
    public class BookingSlotColumn : DataGridViewTextBoxColumn
    {
        public BookingSlotColumn()
        {
            CellTemplate = new BookingSlotCell();
        }
    }
}
