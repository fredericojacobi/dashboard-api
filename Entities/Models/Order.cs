using System;
using System.Collections.Generic;
using Generics;
using Generics.Entities;

namespace Entities.Models
{
    public class Order : ModelBase
    {
        public DateTime DeliveredAt { get; set; }
        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }
        public Guid? TeamId { get; set; }
        public Team? Team { get; set; }
        public IEnumerable<OrderProduct> OrdersProducts { get; set; }
    }
}