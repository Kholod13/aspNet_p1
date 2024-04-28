using Microsoft.AspNetCore.Mvc;
using UseThi.Data;
using UseThi.Data.Entities;

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

        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                // Отримання об'єкта категорії за допомогою її ідентифікатора
                var category = context.Categories.Find(model.CategoryId);
                // Перевірка, чи категорія існує
                if (category == null)
                {
                    // Обробка помилки - категорія не знайдена
                    return NotFound("Category not found");
                }
                // Встановлення об'єкта категорії для продукту
                model.Category = category;
                // Додавання продукту та збереження змін у базі даних
                context.Products.Add(model);
                context.SaveChanges();
                // Повернення користувача на сторінку списку продуктів
                return RedirectToAction(nameof(Index));
            }
            // Якщо модель недійсна, повертаємо користувача на сторінку створення продукту з повідомленням про помилку
            return View(model);
        }



        public IActionResult Delete(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return NotFound();

            if (item.Quantity <= 1)
            {
                context.Products.Remove(item);
            }
            else
            {
                item.Quantity--;
            }
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
