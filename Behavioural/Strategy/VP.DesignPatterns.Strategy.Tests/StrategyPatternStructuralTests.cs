namespace VP.DesignPatterns.Strategy.Tests;

public class StrategyPatternStructuralTests
{
    [Test]
    public void DrivingStrategies_Implement_IDrivingStrategy_Interface()
    {
        // Arrange
        var normalDrivingStrategy = new NormalDrivingStrategy();
        var defensiveDrivingStrategy = new DefensiveDrivingStrategy();
        var aggressiveDrivingStrategy = new AggressiveDrivingStrategy();

        // Act & Assert
        Assert.IsInstanceOf<IDrivingStrategy>(normalDrivingStrategy);
        Assert.IsInstanceOf<IDrivingStrategy>(defensiveDrivingStrategy);
        Assert.IsInstanceOf<IDrivingStrategy>(aggressiveDrivingStrategy);
    }

    [Test]
    public void Strategies_Can_Be_Changed_At_Runtime()
    {
        // Arrange
        var vehicle1 = new Vehicle(new NormalDrivingStrategy());
        var vehicle2 = new Vehicle(new DefensiveDrivingStrategy());

        // Act
        var sw = new StringWriter();
        Console.SetOut(sw);
        vehicle1.Drive();
        vehicle2.Drive();
        var output = sw.ToString().Trim();

        // Assert
        StringAssert.Contains("Driving normally.", output);
        StringAssert.Contains("Driving defensively.", output);
    }
}