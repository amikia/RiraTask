using Microsoft.AspNetCore.Mvc;
using RiraTask.WebApp.ViewModels;
using Services;
using AutoMapper;
using Entities;

namespace RiraTask.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IActionResult ProductsOfCategoryOne()
        {
            var products = _productService.GetProductsFromCategoryOne();
            var productViewModels = _mapper.Map<List<ProductViewModel>>(products);

            var viewModel = new ProductListViewModel
            {
                Products = productViewModels,
            };

            return View(viewModel);
        }

        public IActionResult SortByCategory()
        {
            var products = _productService.OrderProductsByCategory();

            var productViewModels = _mapper.Map<List<ProductViewModel>>(products);

            var viewModel = new ProductListViewModel
            {
                Products = productViewModels,
            };

            return View(viewModel); 
        }

        public IActionResult HighestValue()
        {
            var product = _productService.GetProductWithHighestValue();

            var productViewModels = new List<ProductViewModel>
            {
                _mapper.Map<ProductViewModel>(product) // Map the single product
            };

            var viewModel = new ProductListViewModel
            {
                Products = productViewModels,
            };

            return View(viewModel);
        }

        public IActionResult SumOfPrices()
        {
            var totalPrice = _productService.ProductsValuesSum();
            
            return View(totalPrice);
        }

        public IActionResult AveragePrice()
        {
            var averagePrice = _productService.ProductsAverageValue();

            return View(averagePrice);
        }
    }
}
