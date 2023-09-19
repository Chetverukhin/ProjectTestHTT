using Microsoft.AspNetCore.Mvc;
using Test.Server.Data;

namespace Test.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ProjectDdContext _context;

        public ProductController(ProjectDdContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
