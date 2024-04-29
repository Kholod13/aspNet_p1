using Microsoft.AspNetCore.Mvc;
using UseThi.Data;
using UseThi.Data.Entities;

namespace UseThi.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShopDbContext _context;

        public ProductsController(ShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var category = _context.Categories.Find(model.CategoryId);
                if (category == null)
                {
                    return NotFound("Category not found");
                }
                model.Category = category;
                _context.Products.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var item = _context.Products.Find(id);
            if (item == null) return NotFound();

            if (item.Quantity <= 1)
            {
                _context.Products.Remove(item);
            }
            else
            {
                item.Quantity--;
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
