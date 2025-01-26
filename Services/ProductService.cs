using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly MockProductRepository _mockProductRepository;
        public ProductService()
        {
            _mockProductRepository = new MockProductRepository();
        }

        #region sync methods

        public List<Product> GetProductsFromCategoryOne()
        {
            // Basically saying that find me products ("p" is like an instance of product) that their category attribute is Category1 

            var result = _mockProductRepository.Products.Where(p => p.Category == Categories.Category1).ToList();
            return result;
        }

        public Product GetProductWithHighestValue()
        {
            // Products in the list are sorted by price value in decending way so the product with highest value should be the first one

            var result = _mockProductRepository.Products.OrderByDescending(p => p.Price).FirstOrDefault();
            return result;
        }

        public List<Product> OrderProductsByCategory()
        {
            // This query sorts the products list by category name
            // The order is Alphabetical (a-z, 1-9). 

            return _mockProductRepository.Products.OrderBy(p => p.Category).ToList();
        }

        public double ProductsAverageValue()
        {
            // Average method calculates avarage price on price column 

            return _mockProductRepository.Products.Average(p => p.Price);
        }

        public int ProductsValuesSum()
        {
            // Sum method calculates total price of all products 
            // Summation of all products prices

            return _mockProductRepository.Products.Sum(p => p.Price);
        }

        #endregion
    }
}
