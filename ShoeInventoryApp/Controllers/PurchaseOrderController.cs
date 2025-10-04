using Microsoft.AspNetCore.Mvc;
using ShoeInventoryApp.Models;
using ShoeInventoryApp.Services;

namespace ShoeInventoryApp.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private readonly IPurchaseOrderService _poService;

        public PurchaseOrderController(IPurchaseOrderService poService)
        {
            _poService = poService;
        }

        public IActionResult Index()
        {
            var orders = _poService.GetAllOrders();
            return View(orders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PurchaseOrder order)
        {
            if (ModelState.IsValid)
            {
                _poService.AddOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        public IActionResult Details(int id)
        {
            var order = _poService.GetOrderById(id);
            if (order == null) return NotFound();
            return View(order);
        }

        public IActionResult Edit(int id)
        {
            var order = _poService.GetOrderById(id);
            if (order == null) return NotFound();
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PurchaseOrder order)
        {
            if (ModelState.IsValid)
            {
                _poService.UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        public IActionResult Delete(int id)
        {
            var order = _poService.GetOrderById(id);
            if (order == null) return NotFound();
            return View(order);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _poService.DeleteOrder(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
