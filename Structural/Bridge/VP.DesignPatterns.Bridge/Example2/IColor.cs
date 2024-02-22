namespace VP.DesignPatterns.Bridge.Example2;

/// <summary>
/// This class as what Bridge pattern calls implementor. Abstraction keep reference to instance of this type.
/// </summary>
public interface IColor
{
    string FillColor();
}
