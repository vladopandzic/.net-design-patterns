namespace VP.DesignPatterns.Memento;

internal class Program
{
    static void Main(string[] args)
    {
        var editor = new Editor("Initial Content", "Arial", 12);
        var history = new EditorHistory();

        history.Save(editor.CreateMemento());

        // Perform operation to change font and font size
        editor.ChangeFont("Times New Roman", 14);
        history.Save(editor.CreateMemento());

        editor.ChangeFont("Verdana", 16);
        history.Save(editor.CreateMemento());

        Console.WriteLine("Current content: " + editor.GetContent());
        Console.WriteLine("Current font: " + editor.GetFont());
        Console.WriteLine("Current font size: " + editor.GetFontSize());

        // Restore to previous state
        _ = history.Undo();
        var lastMemento = history.Undo();

        editor.Restore(lastMemento!);

        Console.WriteLine("\nRestored content: " + editor.GetContent());
        Console.WriteLine("Restored font: " + editor.GetFont());
        Console.WriteLine("Restored font size: " + editor.GetFontSize());


        var previous = history.Undo();

        editor.Restore(previous!);

        Console.WriteLine("\nRestored content: " + editor.GetContent());
        Console.WriteLine("Restored font: " + editor.GetFont());
        Console.WriteLine("Restored font size: " + editor.GetFontSize());
    }
}
