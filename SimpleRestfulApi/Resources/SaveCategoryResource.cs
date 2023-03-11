using System.ComponentModel.DataAnnotations;

namespace SimpleRestfulApi.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
