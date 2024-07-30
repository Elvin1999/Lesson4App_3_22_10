using Lesson4App.Data;
using Lesson4App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson4App.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ProductDBContext _context;

        public IndexModel(ProductDBContext context)
        {
            _context = context;
        }

        public List<Entities.Product> Products { get; set; }
        public void OnGet(string info = "")
        {
            Products = _context.Products.ToList();
            Info = info;
        }

        public string Info { get; set; }

        [BindProperty]
        public Entities.Product Product { get; set; }

        public IActionResult OnPost()
        {
            if (Product != null)
            {
                _context.Products.Add(Product);
                _context.SaveChanges();
                Info = $"{Product.Name} added successfuly";
                return RedirectToPage("Index", new { info = Info });
            }
            return RedirectToPage("Index", new { info = "Data is null" });
        }
    }
}
