using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Item
    {
        public Guid Id { get; init; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Item(string Name, int Price)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Price = Price;
        }
    }
}
    