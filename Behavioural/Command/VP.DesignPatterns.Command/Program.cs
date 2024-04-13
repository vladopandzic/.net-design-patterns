namespace VP.DesignPatterns.Command;

internal class Program
{
    static void Main(string[] args)
    {
        var tvReceiver = new TVReceiver();

        var turnOnCommand = new TurnOnCommand(tvReceiver);

        var turOffCommand = new TurnOffCommand(tvReceiver);

        Invoker invoker = new Invoker();

        invoker.AddCommand(turnOnCommand);
        invoker.AddCommand(turOffCommand);

        invoker.ExecuteCommands();


        invoker.Undo();
    }
}
