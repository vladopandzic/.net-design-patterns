namespace VP.DesignPatterns.Composite.Example1;

/// <summary>
/// This is leaf node. Client treats this leaf node and composite (<see cref="MenuItem"/> the same since both of them
/// are <see cref="IMenuItem"/>.
/// </summary>
public class LeafMenuItem : IMenuItem
{
    public LeafMenuItem(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Display()
    {
        Console.WriteLine($"{Name}");
    }
}
