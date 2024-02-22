using VP.DesignPatterns.Composite.Example1;

namespace VP.DesignPatterns.Composite.Tests.Example1;

public class CompositePatternExample1Tests
{
    private StringWriter _stringWriter;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [Test]
    public void MenuItem_Should_Display_Itself()
    {
        // Arrange
        IMenuItem menuItem = new MenuItem("Main Menu", new List<IMenuItem>());

        // Act
        string output = CaptureConsoleOutput(() => menuItem.Display());

        // Assert
        Assert.That(output, Is.EqualTo("Main Menu"));
    }

    [Test]
    public void LeafMenuItem_Should_Display_Itself()
    {
        // Arrange
        IMenuItem leafMenuItem = new LeafMenuItem("Settings");

        // Act
        string output = CaptureConsoleOutput(() => leafMenuItem.Display());

        // Assert
        Assert.That(output, Is.EqualTo("Settings"));
    }

    [Test]
    public void MenuItem_Should_Display_Children_Recursively()
    {
        // Arrange
        var subMenu = new MenuItem("Sub Menu", new List<IMenuItem> { new LeafMenuItem("Option 1"), new LeafMenuItem("Option 2") });

        // Act
        string output = CaptureConsoleOutput(() => subMenu.Display());

        // Assert
        Assert.That(output, Does.Contain("Option 1"));
        Assert.That(output, Does.Contain("Option 2"));
        Assert.That(output, Does.Contain("Sub Menu"));
    }

    private string CaptureConsoleOutput(Action action)
    {
        using(StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            action.Invoke();
            return sw.ToString().Trim();
        }
    }
}