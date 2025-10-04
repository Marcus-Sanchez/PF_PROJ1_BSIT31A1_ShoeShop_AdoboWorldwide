using System;

namespace ShoeInventoryApp.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }             // Primary key
        public int SupplierId { get; set; }     // Foreign key
        public DateTime OrderDate { get; set; } // <-- This must exist
        public decimal TotalAmount { get; set; }

        // Navigation property
        public Supplier Supplier { get; set; }
    }
}
