using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Magenta.WannaPlay.UI.WinForms.Domain;

namespace Magenta.WannaPlay.UI.WinForms.Controls.GridCells
{
    public class FacilityBookingIndicatorCell : DataGridViewTextBoxCell
    {
        public override Type ValueType
        {
            get { return typeof(FacilityBookingSlot); }
        }

        void BasePaint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            Action<DataGridViewPaintParts> BasePaintPart =
                p => BasePaint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, p);

            BasePaintPart(DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.SelectionBackground /*| DataGridViewPaintParts.ContentBackground*/);

            PaintBookingIndicator(graphics, cellBounds, value);

            BasePaintPart(DataGridViewPaintParts.Focus /*| DataGridViewPaintParts.ContentForeground*/);
        }

        void PaintBookingIndicator(Graphics graphics, Rectangle cellBounds, object value)
        {
            var bookingSlot = (FacilityBookingSlot)value;
            if (!bookingSlot.IsEmpty)
            {
                //var rectangle = new Rectangle(cellBounds.Location, new Size((int)(cellBounds.Width * ratio), cellBounds.Height));
                graphics.FillRectangle(new HatchBrush(HatchStyle.DiagonalCross, Color.Red, Color.Transparent), cellBounds);
            }
        }
    }
}
