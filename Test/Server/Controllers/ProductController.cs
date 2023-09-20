using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        [HttpGet]
        public IEnumerable<ProductResponseModel> Get()
        {
            //FileProvider.SaveDataBase(_context.Genres, "DB_Genres");


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
