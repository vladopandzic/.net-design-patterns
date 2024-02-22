namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This is concrete implementor in Bridge pattern implementation. This class can be used inside any of concrete
/// abstractions through <see cref="IRemoteControl"/>.
/// </summary>
public class DVDPlayer : ElectronicDevice
{
    public DVDPlayer(IRemoteControl remoteControl) : base(remoteControl)
    {
    }

    public override void ChangeChannel(int channelNumber)
    {
        remoteControl.SwitchToChannel(channelNumber);
    }

    public override void PowerDown()
    {
        remoteControl.PowerOff();
    }

    public override void PowerOn()
    {
        remoteControl.PowerOn();
    }

    public override void VolumeAdjustment(int level)
    {
        remoteControl.AdjustVolume(level);
    }
}
