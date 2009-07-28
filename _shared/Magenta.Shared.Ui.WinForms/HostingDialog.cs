using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magenta.Shared.UI.WinForms
{
    public partial class HostingDialog : Form
    {
        public HostingDialog()
        {
            InitializeComponent();
        }

        public Control Content
        {
            get { return content.Controls[0]; }
            set
            {
                content.Controls.Clear();
                content.Controls.Add(value);
                value.Dock = DockStyle.Fill;
            }
        }

        public void SetButtons(IEnumerable<Button> buttons)
        {
            buttonsTable.ColumnCount = buttons.Count();

            int columnIndex = 0;

            foreach (var button in buttons)
            {
                buttonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / buttons.Count()));

                buttonsTable.Controls.Add(button, columnIndex, 0);

                columnIndex++;
            }
        }
    }
}
