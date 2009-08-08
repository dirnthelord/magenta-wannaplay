using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace System
{
    public static class EventExtensions
    {
        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
            where TEventArgs: EventArgs
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }

        public static void Raise(this EventHandler eventHandler, object sender, EventArgs e)
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }

        public static void Raise(this PropertyChangedEventHandler eventHandler, object sender, string propertyName)
        {
            if (eventHandler != null)
                eventHandler(sender, new PropertyChangedEventArgs(propertyName));
        }
    }
}
