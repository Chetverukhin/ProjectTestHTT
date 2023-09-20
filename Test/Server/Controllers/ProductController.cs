using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Test.Server.Data;
using Test.Server.Helper;
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

        [HttpGet]
        public IEnumerable<ProductResponseModel> Get()
        {
            if (_context.Products.IsNullOrEmpty())
            {
                _context.Products.AddRangeAsync(Initialization.GetProducts());
                _context.SaveChanges();
            }

            if (_context.Genres.IsNullOrEmpty())
            {
                _context.Genres.AddRangeAsync(Initialization.GetGenres());
                _context.SaveChanges();
            }


            var model = _context.Products.Join(_context.Genres,
                p => p.GenreId,
                g => g.Id,
                (p, g) => new ProductResponseModel
                {
                    ProductName = p.ProductName,
                    Cost = p.Cost,
                    Author = p.Author,
                    GenreName = g.GenreName
                });

            return model.ToList();
        }
    }
}
