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
        #region sync methods
        
        List<Product> GetProductsFromCategoryOne();
        Product GetProductWithHighestValue();
        int ProductsValuesSum();
        List<Product> OrderProductsByCategory();
        double ProductsAverageValue();

        #endregion

        // As there is no database and EF Core there is no use in writing async methods
    }
}
