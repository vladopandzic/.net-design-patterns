namespace VP.DesignPatterns.Bridge.Example2;

//This class behaves as so called refined abstraction inside Bridge pattern,
public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override string Draw()
    {
        return $"Drawing Circle. {color.FillColor()}";
    }
}
