using VP.DesignPatterns.Composite.Example2;

namespace VP.DesignPatterns.Composite.Tests.Example2;

[TestFixture]
public class CompositePatternExample2Tests
{
    [Test]
    public void CanNetwork_Should_Display_Itself()
    {
        // Arrange
        ICanNetworkComponent canNetwork = new CanNetwork("Main Network", new List<ICanNetworkComponent>());

        // Act
        string output = CaptureConsoleOutput(() => canNetwork.Display());

        // Assert
        Assert.That(output, Is.EqualTo("Main Network"));
    }

    [Test]
    public void CanNetworkNode_Should_Display_Itself()
    {
        // Arrange
        ICanNetworkComponent node = new CanNetworkNode("Node 1");

        // Act
        string output = CaptureConsoleOutput(() => node.Display());

        // Assert
        Assert.That(output, Is.EqualTo("Node 1"));
    }

    [Test]
    public void CanNetwork_Should_Display_Children_Recursively()
    {
        // Arrange
        var subNetwork = new CanNetwork("Sub Network", new List<ICanNetworkComponent> {
                new CanNetworkNode("Node 1"),
                new CanNetworkNode("Node 2")
            });

        // Act
        string output = CaptureConsoleOutput(() => subNetwork.Display());

        // Assert
        Assert.That(output, Does.Contain("Node 1"));
        Assert.That(output, Does.Contain("Node 2"));
        Assert.That(output, Does.Contain("Sub Network"));
    }

    private string CaptureConsoleOutput(Action action)
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            action.Invoke();
            return sw.ToString().Trim();
        }
    }
}