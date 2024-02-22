namespace VP.DesignPatterns.Bridge.Example2;

/// <summary>
/// This is concrete implementor. Implements implementor, in this case <see cref="IColor"/>.
/// </summary>
public class RedColor : IColor
{
    public string FillColor()
    {
        return "Filled with Red color.";
    }
}
