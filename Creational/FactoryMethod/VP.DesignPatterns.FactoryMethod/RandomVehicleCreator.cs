namespace VP.DesignPatterns.FactoryMethod;

public class RandomVehicleCreator : VehicleCreator
{
    private Random _random;

    public RandomVehicleCreator()
    {
        _random = new Random();
    }

    public override IVehicle CreateVehicle()
    {
        switch (_random.Next(1, 4))
        {
            case 1:
                return new Car();
            case 2:
                return new Bike();
            case 3:
                return new Boat();
            default:
                throw new InvalidOperationException("Invalid random number generated.");
        }
    }
}