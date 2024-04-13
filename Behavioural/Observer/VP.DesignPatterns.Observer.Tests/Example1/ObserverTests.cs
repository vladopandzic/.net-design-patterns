using NSubstitute;
using VP.DesignPatterns.Observer.Example1;

namespace VP.DesignPatterns.Observer.Tests.Example1;

public class ObserverTests
{
    [Test]
    public void Car_Notifies_Observer_On_Speed_Change()
    {
        // Arrange
        var car = new Car();
        var observer = Substitute.For<ISpeedMonitor>();
        car.Attach(observer);

        // Act
        car.Speed = 70;

        // Assert
        observer.Received().Update(70);
    }

    [Test]
    public void Car_Notifies_Multiple_Observers_On_Speed_Change()
    {
        // Arrange
        var car = new Car();
        var observer1 = Substitute.For<ISpeedMonitor>();
        var observer2 = Substitute.For<ISpeedMonitor>();
        car.Attach(observer1);
        car.Attach(observer2);

        // Act
        car.Speed = 80;

        // Assert
        observer1.Received().Update(80);
        observer2.Received().Update(80);
    }

    [Test]
    public void Car_Does_Not_Notify_Observer_After_Detachment()
    {
        // Arrange
        var car = new Car();
        var observer = Substitute.For<ISpeedMonitor>();
        car.Attach(observer);

        // Act
        car.Detach(observer);
        car.Speed = 90;

        // Assert
        observer.DidNotReceive().Update(Arg.Any<int>());
    }

    [Test]
    public void Car_Notifies_Observer_Only_Once_On_Same_Speed()
    {
        // Arrange
        var car = new Car();
        var observer = Substitute.For<ISpeedMonitor>();
        car.Attach(observer);

        // Act
        car.Speed = 100;
        car.Speed = 100;

        // Assert
        observer.Received(1).Update(100);
    }
}