using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magenta.WannaPlay.UI.WinForms.Controls;
using System.Windows.Forms;

namespace Magenta.WannaPlay.UI.WinForms.Services
{
    public interface ICommonUIService
    {
        Form MainForm { get; set; }
        void AskToSelectCurrentDutyGuard();
    }
}
