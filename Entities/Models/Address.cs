using System;
using System.Collections.Generic;
using Entities.Models.Generics;

namespace Entities.Models
{
    public class Address : ModelBase
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string? Additional { get; set; }
        public int? ZipCode { get; set; }
        public string City { get; set; }
        public string? Country { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}