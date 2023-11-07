using ArchitectureSkeleton.Contract.Handler;
using ArchitectureSkeleton.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArchitectureSkeleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productHandler;

        public ProductController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productHandler.GetAllProducts();
            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productHandler.GetProductById(id);
            return Ok(product);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post(Product product)
        {
            _productHandler.CreateAndUpdateProduct(product);
        }
    }
}
