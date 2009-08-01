using System;

namespace Magenta.WannaPlay.UI.WinForms.Diagnostics
{
    public interface IExceptionNotifier
    {
        bool Notify(Exception exception);
    }
}