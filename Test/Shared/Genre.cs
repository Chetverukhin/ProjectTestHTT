namespace Test.Shared
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public Genre()
        {
            Products = new List<Product>();
        }
    }
}
