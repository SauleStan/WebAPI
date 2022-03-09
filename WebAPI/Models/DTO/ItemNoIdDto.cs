using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.DTO
{
    public class ItemNoIdDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
