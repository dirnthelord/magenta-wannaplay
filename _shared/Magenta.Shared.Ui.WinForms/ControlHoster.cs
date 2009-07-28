using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Magenta.Shared.UI.WinForms;

namespace Magenta.Shared.Ui.WinForms
{
    public static class ControlHoster
    {
        public static HostingForm HostInForm(Bitmap icon, string title, Control content)
        {
            var form = new HostingForm
            {
                Text = title,
                ClientSize = content.Size,
                Icon = icon == null ? null : Icon.FromHandle(icon.GetHicon()),
            };

            content.Dock = DockStyle.Fill;
            form.Controls.Add(content);

            return form;
        }

        public static HostingDialog HostInDialog(Bitmap icon, string title, Control content, params Button[] buttons)
        {
            var dialog = new HostingDialog
            {
                Text = title,
                Icon = icon == null ? null : Icon.FromHandle(icon.GetHicon()),
            };

            dialog.Content = content;

            dialog.SetButtons(buttons);

            return dialog;
        }
    }
}
