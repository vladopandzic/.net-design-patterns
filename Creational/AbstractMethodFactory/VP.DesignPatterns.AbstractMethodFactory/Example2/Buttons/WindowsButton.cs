namespace VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Painting windows button");
    }
}
