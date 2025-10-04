using System.Collections.Generic;

namespace PF.Repository.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<ShoeColorVariation> ColorVariations { get; set; } = new List<ShoeColorVariation>();
    }
}
