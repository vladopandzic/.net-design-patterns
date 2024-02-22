using VP.DesignPatterns.AbstractMethodFactory.Example2;

namespace VP.DesignPatterns.AbstractMethodFactory.Tests.Example2;

public class AbstractFactoryMethodFactoryExample2Tests
{
    [Test]
    public void MacGUIFactory_Should_Create_MacButton_And_MacCheckbox()
    {
        // Arrange
        GUIApplication app = new GUIApplication(new MacGUIFactory());
        string expectedButtonOutput = "Painting mac button";
        string expectedCheckboxOutput = "Painting mac checkbox";

        // Act
        app.CreateUI();

        // Assert
        Assert.That(app.Button, Is.Not.Null);
        Assert.That(app.Checkbox, Is.Not.Null);
        Assert.That(() => GetConsoleOutput(() => app.Button.Paint()), Is.EqualTo(expectedButtonOutput).IgnoreCase);
        Assert.That(() => GetConsoleOutput(() => app.Checkbox.Paint()), Is.EqualTo(expectedCheckboxOutput).IgnoreCase);
    }

    [Test]
    public void WindowsGUIFactory_Should_Create_WindowsButton_And_WindowsCheckbox()
    {
        // Arrange
        GUIApplication app = new GUIApplication(new WindowsGUIFactory());
        string expectedButtonOutput = "Painting windows button";
        string expectedCheckboxOutput = "Painting windows checkbox";

        // Act
        app.CreateUI();

        // Assert
        Assert.That(app.Button, Is.Not.Null);
        Assert.That(app.Checkbox, Is.Not.Null);
        Assert.That(() => GetConsoleOutput(() => app.Button.Paint()), Is.EqualTo(expectedButtonOutput).IgnoreCase);
        Assert.That(() => GetConsoleOutput(() => app.Checkbox.Paint()), Is.EqualTo(expectedCheckboxOutput).IgnoreCase);
    }

    private string GetConsoleOutput(Action action)
    {
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);

        action.Invoke();

        return consoleOutput.ToString().Trim();
    }
}
