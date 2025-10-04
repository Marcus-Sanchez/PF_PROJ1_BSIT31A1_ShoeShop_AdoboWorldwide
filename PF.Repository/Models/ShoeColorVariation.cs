using System.Collections.Generic;

namespace PF.Repository.Models
{
    public class ShoeColorVariation
    {
        public int Id { get; set; }
        public int ShoeId { get; set; }
        public string ColorName { get; set; } = null!;
        public string HexCode { get; set; } = null!;
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; } = 5;
        public bool IsActive { get; set; } = true;

        // Navigation
        public Shoe Shoe { get; set; } = null!;
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();
        public ICollection<StockPullOut> StockPullOuts { get; set; } = new List<StockPullOut>();
    }
}
