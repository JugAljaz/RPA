using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Prodajalna.Models
{
    public class OrderContextInitializer:DropCreateDatabaseIfModelChanges<OrderContext>
    {
        protected override void Seed(OrderContext context)
        {
            var produkti = new List<Product>()
            {
                new Product(){Name="Paradižnikova juha", Price=1.3m,ActualCost=0.99m},
                new Product(){Name="Šparuge", Price=6.9m,ActualCost=4.99m},
                new Product(){Name="Lowski gulaš", Price=2.3m,ActualCost=0.69m}
            };
            foreach (var p in produkti)
                context.Products.Add(p);
            context.SaveChanges();

            var naročilo = new Order() { Customer = "Bobo" };
            var vrstice = new List<OrderDetail>()
            {
                new OrderDetail(){ Product=produkti[0], Quantity=2, Order=naročilo},
                new OrderDetail(){ Product=produkti[1], Quantity=4, Order=naročilo},
            };
            context.Orders.Add(naročilo);
            vrstice.ForEach(x => context.OrderDetails.Add(x));
            context.SaveChanges();
        }
    }
}