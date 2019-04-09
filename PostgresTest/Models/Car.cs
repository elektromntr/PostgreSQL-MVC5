using System.ComponentModel.DataAnnotations;

namespace PostgresTest.Models
{
    public class Car
    {
        [Key]
        public int LicenseNumber { get; set; }
        public string Insurance { get; set; }
        public int? Year { get; set; }
        public int HorsePower { get; set; }
        public decimal EngineCapacity { get; set; }
    }
}