using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Encapsulation.Sample.DataAccess;
using EntityFramework.Encapsulation.Sample.Domain.Model;

namespace EntityFramework.Encapsulation.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = new Random().Next(1, 10000);

            using (var context = new SalesDbContext())
            {
                var order = new Order(id, DateTime.Now, "Hadi Ahmadi");
                order.AddOrderItem(new OrderItem("Western Digital 1TB HDD", 1, 2000000));
                order.AddOrderItem(new OrderItem("Adata Premier PC3-12800 4GB DDR3", 2, 1300000));

                context.Orders.Add(order);
                context.SaveChanges();
            }


            Console.ReadLine();
        }
    }
}
