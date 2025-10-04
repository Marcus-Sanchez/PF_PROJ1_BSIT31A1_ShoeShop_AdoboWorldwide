using System;
using System.Collections.Generic;

namespace PF.Repository.Models
{
    public enum PurchaseOrderStatus { Pending, Confirmed, Shipped, Received, Cancelled }

    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; } = null!;
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime ExpectedDate { get; set; }
        public PurchaseOrderStatus Status { get; set; } = PurchaseOrderStatus.Pending;
        public decimal TotalAmount { get; set; }

        // Navigation
        public Supplier Supplier { get; set; } = null!;
        public ICollection<PurchaseOrderItem> Items { get; set; } = new List<PurchaseOrderItem>();
    }
}
