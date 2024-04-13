namespace VP.DesignPatterns.Command;

public class TurnOffCommand : ICommand
{
    readonly TVReceiver _tvReceiver;
    public TurnOffCommand(TVReceiver tvReceiver)
    {
        _tvReceiver = tvReceiver;
    }

    public void Execute()
    {
        _tvReceiver.TurnOff();
    }

    public void Undo()
    {
        _tvReceiver.TurnOn();
    }
}
