using VP.DesignPatterns.AbstractMethodFactory.Example1;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Dashboard;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

namespace VP.DesignPatterns.AbstractMethodFactory.Tests.Example1;
public class AbstractMethodFactoryPatternExample1Tests
{
    [Test]
    public void LuxuryCarCreator_Should_Create_HybridEngine()
    {
        // Arrange
        ICarCreator luxuryCarCreator = new LuxuryCarCreator();
        string expectedOutput = "Hybrid engine started";

        // Act
        IEngine engine = luxuryCarCreator.StartEngine();

        // Assert
        Assert.That(engine, Is.Not.Null);
        Assert.That(GetConsoleOutput(() => engine.Start()), Is.EqualTo(expectedOutput).IgnoreCase);
    }

    [Test]
    public void LuxuryCarCreator_Should_Create_DigitalDashboard()
    {
        // Arrange
        ICarCreator luxuryCarCreator = new LuxuryCarCreator();
        string expectedOutput = "Displaying digital dashboard";

        // Act
        IDashboard dashboard = luxuryCarCreator.DisplayDashboard();

        // Assert
        Assert.That(dashboard, Is.Not.Null);
        Assert.That(GetConsoleOutput(() => dashboard.Display()), Is.EqualTo(expectedOutput).IgnoreCase);
    }

    [Test]
    public void LuxuryCarCreator_Should_Create_LeatherSeats()
    {
        // Arrange
        ICarCreator luxuryCarCreator = new LuxuryCarCreator();
        string expectedOutput = "Leather seats installed.";

        // Act
        ISeat seats = luxuryCarCreator.InstallSeats();

        // Assert
        Assert.That(seats, Is.Not.Null);
        Assert.That(GetConsoleOutput(() => seats.ChooseMaterial()), Is.EqualTo(expectedOutput).IgnoreCase);
    }

    private string GetConsoleOutput(Action action)
    {
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);

        action.Invoke();

        return consoleOutput.ToString().Trim();
    }
}
