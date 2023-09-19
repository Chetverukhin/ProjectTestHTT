namespace Test.Shared
{
    public class Genre
    {
        public string GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public Genre()
        {
            Products = new List<Product>();
        }
    }
}
