using VP.DesignPatterns.AbstractMethodFactory.Example1.Dashboard;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

namespace VP.DesignPatterns.AbstractMethodFactory.Example1;

public class LuxuryCarCreator : ICarCreator
{
    public IDashboard DisplayDashboard()
    {
        return new DigitalDashboard();
    }

    public ISeat InstallSeats()
    {
        return new LeatherSeat();
    }

    public IEngine StartEngine()
    {
        return new HybridEngine();
    }
}
