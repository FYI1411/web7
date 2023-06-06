using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web7.Data;

namespace web7.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _context;

        public ProductController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            try
            {
                var product = _context.Products.Find(Id);
                return View(product);
            }
            catch
            {
            }

            return View();
        }

        public IActionResult product(int categoryId)
        {
            try
            {
                var product = _context.Products.Where(p => p.CategoryId == categoryId);
                return View(product);
            }
            catch
            {
            }

            return View();
        }

        public IActionResult listProduct(int Id)
        {
            var prolist = _context.Products.Where(p => p.CategoryId == Id).ToList();
            return View(prolist);
        }

    }
}
