using VP.DesignPatterns.AbstractMethodFactory.Example1;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Dashboard;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Engines;
using VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

namespace VP.DesignPatterns.AbstractMethodFactory.Tests.Example1;

public class AbstractFactoryPatternStructuralTests
{
    [Test]
    public void Each_Concrete_Factory_Should_Implement_Factory_Interface()
    {
        // Arrange
        var luxuryCarCreator = new LuxuryCarCreator();

        // Act & Assert
        Assert.IsTrue(luxuryCarCreator is ICarCreator, "LuxuryCarCreator should implement ICarCreator interface");
    }

    [Test]
    public void Each_Product_Should_Correctly_Implement_Respective_Interface()
    {
        // Arrange
        var analogDashboard = new AnalogDashboard();
        var digitalDashboard = new DigitalDashboard();
        var dieselEngine = new DieselEngine();
        var hybridEngine = new HybridEngine();
        var fabricSeat = new FabricSeat();
        var leatherSeat = new LeatherSeat();

        // Act & Assert
        Assert.IsTrue(analogDashboard is IDashboard, "AnalogDashboard should implement IDashboard interface");
        Assert.IsTrue(digitalDashboard is IDashboard, "DigitalDashboard should implement IDashboard interface");
        Assert.IsTrue(dieselEngine is IEngine, "DieselEngine should implement IEngine interface");
        Assert.IsTrue(hybridEngine is IEngine, "HybridEngine should implement IEngine interface");
        Assert.IsTrue(fabricSeat is ISeat, "FabricSeat should implement ISeat interface");
        Assert.IsTrue(leatherSeat is ISeat, "LeatherSeat should implement ISeat interface");
    }

    [Test]
    public void Concrete_Factory_Returns_Correct_Interface_Types()
    {
        // Arrange
        var luxuryCarCreator = new LuxuryCarCreator();

        // Act
        var dashboard = luxuryCarCreator.DisplayDashboard();
        var engine = luxuryCarCreator.StartEngine();
        var seats = luxuryCarCreator.InstallSeats();

        // Assert
        Assert.IsNotNull(dashboard);
        Assert.IsNotNull(engine);
        Assert.IsNotNull(seats);
        Assert.IsTrue(dashboard is IDashboard, "Dashboard should be of type IDashboard");
        Assert.IsTrue(engine is IEngine, "Engine should be of type IEngine");
        Assert.IsTrue(seats is ISeat, "Seats should be of type ISeat");
    }
}