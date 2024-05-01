using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Utilities;
using System.Text.Json;
using UseThi.Data;
using UseThi.Extensions;
using UseThi.Models;

namespace UseThi.Controllers
{
    public class CartController : Controller
    {
        private readonly ShopDbContext context;
        public CartController(ShopDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>("cart");
            if(ids == null ) ids = new List<int>();

            var entities = context.Products.Where(x => ids.Contains(x.Id)).ToList();
            var list = new List<ProductCartModel>();

            foreach (var entity in entities)
            {
                var model = new ProductCartModel
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Price = entity.Price,
                    Quantity = entity.Quantity,
                    Description = entity.Description,
                    Discount = entity.Discount,
                    ImageUrl = entity.ImageUrl,
                    Status = entity.Status,
                    Location = entity.Location,
                    Contact = entity.Contact,
                    Category = entity.Category,
                };

                list.Add(model);
            }

            return View(list);
        }
        public IActionResult Append(int id)
        {
            var ids = HttpContext.Session.Get<List<int>>("cart");

            if (ids == null) ids = new List<int>();

            ids.Add(id);

            HttpContext.Session.Set("cart", id);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            return View();
        }
        public IActionResult Clear()
        {
            return View();
        }
    }
}
