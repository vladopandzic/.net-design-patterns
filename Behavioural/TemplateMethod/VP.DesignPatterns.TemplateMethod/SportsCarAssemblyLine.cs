using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.DesignPatterns.TemplateMethod;
public class SportsCarAssemblyLine : CarAssemblyLine
{
    protected override void InstallBody()
    {
        Console.WriteLine("Installing sports car body.");
    }

    protected override void InstallChassis()
    {
        Console.WriteLine("Installing sports car chassis.");
    }

    protected override void InstallElectonics()
    {
        Console.WriteLine("Installing sports car electronics.");
    }

    protected override void InstallEngine()
    {
        Console.WriteLine("Installing sports car engine.");
    }
}
