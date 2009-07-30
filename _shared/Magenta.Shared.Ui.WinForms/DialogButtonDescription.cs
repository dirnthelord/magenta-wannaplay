using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magenta.Shared.UI.WinForms
{
    public class DialogButtonDescription
    {
        public string Text { get; set; }
        public bool IsAcceptButton { get; set; }
        public bool IsCancelButton { get; set; }
        public Action OnClick { get; set; }
    }
}
