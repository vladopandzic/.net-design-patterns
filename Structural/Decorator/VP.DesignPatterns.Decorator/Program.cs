namespace VP.DesignPatterns.Decorator;

internal class Program
{
    static void Main(string[] args)
    {
        ICar basicCar = new BasicCar();

        ICar sportsCar = new SportsCarDecorator(basicCar);
        sportsCar.Assemble();

        Console.ReadKey();
    }
}
