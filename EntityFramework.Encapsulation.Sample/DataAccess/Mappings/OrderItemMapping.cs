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
    public class OrderItemMapping : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMapping()
        {
            ToTable("OrderItem")
                .HasKey(a => a.Id)
                .Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.PrivateProperty(a => a.Amount);
            this.PrivateProperty(a => a.EachPrice);
            this.PrivateProperty(a => a.ProductName);
            Ignore(a => a.TotalPrice);
        }
    }
}
