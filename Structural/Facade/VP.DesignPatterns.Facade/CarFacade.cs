namespace VP.DesignPatterns.Facade;

public class CarFacade
{
    private readonly Engine _engine;
    private readonly Transmission _transmission;
    private readonly Dashboard _dashboard;

    public CarFacade()
    {
        _engine = new Engine();
        _transmission = new Transmission();
        _dashboard = new Dashboard();
    }

    public void StartCar()
    {
        _engine.Start();
        _transmission.ShiftGear(1);
        _dashboard.Display("Car started.");
    }

    public void StopCar()
    {
        _engine.Stop();
        _dashboard.Display("Car stopped.");
    }
}
