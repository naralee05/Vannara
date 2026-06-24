using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vannara_mvc.Models;

namespace vannara_mvc.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult ProductList()
        {
            List<string> Products = new List<string> { 
                "iPhone 15 Pro Max",
                "MacBook Air M3",
                "Apple Watch Series 9",
                "iPad Pro 2"
            };

            ViewBag.Products = Products;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}