namespace EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders
{
    internal interface IPrivatePropertyFinder
    {
        string Find(string publicPropertyName);
    }
}
