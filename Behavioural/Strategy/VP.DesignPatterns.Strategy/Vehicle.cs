namespace VP.DesignPatterns.Strategy;

public class Vehicle
{
    private IDrivingStrategy _drivingStrategy;

    public Vehicle(IDrivingStrategy drivingStrategy)
    {
        _drivingStrategy = drivingStrategy;
    }

    public void SetDrivingStrategy(IDrivingStrategy drivingStrategy)
    {
        _drivingStrategy = drivingStrategy;
    }

    public void Drive()
    {
        _drivingStrategy.Drive();
    }
}
