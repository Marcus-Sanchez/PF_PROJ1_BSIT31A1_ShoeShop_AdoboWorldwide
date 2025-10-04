using ShoeInventoryApp.Models;
using System.Collections.Generic;

namespace ShoeInventoryApp.Services
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int id);
    }
}
