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
        public static HostingForm CreateForm(Bitmap icon, string title, Control content)
        {
            content.Padding = new Padding(8);

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

        public static void HostInModalDialog(DialogDescription dialogDescription)
        {
            using (var dialogForm = CreateDialog(dialogDescription))
                dialogForm.ShowDialog();
        }

        public static HostingDialog CreateDialog(DialogDescription dialogDescription)
        {
            var dialog = new HostingDialog
            {
                Text = dialogDescription.Title,

                Icon = dialogDescription.Icon == null ? null : Icon.FromHandle(dialogDescription.Icon.GetHicon()),
                ShowIcon = dialogDescription.Icon != null,

                Owner = dialogDescription.Parent,
            };


            // Add buttons first to understand how much space they will take
            // ButtonsPanel's size is later used to calculate dialogForm client size
            dialog.SetButtons(dialogDescription.ButtonDescriptions);


            var content = dialogDescription.Content;

            content.Padding = new Padding(8, 8, 8, 8);

            dialog.ClientSize = new Size
            {
                Width = content.Width + content.Padding.Horizontal,
                Height = content.Height + content.Padding.Vertical + dialog.ButtonsPanel.Height
            };


            dialog.Content = dialogDescription.Content;


            // Workaround to emulate FormStartPosition.CenterParent which does not work for non-modal dialogs
            if (dialogDescription.Parent != null)
                dialog.Load += delegate
                {
                    dialog.StartPosition = FormStartPosition.Manual;
                    var x = dialogDescription.Parent.Location.X + (dialogDescription.Parent.Width / 2) - (dialog.Width / 2);
                    var y = dialogDescription.Parent.Location.Y + (dialogDescription.Parent.Height / 2) - (dialog.Height / 2);
                    dialog.Location = new Point(x, y);
                };

            return dialog;
        }
    }
}
