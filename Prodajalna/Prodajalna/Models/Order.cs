using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace Prodajalna.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}