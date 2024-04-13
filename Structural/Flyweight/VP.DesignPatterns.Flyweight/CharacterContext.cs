namespace VP.DesignPatterns.Flyweight;

public class CharacterContext
{
    public string Name { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public Sprite Sprite { get; set; }

    public CharacterContext(string name, int x, int y, Sprite sprite)
    {
        Name = name;
        X = x;
        Y = y;
        Sprite = sprite;
    }
}
