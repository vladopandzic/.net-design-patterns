using VP.DesignPatterns.AbstractMethodFactory.Example1;
using VP.DesignPatterns.AbstractMethodFactory.Example2;

namespace VP.DesignPatterns.AbstractMethodFactory;

internal class Program
{
    static void Main(string[] args)
    {
        ICarCreator factoryCreator = new LuxuryCarCreator();

        var seat = factoryCreator.InstallSeats();

        var dashboard = factoryCreator.DisplayDashboard();

        var engine = factoryCreator.StartEngine();

        seat.ChooseMaterial();

        dashboard.Display();

        engine.Start();

        Console.ReadKey();

        GUIFactory guiFactory = new WindowsGUIFactory();

        GUIApplication app = new GUIApplication(guiFactory);

        app.CreateUI();

        app.Button.Paint();

        app.Checkbox.Paint();

        Console.ReadKey();

    }
}
