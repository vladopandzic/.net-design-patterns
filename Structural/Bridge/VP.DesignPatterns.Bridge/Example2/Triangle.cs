using System.Drawing;

namespace VP.DesignPatterns.Bridge.Example2;

/// <summary>
/// This class behaves as so called refined abstraction inside Bridge pattern.
/// </summary>
public class Triangle : Shape
{
    public Triangle(IColor color) : base(color)
    {
    }

    public override string Draw()
    {
        return $"Drawing Triangle. {color.FillColor()}";
    }
}
