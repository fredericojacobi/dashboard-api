using System;

namespace Entities.Models
{
    public class Package : ModelBase
    {
        public Guid? OrderId { get; set; }
        public Guid? TeamId { get; set; }
        public Order Order { get; set; }
        public Team Team { get; set; }
    }
}