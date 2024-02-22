using NetArchTest.Rules;
using System.IO;
using System.Reflection;
using VP.DesignPatterns.Bridge.Example1;

namespace VP.DesignPatterns.Bridge.Tests.Example1;

public class BridgePatternExample1Tests
{
    private StringWriter _stringWriter;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [Test]
    public void PowerOn_WhenTVWithAdvancedRemoteIsUsed_ShouldCorrectlyBehave()
    {
        //Arrange
        var electronicDevice = new TV(new AdvancedRemoteControl());

        //Act
        electronicDevice.PowerOn();

        //Assert
        string expectedMessage = "Activating power using advanced remote control.";
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo(expectedMessage));
    }

    [Test]
    public void PowerOff_WhenTVWithAdvancedRemoteIsUsed_ShouldCorrectlyBehave()
    {
        //Arrange
        var electronicDevice = new TV(new AdvancedRemoteControl());

        //Act
        electronicDevice.PowerDown();

        //Assert
        string expectedMessage = "Shutting down the device using advanced remote control.";
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo(expectedMessage));
    }

    [Test]
    public void VolumeAdjustment_WhenTVWithAdvancedRemoteIsUsed_ShouldCorrectlyBehave()
    {
        //Arrange
        var electronicDevice = new TV(new AdvancedRemoteControl());

        //Act
        electronicDevice.VolumeAdjustment(5);

        //Assert
        string expectedMessage = "Modifying volume: 5 with advanced remote control.";
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo(expectedMessage));
    }

    [Test]
    public void ChangeChannel_WhenTVWithAdvancedRemoteIsUsed_ShouldCorrectlyBehave()
    {
        //Arrange
        var electronicDevice = new TV(new AdvancedRemoteControl());

        //Act
        electronicDevice.ChangeChannel(15);

        //Assert
        string expectedMessage = "Tuning into channel 15 using advanced remote control.";
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo(expectedMessage));
    }


}