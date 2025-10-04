using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PF.Web.Models;
using PF.Web.Services;

namespace PF.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    private readonly IShoeService _shoeService;
    private readonly ISupplierService _supplierService;
    private readonly IPurchaseOrderService _purchaseOrderService;
    private readonly IShoeColorVariationService _shoeColorVariationService;

    public HomeController(ILogger<HomeController> logger, AppDbContext context, IShoeService shoeService, ISupplierService supplierService, IPurchaseOrderService purchaseOrderService, IShoeColorVariationService shoeColorVariationService)
    {
        _logger = logger;
        _context = context;
        _shoeService = shoeService;
        _supplierService = supplierService;
        _purchaseOrderService = purchaseOrderService;
        _shoeColorVariationService = shoeColorVariationService;
    }

    public IActionResult Index()
    {
        // Create dashboard data
        var dashboardData = new
        {
            TotalShoes = _context.Shoes.Count(),
            TotalStock = _context.ShoeColorVariations.Sum(s => s.Stock),
            TotalSuppliers = _context.Suppliers.Count(),
            TotalPurchaseOrders = _context.PurchaseOrders.Count(),
            LowStockItems = _context.ShoeColorVariations.Where(s => s.Stock < 5).Count(),
            RecentShoes = _context.Shoes.OrderByDescending(s => s.Id).Take(5).ToList(),
            TopBrands = _context.Shoes.GroupBy(s => s.Brand)
                                    .Select(g => new { Brand = g.Key, Count = g.Count() })
                                    .OrderByDescending(x => x.Count)
                                    .Take(5)
                                    .ToList(),
            LowStockVariations = _context.ShoeColorVariations
                                       .Include(s => s.Shoe)
                                       .Where(s => s.Stock < 5)
                                       .OrderBy(s => s.Stock)
                                       .Take(10)
                                       .ToList()
        };
        
        ViewBag.DashboardData = dashboardData;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
