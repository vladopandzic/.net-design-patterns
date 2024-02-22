namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This class is called inside Bridge pattern as refined abstraction.
/// </summary>
public class TV : ElectronicDevice
{
    public TV(IRemoteControl remoteControl) : base(remoteControl)
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
