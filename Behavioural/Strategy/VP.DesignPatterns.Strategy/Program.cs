namespace VP.DesignPatterns.Strategy;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Vehicle(new NormalDrivingStrategy());
        car.Drive();

        Console.ReadKey();
    }
}
