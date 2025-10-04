using Microsoft.AspNetCore.Mvc;
using ShoeInventoryApp.Models;
using ShoeInventoryApp.Services;

namespace ShoeInventoryApp.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public IActionResult Index()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            return View(suppliers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _supplierService.AddSupplier(supplier);
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        public IActionResult Details(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);
            if (supplier == null) return NotFound();
            return View(supplier);
        }

        public IActionResult Edit(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);
            if (supplier == null) return NotFound();
            return View(supplier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _supplierService.UpdateSupplier(supplier);
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        public IActionResult Delete(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);
            if (supplier == null) return NotFound();
            return View(supplier);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _supplierService.DeleteSupplier(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
