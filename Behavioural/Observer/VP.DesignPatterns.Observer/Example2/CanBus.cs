namespace VP.DesignPatterns.Observer.Example2;
public class CanBus
{
    private readonly List<IEcu> _ecus = new List<IEcu>();

    public void Attach(IEcu ecu)
    {
        _ecus.Add(ecu);
    }

    public void Detach(IEcu ecu)
    {
        _ecus.Remove(ecu);
    }

    public void TransmitData(string data)
    {
        Console.WriteLine($"CAN Bus transmitting data: {data}");
        NotifyDataReceived(data);
    }

    public void NotifyDataReceived(string data)
    {
        foreach (var ecu in _ecus)
        {
            ecu.ReceiveData(data);

        }
    }
}
