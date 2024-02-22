namespace VP.DesignPatterns.Decorator.Tests;

public class DecoratorPatternTests
{
    [Test]
    public void BasicCar_Assemble_Should_Print_Basic_Car_Assembled()
    {
        // Arrange
        ICar basicCar = new BasicCar();
        string expectedOutput = "Basic Car Assembled";

        // Act
        string actualOutput = GetConsoleOutput(() => basicCar.Assemble());

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput).IgnoreCase);
    }

    [Test]
    public void SportsCarDecorator_Assemble_Should_Print_Sports_Car_Features_After_Basic_Car_Assembled()
    {
        // Arrange
        ICar sportsCar = new SportsCarDecorator(new BasicCar());
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
            Console.SetOut(consoleOutput);
            action.Invoke();
            return consoleOutput.ToString().Trim();
        }
    }
}
