using System;
using System.Collections.Generic;
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

        public ProductService(MockProductRepository mockProductRepository)
        {
            _mockProductRepository = mockProductRepository;
        }

        public List<Product> GetProductsFromCategoryOne()
        {
            var result = _mockProductRepository.Products.Where(p => p.Category == Categories.Category1).ToList();
            return result;
        }

        public Product GetProductWithHighestValue()
        {
            var result = _mockProductRepository.Products.OrderByDescending(p => p.Price).FirstOrDefault();
            return result;
        }

        public List<Product> OrderProductsByCategory()
        {
            return _mockProductRepository.Products.OrderBy(p => p.Category).ToList();
        }

        public double ProductsAverageValue()
        {
            return _mockProductRepository.Products.Average(p => p.Price);
        }

        public int ProductsValuesSum()
        {
            return _mockProductRepository.Products.Sum(p => p.Price);
        }
    }
}
