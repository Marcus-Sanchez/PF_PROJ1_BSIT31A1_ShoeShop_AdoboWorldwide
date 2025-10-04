using PF.Web.Models;
using System.Collections.Generic;

namespace PF.Web.Services
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

using PF.Web.Models;

namespace PF.Web.Services
{
    public interface IShoeColorVariationService
    {
        IEnumerable<ShoeColorVariation> GetAll();
        ShoeColorVariation? GetById(int id);
        void Add(ShoeColorVariation variation);
        void Update(ShoeColorVariation variation);
        void Delete(int id);
    }
}

using PF.Web.Models;

namespace PF.Web.Services
{
    public interface IShoeService
    {
        IEnumerable<Shoe> GetAllShoes();
        Shoe GetShoeById(int id);
        void AddShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoe(int id);
    }
}

using PF.Web.Models;
using System.Collections.Generic;

namespace PF.Web.Services
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

using PF.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace PF.Web.Services
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

using PF.Web.Models;

namespace PF.Web.Services
{
    public class ShoeColorVariationService : IShoeColorVariationService
    {
        private readonly AppDbContext _context;

        public ShoeColorVariationService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ShoeColorVariation> GetAll()
        {
            return _context.ShoeColorVariations.ToList();
        }

        public ShoeColorVariation? GetById(int id)
        {
            return _context.ShoeColorVariations.Find(id);
        }

        public void Add(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Add(variation);
            _context.SaveChanges();
        }

        public void Update(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Update(variation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var variation = _context.ShoeColorVariations.Find(id);
            if (variation != null)
            {
                _context.ShoeColorVariations.Remove(variation);
                _context.SaveChanges();
            }
        }
    }
}

using PF.Web.Models;

namespace PF.Web.Services
{
    public class ShoeService : IShoeService  // <-- Must implement the interface
    {
        private readonly AppDbContext _context;

        public ShoeService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shoe> GetAllShoes()
        {
            return _context.Shoes.ToList();
        }

        public Shoe GetShoeById(int id)
        {
            return _context.Shoes.Find(id);
        }

        public void AddShoe(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
            _context.SaveChanges();
        }

        public void UpdateShoe(Shoe shoe)
        {
            _context.Shoes.Update(shoe);
            _context.SaveChanges();
        }

        public void DeleteShoe(int id)
        {
            var shoe = _context.Shoes.Find(id);
            if (shoe != null)
            {
                _context.Shoes.Remove(shoe);
                _context.SaveChanges();
            }
        }
    }
}

using PF.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace PF.Web.Services
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

