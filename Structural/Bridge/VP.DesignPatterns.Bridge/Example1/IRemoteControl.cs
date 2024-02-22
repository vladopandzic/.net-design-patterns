namespace VP.DesignPatterns.Bridge.Example1;

/// <summary>
/// This class is known as Implementor inside Bridge pattern.
/// </summary>
public interface IRemoteControl
{
    /// <summary>
    /// Powers on device. Class implementing implementor (can be more than one) implements this methods. "Abstraction" will
    /// have reference to this interface and call this methods.
    /// </summary>
    void PowerOn();

    /// <summary>
    /// Powers off device. Class implementing implementor (can be more than one) implements this methods. "Abstraction" will
    /// have reference to this interface and call this methods.
    /// </summary>
    void PowerOff();

    /// <summary>
    /// Adjust volume. Class implementing implementor (can be more than one) implements this methods. "Abstraction" will
    /// have reference to this interface and call this methods.
    /// </summary>
    void AdjustVolume(int level);

    /// <summary>
    /// Switch channel. Class implementing implementor (can be more than one) implements this methods. "Abstraction" will
    /// have reference to this interface and call this methods.
    /// </summary>
    void SwitchToChannel(int channelNumber);
}
