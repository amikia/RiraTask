using Microsoft.AspNetCore.Mvc;
using Services;

namespace RiraTask.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Product()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
