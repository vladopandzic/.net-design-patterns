namespace VP.DesignPatterns.Iterator;

internal class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        // Add books to the library
        library.AddBook(new Book("Book1", "Author1"));
        library.AddBook(new Book("Book2", "Author2"));
        library.AddBook(new Book("Book3", "Author3"));

        var iterator = library.GetEnumerator();

        // Iterate over the books and print their titles and authors
        do
        {
            var currentBook = iterator.Current;
            Console.WriteLine($"Title: {currentBook.Title}, Author: {currentBook.Author}");
        } while (iterator.MoveNext());

        Console.ReadKey();
    }
}
