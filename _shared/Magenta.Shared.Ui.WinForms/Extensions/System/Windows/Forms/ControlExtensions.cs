using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Magenta.Shared;

namespace System.Windows.Forms
{
    public static class ControlExtensions
    {
        public static Binding AddBinding<TControl, TDataSource, TMember>
            (
                this TControl control,
                BindingSource dataSource,
                Expression<Func<TControl, TMember>> controlProperty,
                Expression<Func<TDataSource, TMember>> dataMemberProperty
            )
            where TControl : Control
        {
            var propertyName = ExpressionHelper.GetPropertyName(controlProperty);
            var dataMember = ExpressionHelper.GetPropertyName(dataMemberProperty);

            return control.DataBindings.Add(propertyName, dataSource, dataMember, true);
        }


        public static Binding AddBinding<TControl, TDataSource>
            (
                this TControl control,
                TDataSource dataSource,
                Expression<Func<TControl, object>> controlProperty,
                Expression<Func<TDataSource, object>> dataMemberProperty
            )
            where TControl : Control
        {
            var propertyName = ExpressionHelper.GetPropertyName(controlProperty);
            var dataMember = ExpressionHelper.GetPropertyName(dataMemberProperty);

            return control.DataBindings.Add(propertyName, dataSource, dataMember, true);
        }
    }
}
