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
