using ShoeInventoryApp.Models;
using System.Collections.Generic;

namespace ShoeInventoryApp.Services
{
    public interface IPurchaseOrderService
    {
        IEnumerable<PurchaseOrder> GetAllOrders();
        PurchaseOrder GetOrderById(int id);
        void AddOrder(PurchaseOrder order);
        void UpdateOrder(PurchaseOrder order);
        void DeleteOrder(int id);
    }
}
