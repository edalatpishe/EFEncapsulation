using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Encapsulation.Sample.Domain.Model;

namespace EntityFramework.Encapsulation.Sample.DataAccess.Mappings
{
public class OrderMapping : EntityTypeConfiguration<Order>
{
    public OrderMapping()
    {
        ToTable("Order")
            .HasKey(a => a.Id)
            .Property(a => a.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        this.PrivateProperty(a => a.CreateDateTime);
        this.PrivateProperty(a => a.CustomerName);
        this.HasManyPrivate(a => a.OrderItems).WithRequired().Map(a=>a.MapKey("OrderId"));
    }
}
}
