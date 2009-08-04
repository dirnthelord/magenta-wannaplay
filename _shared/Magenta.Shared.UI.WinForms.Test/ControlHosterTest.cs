using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Magenta.Shared.Ui.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace Magenta.Shared.UI.WinForms
{
    [TestFixture]
    public class ControlHosterTest
    {
        [Explicit, Test]
        public void HostInDialog()
        {
            var controlToHost = new Label 
            { 
                Text = "Test", 
                Font = new Font(FontFamily.GenericMonospace, 24), 
                TextAlign = ContentAlignment.MiddleCenter 
            };

            ControlHoster.HostInModalDialog(new DialogDescription
            {
                Title = "Test",
                Content = controlToHost,
                ButtonDescriptions = new[]
                {
                    new DialogButtonDescription { Text = "OK", OnClick = () => MessageBox.Show("OK") },
                    new DialogButtonDescription { Text = "Not OK", OnClick = () => MessageBox.Show("Not OK") }
                }
            });
        }
    }
}
