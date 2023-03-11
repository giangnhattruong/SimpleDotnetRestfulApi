using System.ComponentModel.DataAnnotations;

namespace SimpleRestfulApi.Resources
{
    public class SaveProductResouce
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public int QuantityInPackage { get; set; }
        [Required]
        public string UnitOfMeasurement { get; set; }
        public CategoryResource Category { get; set; }
    }
}
