using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Server.Data;
using Test.Shared;

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
            //var model = _context.Products.Join(_context.Genres,
            //    p => p.ProductId,
            //    g => g.GenreId,
            //    (p, g) => new ProductModel
            //    {
            //        Name = p.Name,
            //        Cost = p.Cost,
            //        Author = p.Author,
            //        GenreName = g.GenreName
            //    });
            return View();
        }
    }
    public class ProductModel
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Author { get; set; }
        public string GenreName { get; set; }
    }
}
