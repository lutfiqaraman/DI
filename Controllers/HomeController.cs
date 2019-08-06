using BasicTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;

namespace BasicTool.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValueCalculator _ValueCalculator;

        private Product[] products = {
            new Product { Name = "Kayak", Category = "Watersports", Price = 250M},
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 50.05M},
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 20.00M},
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M},
        };

        public HomeController(IValueCalculator ValueCalculator)
        {
            _ValueCalculator = ValueCalculator;
        }

        // GET: Home
        public ActionResult Index()
        {
            decimal totalValue =  _ValueCalculator.ValueProducts(products);

            return View(totalValue);
        }
    }
}