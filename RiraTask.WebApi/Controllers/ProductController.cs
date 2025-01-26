using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace RiraTask.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("ProductsFromCategoryOne")]
        public ActionResult<List<Product>> GetProductsFromCategoryOne()
        {
            var result = _productService.GetProductsFromCategoryOne();
            
            if (result != null) 
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet("OrderByCategory")]
        public ActionResult<List<Product>> OrderProductsByCategory()
        {
            var result = _productService.OrderProductsByCategory();

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }


        [HttpGet("ProductWithHighestValue")]
        public ActionResult<Product> GetProductWithHighestValue()
        {
            var result = _productService.GetProductWithHighestValue();

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet("ProductsValuesSum")]
        public IActionResult ProductsValuesSum()
        {
            var result  = _productService.ProductsValuesSum();
            return Ok( new { TotalProductsPrice = result } );
        }

        [HttpGet("ProductsAverageValue")]
        public IActionResult ProductsAverageValue()
        {
            var result = _productService.ProductsAverageValue();
            return Ok(new { AverageProductPrice = result });
        }
    }
}
