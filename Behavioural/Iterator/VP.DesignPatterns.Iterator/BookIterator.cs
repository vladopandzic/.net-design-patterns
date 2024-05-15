namespace VP.DesignPatterns.Iterator;

public class BookIterator : IIterator<Book>
{
    private readonly List<Book> _items;
    private int _index = 0;

    public BookIterator(List<Book> items)
    {
        _items = items;
    }

    public Book Current => _items[_index];

    public bool MoveNext()
    {
        _index++;
        return _index < _items.Count;
    }
}
