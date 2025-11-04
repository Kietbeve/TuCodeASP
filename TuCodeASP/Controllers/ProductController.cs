using Microsoft.AspNetCore.Mvc;
using TuCodeASP.Domain.Abstract;

namespace TuCodeASP.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepo) {
            _productRepo = productRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            var products = _productRepo.Products;
            return View(products);
        }
    }
}
