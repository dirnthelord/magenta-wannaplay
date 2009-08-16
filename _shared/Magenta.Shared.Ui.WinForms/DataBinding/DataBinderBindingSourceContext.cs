using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.DesignByContract;
using System.Linq.Expressions;

namespace Magenta.Shared.UI.WinForms.DataBinding
{
    public class DataBinderBindingSourceContext<TDataSource>
    {
        public readonly BindingSource BindingSource;

        public DataBinderBindingSourceContext(BindingSource bindingSource)
        {
            BindingSource = RequireArg.NotNull(bindingSource);
        }

        public DataBinderControlContext<TDataSource, TProperty> ObjectProperty<TProperty>(Expression<Func<TDataSource, TProperty>> property)
        {
            return new DataBinderControlContext<TDataSource, TProperty>(this, property);
        }
    }
}
