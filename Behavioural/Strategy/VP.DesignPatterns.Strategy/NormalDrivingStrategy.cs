namespace VP.DesignPatterns.Strategy;

public class NormalDrivingStrategy : IDrivingStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving normally.");
    }
}
