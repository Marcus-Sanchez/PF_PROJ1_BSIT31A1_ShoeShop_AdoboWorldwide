namespace PF.Repository.Models
{
    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ShoeColorVariationId { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityReceived { get; set; }
        public decimal UnitCost { get; set; }

        // Navigation
        public PurchaseOrder PurchaseOrder { get; set; } = null!;
        public ShoeColorVariation ShoeColorVariation { get; set; } = null!;
    }
}
