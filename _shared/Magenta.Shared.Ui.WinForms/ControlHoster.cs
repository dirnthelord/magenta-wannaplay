using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Magenta.Shared.UI.WinForms;
using Magenta.Shared.Validation;

namespace Magenta.Shared.Ui.WinForms
{
    public static class ControlHoster
    {
        public static HostingForm HostInForm(Bitmap icon, string title, Control content)
        {
            content.Padding = new Padding(16);

            var form = new HostingForm
            {
                Text = title,
                ClientSize = new Size 
                {
                    Width = content.Size.Width + content.Padding.Horizontal, 
                    Height = content.Size.Height + content.Padding.Vertical
                },
                StartPosition = FormStartPosition.CenterParent,
                Icon = icon == null ? null : Icon.FromHandle(icon.GetHicon()),
            };

            content.Dock = DockStyle.Fill;
            form.Controls.Add(content);

            return form;
        }

        public static HostingDialog HostInDialog(Form parent, string title, Control content, params DialogButtonDescription[] buttonDescriptions)
        {
            var dialog = new HostingDialog
            {
                Text = title,
            };

            dialog.Owner = parent;

            dialog.SetButtons(buttonDescriptions);

            content.Padding = new Padding(18, 16, 16, 8);
            dialog.ClientSize = new Size
            {
                Width = content.Width + content.Padding.Horizontal,
                Height = content.Height + dialog.ButtonsPanel.Height + content.Padding.Vertical
            };
            dialog.Content = content;

            if (parent != null)
                dialog.Load += delegate
                {
                    dialog.StartPosition = FormStartPosition.Manual;
                    var x = parent.Location.X + (parent.Width / 2) - (dialog.Width / 2);
                    var y = parent.Location.Y + (parent.Height / 2) - (dialog.Height / 2);
                    dialog.Location = new Point(x, y);
                };

            return dialog;
        }
    }
}
