using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magenta.Shared.UI.WinForms.DataBinding
{
    public static class DataBinder
    {
        public static DataBinderBindingSourceContext<TDataSource> BindTo<TDataSource>(BindingSource bindingSource)
        {
            return new DataBinderBindingSourceContext<TDataSource>(bindingSource);
        }
    }
}
