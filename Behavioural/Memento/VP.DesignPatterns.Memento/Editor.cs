namespace VP.DesignPatterns.Memento;

/// <summary>
/// Originator
/// </summary>
public class Editor
{
    private string _content;

    private string _font;

    private int _fontSize;

    public Editor(string content, string font, int fontSize)
    {
        _content = content;
        _font = font;
        _fontSize = fontSize;
    }

    public string GetContent()
    {
        return _content;
    }

    public string GetFont()
    {
        return _font;
    }

    public int GetFontSize()
    {
        return _fontSize;
    }

    public void ChangeFont(string font, int fontSize)
    {
        _font = font;
        _fontSize = fontSize;
    }

    public EditorMemento CreateMemento()
    {
        return new EditorMemento(_content, _font, _fontSize);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.GetSavedContent();
        _font = memento.GetSavedFont();
        _fontSize = memento.GetSavedFontSize();
    }
}
