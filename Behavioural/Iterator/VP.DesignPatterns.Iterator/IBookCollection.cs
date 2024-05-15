namespace VP.DesignPatterns.Iterator;

public interface IBookCollection
{
    IIterator<Book> GetEnumerator();
}
