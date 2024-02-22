using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.DesignPatterns.Facade;
public class Transmission
{
    public void ShiftGear(int gear)
    {
        Console.WriteLine($"Gear shifted to {gear}.");
    }
}
