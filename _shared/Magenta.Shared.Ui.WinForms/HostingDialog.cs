using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.DesignByContract;

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

        public void SetButtons(IEnumerable<DialogButtonDescription> buttonDescriptions)
        {
            RequireArg.Complies(buttonDescriptions.Where(d => d.IsAcceptButton).Count() <= 1);
            RequireArg.Complies(buttonDescriptions.Where(d => d.IsCancelButton).Count() <= 1);

            var columnIndex = 1;

            foreach (var buttonDescription in buttonDescriptions)
            {
                var button = new Button
                {
                    Text = buttonDescription.Text,
                    Tag = buttonDescription,
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                };

                if (buttonDescription.IsAcceptButton)
                    AcceptButton = button;

                if (buttonDescription.IsCancelButton)
                    CancelButton = button;

                button.Click += button_Click;
                var columnStyle = new ColumnStyle(SizeType.AutoSize);
                buttonsPanel.ColumnStyles.Add(columnStyle);

                buttonsPanel.Controls.Add(button, columnIndex, 0);
                columnIndex++;
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            try
            {
                InvokeDialogButtonClickHandler((DialogButtonDescription)((Button)sender).Tag);
            }
            finally
            {
                Close(); // Close() must be _after_ invoking button handler, otherwise BindingSource.DataSource will be null in Content control
            }
        }

        private void InvokeDialogButtonClickHandler(DialogButtonDescription clickedButtonDescription)
        {
            var handler = clickedButtonDescription.OnClick;

            if (handler != null)
                handler();
        }

        public Panel ButtonsPanel
        {
            get { return buttonsPanel; }
        }
    }
}
