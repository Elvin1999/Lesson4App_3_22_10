using Lesson4App.Data;
using Lesson4App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson4App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDBContext _context;

        public HomeController(ProductDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Select(p => new ProductViewModel { Name = p.Name, Price = p.Price });
            var categories = _context.Categories.Select(c => new CategoryViewModel { Title = c.Title });

            var vm = new ProductCategoryListViewModel
            {
                Categories = categories,
                Products = products
            };

            return View(vm);
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
}
