using System.Collections.Generic;

namespace ShoeInventoryApp.Models
{
    public class Shoe
    {
        public int Id { get; set; }             // Primary key
        public string Name { get; set; }        // Shoe name
        public string Brand { get; set; }       // Brand
        public double Price { get; set; }       // Price
        public List<ShoeColorVariation> ColorVariations { get; set; } // Navigation
    }
}
