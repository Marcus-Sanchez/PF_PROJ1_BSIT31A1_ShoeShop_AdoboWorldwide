using Microsoft.AspNetCore.Mvc;
using ShoeInventoryApp.Models;
using ShoeInventoryApp.Services;

namespace ShoeInventoryApp.Controllers
{
    public class ShoeController : Controller
    {
        private readonly IShoeService _shoeService;

        public ShoeController(IShoeService shoeService)
        {
            _shoeService = shoeService;
        }

        public IActionResult Index()
        {
            var shoes = _shoeService.GetAllShoes();
            return View(shoes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Shoe shoe)
        {
            if (ModelState.IsValid)
            {
                _shoeService.AddShoe(shoe);
                return RedirectToAction(nameof(Index));
            }
            return View(shoe);
        }

        public IActionResult Details(int id)
        {
            var shoe = _shoeService.GetShoeById(id);
            if (shoe == null) return NotFound();
            return View(shoe);
        }

        public IActionResult Edit(int id)
        {
            var shoe = _shoeService.GetShoeById(id);
            if (shoe == null) return NotFound();
            return View(shoe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Shoe shoe)
        {
            if (ModelState.IsValid)
            {
                _shoeService.UpdateShoe(shoe);
                return RedirectToAction(nameof(Index));
            }
            return View(shoe);
        }

        public IActionResult Delete(int id)
        {
            var shoe = _shoeService.GetShoeById(id);
            if (shoe == null) return NotFound();
            return View(shoe);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _shoeService.DeleteShoe(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
