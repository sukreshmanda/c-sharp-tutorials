namespace Library
{
    public class Book(string name, Author author, float rating)
    {
        public string Name { get; set; } = name;
        public Author Author { get; set; } = author;
        public float Rating { get; set; } = rating;

        public string AuthorName => Author.Name;
        public float AuthorAge => Author.Age;
    }
}