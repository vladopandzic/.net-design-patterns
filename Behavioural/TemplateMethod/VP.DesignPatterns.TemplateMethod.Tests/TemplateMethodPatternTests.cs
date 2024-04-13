namespace VP.DesignPatterns.TemplateMethod.Tests;


public class TemplateMethodPatternTests
{
    private StringWriter stringWriter;

    [SetUp]
    public void Setup()
    {
        stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
    }

    [TearDown]
    public void TearDown()
    {
        stringWriter.Dispose();
    }

    [Test]
    public void Car_Assembly_Process_Completes_Successfully()
    {
        // Arrange
        CarAssemblyLine assemblyLine = new SportsCarAssemblyLine();
        var expectedOutput = new List<string>
        {
            "Installing sports car chassis.",
            "Installing sports car engine.",
            "Installing sports car body.",
            "Installing sports car electronics.",
            "Painting car...",
        };

        // Act
        assemblyLine.AssembleCar();

        // Assert
        var actualOutput = stringWriter.ToString().Trim().Split("\r\n").Select(line => line.Trim());
        Assert.That(actualOutput, Is.EquivalentTo(expectedOutput), "Printed statements should match the expected sequence.");
    }
}