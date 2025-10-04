using ShoeInventoryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoeInventoryApp.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly AppDbContext _context;

        public PurchaseOrderService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PurchaseOrder> GetAllOrders()
        {
            return _context.PurchaseOrders.ToList();
        }

        public PurchaseOrder GetOrderById(int id)
        {
            return _context.PurchaseOrders.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrder(PurchaseOrder order)
        {
            _context.PurchaseOrders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(PurchaseOrder order)
        {
            _context.PurchaseOrders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.PurchaseOrders.Find(id);
            if (order != null)
            {
                _context.PurchaseOrders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
