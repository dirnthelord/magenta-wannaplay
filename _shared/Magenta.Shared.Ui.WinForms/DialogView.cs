using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.DesignByContract;

namespace Magenta.Shared.UI.WinForms
{
    public partial class DialogView : UserControl
    {
        public DialogView()
        {
            InitializeComponent();
        }

        public void SetButtons(IEnumerable<DialogButtonDescription> buttonDescriptions)
        {
            //buttonsPanel.Controls.Clear();
            //buttonsPanel.ColumnStyles.Clear();

            // First column (with zero index) is set to fill mode to make sure buttons are aligned to the right corner
            var columnIndex = 1;
            foreach (var buttonDescription in buttonDescriptions)
            {
                var button = new Button
                {
                    Tag = buttonDescription,
                    Text = buttonDescription.Text,
                    Anchor = AnchorStyles.None,
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                    AutoSize = true,
                };

                button.Click += button_Click;

                buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                buttonsPanel.Controls.Add(button, columnIndex, 0);
                columnIndex++;
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            ((DialogButtonDescription)((Button)sender).Tag).OnClick();
        }
    }
}
