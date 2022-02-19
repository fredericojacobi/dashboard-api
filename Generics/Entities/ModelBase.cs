using System;
using System.ComponentModel.DataAnnotations;

namespace Generics.Entities
{
    public class ModelBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}