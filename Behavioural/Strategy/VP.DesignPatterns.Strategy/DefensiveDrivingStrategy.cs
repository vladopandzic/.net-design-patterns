namespace VP.DesignPatterns.Strategy;

public class DefensiveDrivingStrategy : IDrivingStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving defensively.");
    }
}
