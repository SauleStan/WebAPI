using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Item
    {
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Item(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
    