using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Magenta.Shared.DesignByContract;
using System.Linq.Expressions;

namespace Magenta.Shared.UI.WinForms.DataBinding
{
    public class DataBinderControlContext<TDataSource, TProperty>
    {
        readonly DataBinderBindingSourceContext<TDataSource> BindingSourceContext;
        readonly Expression<Func<TDataSource, TProperty>> ObjectProperty;

        public DataBinderControlContext
            (
                DataBinderBindingSourceContext<TDataSource> bindingSourceContext,
                Expression<Func<TDataSource, TProperty>> objectProperty
            )
        {
            BindingSourceContext = RequireArg.NotNull(bindingSourceContext);
            ObjectProperty = RequireArg.NotNull(objectProperty);
        }

        public DataBinderControlContext<TDataSource, TProperty> ControlProperty<TControl>(TControl control, Expression<Func<TControl, TProperty>> property)
            where TControl : Control
        {
            control.AddBinding(BindingSourceContext.BindingSource, property, ObjectProperty);

            return this;
        }

    }
}
