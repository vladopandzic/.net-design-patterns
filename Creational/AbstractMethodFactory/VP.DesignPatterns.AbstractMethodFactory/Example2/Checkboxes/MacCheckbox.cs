namespace VP.DesignPatterns.AbstractMethodFactory.Example2.Checkboxes;

public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Painting mac checkbox");
    }
}
