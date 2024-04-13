using NSubstitute;
using System.Reflection;
using VP.DesignPatterns.Observer.Example1;

namespace VP.DesignPatterns.Observer.Tests.Example1;

public class ObserverStructuralTests
{
    [Test]
    public void Car_Has_List_Of_ISpeedMonitor_Observers()
    {
        // Arrange
        var car = new Car();

        // Act

        // Assert
        Assert.That(car.GetType().GetField("_speedMonitors", BindingFlags.NonPublic | BindingFlags.Instance), Is.Not.Null);
        Assert.That(car.GetType().GetField("_speedMonitors", BindingFlags.NonPublic | BindingFlags.Instance).FieldType, Is.EqualTo(typeof(List<ISpeedMonitor>)));
    }

    [Test]
    public void Attaching_Observer_Adds_It_To_Car()
    {
        // Arrange
        var car = new Car();
        var observer = new PoliceRadar(60);

        // Act
        car.Attach(observer);

        // Assert
        Assert.Contains(observer, GetSpeedMonitors(car));
    }

    [Test]
    public void Detaching_Observer_Removes_It_From_Car()
    {
        // Arrange
        var car = new Car();
        var observer = new PoliceRadar(60);
        car.Attach(observer);

        // Act
        car.Detach(observer);

        // Assert
        Assert.IsEmpty(GetSpeedMonitors(car));
    }

    [Test]
    public void Speed_Change_Notifies_Observers()
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
    public void Multiple_Observers_Are_Notified()
    {
        // Arrange
        var car = new Car();
        var observers = new List<ISpeedMonitor> { Substitute.For<ISpeedMonitor>(), Substitute.For<ISpeedMonitor>(), Substitute.For<ISpeedMonitor>() };

        foreach (var observer in observers)
        {
            car.Attach(observer);
        }

        // Act
        car.Speed = 70;

        // Assert
        foreach (var observer in observers)
        {
            observer.Received().Update(70);
        }
    }

    [Test]
    public void Detaching_Observer_Stops_Notification()
    {
        // Arrange
        var car = new Car();
        var observer = Substitute.For<ISpeedMonitor>();
        car.Attach(observer);

        // Act
        car.Detach(observer);
        car.Speed = 70;

        // Assert
        observer.DidNotReceive().Update(Arg.Any<int>());
    }

    [Test]
    public void Updating_With_Same_Value_No_Unnecessary_Notification()
    {
        // Arrange
        var car = new Car();
        var observer = Substitute.For<ISpeedMonitor>();
        car.Attach(observer);

        // Act
        car.Speed = 70; // Speed changed to trigger notification
        car.Speed = 70; // Speed changed to same value again

        // Assert
        observer.Received(1).Update(70); // Observer should only be notified once
    }

    private List<ISpeedMonitor> GetSpeedMonitors(Car car)
    {
        var speedMonitorsField = car.GetType().GetField("_speedMonitors", BindingFlags.NonPublic | BindingFlags.Instance);
        return (List<ISpeedMonitor>)speedMonitorsField!.GetValue(car)!;
    }
}
