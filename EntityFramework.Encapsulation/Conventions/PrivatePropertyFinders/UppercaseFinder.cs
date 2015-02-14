using EntityFramework.Encapsulation.Exceptions;

namespace EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders
{
    internal class UppercaseFinder : IPrivatePropertyFinder
    {
        public string Find(string publicPropertyName)
        {
            var output = publicPropertyName.ToUpper();

            if(output.Equals(publicPropertyName))
                throw  new InvalidConventionException(NamingConventions.Uppercase, publicPropertyName,output,NamingConventions.Lowercase);

            return output;
        }
    }
}
