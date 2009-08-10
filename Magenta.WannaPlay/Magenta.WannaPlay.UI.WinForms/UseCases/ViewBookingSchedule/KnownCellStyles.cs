using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Magenta.WannaPlay.UI.WinForms.UseCases.ViewBookingSchedule
{
    static class KnownCellStyles
    {
        public static DataGridViewCellStyle BookedSlotCellStyle { get; private set; }

        static KnownCellStyles()
        {
            BookedSlotCellStyle = new DataGridViewCellStyle(new DataGridViewTextBoxColumn().CellTemplate.Style);

            BookedSlotCellStyle.BackColor = Color.LightSteelBlue;
            
            BookedSlotCellStyle.ForeColor = Color.Black;
            BookedSlotCellStyle.SelectionBackColor = Color.DarkOrange;
        }
    }
}
