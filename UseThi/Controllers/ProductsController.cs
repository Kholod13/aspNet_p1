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
    }
}
