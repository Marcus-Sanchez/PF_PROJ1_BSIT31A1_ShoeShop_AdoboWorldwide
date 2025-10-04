using System.Collections.Generic;

namespace PF.Repository.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public bool IsActive { get; set; } = true;

        // Navigation
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
    }
}
