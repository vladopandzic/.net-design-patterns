namespace VP.DesignPatterns.FactoryMethod.Tests;

public class FactoryMethodPatternTests
{
    [Test]
    public void AlwaysBikeCreator_Returns_Bike()
    {
        // Arrange
        var creator = new AlwaysBikeCreator();

        // Act
        IVehicle vehicle = creator.CreateVehicle();

        // Assert
        Assert.IsNotNull(vehicle);
        Assert.IsInstanceOf<Bike>(vehicle);
    }

    [Test]
    public void RandomVehicleCreator_Returns_Car_Or_Bike_Or_Boat()
    {
        // Arrange
        var creator = new RandomVehicleCreator();

        // Act
        IVehicle vehicle = creator.CreateVehicle();

        // Assert
        Assert.IsNotNull(vehicle);
        Assert.That(vehicle, Is.InstanceOf<Car>().Or.InstanceOf<Bike>().Or.InstanceOf<Boat>());
    }

    [Test]
    public void Car_Can_Be_Driven()
    {
        // Arrange
        var car = new Car();

        // Act
        var sw = new StringWriter();
        Console.SetOut(sw);
        car.Drive();

        // Assert
        Assert.That(sw.ToString(), Does.Contain("Driving car"));
    }
}