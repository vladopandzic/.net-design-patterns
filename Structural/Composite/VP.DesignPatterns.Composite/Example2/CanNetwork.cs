namespace VP.DesignPatterns.Composite.Example2;

/// <summary>
/// This class is Composite. It has List of ICanNetworkComponent as children and also it is ICanNetworkComponent.
/// </summary>
public class CanNetwork : ICanNetworkComponent
{
    public CanNetwork(string name, List<ICanNetworkComponent> children)
    {
        Name = name;
        Children = children;
    }

    public string Name { get; }

    public List<ICanNetworkComponent> Children { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Name}");
        if(Children.Count > 0)
        {
            foreach(var child in Children)
            {
                Console.Write($"Children of {Name}:");
                child.Display();
            }
        }
    }
}
