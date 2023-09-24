using Numbers;
using Library;

namespace MyNameSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Author author = new(name: "Crow", age: 22);
            Book book = new(name: "My Book", author: author, rating: 22.5f);

            Console.WriteLine(book.AuthorName);
            Console.WriteLine(book.AuthorAge);

        }
    }
}