namespace VP.DesignPatterns.Decorator;

public class BasicCar : ICar
{
    public void Assemble()
    {
        Console.WriteLine("Basic Car Assembled");
    }
}
