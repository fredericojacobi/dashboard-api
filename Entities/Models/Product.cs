using System;
using System.Collections.Generic;
using Entities.Models.Generics;

namespace Entities.Models
{
    public class Product : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IEnumerable<OrderProduct> OrdersProducts { get; set; }
    }
}