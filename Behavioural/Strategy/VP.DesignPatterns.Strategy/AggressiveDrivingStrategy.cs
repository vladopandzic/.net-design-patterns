namespace VP.DesignPatterns.Strategy;

public class AggressiveDrivingStrategy : IDrivingStrategy
{
    public void Drive()
    {
        Console.WriteLine("Driving aggressively.");
    }
}
