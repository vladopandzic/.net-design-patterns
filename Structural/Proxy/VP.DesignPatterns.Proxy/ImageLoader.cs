namespace VP.DesignPatterns.Proxy;

public class ImageLoader : IImageLoader
{
    public void LoadImage(string imageName)
    {
        Console.WriteLine($"Loading image '{imageName}' from remote server...");
        Console.WriteLine($"Image '{imageName}' loaded successfully.");
    }
}