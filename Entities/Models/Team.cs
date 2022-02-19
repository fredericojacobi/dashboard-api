using System;
using System.Collections.Generic;
using Generics;
using Generics.Entities;

namespace Entities.Models
{
    public class Team : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }
    }
}