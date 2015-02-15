using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Encapsulation.Conventions;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Sample.DataAccess.Mappings;
using EntityFramework.Encapsulation.Sample.Domain.Model;

namespace EntityFramework.Encapsulation.Sample.DataAccess
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public SalesDbContext() : base("name=DBConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Defaults.DefaultNamingConvention = NamingConventions.UnderscoreCamelCase;

            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new OrderItemMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
