using System.Text;
using VP.DesignPatterns.Composite.Example1;

namespace VP.DesignPatterns.Composite.Tests.Example1;

public class CompositePatternExample1StructuralTests
{
    private StringWriter _stringWriter;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [Test, Description("Verifies that leaf menu can be added to hierarchy")]
    public void Component_Hierarchy_Should_Be_Well_Formed()
    {
        // Arrange & Act
        IMenuItem leaf = new LeafMenuItem("Leaf menu item");
        IMenuItem root = new MenuItem("Root", new List<IMenuItem>() { leaf });


        // Assert
        Assert.That((root as MenuItem)!.Children, Contains.Item(leaf));
    }

    [Test, Description("Verifies that hierarchy can be recursive.")]
    public void Composite_Should_Perform_Operations_Recursively()
    {
        // Arrange
        IMenuItem child2 = new LeafMenuItem("Child2");
        IMenuItem child1 = new MenuItem("Child1", new List<IMenuItem>() { child2 });

        IMenuItem root = new MenuItem("Root", new List<IMenuItem>() { child1 });

        // Act
        root.Display();

        // Assert
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo("Root\r\nChildren of Root:Child1\r\nChildren of Child1:Child2")); // Verify that the operation is performed recursively
    }

    [Test, Description("Verifies that both leaf node (LeafMenuItem) and MenuItem implement IMenuItem")]
    public void LeafMenuItem_And_MenuItem_Should_Implement_IMenuItem_Interface()
    {
        // Arrange
        IMenuItem leafMenuItem = new LeafMenuItem("Leaf");
        IMenuItem menuItem = new MenuItem("Menu", new List<IMenuItem>());

        // Act & Assert
        Assert.That(leafMenuItem, Is.InstanceOf<IMenuItem>(), "LeafMenuItem should implement IMenuItem interface");
        Assert.That(menuItem, Is.InstanceOf<IMenuItem>(), "MenuItem should implement IMenuItem interface");
    }

    [Test, Description("Leaf node and composite node should be treated the same way")]
    public void Composite_Should_Allow_Uniform_Access()
    {
        // Arrange
        IMenuItem menuItem = new MenuItem("Menu", new List<IMenuItem>());
        IMenuItem leafItem = new LeafMenuItem("Leaf");

        // Act & Assert
        Assert.That(menuItem, Is.InstanceOf<IMenuItem>(), "MenuItem should be an instance of IMenuItem");
        Assert.That(leafItem, Is.InstanceOf<IMenuItem>(), "LeafMenuItem should be an instance of IMenuItem");
    }

    [Test, Description("Root menu item should display itself (call operation on IMenuItem) which in this case is Display method.")]
    public void MenuItem_Should_Display_Itself()
    {
        // Arrange
        IMenuItem menuItem = new MenuItem("Menu", new List<IMenuItem>());
        IMenuItem leafMenuItem = new LeafMenuItem("Leaf");

        // Act & Assert
        Assert.That(CaptureConsoleOutput(() => menuItem.Display()), Is.EqualTo("Menu\r\n"), "MenuItem should display itself");
        Assert.That(CaptureConsoleOutput(() => leafMenuItem.Display()), Is.EqualTo("Leaf\r\n"), "LeafMenuItem should display itself");
    }

    [Test, Description("Travelrsal is possible through hierarchy")]
    public void Composite_Should_Allow_Traversal_And_Operations()
    {
        // Arrange
        var child1 = new LeafMenuItem("Child1");
        var child2 = new LeafMenuItem("Child2");
        var subMenu = new MenuItem("SubMenu", new List<IMenuItem> { child1, child2 });
        var menuItem = new MenuItem("Menu", new List<IMenuItem> { subMenu });

        // Act
        string output = CaptureConsoleOutput(() =>
        {
            menuItem.Display();
            subMenu.Display();
        });

        // Assert
        Assert.That(output, Does.Contain("Child1"));
        Assert.That(output, Does.Contain("Child2"));
        Assert.That(output, Does.Contain("SubMenu"));
    }

    private string TraverseAndOperate(IMenuItem menuItem)
    {
        StringBuilder result = new StringBuilder();
        menuItem.Display();
        result.AppendLine();

        if(menuItem is MenuItem composite)
        {
            foreach(var child in composite.Children)
            {
                result.Append(TraverseAndOperate(child));
            }
        }

        return result.ToString();
    }

    private string CaptureConsoleOutput(Action action)
    {
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        action.Invoke();
        return stringWriter.ToString();
    }
}
