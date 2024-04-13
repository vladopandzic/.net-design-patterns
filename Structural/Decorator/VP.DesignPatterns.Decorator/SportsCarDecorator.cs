namespace VP.DesignPatterns.Decorator;

public class SportsCarDecorator : CarDecorator
{
    public SportsCarDecorator(ICar decoratedCar) : base(decoratedCar)
    {
    }

    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Adding Sports Car Features: Racing Stripes, Spoiler");
    }
}
