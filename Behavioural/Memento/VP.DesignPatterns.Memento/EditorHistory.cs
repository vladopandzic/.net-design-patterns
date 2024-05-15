namespace VP.DesignPatterns.Memento;

/// <summary>
/// Caretaker class
/// </summary>
public class EditorHistory
{
    private readonly Stack<EditorMemento> _mementos = new Stack<EditorMemento>();

    public void Save(EditorMemento memento)
    {
        _mementos.Push(memento);
    }

    public EditorMemento? Undo()
    {
        if (_mementos.Any())
        {
            return _mementos.Pop();
        }
        return null;
    }

    public int GetMementosCount()
    {
        return _mementos.Count;
    }
}
