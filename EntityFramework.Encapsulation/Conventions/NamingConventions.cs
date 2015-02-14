namespace EntityFramework.Encapsulation.Conventions
{
    /// <summary>
    /// Naming conventions for "EntityFramework.Encapsulation" library to find private properties 
    /// </summary>
    public enum NamingConventions
    {
        ///<summary>Use "CamelCase" convention to find private property</summary>
        ///<example>searches "officeAddress" for "OfficeAddress" property</example>
        CamelCase,

        ///<summary>Use "Underscore CamelCase" convention to find private property</summary>
        ///<example>searches "_officeAddress" for "OfficeAddress" property</example>
        UnderscoreCamelCase,

        ///<summary>Use "Underscore case" convention to find private property</summary>
        ///<example>searches "Office_Address" for "OfficeAddress" property</example>
        UnderscoreCase,

        ///<summary>Use "Uppercase" convention to find private property</summary>
        ///<example>searches "OFFICEADDRESS" for "OfficeAddress" property</example>
        Uppercase,

        ///<summary>Use "Lowercase" convention to find private property</summary>
        ///<example>searches "officeaddress" for "OfficeAddress" property</example>
        Lowercase
    }
}
