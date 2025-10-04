using ShoeInventoryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoeInventoryApp.Services
{
    public class SupplierService : ISupplierService   // <-- MUST implement the interface
    {
        private readonly AppDbContext _context;

        public SupplierService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
