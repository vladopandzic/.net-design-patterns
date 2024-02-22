namespace VP.DesignPatterns.FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        VehicleCreator factoryCreator = new AlwaysBikeCreator();

        var vehicle = factoryCreator.CreateVehicle();

        vehicle.Drive();

        Console.ReadKey();
    }
}
