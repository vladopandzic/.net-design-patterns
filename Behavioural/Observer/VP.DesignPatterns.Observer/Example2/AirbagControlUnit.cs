namespace VP.DesignPatterns.Observer.Example2;

public class AirbagControlUnit : IEcu
{
    public void ReceiveData(string data)
    {
        Console.WriteLine($"Airbag Control Unit received data: {data}");
    }
}
