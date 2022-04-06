using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Character
    {
        public Guid Id { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public CharacterClass CharacterClass { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public int Health { get; set; }
        [Required]
        public float Experience { get; set; }
        public List<Item> Inventory { get; set; }

        public Character(string name, CharacterClass characterClass, int level, int health, float experience)
        {
            Id = Guid.NewGuid();
            Name = name;
            CharacterClass = characterClass;
            Level = level;
            Health = health;
            Experience = experience;
            Inventory = new();
        }
    }
}
