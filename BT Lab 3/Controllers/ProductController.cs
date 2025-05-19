using BT_Lab_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT_Lab_3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Sample Product",
                Price = 19.99m
            };
            return View(product);
        }
    }
}
