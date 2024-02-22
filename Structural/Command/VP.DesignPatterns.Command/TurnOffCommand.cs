using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.DesignPatterns.Command;

internal class TurnOffCommand : ICommand
{
    readonly TVReceiver _tvReceiver;
    public TurnOffCommand(TVReceiver tvReceiver)
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
