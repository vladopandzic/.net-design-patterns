using NSubstitute;
using VP.DesignPatterns.Observer.Example2;

namespace VP.DesignPatterns.Observer.Tests.Example2;
public class ObserverExample2Tests
{
    [Test]
    public void CanBus_Transmits_Data_To_Attached_ECUs()
    {
        // Arrange
        var canBus = new CanBus();
        var airbagEcu = Substitute.For<IEcu>();
        var engineEcu = Substitute.For<IEcu>();
        canBus.Attach(airbagEcu);
        canBus.Attach(engineEcu);

        // Act
        canBus.TransmitData("Engine error: low oil pressure");

        // Assert
        airbagEcu.Received().ReceiveData("Engine error: low oil pressure");
        engineEcu.Received().ReceiveData("Engine error: low oil pressure");
    }

    [Test]
    public void CanBus_Notifies_Multiple_ECUs_On_Data_Transmission()
    {
        // Arrange
        var canBus = new CanBus();
        var ecus = new List<IEcu>
            {
                Substitute.For<IEcu>(),
                Substitute.For<IEcu>(),
                Substitute.For<IEcu>()
            };
        foreach (var ecu in ecus)
        {
            canBus.Attach(ecu);
        }

        // Act
        canBus.TransmitData("Airbag deployment: front left");

        // Assert
        foreach (var ecu in ecus)
        {
            ecu.Received().ReceiveData("Airbag deployment: front left");
        }
    }

    [Test]
    public void CanBus_Detaches_ECU_Stopped_Notification()
    {
        // Arrange
        var canBus = new CanBus();
        var engineEcu = Substitute.For<IEcu>();
        canBus.Attach(engineEcu);

        // Act
        canBus.Detach(engineEcu);
        canBus.TransmitData("Engine error: overheating");

        // Assert
        engineEcu.DidNotReceive().ReceiveData(Arg.Any<string>());
    }
}
