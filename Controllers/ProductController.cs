using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductModel>
        {
                new ProductModel { ID = 1, Name = "Wooden Chair", Price = 50.00m, CreatedDate = DateTime.Now.AddDays(-1) },
                new ProductModel { ID = 2, Name = "Coffee Table", Price = 120.00m, CreatedDate = DateTime.Now.AddDays(-2) },
                new ProductModel { ID = 3, Name = "Sofa Set", Price = 350.00m, CreatedDate = DateTime.Now },
                new ProductModel { ID = 4, Name = "Bookshelf", Price = 80.50m, CreatedDate = DateTime.Now.AddDays(-8) },
                new ProductModel { ID = 5, Name = "Lamp Stand", Price = 25.75m, CreatedDate = DateTime.Now.AddDays(-3) }
        };

            return View(products);
        }
    }
}
