namespace VP.DesignPatterns.Facade;

public class Dashboard
{
    public void Display(string message)
    {
        Console.WriteLine($"Dashboard: {message}");
    }
}