using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.UI.WinForms.Controls
{
    public class GridSelectionChangingEventArgs :EventArgs
    {
        public int ColumnIndex { get; private set; }
        public int RowIndex { get; private set; }
        public bool TargetSelectionState { get; private set; }
        public bool Cancel { get; set; }

        public GridSelectionChangingEventArgs(int columnIndex, int rowIndex, bool targetSelectionState)
        {
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
            TargetSelectionState = targetSelectionState;
        }
    }
}
