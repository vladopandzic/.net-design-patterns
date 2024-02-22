namespace VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Painting windows checkbox");
    }
}
