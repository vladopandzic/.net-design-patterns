namespace VP.DesignPatterns.AbstractMethodFactory.Example2.Buttons;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Painting mac button");
    }
}
