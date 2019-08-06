using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicTool.Models
{
    public class ShoppingCart
    {
        private IValueCalculator ValueCalculator;

        public ShoppingCart(IValueCalculator _ValueCalculator)
        {
            ValueCalculator = _ValueCalculator;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return ValueCalculator.ValueProducts(Products);
        }
    }
}