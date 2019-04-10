using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

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
        internal string _Tags { get; set; } //Property to map JSON from database
        [NotMapped]
        public string[] Tags //Property to serialize JSON to database and back
        {
            get { return _Tags == null ? null : JsonConvert.DeserializeObject<string[]>(_Tags); }
            set { _Tags = JsonConvert.SerializeObject(value); }
        }
    }
}