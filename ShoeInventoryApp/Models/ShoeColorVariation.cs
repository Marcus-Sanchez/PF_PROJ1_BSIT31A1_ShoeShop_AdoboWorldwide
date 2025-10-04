namespace ShoeInventoryApp.Models
{
    public class ShoeColorVariation
    {
        public int Id { get; set; }
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
    }
}
