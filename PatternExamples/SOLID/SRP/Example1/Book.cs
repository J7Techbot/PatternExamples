namespace SOLID.SRP.Example1
{
    internal class Book
    {
        public string Name;
        public string AuthorName;
        public int Year;
        public int Price;
        public string Isbn;

        public Book(string name, string authorName, int year, int price, string isbn)
        {
            Name = name;
            AuthorName = authorName;
            Year = year;
            Price = price;
            Isbn = isbn;
        }
    }
}
