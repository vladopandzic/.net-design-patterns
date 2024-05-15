namespace VP.DesignPatterns.Memento;

/// <summary>
/// Memento
/// </summary>
public class EditorMemento
{
    private readonly string _savedContent;

    private readonly string _savedFont;

    private readonly int _savedFontSize;

    public EditorMemento(string content, string font, int fontSize)
    {
        _savedContent = content;
        _savedFont = font;
        _savedFontSize = fontSize;
    }

    public string GetSavedContent()
    {
        return _savedContent;
    }

    public string GetSavedFont()
    {
        return _savedFont;
    }

    public int GetSavedFontSize()
    {
        return _savedFontSize;
    }
}
