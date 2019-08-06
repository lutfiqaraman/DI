using System.Collections.Generic;

namespace BasicTool.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}