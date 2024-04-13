namespace VP.DesignPatterns.Observer.Example1;

public class PoliceRadar : ISpeedMonitor
{
    readonly int _speedLimit;
    public PoliceRadar(int speedLimit)
    {
        _speedLimit = speedLimit;
    }

    public void Update(int speed)
    {
        if (speed > _speedLimit)
        {
            Console.WriteLine("Police radar: noticed speeding vehicle");
        }
    }
}
