using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.DesignPatterns.Command;

/// <summary>
/// Actual class that does some work. Each command will usually have <see cref="ICommand.Execute"/> method that will
/// call one of this method. or methods from other receivers.
/// </summary>
public class TVReceiver
{
    public void TurnOn()
    {
        Console.WriteLine("Turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off");
    }
}
