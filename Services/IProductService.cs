using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IProductService
    {
        List<Product> GetProductsFromCategoryOne();
        Product GetProductWithHighestValue();
        int ProductsValuesSum();
        List<Product> OrderProductsByCategory();
        double ProductsAverageValue();
    }
}
