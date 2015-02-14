using System;
using System.Text;
using EntityFramework.Encapsulation.Conventions;

namespace EntityFramework.Encapsulation.Exceptions
{
    public class InvalidConventionException : Exception
    {
        public InvalidConventionException(NamingConventions convention, string publicPropertyName, string result, NamingConventions? alternativeConvention = null)
            :base(CreateMessage(convention,publicPropertyName,result,alternativeConvention))
        {
            
        }

        private static string CreateMessage(NamingConventions convention, string publicPropertyName, string result, NamingConventions? alternativeConvention)
        {
            var errorBuilder = new StringBuilder();
            errorBuilder.Append(string.Format("Error while applying {0} convention on '{1}' property because" +
                                          " result is same as property name." + Environment.NewLine +
                                          "Property original name : '{1}', Proeprty after applying Camelcase : {2}"
                                          ,convention.ToString(),publicPropertyName,result));

            if (alternativeConvention != null)
            {
                errorBuilder.Append(Environment.NewLine)
                    .Append(string.Format("Consider using {0} convention", alternativeConvention.ToString()));
            }

            return errorBuilder.ToString();
        }
    }
}
