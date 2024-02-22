namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This is concrete implementor. Methods of this class will call abstaction class since it has reference to <see
/// cref="IRemoteControl"/>.
/// </summary>
public class AdvancedRemoteControl : IRemoteControl
{
    public void AdjustVolume(int level)
    {
        Console.WriteLine($"Modifying volume: {level} with advanced remote control.");
    }

    public void PowerOff()
    {
        Console.WriteLine("Shutting down the device using advanced remote control.");
    }

    public void PowerOn()
    {
        Console.WriteLine("Activating power using advanced remote control.");
    }

    public void SwitchToChannel(int channelNumber)
    {
        Console.WriteLine($"Tuning into channel {channelNumber} using advanced remote control.");
    }
}
