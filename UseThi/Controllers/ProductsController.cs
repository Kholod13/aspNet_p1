using Microsoft.AspNetCore.Mvc;
using UseThi.Data;

namespace UseThi.Controllers
{
    public class ProductsController : Controller
    {
        private ShopDbContext context;
        public ProductsController()
        {
            context = new ShopDbContext();
        }


        public IActionResult Index()
        {
            //get products form Db
            var products = context.Products.ToList();

            return View(products);
        }
        public IActionResult Delete(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return NotFound();

            context.Products.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
