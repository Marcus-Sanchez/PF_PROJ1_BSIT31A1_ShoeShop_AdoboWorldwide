using System.Collections.Generic;

namespace ShoeInventoryApp.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
