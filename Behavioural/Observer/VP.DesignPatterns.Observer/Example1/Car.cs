namespace VP.DesignPatterns.Observer.Example1;

public class Car
{
    private int _speed;
    private readonly List<ISpeedMonitor> _speedMonitors = new List<ISpeedMonitor>();

    public void Attach(ISpeedMonitor speedMonitor)
    {
        _speedMonitors.Add(speedMonitor);
    }

    public void Detach(ISpeedMonitor speedMonitor)
    {
        _speedMonitors.Remove(speedMonitor);
    }

    public int Speed
    {
        get { return _speed; }
        set
        {
            if (_speed != value)
            {
                _speed = value;
                NotifySpeedChange();
            }
        }
    }

    private void NotifySpeedChange()
    {
        foreach (var speedMonitor in _speedMonitors)
        {
            speedMonitor.Update(Speed);
        }
    }
}
