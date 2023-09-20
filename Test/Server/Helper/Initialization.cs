using Newtonsoft.Json;
using Test.Shared;

namespace Test.Server.Helper
{
    public static class Initialization
    {
        private static readonly string _producstFileName = "DB_Products.json";

        private static readonly string _genresFileName = "DB_Genres.json";

        public static List<Product>? GetProducts()
        {
            return File.Exists(_producstFileName)
                        ? JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(_producstFileName))
                        : new List<Product>();
        }

        public static List<Genre>? GetGenres()
        {
            return File.Exists(_genresFileName)
                        ? JsonConvert.DeserializeObject<List<Genre>>(File.ReadAllText(_genresFileName))
                        : new List<Genre>();
        }
    }
}
