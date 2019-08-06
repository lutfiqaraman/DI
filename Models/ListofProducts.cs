using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicTool.Models
{
    public class ListofProducts
    {
        

        public Product[] products = {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M},
        };
    }
}