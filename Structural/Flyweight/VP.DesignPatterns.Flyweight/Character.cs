namespace VP.DesignPatterns.Flyweight;

public class Character : ICharacter
{
    public Sprite Sprite { get; }
    readonly string _name; // Shared intrinsic state

    public Character(string name, Sprite sprite)
    {
        _name = name;
        Sprite = sprite;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Displaying {_name} at position ({x}, {y}) with sprite '{Sprite.ImagePath}'");
    }
}
