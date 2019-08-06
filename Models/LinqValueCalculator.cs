using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicTool.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            var total = products.Sum(x => x.Price);
            return total;
        }
    }
}