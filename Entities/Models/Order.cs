using System;
using System.Collections.Generic;
using Entities.Models.Generics;

namespace Entities.Models
{
    public class Order : ModelBase
    {
        public DateTime DeliveredAt { get; set; }
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }
        public Guid? PackageId { get; set; }
        public Package? Package { get; set; }
        public IEnumerable<OrderProduct> OrdersProducts { get; set; }
    }
}