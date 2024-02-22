namespace VP.DesignPatterns.Decorator.Tests;

public class DecoratorPatternStructuralTests
{
    [Test]
    public void BasicCar_Should_Implement_ICar_Interface()
    {
        // Arrange & Act
        var basicCar = new BasicCar();

        // Assert
        Assert.That(basicCar, Is.InstanceOf<ICar>());
    }

    [Test]
    public void CarDecorator_Should_Implement_ICar_Interface()
    {
        // Arrange & Act
        var carDecorator = new CarDecorator(new BasicCar());

        // Assert
        Assert.That(carDecorator, Is.InstanceOf<ICar>());
    }

    [Test]
    public void SportsCarDecorator_Should_Override_Assemble_Behavior()
    {
        // Arrange
        var basicCar = new BasicCar();
        var sportsCar = new SportsCarDecorator(basicCar);
        string expectedOutput = "Basic Car Assembled\r\nAdding Sports Car Features: Racing Stripes, Spoiler";

        // Act
        string actualOutput = GetConsoleOutput(() => sportsCar.Assemble());

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput).IgnoreCase);
    }

    private string GetConsoleOutput(Action action)
    {
        using (var consoleOutput = new System.IO.StringWriter())
        {
            System.Console.SetOut(consoleOutput);
            action.Invoke();
            return consoleOutput.ToString().Trim();
        }
    }
}