using VP.DesignPatterns.AbstractMethodFactory.Example1.Dashboard;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

namespace VP.DesignPatterns.AbstractMethodFactory.Example1;

public interface ICarCreator
{
    IEngine StartEngine();

    IDashboard DisplayDashboard();

    ISeat InstallSeats();
}
