namespace VP.DesignPatterns.Observer.Example2;

public class EngineEcu : IEcu
{
    public void ReceiveData(string data)
    {
        Console.WriteLine($"Engine Control Unit received data: {data}");
    }
}
