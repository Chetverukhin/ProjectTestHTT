namespace Test.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public string Author { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set;}
    }
}
