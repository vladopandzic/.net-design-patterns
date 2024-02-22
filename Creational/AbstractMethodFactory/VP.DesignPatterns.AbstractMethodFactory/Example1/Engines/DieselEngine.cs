namespace VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;

public class DieselEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Diesel engine started");
    }
}
