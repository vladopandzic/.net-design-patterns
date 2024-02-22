namespace VP.DesignPatterns.AbstractMethodFactory.Example1.Dashboard;

public class AnalogDashboard : IDashboard
{
    public void Display()
    {
        Console.WriteLine("Displaying analog dashboard");
    }
}
