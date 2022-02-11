namespace Entities.Models
{
    public class Vehicle : ModelBase
    {
        public string IdentificationPlate { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
    }
}