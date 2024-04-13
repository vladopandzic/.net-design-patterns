using NSubstitute;

namespace VP.DesignPatterns.Command.Tests;

public class Tests
{
    [Test]
    public void ICommand_Implemented_By_Command_Classes()
    {
        // Arrange
        var turnOnCommand = new TurnOnCommand(new TVReceiver());
        var turnOffCommand = new TurnOffCommand(new TVReceiver());

        // Act & Assert
        Assert.That(turnOnCommand, Is.InstanceOf<ICommand>());
        Assert.That(turnOffCommand, Is.InstanceOf<ICommand>());
    }

    [Test]
    public void ICommand_Requires_Execute_And_Undo_Methods()
    {
        // Arrange
        var commandInterface = typeof(ICommand);

        // Act & Assert
        Assert.That(commandInterface.GetMethod("Execute"), Is.Not.Null);
        Assert.That(commandInterface.GetMethod("Undo"), Is.Not.Null);
    }

    [Test]
    public void Command_Accepts_Receiver_And_Calls_Its_Method()
    {
        // Arrange
        var tvReceiver = new TVReceiver();
        var turnOnCommand = new TurnOnCommand(tvReceiver);
        var expectedOutput = "Turn on";

        // Act
        var sw = new StringWriter();
        Console.SetOut(sw);
        turnOnCommand.Execute();
        var actualOutput = sw.ToString().Trim();

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Command_Accepts_Receiver_And_Calls_Method()
    {
        // Arrange
        var mockReceiver = Substitute.For<TVReceiver>();
        var turnOnCommand = new TurnOnCommand(mockReceiver);

        // Act
        turnOnCommand.Execute();

        // Assert
        mockReceiver.Received(1).TurnOn();
    }

    [Test]
    public void Commands_Executed_In_Correct_Order()
    {
        // Arrange
        var mockReceiver = Substitute.For<TVReceiver>();
        var invoker = new Invoker();
        var turnOnCommand = new TurnOnCommand(mockReceiver);
        var turnOffCommand = new TurnOffCommand(mockReceiver);

        // Act
        invoker.AddCommand(turnOnCommand);
        invoker.AddCommand(turnOffCommand);
        invoker.ExecuteCommands();

        // Assert
        Received.InOrder(() =>
        {
            mockReceiver.TurnOn();
            mockReceiver.TurnOff();
        });
    }

    [Test]
    public void Execute_Commands_And_Undo_Them()
    {
        // Arrange
        var mockReceiver = Substitute.For<TVReceiver>();
        var invoker = new Invoker();
        var turnOnCommand = new TurnOnCommand(mockReceiver);
        var turnOffCommand = new TurnOffCommand(mockReceiver);

        // Act
        invoker.AddCommand(turnOnCommand);
        invoker.AddCommand(turnOffCommand);
        invoker.ExecuteCommands();

        // Undo commands
        invoker.Undo();

        // Assert
        Received.InOrder(() =>
        {
            mockReceiver.TurnOn();
            mockReceiver.TurnOff();
            mockReceiver.TurnOn(); // Undo should turn on again
        });
    }
}