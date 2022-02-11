using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class OrderProduct : ModelBase
    {
        public Guid? OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}