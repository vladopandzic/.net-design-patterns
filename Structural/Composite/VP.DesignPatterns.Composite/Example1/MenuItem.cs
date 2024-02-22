namespace VP.DesignPatterns.Composite.Example1;

/// <summary>
/// This class is Composite. It has List of IMenuItem as children and also it is IMenuItem.
/// </summary>
public class MenuItem : IMenuItem
{
    public MenuItem(string name, List<IMenuItem> children)
    {
        Name = name;
        Children = children;
    }

    public string Name { get; }

    public List<IMenuItem> Children { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Name}");
        if (Children.Count > 0)
        {
            foreach (var child in Children)
            {
                Console.Write($"Children of {Name}:");
                child.Display();
            }
        }
    }
}
