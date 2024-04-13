namespace VP.DesignPatterns.Strategy.Tests;

public class StrategyPatternTests
{
    [Test]
    public void Vehicle_Drives_With_Normal_Strategy_After_Switching_Back()
    {
        // Arrange
        var vehicle = new Vehicle(new DefensiveDrivingStrategy());
        var expectedOutput1 = "Driving defensively.";
        var expectedOutput2 = "Driving normally.";

        // Act
        var sw = new StringWriter();
        Console.SetOut(sw);
        vehicle.Drive();
        var actualOutput1 = sw.ToString().Trim();

        // Assert
        Assert.That(actualOutput1, Is.EqualTo(expectedOutput1));

        // Act (switching back to normal strategy)
        sw = new StringWriter();
        Console.SetOut(sw);
        vehicle.SetDrivingStrategy(new NormalDrivingStrategy());
        vehicle.Drive();
        var actualOutput2 = sw.ToString().Trim();

        // Assert
        Assert.That(actualOutput2, Is.EqualTo(expectedOutput2));
    }


    [Test]
    public void Vehicle_Can_Switch_Between_Driving_Strategies()
    {
        // Arrange
        var vehicle = new Vehicle(new NormalDrivingStrategy());
        var expectedOutput1 = "Driving defensively.";
        var expectedOutput2 = "Driving aggressively.";

        // Act
        var sw = new StringWriter();
        Console.SetOut(sw);
        vehicle.SetDrivingStrategy(new DefensiveDrivingStrategy());
        vehicle.Drive();
        var actualOutput1 = sw.ToString().Trim();

        // Assert
        Assert.That(actualOutput1, Is.EqualTo(expectedOutput1));

        // Act (switching to another strategy)
        sw = new StringWriter();
        Console.SetOut(sw);
        vehicle.SetDrivingStrategy(new AggressiveDrivingStrategy());
        vehicle.Drive();
        var actualOutput2 = sw.ToString().Trim();

        // Assert
        Assert.That(actualOutput2, Is.EqualTo(expectedOutput2));
    }
}
