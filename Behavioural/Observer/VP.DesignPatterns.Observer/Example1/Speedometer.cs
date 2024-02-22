namespace VP.DesignPatterns.Observer.Example1;

public class Speedometer : ISpeedMonitor
{
    private readonly int _speedLimit;

    public Speedometer(int speedLimit)
    {
        _speedLimit = speedLimit;
    }

    public void Update(int speed)
    {
        if (speed > _speedLimit)
        {
            Console.WriteLine($"Speed Limit Monitor: Warning! Exceeded speed limit of {_speedLimit} km/h.");
        }
    }
}
