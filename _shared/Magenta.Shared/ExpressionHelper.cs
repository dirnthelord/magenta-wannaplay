using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Magenta.Shared
{
    public static class ExpressionHelper
    {
        public static string GetPropertyName<TResult>(Expression<Func<TResult>> property)
        {
            return GetMemberNames(((LambdaExpression)property).Body).Skip(1).Join(".");
        }
    
        public static string GetPropertyName<T, TResult>(T obj, Expression<Func<T, TResult>> property)
        {
            return GetMemberNames(((LambdaExpression)property).Body).Join(".");
        }

        static IEnumerable<string> GetMemberNames(Expression expression)
        {
            if (expression is ConstantExpression || expression is ParameterExpression)
                yield break;

            var memberExpression = (MemberExpression)expression;

            foreach (var memberName in GetMemberNames(memberExpression.Expression))
                yield return memberName;

            yield return memberExpression.Member.Name;
        }
    }
}
