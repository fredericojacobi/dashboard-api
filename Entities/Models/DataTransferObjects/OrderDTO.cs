using System;
using System.Collections.Generic;

namespace Entities.Models.DataTransferObjects
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public Team Team { get; set; }
        public DateTime DeliveredAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public IEnumerable<OrderProduct> OrdersProducts { get; set; }

        public OrderDTO()
        {
        }
    }
}