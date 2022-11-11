using System.ComponentModel.DataAnnotations;

namespace AcUniform.Models
{
    public class Junior
    {
        public int JuniorID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }


    }
}
