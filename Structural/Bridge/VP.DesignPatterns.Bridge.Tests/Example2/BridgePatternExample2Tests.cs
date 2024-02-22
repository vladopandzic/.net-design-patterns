using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP.DesignPatterns.Bridge.Example1;
using VP.DesignPatterns.Bridge.Example2;

namespace VP.DesignPatterns.Bridge.Tests.Example2;
public class BridgePatternExample2Tests
{
    [Test]
    public void PowerOn_WhenTVWithAdvancedRemoteIsUsed_ShouldCorrectlyBehave()
    {
        //Arrange
        var blueCircle = new Circle(new BlueColor());

        //Act
        var result = blueCircle.Draw();

        //Assert
        string expectedMessage = "Drawing Circle. Filled with Blue color.";
        Assert.That(result, Is.EqualTo(expectedMessage));
    }
}
