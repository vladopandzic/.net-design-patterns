namespace VP.DesignPatterns.Composite.Example2;

/// <summary>
/// This is leaf node. Client treats this leaf node and composite (<see cref="CanNetwork"/> the same since both of them
/// are <see cref="ICanNetworkComponent"/>.
/// </summary>
public class CanNetworkNode : ICanNetworkComponent
{
    public CanNetworkNode(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Display()
    {
        Console.WriteLine(Name);
    }
}
