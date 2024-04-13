namespace VP.DesignPatterns.Command.Tests;

public class CommandPatternTests
{
    [Test]
    public void Invoker_Executes_And_Undoes_Commands_Correctly()
    {
        // Arrange
        var tvReceiver = new TVReceiver();
        var invoker = new Invoker();
        var turnOnCommand = new TurnOnCommand(tvReceiver);
        var turnOffCommand = new TurnOffCommand(tvReceiver);

        // Act
        invoker.AddCommand(turnOnCommand);
        invoker.AddCommand(turnOffCommand);

        // Assert - Commands executed
        var expectedOutput = "Turn on\r\nTurn off\r\n";
        Assert.That(GetConsoleOutput(() => invoker.ExecuteCommands()), Is.EqualTo(expectedOutput));

        // Act - Undo commands

        // Assert - Commands undone
        Assert.That(GetConsoleOutput(() => invoker.Undo()), Is.EqualTo("Turn on\r\n"));
    }

    private string GetConsoleOutput(Action action)
    {
        StringWriter sw = new StringWriter();

        Console.SetOut(sw);
        action.Invoke();
        return sw.ToString();
    }
}
