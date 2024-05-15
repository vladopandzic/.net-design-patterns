namespace VP.DesignPatterns.Iterator;

public class Library : IBookCollection
{
    private readonly List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IIterator<Book> GetEnumerator()
    {
        return new BookIterator(_books);
    }
}
