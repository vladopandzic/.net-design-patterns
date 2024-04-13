namespace VP.DesignPatterns.Flyweight;

public class Sprite
{
    public string ImagePath { get; set; }

    public Sprite(string imagePath)
    {
        ImagePath = imagePath;
    }
}
