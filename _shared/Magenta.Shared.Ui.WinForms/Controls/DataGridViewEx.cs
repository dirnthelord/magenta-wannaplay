using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Magenta.Shared.UI.WinForms.Controls;

namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    public class DataGridViewEx : DataGridView
    {
        public event EventHandler<GridSelectionChangingEventArgs> SelectionChanging;
        protected void OnSelectionChanging(GridSelectionChangingEventArgs e)
        {
            var handler = SelectionChanging;

            if (handler != null)
                handler(this, e);
        }


        protected override void SetSelectedCellCore(int columnIndex, int rowIndex, bool selected)
        {
            var e = new GridSelectionChangingEventArgs(columnIndex, rowIndex, selected);

            OnSelectionChanging(e);

            if (!e.Cancel)
                base.SetSelectedCellCore(columnIndex, rowIndex, selected);
        }
    }
}
