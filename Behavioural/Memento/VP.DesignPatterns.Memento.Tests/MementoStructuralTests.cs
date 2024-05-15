namespace VP.DesignPatterns.Memento.Tests;


[TestFixture]
public class MementoStructuralTests
{
    [Test]
    public void Editor_CreateMemento_ReturnsMementoWithCorrectState()
    {
        // Arrange
        var editor = new Editor("Initial Content", "Arial", 12);

        // Act
        var memento = editor.CreateMemento();

        // Assert
        Assert.That(memento.GetSavedContent(), Is.EqualTo("Initial Content"));
        Assert.That(memento.GetSavedFont(), Is.EqualTo("Arial"));
        Assert.That(memento.GetSavedFontSize(), Is.EqualTo(12));
    }

    [Test]
    public void Editor_Restore_RestoresStateFromMemento()
    {
        // Arrange
        var editor = new Editor("Initial Content", "Arial", 12);
        var memento = new EditorMemento("New Content", "Times New Roman", 14);

        // Act
        editor.Restore(memento);

        // Assert
        Assert.That(editor.GetContent(), Is.EqualTo("New Content"));
        Assert.That(editor.GetFont(), Is.EqualTo("Times New Roman"));
        Assert.That(editor.GetFontSize(), Is.EqualTo(14));
    }

    [Test]
    public void History_Save_AddsMementoToHistory()
    {
        // Arrange
        var history = new EditorHistory();
        var memento = new EditorMemento("Content", "Arial", 12);

        // Act
        history.Save(memento);

        // Assert
        Assert.That(history.GetMementosCount(), Is.EqualTo(1));
    }

    [Test]
    public void History_Undo_RestoresStateToPreviousMemento()
    {
        // Arrange
        var editor = new Editor("Initial Content", "Arial", 12);
        var history = new EditorHistory();
        var memento1 = new EditorMemento("Content 1", "Arial", 12);
        var memento2 = new EditorMemento("Content 2", "Times New Roman", 14);
        history.Save(memento1);
        history.Save(memento2);

        // Act
        _ = history.Undo();
        var restoredMemento = history.Undo();

        editor.Restore(restoredMemento!);

        // Assert
        Assert.That(editor.GetContent(), Is.EqualTo("Content 1"));
        Assert.That(editor.GetFont(), Is.EqualTo("Arial"));
        Assert.That(editor.GetFontSize(), Is.EqualTo(12));
    }
}
