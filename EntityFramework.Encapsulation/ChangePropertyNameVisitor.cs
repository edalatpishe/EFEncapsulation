using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Encapsulation
{
    internal class ChangePropertyNameVisitor : ExpressionVisitor
    {
        private readonly string _propertyNewName;
        public ChangePropertyNameVisitor(string propertyNewName)
        {
            this._propertyNewName = propertyNewName;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var otherMember = _propertyNewName;
            var inner = Visit(node.Expression);
            var x = true;
            return Expression.Property(inner, otherMember); 

        }
    }
}
