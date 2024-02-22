namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This class is known in Bridge pattern as abstaction. Concrete or refined abstractions will implement <see
/// cref="ElectronicDevice"/>. Notice how <see cref="ElectronicDevice"/> has reference to <see cref="IRemoteControl"/>,
/// and not concrete implementations.
/// </summary>
public abstract class ElectronicDevice
{
    protected IRemoteControl remoteControl;

    protected ElectronicDevice(IRemoteControl remoteControl)
    {
        this.remoteControl = remoteControl;
    }

    public void SetRemoteControl(IRemoteControl remoteControl)
    {
        this.remoteControl = remoteControl;
    }

    public abstract void PowerOn();

    public abstract void PowerDown();

    public abstract void VolumeAdjustment(int level);

    public abstract void ChangeChannel(int channelNumber);
}
