namespace VP.DesignPatterns.FactoryMethod;

public class AlwaysBikeCreator : VehicleCreator
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}
