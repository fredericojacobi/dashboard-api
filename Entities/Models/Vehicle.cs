using System;
using Generics;
using Generics.Entities;

namespace Entities.Models
{
    public class Vehicle : ModelBase
    {
        public string IdentificationPlate { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public Guid? TeamId { get; set; }
        public Team? Team { get; set; }
    }
}