namespace VP.DesignPatterns.Bridge.Example2;

/// <summary>
/// This is concrete implementor. Implements implementor, in this case <see cref="IColor"/>.
/// </summary>
public class BlueColor : IColor
{
    public string FillColor()
    {
        return "Filled with Blue color.";
    }
}
