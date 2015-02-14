using System.Linq;
using System.Text.RegularExpressions;
using EntityFramework.Encapsulation.Exceptions;

namespace EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders
{
    internal class UnderscoreCaseFinder : IPrivatePropertyFinder
    {
        public string Find(string publicPropertyName)
        {
            var parts = Regex.Split(publicPropertyName, @"(?<!^)(?=[A-Z])").ToList();

            var output = string.Join("_", parts);

            if (output.Equals(publicPropertyName))
            {
                throw new InvalidConventionException(NamingConventions.UnderscoreCase,publicPropertyName,output,null);
            }

            return output;
        }
    }
}
