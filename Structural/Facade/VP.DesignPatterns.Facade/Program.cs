namespace VP.DesignPatterns.Facade;

internal class Program
{
    static CarFacade _carFacade;

    static void Main(string[] args)
    {
        _carFacade = new CarFacade();

        _carFacade.StartCar();

        _carFacade.StopCar();

        Console.ReadKey();
    }
}
