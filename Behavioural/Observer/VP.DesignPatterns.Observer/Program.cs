using VP.DesignPatterns.Observer.Example1;
using VP.DesignPatterns.Observer.Example2;

namespace VP.DesignPatterns.Observer;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        var speedLimit = 100;

        car.Attach(new Speedometer(speedLimit));
        car.Attach(new PoliceRadar(speedLimit));

        car.Speed = 50;

        car.Speed = 110;

        CanBus canBus = new CanBus();

        IEcu engineControlUnit = new EngineEcu();
        canBus.Attach(engineControlUnit);

        IEcu airbagControlUnit = new AirbagControlUnit();
        canBus.Attach(airbagControlUnit);

        canBus.TransmitData("Temperature:90°C");

        canBus.TransmitData("Airbag deployed");

        Console.ReadKey();


    }
}
