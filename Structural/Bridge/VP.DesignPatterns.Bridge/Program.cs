using VP.DesignPatterns.Bridge.Example1;
using VP.DesignPatterns.Bridge.Example2;

namespace VP.DesignPatterns.Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        var electronicDevice = new TV(new AdvancedRemoteControl());

        electronicDevice.PowerOn();

        var shape = new Circle(new BlueColor());

        var result = shape.Draw();

        Console.WriteLine(result);

        Console.ReadKey();

    }
}
