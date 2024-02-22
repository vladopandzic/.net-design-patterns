namespace VP.DesignPatterns.Command;


internal class TurnOnCommand : ICommand
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
