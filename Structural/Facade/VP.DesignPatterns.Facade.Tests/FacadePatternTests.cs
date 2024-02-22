namespace VP.DesignPatterns.Facade.Tests;

public class FacadePatternTests
{
    private StringWriter _consoleOutput;
    private TextWriter _originalConsoleOutput;

    [SetUp]
    public void Setup()
    {
        _consoleOutput = new StringWriter();
        _originalConsoleOutput = Console.Out;
        Console.SetOut(_consoleOutput);
    }

    [TearDown]
    public void Cleanup()
    {
        _consoleOutput.Dispose();
        Console.SetOut(_originalConsoleOutput);
    }

    [Test]
    public void CarFacade_Should_Have_Methods_To_Start_And_Stop_Car()
    {
        // Arrange
        var carFacade = new CarFacade();

        // Act & Assert
        Assert.That(() => carFacade.StartCar(), Throws.Nothing);
        Assert.That(() => carFacade.StopCar(), Throws.Nothing);
    }

    [Test]
    public void CarFacade_StartCar_Should_Start_Engine_Shift_Gear_And_Display_Success_Message_On_Dashboard()
    {
        // Arrange
        var carFacade = new CarFacade();

        // Act
        carFacade.StartCar();

        // Assert
        string expectedOutput = "Engine started.\r\nGear shifted to 1.\r\nDashboard: Car started.\r\n";
        Assert.That(_consoleOutput.ToString(), Is.EqualTo(expectedOutput));
    }

    [Test]
    public void CarFacade_StopCar_Should_Stop_Engine_And_Display_Success_Message_On_Dashboard()
    {
        // Arrange
        var carFacade = new CarFacade();

        // Act
        carFacade.StopCar();

        // Assert
        string expectedOutput = "Engine stopped.\r\nDashboard: Car stopped.\r\n";
        Assert.That(_consoleOutput.ToString(), Is.EqualTo(expectedOutput));
    }
}