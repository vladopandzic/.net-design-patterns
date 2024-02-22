namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This is concrete implementor. Implements <see cref="IRemoteControl"/> and abstraction will in the end call methods
/// of this class.
/// </summary>
public class BasicRemoteControl : IRemoteControl
{
    public void AdjustVolume(int level)
    {
        Console.WriteLine($"Adjusting volume level to {level} using basic remote control.");
    }

    public void PowerOff()
    {
        Console.WriteLine("Turning off device ON using basic remote control.");
    }

    public void PowerOn()
    {
        Console.WriteLine("Turning the device ON using basic remote control.");
    }

    public void SwitchToChannel(int channelNumber)
    {
        Console.WriteLine($"Switching to channel {channelNumber} using basic remote control.");
    }
}
