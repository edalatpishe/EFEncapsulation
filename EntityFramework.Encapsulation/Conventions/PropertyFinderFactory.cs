using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;

namespace EntityFramework.Encapsulation.Conventions
{
    internal static class PropertyFinderFactory
    {
        public static IPrivatePropertyFinder Create(NamingConventions? convention)
        {
            if (!convention.HasValue)
                convention = Defaults.DefaultNamingConvention;

            switch (convention)
            {
               case NamingConventions.CamelCase:
                    return new CamelCaseFinder();
                case NamingConventions.Lowercase:
                    return new LowercaseFinder();
                case NamingConventions.UnderscoreCamelCase:
                    return new UnderscoreCamelCaseFinder();
                case NamingConventions.UnderscoreCase:
                    return new UnderscoreCaseFinder();
                case NamingConventions.Uppercase:
                    return new UppercaseFinder();
                default:
                    throw  new NotImplementedException();
            }
        }
    }
}
