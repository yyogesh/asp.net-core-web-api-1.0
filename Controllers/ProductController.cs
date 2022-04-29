using Microsoft.AspNetCore.Mvc;
using webapi_core_project.Data;

namespace webapi_core_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("/controller/[action]")]
        public ActionResult<List<Product>> Get()
        {
            return _context.Products.ToList();
        }
    }
}