using Newtonsoft.Json;
using Test.Shared;

namespace Test.Server.Helper
{
    public static class Initialization
    {
        public static List<Product> GetProducts()
        {
            var products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(GetPath("DB_Products")));
            return products;
        }
        public static List<Genre> GetGenres()
        {
            var genres = JsonConvert.DeserializeObject<List<Genre>>(File.ReadAllText(GetPath("DB_Genres")));
            return genres;
        }
        public static string GetPath(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, fileName);
        }
    }
}
