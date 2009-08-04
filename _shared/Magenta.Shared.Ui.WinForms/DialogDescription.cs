using System.Drawing;
using System.Windows.Forms;
using Magenta.Shared.UI.WinForms;

namespace Magenta.Shared.Ui.WinForms
{
    public class DialogDescription
    {
        public Control Content { get; set; }

        public Form Parent { get; set; }

        public string Title { get; set; }

        public Bitmap Icon { get; set; }

        public DialogButtonDescription[] ButtonDescriptions { get; set; }
    }
}