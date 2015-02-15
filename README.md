# Entity Framework Encapsulation
This library enables you to map private properties using entity framework in order to build encapsulated and rich domain models. 

## Download
The 'Entity Framework Encapsulation' library is available on nuget.org. Run the following command in "Package Manager Console" window in Microsoft Visual Studio :
> Install-Package EntityFramework.Encapsulation

## Usage
Consider the following 'Order' entity :

```
public class Order
{
    private DateTime _createDateTime { get; set; }
    private string _customerName;
    private List<OrderItem> _orderItems { get; set; } 

    public long Id { get; private set; }
    public DateTime CreateDateTime { get { return _createDateTime; } }
    public string CustomerName { get { return _customerName; } }
    public ICollection<OrderItem> OrderItems { get { return _orderItems.AsReadOnly(); } }
    public decimal TotalPrice
    {
        get { return this._orderItems.Sum(a => a.TotalPrice); }
    }
    .
    .
    .
}
```

This kind of encapsulating is common way to build rich domain models in DDD approach. In this case, If you want to keep your mapping separated from your domain model, then entity framework is unable to map your class. By installing and adding 'Entity Framework Encapsulation' library to your project, then you have two extension methods to map private properties by convention :

```
public class OrderMapping : EntityTypeConfiguration<Order>
{
    public OrderMapping()
    {
        .
        .
        .
        this.PrivateProperty(a => a.CreateDateTime);
        this.PrivateProperty(a => a.CustomerName);
        this.HasManyPrivate(a => a.OrderItems).WithRequired().Map(a=>a.MapKey("OrderId"));
    }
}
```

Both 'PrivateProperty' and 'HasManyPrivate' methods have overloads to specify the naming convention of their private property :
```
this.PrivateProperty(a => a.CreateDateTime,NamingConventions.UnderscoreCamelCase);
```
Passing "null" or not passing any value to the class cause the library to use the default naming convention.

## Naming Conventions
Entity Framework Encapsulation uses naming conventions to find the name of the private properties and map them. There are currently 5 naming conventions. CamelCase (which is the default one), UnderscoreCamelCase, UnderscoreCase, Lowercase and Uppercase. See the following table for examples :

| PublicProperty  |   CamelCase   | UnderscoreCamelCase | UnderscoreCase  | Uppercase   | Lowercase   |
|:---------------:|:-------------:|:-------------------:|:---------------:|:-----------:|:-----------:|
|Firstname        |firstname      |_firstname           |_Firstname       |FIRSTNAME    |firstname    |
|OfficePhone      |officePhone    |_officePhone         |_OfficePhone     |OFFICEPHONE  |officephone  | 
|officephone      |XXXX           |_officephone         |_officephone     |OFFICEPHONE  |XXXX         |

Naming Conventions can be changed for each property (using overload for 'PrivateProperty' and 'HasManyPrivate' method). you can also change the default naming convention globally :

```
Defaults.DefaultNamingConvention = NamingConventions.UnderscoreCamelCase;
```
