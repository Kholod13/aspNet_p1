using Microsoft.AspNetCore.Mvc;
using UseThi.Data.Entities;
using UseThi.Data;

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

    [HttpGet] // Додали атрибут [HttpGet] для відображення форми створення
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost] // Використовуємо [HttpPost] для обробки даних форми при створенні продукту
    public IActionResult Create(Product model)
    {
        var category = _context.Categories.Find(model.CategoryId);
        if (category == null)
        {
            return NotFound("Category not found");
        }
        model.Category = category;
        if (model.ImageUrl == null)
        {
            model.ImageUrl = "https://static.vecteezy.com/system/resources/previews/004/141/669/original/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg";
        }
        if (model.Name == null)
        {
            model.Name = "None";
        }
        _context.Products.Add(model);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

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
