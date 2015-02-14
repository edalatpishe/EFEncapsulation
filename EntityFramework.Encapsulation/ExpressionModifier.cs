using System;
using System.Linq.Expressions;
using EntityFramework.Encapsulation.Conventions;

namespace EntityFramework.Encapsulation
{
    internal static class ExpressionModifier
    {
        public static void ToPrivate(ref dynamic publicExpression, NamingConventions? conventions, out string defaultColumnName)
        {
            var memberExpression = publicExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentNullException("publicExpression.Body");


            defaultColumnName = memberExpression.Member.Name;
            var finder = PropertyFinderFactory.Create(conventions);
            var privateProperty = finder.Find(defaultColumnName);

            var visitor = new ChangePropertyNameVisitor(privateProperty);
            publicExpression = visitor.Visit(publicExpression);
        }
    }
}
