namespace VP.DesignPatterns.Bridge.Example2;

/// <summary>
/// This class in abstraction. Any refined abstraction like <see cref="Circle"/> implement this abstract class
/// Each has reference to implementor which is <see cref="IColor"/> but doesn't have to reference concrete implementor and
/// abstractions and implementations can vary independately.
/// </summary>
public abstract class Shape
{
    protected readonly IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract string Draw();

}
