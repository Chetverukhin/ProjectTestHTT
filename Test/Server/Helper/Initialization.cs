using Newtonsoft.Json;
using Test.Shared;

namespace Test.Server.Helper
{
    public static class Initialization
    {
        public static List<Product> GetProducts()
        {
            return JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("DB_Products.json")).Select(p => new Product
            {
                ProductName = p.ProductName,
                Cost = p.Cost,
                Author = p.Author,
                GenreId = p.GenreId,
            }).ToList();
        }

        public static List<Genre> GetGenres()
        {
            var genresName = new[] { "Детектив", "Фантастика", "Фентези", "Проза" };

            var genres = new List<Genre>();
            foreach (var genre in genresName)
            {
                genres.Add(new Genre
                {
                    GenreName = genre,
                    Description = string.Empty,
                });
            }

            return genres;
        }
        public static string GetPath(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, fileName);
        }
    }
}
