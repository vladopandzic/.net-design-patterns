namespace VP.DesignPatterns.Command;

/// <summary>
/// Example on one concrete command. Implements <see cref="ICommand"/> like all commands. 
/// Methods for executing or undoing can actually be simple. They can just call methods on receiver. <see cref="TVReceiver"/> in this case.
/// Receiver as dependency is retrived from constructor.
/// </summary>
public class TurnOnCommand : ICommand
{
    readonly TVReceiver _tvReceiver;

    public TurnOnCommand(TVReceiver tvReceiver)
    {
        _tvReceiver = tvReceiver;
    }

    public void Execute()
    {
        _tvReceiver.TurnOn();
    }

    public void Undo()
    {
        _tvReceiver.TurnOff();
    }
}
