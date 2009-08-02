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

        [Obsolete]
        public static HostingDialog HostInDialog(Form parent, string title, Control content, params DialogButtonDescription[] buttonDescriptions)
        {
            return HostInDialog(new DialogDescription
                                    {
                                        Content = content,
                                        Parent = parent,
                                        Title = title,
                                        ButtonDescriptions = buttonDescriptions
                                    });
        }

        public static HostingDialog HostInDialog(DialogDescription dialogDescription)
        {
            var dialog = new HostingDialog
            {
                Text = dialogDescription.Title,
            };

            dialog.Icon = dialogDescription.Icon;
            dialog.ShowIcon = dialogDescription.Icon != null;

            dialog.Owner = dialogDescription.Parent;

            dialog.SetButtons(dialogDescription.ButtonDescriptions);

            dialogDescription.Content.Padding = new Padding(8, 8, 8, 8);
            dialog.ClientSize = new Size
            {
                Width = dialogDescription.Content.Width + dialogDescription.Content.Padding.Horizontal,
                Height = dialogDescription.Content.Height + dialog.ButtonsPanel.Height + dialogDescription.Content.Padding.Vertical
            };
            dialog.Content = dialogDescription.Content;

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
