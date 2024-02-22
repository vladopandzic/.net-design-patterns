namespace VP.DesignPatterns.Decorator;

public class CarDecorator : ICar
{
    private readonly ICar _decoratedCar;

    public CarDecorator(ICar decoratedCar)
    {
        _decoratedCar = decoratedCar;
    }

    public virtual void Assemble()
    {
        _decoratedCar.Assemble();
    }
}
