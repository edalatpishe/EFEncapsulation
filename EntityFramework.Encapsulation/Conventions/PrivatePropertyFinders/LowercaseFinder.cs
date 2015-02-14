using EntityFramework.Encapsulation.Exceptions;

namespace EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders
{
    internal class LowercaseFinder : IPrivatePropertyFinder
    {
        public string Find(string publicPropertyName)
        {
            var output = publicPropertyName.ToLower();

            if (output.Equals(publicPropertyName))
                throw new InvalidConventionException(NamingConventions.Lowercase, publicPropertyName, output, NamingConventions.UnderscoreCamelCase);

            return output;
        }
    }
}
