namespace VP.DesignPatterns.FactoryMethod.Tests;

public class FactoryMethodPatternStructuralTests
{
    [Test]
    public void VehicleCreator_Is_Abstract()
    {
        // Arrange & Act
        Type vehicleCreatorType = typeof(VehicleCreator);

        // Assert
        Assert.IsTrue(vehicleCreatorType.IsAbstract || vehicleCreatorType.IsInterface);
    }

    [Test]
    public void VehicleCreator_Has_FactoryMethod()
    {
        // Arrange & Act
        Type vehicleCreatorType = typeof(VehicleCreator);
        var factoryMethod = vehicleCreatorType.GetMethod("CreateVehicle");

        // Assert
        Assert.IsNotNull(factoryMethod);
    }

    [Test]
    public void VehicleCreator_Creates_Vehicles()
    {
        // Arrange
        var creator = new AlwaysBikeCreator();

        // Act
        IVehicle vehicle = creator.CreateVehicle();

        // Assert
        Assert.IsNotNull(vehicle);
    }

    [Test]
    public void EachVehicle_Implements_IVehicle_Interface()
    {
        // Arrange & Act
        Type carType = typeof(Car);
        Type bikeType = typeof(Bike);
        Type boatType = typeof(Boat);

        // Assert
        Assert.IsTrue(typeof(IVehicle).IsAssignableFrom(carType));
        Assert.IsTrue(typeof(IVehicle).IsAssignableFrom(bikeType));
        Assert.IsTrue(typeof(IVehicle).IsAssignableFrom(boatType));
    }
}
