namespace VP.DesignPatterns.Iterator;
public interface IIterator<T>
{
    T Current { get; }

    bool MoveNext();
}
