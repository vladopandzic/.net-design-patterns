namespace VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;

public class HybridEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Hybrid engine started");
    }
}
