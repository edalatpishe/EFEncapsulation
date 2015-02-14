using System.Linq;
using System.Text.RegularExpressions;
using EntityFramework.Encapsulation.Exceptions;

namespace EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders
{
    internal class UnderscoreCamelCaseFinder : IPrivatePropertyFinder
    {
        public string Find(string publicPropertyName)
        {
            var parts = Regex.Split(publicPropertyName, @"(?<!^)(?=[A-Z])").ToList();

            if (parts.Any() && parts[0][0] != '_')
                parts[0] = "_" + parts[0].ToLower();

            var output = string.Join("", parts);

            if (output.Equals(publicPropertyName))
            {
                throw new InvalidConventionException(NamingConventions.UnderscoreCamelCase,publicPropertyName,output,NamingConventions.UnderscoreCase);
            }

            return output;
        }
    }
}
